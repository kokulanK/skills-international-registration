using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SkillsInternational
{
    /// <summary>
    /// Form2 — Student Registration Form
    /// Provides full CRUD operations against a MySQL database.
    /// </summary>
    public partial class Form2 : Form
    {
        private readonly Form1 _loginForm;

        public Form2(Form1 loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        // ---------------------------------------------------------------
        // FORM LOAD — populate Reg No combo box
        // ---------------------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadRegNumbers();
        }

        private void LoadRegNumbers()
        {
            try
            {
                cmbRegNo.Items.Clear();
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT regNo FROM Registration ORDER BY regNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            cmbRegNo.Items.Add(reader["regNo"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------------
        // COMBO BOX SELECTION — load student fields from DB
        // ---------------------------------------------------------------
        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex < 0) return;
            string selectedReg = cmbRegNo.SelectedItem.ToString();

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", int.Parse(selectedReg));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.Text   = reader["firstName"].ToString();
                                txtLastName.Text    = reader["lastName"].ToString();
                                dtpDOB.Value        = Convert.ToDateTime(reader["dateOfBirth"]);
                                string gender       = reader["gender"].ToString();
                                rbMale.Checked      = gender == "Male";
                                rbFemale.Checked    = gender == "Female";
                                txtAddress.Text     = reader["address"].ToString();
                                txtEmail.Text       = reader["email"].ToString();
                                txtMobilePhone.Text = reader["mobilePhone"].ToString();
                                txtHomePhone.Text   = reader["homePhone"].ToString();
                                txtParentName.Text  = reader["parentName"].ToString();
                                txtNic.Text         = reader["nic"].ToString();
                                txtContactNo.Text   = reader["contactNo"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------------
        // REGISTER BUTTON — INSERT new student record
        // ---------------------------------------------------------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (string.IsNullOrWhiteSpace(cmbRegNo.Text) ||
                !int.TryParse(cmbRegNo.Text.Trim(), out int regNo))
            {
                MessageBox.Show("Please enter a valid numeric Registration Number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRegNo.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO Registration
                            (regNo, firstName, lastName, dateOfBirth, gender,
                             address, email, mobilePhone, homePhone,
                             parentName, nic, contactNo)
                        VALUES
                            (@regNo, @firstName, @lastName, @dateOfBirth, @gender,
                             @address, @email, @mobilePhone, @homePhone,
                             @parentName, @nic, @contactNo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        BuildParameters(cmd, regNo);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Added Succesfully", "Register Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRegNumbers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------------
        // UPDATE BUTTON — UPDATE existing student record
        // ---------------------------------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Registration Number to update.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;

            int regNo = int.Parse(cmbRegNo.SelectedItem.ToString());

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE Registration SET
                            firstName   = @firstName,
                            lastName    = @lastName,
                            dateOfBirth = @dateOfBirth,
                            gender      = @gender,
                            address     = @address,
                            email       = @email,
                            mobilePhone = @mobilePhone,
                            homePhone   = @homePhone,
                            parentName  = @parentName,
                            nic         = @nic,
                            contactNo   = @contactNo
                        WHERE regNo = @regNo";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        BuildParameters(cmd, regNo);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Updated Succesfully", "Update Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------------
        // DELETE BUTTON — confirm then DELETE student record
        // ---------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Registration Number to delete.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure, Do you really want to Delete this Record...?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            int regNo = int.Parse(cmbRegNo.SelectedItem.ToString());

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", regNo);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record Deleted Succesfully", "Delete Student",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadRegNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------------
        // CLEAR BUTTON
        // ---------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        // ---------------------------------------------------------------
        // LOGOUT LINK
        // ---------------------------------------------------------------
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _loginForm.Show();
        }

        // ---------------------------------------------------------------
        // EXIT LINK
        // ---------------------------------------------------------------
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

        // ===============================================================
        // HELPERS
        // ===============================================================

        private void BuildParameters(MySqlCommand cmd, int regNo)
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
        }

        private bool ValidateInputs()
        {
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

        private void ClearForm()
        {
            cmbRegNo.SelectedIndex = -1;
            cmbRegNo.Text          = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value           = DateTime.Today;
            rbMale.Checked         = false;
            rbFemale.Checked       = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNic.Clear();
            txtContactNo.Clear();
            cmbRegNo.Focus();
        }
    }
}
