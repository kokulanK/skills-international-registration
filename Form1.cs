using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SkillsInternational
{
    /// <summary>
    /// Form1 — Login Form
    /// Validates the user's credentials and opens the Registration form on success.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------------
        // LOGIN BUTTON
        // ---------------------------------------------------------------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT role, regNo FROM Logins WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                
                                if (role == "Admin")
                                {
                                    LoginSuccess();
                                }
                                else if (role == "Student")
                                {
                                    if (reader["regNo"] != DBNull.Value)
                                    {
                                        int regNo = Convert.ToInt32(reader["regNo"]);
                                        LoginStudentSuccess(regNo);
                                    }
                                    else
                                    {
                                        MessageBox.Show("This student account is not linked to a student profile record.",
                                            "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Unknown user role: " + role, "Login Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If we reach here, credentials were wrong
            MessageBox.Show(
                "Invalid Login credentials, please check Username and Password and try again",
                "Invalid login Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>Opens the Admin Registration form and hides the Login form.</summary>
        private void LoginSuccess()
        {
            Form2 registrationForm = new Form2(this);
            this.Hide();
            registrationForm.Show();
        }

        /// <summary>Opens the Student Dashboard form and hides the Login form.</summary>
        private void LoginStudentSuccess(int regNo)
        {
            StudentDashboardForm studentForm = new StudentDashboardForm(this, regNo);
            this.Hide();
            studentForm.Show();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            this.Hide();
            registerForm.Show();
        }

        // ---------------------------------------------------------------
        // CLEAR BUTTON
        // ---------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // ---------------------------------------------------------------
        // EXIT BUTTON
        // ---------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
