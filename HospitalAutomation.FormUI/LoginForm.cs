using HospitalAutomation.Business;
using HospitalAutomation.DataAccess;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.FormUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void loginProcess(string loginType) // Doktor veya Hasta giriş için gerekli işlemleri sağlayan metot.
        {
            if (string.IsNullOrEmpty(tbxNationalId.Text) || string.IsNullOrEmpty(tbxPassword.Text)) // T.C. Kimlik veya Şifre boş ise koşul sağlanır.
            {
                lblStatus.Text = "T.C. Kimlik veya Şifre boş bırakılamaz."; // Durum mesajını değiştirir.
                lblStatus.ForeColor = Color.Red; // Durum mesajının rengini kırmızı yapar.
                return; // Girilen bilgiler eksik olduğu için işleme devam etmeden metodu sonlandırır.
            }

            string nationalId = tbxNationalId.Text; // Metin kutusuna girilen T.C. Kimlik bilgisini String olarak tutar.
            string password = tbxPassword.Text; // Metin kutusuna girilen Şifre bilgisini String olarak tutar.
            bool loginStatus = false; // Giriş durumunu Boolean olarak tutacak değişken.
            int userId = 0; // Giriş yapan kullanıcının Id değerini tutacak değişken.

            if (loginType == "Doctor") // Giriş türü 'Doctor' ise koşul sağlanır.
            {
                DoctorManager doctorManager = new DoctorManager(new DoctorDal()); // Doktorlar için nesne oluşturulur.
                foreach (var doctor in doctorManager.GetAll()) // Bütün doktorlar sırayla döngüde işleme alınır.
                {
                    if (nationalId == doctor.NationalId && password == doctor.Password) // T.C. Kimlik ve Şifre kontrolü sağlanır.
                    {
                        loginStatus = true; // Girilen bilgiler bir doktorun bilgileri ile eşleştiyse giriş durumu 'True' olur.
                        userId = doctor.Id; // Giriş yapan doktorun Id değerini sonra kullanmak için kullanıcı değişkenine atar.
                        break; // Giriş başarılı olduğu için sonraki doktorlar kontrol edilmeden döngüden çıkılır.
                    }
                }
            }
            else if (loginType == "Patient") // Giriş türü 'Patient' ise koşul sağlanır.
            {
                PatientManager patientManager = new PatientManager(new PatientDal()); // Hastalar için nesne oluşturulur.
                foreach (var patient in patientManager.GetAll()) // Bütün hastalar sırayla döngüde işleme alınır.
                {
                    if (nationalId == patient.NationalId && password == patient.Password) // T.C. Kimlik ve Şifre kontrolü sağlanır.
                    {
                        loginStatus = true; // Girilen bilgiler bir hastanın bilgileri ile eşleştiyse giriş durumu 'True' olur.
                        userId = patient.Id; // Giriş yapan hastanın Id değerini sonra kullanmak için kullanıcı değişkenine atar.
                        break; // Giriş başarılı olduğu için sonraki hastalar kontrol edilmeden döngüden çıkılır.
                    }
                }
            }

            if (loginStatus == true) // Giriş durumu 'True' ise koşul sağlanır.
            {
                lblStatus.Text = "Giriş Başarılı."; // Durum mesajını değiştirir.
                lblStatus.ForeColor = Color.Green; // Durum mesajının rengini yeşil yapar.
                if (loginType == "Doctor") // Giriş türü 'Doctor' ise koşul sağlanır.
                {
                    this.Hide(); // Mevcut formu gizler.
                    DoctorForm doctorForm = new DoctorForm(); // Doktor formunu nesne olarak tanımlar.
                    doctorForm.doctorId = userId; // Giriş yapan doktorun Id değerini doktor formuna gönderir.
                    doctorForm.Show(); // Doktor formunu açar.
                }
                else if (loginType == "Patient") // Giriş türü 'Patient' ise koşul sağlanır.
                {
                    this.Hide(); // Mevcut formu gizler.
                    PatientForm patientForm = new PatientForm(); // Hasta formunu nesne olarak tanımlar.
                    patientForm.patientId = userId; // Giriş yapan hastanın Id değerini hasta formuna gönderir.
                    patientForm.ShowDialog(); // Hasta formunu açar.
                }
            }
            else // Giriş durumu 'False' ise koşul sağlanır.
            {
                lblStatus.Text = "Giriş Bilgileri Geçersiz."; // Durum mesajını değiştirir.
                lblStatus.ForeColor = Color.Red; // Durum mesajının rengini kırmızı yapar.
            }
            tbxPassword.Clear(); // Şifre girilen metin kutusunu temizler.
        }

        private void btnLoginAsDoctor_Click(object sender, EventArgs e) // 'Doktor Girişi' butonuna basıldığında çalışır.
        {
            loginProcess("Doctor"); // Giriş işlemini 'Doctor' parametresi ile çalıştırır.
        }

        private void btnLoginAsPatient_Click(object sender, EventArgs e) // 'Hasta Girişi' butonuna basıldığında çalışır.
        {
            loginProcess("Patient"); // Giriş işlemini 'Patient' parametresi ile çalıştırır.
        }

        private void ckbxShowPassword_CheckedChanged(object sender, EventArgs e) // Şifreyi gösteren CheckBox'ın seçimi değiştiğinde çalışır.
        {
            if (ckbxShowPassword.Checked == true) // Şifreyi gösteren CheckBox seçildiyse koşul sağlanır.
            {
                tbxPassword.PasswordChar = '\0'; // Şifreyi görünür yapar.
            }
            else // CheckBox seçilmediyse koşul sağlanır.
            {
                tbxPassword.PasswordChar = '*'; // Şifreyi gizler.
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) // Sayfa yüklendiğinde bu metot otomatik olarak çalışır.
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) // Kapatma butonuna basıldığında bu metot çalışır.
        {
            Application.Exit(); // Uygulamayı sonlandırır.
        }
    }
}
