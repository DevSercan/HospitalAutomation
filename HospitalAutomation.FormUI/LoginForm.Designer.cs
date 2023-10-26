namespace HospitalAutomation.FormUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblTitle = new Label();
            gpbxLogin = new GroupBox();
            tbxNationalId = new TextBox();
            tbxPassword = new TextBox();
            btnLoginAsDoctor = new Button();
            btnLoginAsPatient = new Button();
            ckbxShowPassword = new CheckBox();
            lblPassword = new Label();
            lblNationalId = new Label();
            lblStatus = new Label();
            gpbxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(72, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bursa Şehir Hastanesi";
            // 
            // gpbxLogin
            // 
            gpbxLogin.Controls.Add(tbxNationalId);
            gpbxLogin.Controls.Add(tbxPassword);
            gpbxLogin.Controls.Add(btnLoginAsDoctor);
            gpbxLogin.Controls.Add(btnLoginAsPatient);
            gpbxLogin.Controls.Add(ckbxShowPassword);
            gpbxLogin.Controls.Add(lblPassword);
            gpbxLogin.Controls.Add(lblNationalId);
            gpbxLogin.Location = new Point(74, 80);
            gpbxLogin.Name = "gpbxLogin";
            gpbxLogin.Size = new Size(332, 111);
            gpbxLogin.TabIndex = 1;
            gpbxLogin.TabStop = false;
            // 
            // tbxNationalId
            // 
            tbxNationalId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNationalId.Location = new Point(6, 37);
            tbxNationalId.Name = "tbxNationalId";
            tbxNationalId.Size = new Size(154, 29);
            tbxNationalId.TabIndex = 8;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.Location = new Point(166, 37);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(154, 29);
            tbxPassword.TabIndex = 9;
            // 
            // btnLoginAsDoctor
            // 
            btnLoginAsDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginAsDoctor.Location = new Point(199, 72);
            btnLoginAsDoctor.Name = "btnLoginAsDoctor";
            btnLoginAsDoctor.Size = new Size(121, 30);
            btnLoginAsDoctor.TabIndex = 10;
            btnLoginAsDoctor.Text = "Doktor Girişi";
            btnLoginAsDoctor.UseVisualStyleBackColor = true;
            btnLoginAsDoctor.Click += btnLoginAsDoctor_Click;
            // 
            // btnLoginAsPatient
            // 
            btnLoginAsPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginAsPatient.Location = new Point(6, 72);
            btnLoginAsPatient.Name = "btnLoginAsPatient";
            btnLoginAsPatient.Size = new Size(187, 30);
            btnLoginAsPatient.TabIndex = 11;
            btnLoginAsPatient.Text = "Hasta Girişi";
            btnLoginAsPatient.UseVisualStyleBackColor = true;
            btnLoginAsPatient.Click += btnLoginAsPatient_Click;
            // 
            // ckbxShowPassword
            // 
            ckbxShowPassword.AutoSize = true;
            ckbxShowPassword.Location = new Point(260, 13);
            ckbxShowPassword.Name = "ckbxShowPassword";
            ckbxShowPassword.Size = new Size(60, 19);
            ckbxShowPassword.TabIndex = 7;
            ckbxShowPassword.Text = "Göster";
            ckbxShowPassword.UseVisualStyleBackColor = true;
            ckbxShowPassword.CheckedChanged += ckbxShowPassword_CheckedChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(166, 13);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifre";
            // 
            // lblNationalId
            // 
            lblNationalId.AutoSize = true;
            lblNationalId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNationalId.Location = new Point(6, 13);
            lblNationalId.Name = "lblNationalId";
            lblNationalId.Size = new Size(81, 21);
            lblNationalId.TabIndex = 0;
            lblNationalId.Text = "T.C. Kimlik";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(74, 194);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(330, 28);
            lblStatus.TabIndex = 9;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(lblStatus);
            Controls.Add(gpbxLogin);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Otomasyonu";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            gpbxLogin.ResumeLayout(false);
            gpbxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gpbxLogin;
        private TextBox tbxNationalId;
        private TextBox tbxPassword;
        private Button btnLoginAsDoctor;
        private Button btnLoginAsPatient;
        private CheckBox ckbxShowPassword;
        private Label lblPassword;
        private Label lblNationalId;
        private Label lblStatus;
    }
}