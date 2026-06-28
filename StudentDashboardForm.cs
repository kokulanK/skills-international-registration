using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class StudentDashboardForm : Form
    {
        private readonly Form1 _loginForm;
        private readonly int _regNo;

        public StudentDashboardForm(Form1 loginForm, int regNo)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _regNo = regNo;
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            lblSubHeading.Text = "Student Profile Dashboard — Reg No: " + _regNo;
            LoadStudentProfile();
        }

        private void LoadStudentProfile()
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", _regNo);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.Text   = reader["firstName"].ToString();
                                txtLastName.Text    = reader["lastName"].ToString();
                                
                                // DOB
                                if (reader["dateOfBirth"] != DBNull.Value)
                                {
                                    DateTime dob = Convert.ToDateTime(reader["dateOfBirth"]);
                                    txtDOB.Text = dob.ToString("yyyy-MM-dd");
                                }
                                
                                txtGender.Text      = reader["gender"].ToString();
                                txtAddress.Text     = reader["address"].ToString();
                                txtEmail.Text       = reader["email"].ToString();
                                txtMobilePhone.Text = reader["mobilePhone"].ToString();
                                txtHomePhone.Text   = reader["homePhone"].ToString();
                                txtParentName.Text  = reader["parentName"].ToString();
                                txtNic.Text         = reader["nic"].ToString();
                                txtContactNo.Text   = reader["contactNo"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No profile data found for student registration: " + _regNo,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
