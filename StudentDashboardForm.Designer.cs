namespace SkillsInternational
{
    partial class StudentDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.grpProfile = new System.Windows.Forms.GroupBox();

            // Basic Details
            this.grpBasic = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();

            // Contact Details
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();

            // Parent Details
            this.grpParent = new System.Windows.Forms.GroupBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblNic = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();

            this.lnkExit = new System.Windows.Forms.LinkLabel();

            this.grpProfile.SuspendLayout();
            this.grpBasic.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpParent.SuspendLayout();
            this.SuspendLayout();

            // ── FORM ──────────────────────────────────────────────────
            this.Text = "Skills International — Student Dashboard";
            this.Name = "StudentDashboardForm";
            this.Size = new System.Drawing.Size(900, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);

            // ── lnkLogout ─────────────────────────────────────────────
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(15, 15);
            this.lnkLogout.Text = "⟵ Logout";
            this.lnkLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkLogout.LinkColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);

            // ── lblHeading ────────────────────────────────────────────
            this.lblHeading.AutoSize = false;
            this.lblHeading.Location = new System.Drawing.Point(200, 10);
            this.lblHeading.Size = new System.Drawing.Size(480, 35);
            this.lblHeading.Text = "Skills International";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);

            // ── lblSubHeading ─────────────────────────────────────────
            this.lblSubHeading.AutoSize = false;
            this.lblSubHeading.Location = new System.Drawing.Point(200, 48);
            this.lblSubHeading.Size = new System.Drawing.Size(480, 20);
            this.lblSubHeading.Text = "Student Profile Dashboard — Reg No: ";
            this.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubHeading.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.lblSubHeading.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // ── grpProfile ────────────────────────────────────────────
            this.grpProfile.Location = new System.Drawing.Point(15, 75);
            this.grpProfile.Size = new System.Drawing.Size(855, 500);
            this.grpProfile.Text = "Your Profile Information";
            this.grpProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpProfile.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);

            // ═══════════════════════════════════════════════════════════
            // GROUP: Basic Details
            // ═══════════════════════════════════════════════════════════
            this.grpBasic.Location = new System.Drawing.Point(15, 40);
            this.grpBasic.Size = new System.Drawing.Size(400, 210);
            this.grpBasic.Text = "Basic Details";
            this.grpBasic.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpBasic.ForeColor = System.Drawing.Color.FromArgb(60, 60, 120);

            // First Name
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 35);
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtFirstName.Location = new System.Drawing.Point(130, 32);
            this.txtFirstName.Size = new System.Drawing.Size(240, 24);
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Last Name
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 75);
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtLastName.Location = new System.Drawing.Point(130, 72);
            this.txtLastName.Size = new System.Drawing.Size(240, 24);
            this.txtLastName.ReadOnly = true;
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Date of Birth
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(15, 115);
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtDOB.Location = new System.Drawing.Point(130, 112);
            this.txtDOB.Size = new System.Drawing.Size(240, 24);
            this.txtDOB.ReadOnly = true;
            this.txtDOB.BackColor = System.Drawing.Color.White;
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Gender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 155);
            this.lblGender.Text = "Gender";
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtGender.Location = new System.Drawing.Point(130, 152);
            this.txtGender.Size = new System.Drawing.Size(240, 24);
            this.txtGender.ReadOnly = true;
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.grpBasic.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFirstName, this.txtFirstName,
                this.lblLastName, this.txtLastName,
                this.lblDOB, this.txtDOB,
                this.lblGender, this.txtGender
            });

            // ═══════════════════════════════════════════════════════════
            // GROUP: Contact Details
            // ═══════════════════════════════════════════════════════════
            this.grpContact.Location = new System.Drawing.Point(430, 40);
            this.grpContact.Size = new System.Drawing.Size(400, 210);
            this.grpContact.Text = "Contact Details";
            this.grpContact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpContact.ForeColor = System.Drawing.Color.FromArgb(60, 60, 120);

            // Address
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 35);
            this.lblAddress.Text = "Address";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtAddress.Location = new System.Drawing.Point(120, 32);
            this.txtAddress.Size = new System.Drawing.Size(260, 55);
            this.txtAddress.Multiline = true;
            this.txtAddress.ReadOnly = true;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 100);
            this.lblEmail.Text = "Email";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtEmail.Location = new System.Drawing.Point(120, 97);
            this.txtEmail.Size = new System.Drawing.Size(260, 24);
            this.txtEmail.ReadOnly = true;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Mobile Phone
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(15, 135);
            this.lblMobilePhone.Text = "Mobile Phone";
            this.lblMobilePhone.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtMobilePhone.Location = new System.Drawing.Point(120, 132);
            this.txtMobilePhone.Size = new System.Drawing.Size(260, 24);
            this.txtMobilePhone.ReadOnly = true;
            this.txtMobilePhone.BackColor = System.Drawing.Color.White;
            this.txtMobilePhone.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Home Phone
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(15, 170);
            this.lblHomePhone.Text = "Home Phone";
            this.lblHomePhone.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtHomePhone.Location = new System.Drawing.Point(120, 167);
            this.txtHomePhone.Size = new System.Drawing.Size(260, 24);
            this.txtHomePhone.ReadOnly = true;
            this.txtHomePhone.BackColor = System.Drawing.Color.White;
            this.txtHomePhone.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.grpContact.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAddress, this.txtAddress,
                this.lblEmail, this.txtEmail,
                this.lblMobilePhone, this.txtMobilePhone,
                this.lblHomePhone, this.txtHomePhone
            });

            // ═══════════════════════════════════════════════════════════
            // GROUP: Parent Details
            // ═══════════════════════════════════════════════════════════
            this.grpParent.Location = new System.Drawing.Point(15, 270);
            this.grpParent.Size = new System.Drawing.Size(815, 140);
            this.grpParent.Text = "Parent Details";
            this.grpParent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpParent.ForeColor = System.Drawing.Color.FromArgb(60, 60, 120);

            // Parent Name
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(15, 35);
            this.lblParentName.Text = "Parent Name";
            this.lblParentName.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtParentName.Location = new System.Drawing.Point(120, 32);
            this.txtParentName.Size = new System.Drawing.Size(200, 24);
            this.txtParentName.ReadOnly = true;
            this.txtParentName.BackColor = System.Drawing.Color.White;
            this.txtParentName.Font = new System.Drawing.Font("Segoe UI", 9F);

            // NIC
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(340, 35);
            this.lblNic.Text = "NIC";
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtNic.Location = new System.Drawing.Point(390, 32);
            this.txtNic.Size = new System.Drawing.Size(180, 24);
            this.txtNic.ReadOnly = true;
            this.txtNic.BackColor = System.Drawing.Color.White;
            this.txtNic.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Contact Number
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(15, 80);
            this.lblContactNo.Text = "Contact Number";
            this.lblContactNo.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.txtContactNo.Location = new System.Drawing.Point(120, 77);
            this.txtContactNo.Size = new System.Drawing.Size(200, 24);
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.grpParent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblParentName, this.txtParentName,
                this.lblNic, this.txtNic,
                this.lblContactNo, this.txtContactNo
            });

            // Add items to grpProfile
            this.grpProfile.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpBasic, this.grpContact, this.grpParent
            });

            // ── lnkExit ───────────────────────────────────────────────
            this.lnkExit.AutoSize = true;
            this.lnkExit.Location = new System.Drawing.Point(820, 590);
            this.lnkExit.Text = "Exit ⟶";
            this.lnkExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkExit.LinkColor = System.Drawing.Color.FromArgb(220, 80, 60);
            this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);

            // ── Add root controls to Form ─────────────────────────────
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.lnkExit);

            this.grpProfile.ResumeLayout(false);
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpParent.ResumeLayout(false);
            this.grpParent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.GroupBox grpProfile;

        private System.Windows.Forms.GroupBox grpBasic;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;

        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;

        private System.Windows.Forms.GroupBox grpParent;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;

        private System.Windows.Forms.LinkLabel lnkExit;
    }
}
