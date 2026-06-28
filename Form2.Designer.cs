namespace SkillsInternational
{
    partial class Form2
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
            this.lnkLogout          = new System.Windows.Forms.LinkLabel();
            this.lblHeading         = new System.Windows.Forms.Label();
            this.grpRegistration    = new System.Windows.Forms.GroupBox();
            this.lblRegNo           = new System.Windows.Forms.Label();
            this.cmbRegNo           = new System.Windows.Forms.ComboBox();

            // Basic Details
            this.grpBasic           = new System.Windows.Forms.GroupBox();
            this.lblFirstName       = new System.Windows.Forms.Label();
            this.txtFirstName       = new System.Windows.Forms.TextBox();
            this.lblLastName        = new System.Windows.Forms.Label();
            this.txtLastName        = new System.Windows.Forms.TextBox();
            this.lblDOB             = new System.Windows.Forms.Label();
            this.dtpDOB             = new System.Windows.Forms.DateTimePicker();
            this.lblGender          = new System.Windows.Forms.Label();
            this.rbMale             = new System.Windows.Forms.RadioButton();
            this.rbFemale           = new System.Windows.Forms.RadioButton();

            // Contact Details
            this.grpContact         = new System.Windows.Forms.GroupBox();
            this.lblAddress         = new System.Windows.Forms.Label();
            this.txtAddress         = new System.Windows.Forms.TextBox();
            this.lblEmail           = new System.Windows.Forms.Label();
            this.txtEmail           = new System.Windows.Forms.TextBox();
            this.lblMobilePhone     = new System.Windows.Forms.Label();
            this.txtMobilePhone     = new System.Windows.Forms.TextBox();
            this.lblHomePhone       = new System.Windows.Forms.Label();
            this.txtHomePhone       = new System.Windows.Forms.TextBox();

            // Parent Details
            this.grpParent          = new System.Windows.Forms.GroupBox();
            this.lblParentName      = new System.Windows.Forms.Label();
            this.txtParentName      = new System.Windows.Forms.TextBox();
            this.lblNic             = new System.Windows.Forms.Label();
            this.txtNic             = new System.Windows.Forms.TextBox();
            this.lblContactNo       = new System.Windows.Forms.Label();
            this.txtContactNo       = new System.Windows.Forms.TextBox();

            // Buttons
            this.btnRegister        = new System.Windows.Forms.Button();
            this.btnUpdate          = new System.Windows.Forms.Button();
            this.btnClear           = new System.Windows.Forms.Button();
            this.btnDelete          = new System.Windows.Forms.Button();
            this.lnkExit            = new System.Windows.Forms.LinkLabel();

            this.grpRegistration.SuspendLayout();
            this.grpBasic.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpParent.SuspendLayout();
            this.SuspendLayout();

            // ── FORM ──────────────────────────────────────────────────
            this.Text            = "Skills International — Student Registration";
            this.Name            = "Form2";
            this.Size            = new System.Drawing.Size(900, 720);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.FromArgb(240, 248, 255);
            this.Load           += new System.EventHandler(this.Form2_Load);

            // ── lnkLogout ─────────────────────────────────────────────
            this.lnkLogout.AutoSize  = true;
            this.lnkLogout.Location  = new System.Drawing.Point(15, 15);
            this.lnkLogout.Text      = "⟵ Logout";
            this.lnkLogout.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkLogout.LinkColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);

            // ── lblHeading ────────────────────────────────────────────
            this.lblHeading.AutoSize  = false;
            this.lblHeading.Location  = new System.Drawing.Point(200, 10);
            this.lblHeading.Size      = new System.Drawing.Size(480, 40);
            this.lblHeading.Text      = "Skills International";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);

            // ── grpRegistration ───────────────────────────────────────
            this.grpRegistration.Location = new System.Drawing.Point(15, 55);
            this.grpRegistration.Size     = new System.Drawing.Size(855, 590);
            this.grpRegistration.Text     = "Student Registration";
            this.grpRegistration.Font     = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRegistration.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);

            // ── Reg No row inside grpRegistration ─────────────────────
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(20, 30);
            this.lblRegNo.Text     = "Reg No";
            this.lblRegNo.Font     = new System.Drawing.Font("Segoe UI", 9.5F);

            this.cmbRegNo.Location         = new System.Drawing.Point(140, 27);
            this.cmbRegNo.Size             = new System.Drawing.Size(180, 24);
            this.cmbRegNo.Name             = "cmbRegNo";
            this.cmbRegNo.Font             = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRegNo.DropDownStyle    = System.Windows.Forms.ComboBoxStyle.DropDown; // editable
            this.cmbRegNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRegNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);

            // ═══════════════════════════════════════════════════════════
            // GROUP: Basic Details
            // ═══════════════════════════════════════════════════════════
            this.grpBasic.Location  = new System.Drawing.Point(15, 60);
            this.grpBasic.Size      = new System.Drawing.Size(400, 200);
            this.grpBasic.Text      = "Basic Details";
            this.grpBasic.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpBasic.ForeColor = System.Drawing.Color.FromArgb(60, 60, 120);

            // First Name
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 30);
            this.lblFirstName.Text     = "First Name";
            this.lblFirstName.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtFirstName.Location = new System.Drawing.Point(130, 27);
            this.txtFirstName.Size     = new System.Drawing.Size(240, 24);
            this.txtFirstName.Name     = "txtFirstName";
            this.txtFirstName.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Last Name
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 65);
            this.lblLastName.Text     = "Last Name";
            this.lblLastName.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtLastName.Location = new System.Drawing.Point(130, 62);
            this.txtLastName.Size     = new System.Drawing.Size(240, 24);
            this.txtLastName.Name     = "txtLastName";
            this.txtLastName.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Date of Birth
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(15, 100);
            this.lblDOB.Text     = "Date of Birth";
            this.lblDOB.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.dtpDOB.Location = new System.Drawing.Point(130, 97);
            this.dtpDOB.Size     = new System.Drawing.Size(240, 24);
            this.dtpDOB.Name     = "dtpDOB";
            this.dtpDOB.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.Format   = System.Windows.Forms.DateTimePickerFormat.Short;

            // Gender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 140);
            this.lblGender.Text     = "Gender";
            this.lblGender.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(130, 138);
            this.rbMale.Text     = "Male";
            this.rbMale.Name     = "rbMale";
            this.rbMale.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(210, 138);
            this.rbFemale.Text     = "Female";
            this.rbFemale.Name     = "rbFemale";
            this.rbFemale.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.grpBasic.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFirstName, this.txtFirstName,
                this.lblLastName,  this.txtLastName,
                this.lblDOB,       this.dtpDOB,
                this.lblGender,    this.rbMale, this.rbFemale
            });

            // ═══════════════════════════════════════════════════════════
            // GROUP: Contact Details
            // ═══════════════════════════════════════════════════════════
            this.grpContact.Location  = new System.Drawing.Point(430, 60);
            this.grpContact.Size      = new System.Drawing.Size(400, 200);
            this.grpContact.Text      = "Contact Details";
            this.grpContact.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpContact.ForeColor = System.Drawing.Color.FromArgb(60, 60, 120);

            // Address
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 30);
            this.lblAddress.Text     = "Address";
            this.lblAddress.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtAddress.Location   = new System.Drawing.Point(120, 27);
            this.txtAddress.Size       = new System.Drawing.Size(260, 55);
            this.txtAddress.Name       = "txtAddress";
            this.txtAddress.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Multiline  = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 95);
            this.lblEmail.Text     = "Email";
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtEmail.Location = new System.Drawing.Point(120, 92);
            this.txtEmail.Size     = new System.Drawing.Size(260, 24);
            this.txtEmail.Name     = "txtEmail";
            this.txtEmail.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Mobile Phone
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(15, 130);
            this.lblMobilePhone.Text     = "Mobile Phone";
            this.lblMobilePhone.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtMobilePhone.Location = new System.Drawing.Point(120, 127);
            this.txtMobilePhone.Size     = new System.Drawing.Size(260, 24);
            this.txtMobilePhone.Name     = "txtMobilePhone";
            this.txtMobilePhone.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Home Phone
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(15, 165);
            this.lblHomePhone.Text     = "Home Phone";
            this.lblHomePhone.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtHomePhone.Location = new System.Drawing.Point(120, 162);
            this.txtHomePhone.Size     = new System.Drawing.Size(260, 24);
            this.txtHomePhone.Name     = "txtHomePhone";
            this.txtHomePhone.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.grpContact.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAddress,    this.txtAddress,
                this.lblEmail,      this.txtEmail,
                this.lblMobilePhone,this.txtMobilePhone,
                this.lblHomePhone,  this.txtHomePhone
            });

            // ═══════════════════════════════════════════════════════════
            // GROUP: Parent Details
            // ═══════════════════════════════════════════════════════════
            this.grpParent.Location  = new System.Drawing.Point(15, 270);
            this.grpParent.Size      = new System.Drawing.Size(815, 130);
            this.grpParent.Text      = "Parent Details";
            this.grpParent.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpParent.ForeColor = System.Drawing.Color.FromArgb(60, 60, 120);

            // Parent Name
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(15, 35);
            this.lblParentName.Text     = "Parent Name";
            this.lblParentName.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtParentName.Location = new System.Drawing.Point(120, 32);
            this.txtParentName.Size     = new System.Drawing.Size(200, 24);
            this.txtParentName.Name     = "txtParentName";
            this.txtParentName.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // NIC
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(340, 35);
            this.lblNic.Text     = "NIC";
            this.lblNic.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtNic.Location = new System.Drawing.Point(390, 32);
            this.txtNic.Size     = new System.Drawing.Size(180, 24);
            this.txtNic.Name     = "txtNic";
            this.txtNic.Font     = new System.Drawing.Font("Segoe UI", 9F);

            // Contact Number
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(15, 78);
            this.lblContactNo.Text     = "Contact Number";
            this.lblContactNo.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.txtContactNo.Location = new System.Drawing.Point(120, 75);
            this.txtContactNo.Size     = new System.Drawing.Size(200, 24);
            this.txtContactNo.Name     = "txtContactNo";
            this.txtContactNo.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.grpParent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblParentName, this.txtParentName,
                this.lblNic,        this.txtNic,
                this.lblContactNo,  this.txtContactNo
            });

            // ═══════════════════════════════════════════════════════════
            // ACTION BUTTONS (inside grpRegistration)
            // ═══════════════════════════════════════════════════════════
            System.Drawing.Font btnFont    = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Size btnSize    = new System.Drawing.Size(110, 38);
            System.Windows.Forms.FlatStyle flat = System.Windows.Forms.FlatStyle.Flat;

            this.btnRegister.Location  = new System.Drawing.Point(80, 425);
            this.btnRegister.Size      = btnSize;
            this.btnRegister.Text      = "Register";
            this.btnRegister.Name      = "btnRegister";
            this.btnRegister.Font      = btnFont;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(31, 120, 56);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = flat;
            this.btnRegister.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Click    += new System.EventHandler(this.btnRegister_Click);

            this.btnUpdate.Location  = new System.Drawing.Point(220, 425);
            this.btnUpdate.Size      = btnSize;
            this.btnUpdate.Text      = "Update";
            this.btnUpdate.Name      = "btnUpdate";
            this.btnUpdate.Font      = btnFont;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = flat;
            this.btnUpdate.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Click    += new System.EventHandler(this.btnUpdate_Click);

            this.btnClear.Location  = new System.Drawing.Point(360, 425);
            this.btnClear.Size      = btnSize;
            this.btnClear.Text      = "Clear";
            this.btnClear.Name      = "btnClear";
            this.btnClear.Font      = btnFont;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(155, 200, 240);
            this.btnClear.FlatStyle = flat;
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            this.btnDelete.Location  = new System.Drawing.Point(500, 425);
            this.btnDelete.Size      = btnSize;
            this.btnDelete.Text      = "Delete";
            this.btnDelete.Name      = "btnDelete";
            this.btnDelete.Font      = btnFont;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 80, 60);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = flat;
            this.btnDelete.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click    += new System.EventHandler(this.btnDelete_Click);

            // Add items to grpRegistration
            this.grpRegistration.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblRegNo, this.cmbRegNo,
                this.grpBasic, this.grpContact, this.grpParent,
                this.btnRegister, this.btnUpdate, this.btnClear, this.btnDelete
            });

            // ── lnkExit ───────────────────────────────────────────────
            this.lnkExit.AutoSize  = true;
            this.lnkExit.Location  = new System.Drawing.Point(820, 665);
            this.lnkExit.Text      = "Exit ⟶";
            this.lnkExit.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lnkExit.LinkColor = System.Drawing.Color.FromArgb(220, 80, 60);
            this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);

            // ── Add root controls to Form ─────────────────────────────
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.grpRegistration);
            this.Controls.Add(this.lnkExit);

            this.grpRegistration.ResumeLayout(false);
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
        private System.Windows.Forms.LinkLabel  lnkLogout;
        private System.Windows.Forms.Label      lblHeading;
        private System.Windows.Forms.GroupBox   grpRegistration;
        private System.Windows.Forms.Label      lblRegNo;
        private System.Windows.Forms.ComboBox   cmbRegNo;

        private System.Windows.Forms.GroupBox   grpBasic;
        private System.Windows.Forms.Label      lblFirstName;
        private System.Windows.Forms.TextBox    txtFirstName;
        private System.Windows.Forms.Label      lblLastName;
        private System.Windows.Forms.TextBox    txtLastName;
        private System.Windows.Forms.Label      lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label      lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;

        private System.Windows.Forms.GroupBox   grpContact;
        private System.Windows.Forms.Label      lblAddress;
        private System.Windows.Forms.TextBox    txtAddress;
        private System.Windows.Forms.Label      lblEmail;
        private System.Windows.Forms.TextBox    txtEmail;
        private System.Windows.Forms.Label      lblMobilePhone;
        private System.Windows.Forms.TextBox    txtMobilePhone;
        private System.Windows.Forms.Label      lblHomePhone;
        private System.Windows.Forms.TextBox    txtHomePhone;

        private System.Windows.Forms.GroupBox   grpParent;
        private System.Windows.Forms.Label      lblParentName;
        private System.Windows.Forms.TextBox    txtParentName;
        private System.Windows.Forms.Label      lblNic;
        private System.Windows.Forms.TextBox    txtNic;
        private System.Windows.Forms.Label      lblContactNo;
        private System.Windows.Forms.TextBox    txtContactNo;

        private System.Windows.Forms.Button     btnRegister;
        private System.Windows.Forms.Button     btnUpdate;
        private System.Windows.Forms.Button     btnClear;
        private System.Windows.Forms.Button     btnDelete;
        private System.Windows.Forms.LinkLabel  lnkExit;
    }
}
