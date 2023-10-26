namespace HospitalAutomation.FormUI
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            lblTitle = new Label();
            lblPolyclinics = new Label();
            cobxPolyclinics = new ComboBox();
            gbxAddAppointment = new GroupBox();
            cobxTime = new ComboBox();
            dtprDate = new DateTimePicker();
            lblAppointmentStatus = new Label();
            btnAppointment = new Button();
            lblDoctors = new Label();
            cobxDoctors = new ComboBox();
            lblNationalId = new Label();
            pbxPatientPhoto = new PictureBox();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblFirstName = new Label();
            gbxMyAppointment = new GroupBox();
            btnUpdate = new Button();
            tbxTime = new TextBox();
            lblTime = new Label();
            tbxDate = new TextBox();
            lblDate = new Label();
            tbxPolyclinic = new TextBox();
            lblPolyclinic = new Label();
            tbxDoctor = new TextBox();
            btnDeleteAppointment = new Button();
            lblDoctor = new Label();
            gbxAddAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPatientPhoto).BeginInit();
            gbxMyAppointment.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 45);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Bursa Şehir Hastanesi";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPolyclinics
            // 
            lblPolyclinics.AutoSize = true;
            lblPolyclinics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPolyclinics.Location = new Point(17, 26);
            lblPolyclinics.Name = "lblPolyclinics";
            lblPolyclinics.Size = new Size(90, 21);
            lblPolyclinics.TabIndex = 10;
            lblPolyclinics.Text = "Poliklinikler";
            // 
            // cobxPolyclinics
            // 
            cobxPolyclinics.DropDownStyle = ComboBoxStyle.DropDownList;
            cobxPolyclinics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cobxPolyclinics.FormattingEnabled = true;
            cobxPolyclinics.Location = new Point(17, 50);
            cobxPolyclinics.Name = "cobxPolyclinics";
            cobxPolyclinics.Size = new Size(262, 29);
            cobxPolyclinics.TabIndex = 9;
            cobxPolyclinics.SelectedIndexChanged += cobxPolyclinics_SelectedIndexChanged;
            // 
            // gbxAddAppointment
            // 
            gbxAddAppointment.Controls.Add(cobxTime);
            gbxAddAppointment.Controls.Add(dtprDate);
            gbxAddAppointment.Controls.Add(lblAppointmentStatus);
            gbxAddAppointment.Controls.Add(btnAppointment);
            gbxAddAppointment.Controls.Add(lblDoctors);
            gbxAddAppointment.Controls.Add(lblPolyclinics);
            gbxAddAppointment.Controls.Add(cobxDoctors);
            gbxAddAppointment.Controls.Add(cobxPolyclinics);
            gbxAddAppointment.Location = new Point(12, 57);
            gbxAddAppointment.Name = "gbxAddAppointment";
            gbxAddAppointment.Size = new Size(296, 312);
            gbxAddAppointment.TabIndex = 25;
            gbxAddAppointment.TabStop = false;
            // 
            // cobxTime
            // 
            cobxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cobxTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cobxTime.FormattingEnabled = true;
            cobxTime.Items.AddRange(new object[] { "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "" });
            cobxTime.Location = new Point(17, 235);
            cobxTime.Name = "cobxTime";
            cobxTime.Size = new Size(262, 29);
            cobxTime.TabIndex = 14;
            cobxTime.SelectedIndexChanged += cobxTime_SelectedIndexChanged;
            // 
            // dtprDate
            // 
            dtprDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtprDate.Location = new Point(17, 200);
            dtprDate.Name = "dtprDate";
            dtprDate.Size = new Size(262, 29);
            dtprDate.TabIndex = 13;
            dtprDate.Value = new DateTime(2023, 10, 26, 0, 0, 0, 0);
            dtprDate.ValueChanged += dtprDate_ValueChanged;
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAppointmentStatus.Location = new Point(17, 274);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new Size(262, 30);
            lblAppointmentStatus.TabIndex = 12;
            lblAppointmentStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAppointment
            // 
            btnAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppointment.Location = new Point(17, 153);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(262, 41);
            btnAppointment.TabIndex = 11;
            btnAppointment.Text = "Randevu Al";
            btnAppointment.UseVisualStyleBackColor = true;
            btnAppointment.Click += btnAppointment_Click;
            // 
            // lblDoctors
            // 
            lblDoctors.AutoSize = true;
            lblDoctors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoctors.Location = new Point(17, 87);
            lblDoctors.Name = "lblDoctors";
            lblDoctors.Size = new Size(76, 21);
            lblDoctors.TabIndex = 10;
            lblDoctors.Text = "Doktorlar";
            // 
            // cobxDoctors
            // 
            cobxDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cobxDoctors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cobxDoctors.FormattingEnabled = true;
            cobxDoctors.Location = new Point(17, 111);
            cobxDoctors.Name = "cobxDoctors";
            cobxDoctors.Size = new Size(262, 29);
            cobxDoctors.TabIndex = 9;
            cobxDoctors.SelectedIndexChanged += cobxDoctors_SelectedIndexChanged;
            // 
            // lblNationalId
            // 
            lblNationalId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNationalId.Location = new Point(622, 115);
            lblNationalId.Name = "lblNationalId";
            lblNationalId.Size = new Size(100, 23);
            lblNationalId.TabIndex = 24;
            lblNationalId.Text = "NationalId";
            lblNationalId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxPatientPhoto
            // 
            pbxPatientPhoto.BackgroundImage = (Image)resources.GetObject("pbxPatientPhoto.BackgroundImage");
            pbxPatientPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            pbxPatientPhoto.Location = new Point(622, 12);
            pbxPatientPhoto.Name = "pbxPatientPhoto";
            pbxPatientPhoto.Size = new Size(100, 100);
            pbxPatientPhoto.TabIndex = 23;
            pbxPatientPhoto.TabStop = false;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(350, 37);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(266, 25);
            lblLastName.TabIndex = 29;
            lblLastName.Text = "LastName";
            lblLastName.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(350, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(266, 25);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.Location = new Point(350, 62);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(266, 25);
            lblPhoneNumber.TabIndex = 27;
            lblPhoneNumber.Text = "PhoneNumber";
            lblPhoneNumber.TextAlign = ContentAlignment.TopRight;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(350, 12);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(266, 25);
            lblFirstName.TabIndex = 26;
            lblFirstName.Text = "FirstName";
            lblFirstName.TextAlign = ContentAlignment.TopRight;
            // 
            // gbxMyAppointment
            // 
            gbxMyAppointment.Controls.Add(btnUpdate);
            gbxMyAppointment.Controls.Add(tbxTime);
            gbxMyAppointment.Controls.Add(lblTime);
            gbxMyAppointment.Controls.Add(tbxDate);
            gbxMyAppointment.Controls.Add(lblDate);
            gbxMyAppointment.Controls.Add(tbxPolyclinic);
            gbxMyAppointment.Controls.Add(lblPolyclinic);
            gbxMyAppointment.Controls.Add(tbxDoctor);
            gbxMyAppointment.Controls.Add(btnDeleteAppointment);
            gbxMyAppointment.Controls.Add(lblDoctor);
            gbxMyAppointment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbxMyAppointment.Location = new Point(350, 141);
            gbxMyAppointment.Name = "gbxMyAppointment";
            gbxMyAppointment.Size = new Size(372, 228);
            gbxMyAppointment.TabIndex = 30;
            gbxMyAppointment.TabStop = false;
            gbxMyAppointment.Text = "Randevu Bilgileri";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(328, 173);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(38, 46);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "↻";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxTime
            // 
            tbxTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTime.Location = new Point(84, 89);
            tbxTime.Name = "tbxTime";
            tbxTime.ReadOnly = true;
            tbxTime.Size = new Size(282, 29);
            tbxTime.TabIndex = 9;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(9, 97);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(40, 21);
            lblTime.TabIndex = 8;
            lblTime.Text = "Saat";
            // 
            // tbxDate
            // 
            tbxDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDate.Location = new Point(84, 54);
            tbxDate.Name = "tbxDate";
            tbxDate.ReadOnly = true;
            tbxDate.Size = new Size(282, 29);
            tbxDate.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(6, 62);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(43, 21);
            lblDate.TabIndex = 5;
            lblDate.Text = "Tarih";
            // 
            // tbxPolyclinic
            // 
            tbxPolyclinic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPolyclinic.Location = new Point(84, 19);
            tbxPolyclinic.Name = "tbxPolyclinic";
            tbxPolyclinic.ReadOnly = true;
            tbxPolyclinic.Size = new Size(282, 29);
            tbxPolyclinic.TabIndex = 4;
            // 
            // lblPolyclinic
            // 
            lblPolyclinic.AutoSize = true;
            lblPolyclinic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPolyclinic.Location = new Point(6, 27);
            lblPolyclinic.Name = "lblPolyclinic";
            lblPolyclinic.Size = new Size(72, 21);
            lblPolyclinic.TabIndex = 3;
            lblPolyclinic.Text = "Poliklinik";
            // 
            // tbxDoctor
            // 
            tbxDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDoctor.Location = new Point(84, 124);
            tbxDoctor.Name = "tbxDoctor";
            tbxDoctor.ReadOnly = true;
            tbxDoctor.Size = new Size(282, 29);
            tbxDoctor.TabIndex = 2;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAppointment.Location = new Point(150, 181);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(175, 37);
            btnDeleteAppointment.TabIndex = 1;
            btnDeleteAppointment.Text = "Randevuyu İptal Et";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoctor.Location = new Point(9, 132);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(58, 21);
            lblDoctor.TabIndex = 0;
            lblDoctor.Text = "Doktor";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(gbxMyAppointment);
            Controls.Add(lblTitle);
            Controls.Add(gbxAddAppointment);
            Controls.Add(lblNationalId);
            Controls.Add(pbxPatientPhoto);
            Controls.Add(lblLastName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblFirstName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Kayıt Sistemi";
            FormClosed += PatientForm_FormClosed;
            Load += PatientForm_Load;
            gbxAddAppointment.ResumeLayout(false);
            gbxAddAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPatientPhoto).EndInit();
            gbxMyAppointment.ResumeLayout(false);
            gbxMyAppointment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPolyclinics;
        private ComboBox cobxPolyclinics;
        private GroupBox gbxAddAppointment;
        private Label lblAppointmentStatus;
        private Button btnAppointment;
        private Label lblDoctors;
        private ComboBox cobxDoctors;
        private Label lblNationalId;
        private PictureBox pbxPatientPhoto;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblFirstName;
        private DateTimePicker dtprDate;
        private ComboBox cobxTime;
        private GroupBox gbxMyAppointment;
        private Button btnDeleteAppointment;
        private Label lblDoctor;
        private TextBox tbxDoctor;
        private TextBox tbxPolyclinic;
        private Label lblPolyclinic;
        private TextBox tbxTime;
        private Label lblTime;
        private TextBox tbxDate;
        private Label lblDate;
        private Button btnUpdate;
    }
}