namespace HospitalAutomation.FormUI
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            lblTitle = new Label();
            pbxDoctorPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxDoctorPhoto).BeginInit();
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
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Bursa Şehir Hastanesi";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbxDoctorPhoto
            // 
            pbxDoctorPhoto.BackgroundImage = (Image)resources.GetObject("pbxDoctorPhoto.BackgroundImage");
            pbxDoctorPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            pbxDoctorPhoto.Location = new Point(622, 12);
            pbxDoctorPhoto.Name = "pbxDoctorPhoto";
            pbxDoctorPhoto.Size = new Size(100, 100);
            pbxDoctorPhoto.TabIndex = 10;
            pbxDoctorPhoto.TabStop = false;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(lblTitle);
            Controls.Add(pbxDoctorPhoto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Sistemi";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbxDoctorPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbxDoctorPhoto;
    }
}