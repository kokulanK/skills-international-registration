using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class RegisterForm : Form
    {
        private readonly Form1 _loginForm;

        public RegisterForm(Form1 loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm.Show();
        }

        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            int regNo = int.Parse(txtRegNo.Text.Trim());

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    // 1. Check if Username already exists
                    string userCheckQuery = "SELECT COUNT(*) FROM Logins WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(userCheckQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int userExists = Convert.ToInt32(cmd.ExecuteScalar());
                        if (userExists > 0)
                        {
                            ShowWarning("Username already exists. Please choose a different username.");
                            txtUsername.Focus();
                            return;
                        }
                    }

                    // 2. Check if Reg No already exists
                    string regCheckQuery = "SELECT COUNT(*) FROM Registration WHERE regNo = @regNo";
                    using (MySqlCommand cmd = new MySqlCommand(regCheckQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", regNo);
                        int regExists = Convert.ToInt32(cmd.ExecuteScalar());
                        if (regExists > 0)
                        {
                            ShowWarning("Registration Number already exists. Please choose a different one or contact Admin.");
                            txtRegNo.Focus();
                            return;
                        }
                    }

                    // 3. Begin Transaction to insert both student and login records
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // A. Insert into Registration table
                            string insertRegQuery = @"
                                INSERT INTO Registration
                                    (regNo, firstName, lastName, dateOfBirth, gender,
                                     address, email, mobilePhone, homePhone,
                                     parentName, nic, contactNo)
                                VALUES
                                    (@regNo, @firstName, @lastName, @dateOfBirth, @gender,
                                     @address, @email, @mobilePhone, @homePhone,
                                     @parentName, @nic, @contactNo)";

                            using (MySqlCommand cmd = new MySqlCommand(insertRegQuery, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@regNo",       regNo);
                                cmd.Parameters.AddWithValue("@firstName",   txtFirstName.Text.Trim());
                                cmd.Parameters.AddWithValue("@lastName",    txtLastName.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value.Date);
                                cmd.Parameters.AddWithValue("@gender",      rbMale.Checked ? "Male" : "Female");
                                cmd.Parameters.AddWithValue("@address",     txtAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@email",       txtEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@mobilePhone", txtMobilePhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@homePhone",   txtHomePhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@parentName",  txtParentName.Text.Trim());
                                cmd.Parameters.AddWithValue("@nic",         txtNic.Text.Trim());
                                cmd.Parameters.AddWithValue("@contactNo",   txtContactNo.Text.Trim());

                                cmd.ExecuteNonQuery();
                            }

                            // B. Insert into Logins table
                            string insertLoginQuery = @"
                                INSERT INTO Logins (username, password, role, regNo)
                                VALUES (@username, @password, 'Student', @regNo)";

                            using (MySqlCommand cmd = new MySqlCommand(insertLoginQuery, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@regNo",    regNo);

                                cmd.ExecuteNonQuery();
                            }

                            trans.Commit();

                            MessageBox.Show("Registration Successful! You can now log in.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to login form
                            this.Hide();
                            _loginForm.Show();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw new Exception("Error during database transaction: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Account validations
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            { ShowWarning("Username is required."); txtUsername.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            { ShowWarning("Password is required."); txtPassword.Focus(); return false; }

            if (txtPassword.Text != txtConfirmPassword.Text)
            { ShowWarning("Passwords do not match."); txtConfirmPassword.Focus(); return false; }

            // Student Profile validations
            if (string.IsNullOrWhiteSpace(txtRegNo.Text) || !int.TryParse(txtRegNo.Text.Trim(), out int regNo))
            { ShowWarning("A valid numeric Registration Number is required."); txtRegNo.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            { ShowWarning("First Name is required."); txtFirstName.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            { ShowWarning("Last Name is required."); txtLastName.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            { ShowWarning("Address is required."); txtAddress.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { ShowWarning("Email is required."); txtEmail.Focus(); return false; }

            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { ShowWarning("Please enter a valid email address."); txtEmail.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtMobilePhone.Text))
            { ShowWarning("Mobile Phone is required."); txtMobilePhone.Focus(); return false; }

            if (!Regex.IsMatch(txtMobilePhone.Text.Trim(), @"^\d+$"))
            { ShowWarning("Mobile Phone must contain digits only."); txtMobilePhone.Focus(); return false; }

            if (!string.IsNullOrWhiteSpace(txtHomePhone.Text) &&
                !Regex.IsMatch(txtHomePhone.Text.Trim(), @"^\d+$"))
            { ShowWarning("Home Phone must contain digits only."); txtHomePhone.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtParentName.Text))
            { ShowWarning("Parent Name is required."); txtParentName.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtNic.Text))
            { ShowWarning("NIC is required."); txtNic.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            { ShowWarning("Contact Number is required."); txtContactNo.Focus(); return false; }

            if (!Regex.IsMatch(txtContactNo.Text.Trim(), @"^\d+$"))
            { ShowWarning("Contact Number must contain digits only."); txtContactNo.Focus(); return false; }

            if (!rbMale.Checked && !rbFemale.Checked)
            { ShowWarning("Please select a Gender."); return false; }

            return true;
        }

        private void ShowWarning(string msg) =>
            MessageBox.Show(msg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
