namespace SkillsInternational
{
    partial class Form1
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────────
            this.Text = "Skills International — Login";
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(460, 480);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255); // Alice Blue

            // ── picLogo ───────────────────────────────────────────────
            this.picLogo.Location = new System.Drawing.Point(165, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(110, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // To show a logo: this.picLogo.Image = Image.FromFile("logo.png");
            this.picLogo.BackColor = System.Drawing.Color.Transparent;

            // ── lblHeading ────────────────────────────────────────────
            this.lblHeading.AutoSize = false;
            this.lblHeading.Location = new System.Drawing.Point(60, 105);
            this.lblHeading.Size = new System.Drawing.Size(320, 36);
            this.lblHeading.Text = "Skills International";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);

            // ── grpLogin ──────────────────────────────────────────────
            this.grpLogin.Location = new System.Drawing.Point(60, 150);
            this.grpLogin.Size = new System.Drawing.Size(320, 220);
            this.grpLogin.Text = "Login";
            this.grpLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpLogin.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lnkRegister);
            this.grpLogin.Controls.Add(this.btnClear);
            this.grpLogin.Controls.Add(this.btnLogin);

            // ── lblUsername ───────────────────────────────────────────
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 40);
            this.lblUsername.Text = "Username";
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);

            // ── txtUsername ───────────────────────────────────────────
            this.txtUsername.Location = new System.Drawing.Point(120, 37);
            this.txtUsername.Size = new System.Drawing.Size(175, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // ── lblPassword ───────────────────────────────────────────
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 80);
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);

            // ── txtPassword ───────────────────────────────────────────
            this.txtPassword.Location = new System.Drawing.Point(120, 77);
            this.txtPassword.Size = new System.Drawing.Size(175, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // ── lnkRegister ───────────────────────────────────────────
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(120, 115);
            this.lnkRegister.Text = "Register new account";
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);

            // ── btnClear ──────────────────────────────────────────────
            this.btnClear.Location = new System.Drawing.Point(60, 155);
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.Name = "btnClear";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(155, 200, 240);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ── btnLogin ──────────────────────────────────────────────
            this.btnLogin.Location = new System.Drawing.Point(170, 155);
            this.btnLogin.Size = new System.Drawing.Size(90, 35);
            this.btnLogin.Text = "Login";
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ── btnExit ───────────────────────────────────────────────
            this.btnExit.Location = new System.Drawing.Point(20, 400);
            this.btnExit.Size = new System.Drawing.Size(90, 35);
            this.btnExit.Text = "Exit";
            this.btnExit.Name = "btnExit";
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(220, 80, 60);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ── Add controls to form ──────────────────────────────────
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnExit);

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}
