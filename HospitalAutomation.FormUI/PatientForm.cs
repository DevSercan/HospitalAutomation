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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        public int patientId; // Mevcut hastanın Id değerini tutar.
        public int doctorId; // Seçilen doktorun Id değerini tutar.
        public int polyclinicId; // Seçilen polikliniğin Id değerini tutar.
        public int appointmentId; // Hastanın randevusunun Id değerini tutacak değişken.
        public AppointmentManager appointmentManager = new AppointmentManager(new AppointmentDal()); // Randevu yönetim nesnesini oluşturur.
        public void getAppointmentValues() // Hastanın randevu bilgilerini getiren metot.
        {
            Appointment appointment = appointmentManager.GetByPatientId(patientId); // Hastanın Id değerine göre randevu bilgilerini alır.
            if (appointment != null) // Hastanın randevusu var ise koşul sağlanır.
            {
                PolyclinicManager polyclinicManager = new PolyclinicManager(new PolyclinicDal()); // Poliklinikler için nesne oluşturulur.
                string polyclinicName = polyclinicManager.GetById(appointment.PolyclinicId).Name; // Poliklinik adını Id değerine göre alır.
                tbxPolyclinic.Text = polyclinicName; // Poliklinik adını TextBox'a yazar.
                tbxDate.Text = appointment.Date; // Randevunun Tarih bilgisini alır ve TextBox'a yazar.
                tbxTime.Text = appointment.Time; // Randevunun zaman bilgisini alır ve TextBox'a yazar.

                DoctorManager doctorManager = new DoctorManager(new DoctorDal()); // Doktor yönetimi için nesne oluşturur.
                string doctorFirstName = doctorManager.GetById(appointment.DoctorId).FirstName; // Doktorun adını Id değerine göre alır.
                string doctorLastName = doctorManager.GetById(appointment.DoctorId).LastName; // Doktorun soy adını Id değerine göre alır.
                tbxDoctor.Text = doctorFirstName + " " + doctorLastName; // Doktorun adını ve soy adını birleştirip TextBox'a yazar.

                appointmentId = appointment.Id; // Randevunun Id değerini değişkene atar.
            }
        }
        private void PatientForm_Load(object sender, EventArgs e) // Sayfa yüklendiğinde bu metot otomatik olarak çalışır.
        {
            dtprDate.CustomFormat = "dd.MM.yyyy"; // Tarih formatını "gün.ay.yıl" şeklinde ayarlar.

            PatientManager patientManager = new PatientManager(new PatientDal()); // Hastalar için nesne oluşturulur.
            Patient patient = patientManager.GetById(patientId); // Giriş yapan hastanın bilgilerini Id değerine göre alır.
            lblFirstName.Text = patient.FirstName; // Hastanın adını ilgili metin kutusuna yazar.
            lblLastName.Text = patient.LastName; // Hastanın soy adını ilgili metin kutusuna yazar.
            lblPhoneNumber.Text = patient.PhoneNumber; // Hastanın telefon numarasını ilgili metin kutusuna yazar.
            lblEmail.Text = patient.Email; // Hastanın eposta adresini ilgili metin kutusuna yazar.
            lblNationalId.Text = patient.NationalId; // Hastanın kimlik adresini ilgili metin kutusuna yazar.

            PolyclinicManager polyclinicManager = new PolyclinicManager(new PolyclinicDal()); // Poliklinikler için nesne oluşturulur.
            List<Polyclinic> polyclinics = polyclinicManager.GetAll(); // Poliklinik nesnelerini alır.
            cobxPolyclinics.DataSource = polyclinics; // Poliklinik nesnelerini poliklinikler ComboBox'ına nesne olarak ekler.
            cobxPolyclinics.DisplayMember = "Name"; // Poliklinikler ComboBox'ında polikliniklerin "Name" değerini gösterir.
            cobxPolyclinics.ValueMember = "Id"; // Poliklinikler ComboBox'ında seçilen polikliniğin "Id" değerini döndürür.

            getAppointmentValues(); // Hastanın randevu bilgilerini varsa getirir.
        }
        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e) // Mevcut form (Hasta formu) kapatıldığında bu metot çalışır.
        {
            LoginForm loginForm = new LoginForm(); // Giriş formunu nesne olarak tanımlar.
            loginForm.Show(); // Giriş formunu görünür hale getirir.
        }

        private void cobxPolyclinics_SelectedIndexChanged(object sender, EventArgs e) // Poliklinik seçildiğinde bu metot çalışır.
        {
            DoctorManager doctorManager = new DoctorManager(new DoctorDal()); // Doktorlar için nesne oluşturulur.
            if (cobxPolyclinics.SelectedItem != null && cobxPolyclinics.SelectedItem is Polyclinic selectedPolyclinic) // Poliklinik seçildiyse ve seçilen poliklinik bir Polyclinic nesnesi ise koşul sağlanır.
            {
                polyclinicId = selectedPolyclinic.Id; // Seçilen polikliniğin Id değerini değişkende tutar.
                List<Doctor> doctors = doctorManager.GetByPolyclinicId(polyclinicId); // Seçilen polikliniğin Id değerine göre doktorları getirir.
                var customDoctorList = doctors.Select(d => new { FullName = d.FirstName + " " + d.LastName, Id = d.Id }).ToList(); // 'Id' ve 'FullName' içeren bir doktor listesi oluşturur.
                cobxDoctors.DataSource = customDoctorList; // Doktor nesnelerini doktorlar ComboBox'ına nesne olarak ekler.
                cobxDoctors.DisplayMember = "FullName"; // Doktorlar ComboBox'ında doktorların "FirstName" değerini gösterir.
                cobxDoctors.ValueMember = "Id"; // Doktorlar ComboBox'ında seçilen doktorun "Id" değerini döndürür.
            }
        }

        private void cobxDoctors_SelectedIndexChanged(object sender, EventArgs e) // Doktor seçildiğinde bu metot çalışır.
        {
            if (cobxDoctors.SelectedItem != null && cobxDoctors.SelectedItem is Doctor selectedDoctor) // Doktor seçildiyse ve seçilen doktor bir Doctor nesnesi ise koşul sağlanır.
            {
                doctorId = selectedDoctor.Id; // Seçilen doktorun Id değerini değişkende tutar.
            }
        }

        public string appointmentDate; // Randevu tarihini String olarak tutacak değişken.
        private void dtprDate_ValueChanged(object sender, EventArgs e) // Randevu tarihi seçildiğinde veya değiştiğinde bu metot çalışır.
        {
            appointmentDate = dtprDate.Text; // Randevu tarihini değişkene atar.
        }

        public string appointmentTime; // Randevu saatini ve dakikasını String olarak tutacak değişken.
        private void cobxTime_SelectedIndexChanged(object sender, EventArgs e) // Randevu saati seçildiğinde veya değiştirildiğinde bu metot çalışır.
        {
            appointmentTime = cobxTime.Text; // Randevu saatini değişkene atar.
        }

        private void btnAppointment_Click(object sender, EventArgs e) // Randevu almak için butona basıldığında bu metot çalışır.
        {
            if (cobxPolyclinics.SelectedIndex == -1 || cobxDoctors.SelectedIndex == -1) // Poliklinik veya Doktor seçilmediyse koşul sağlanır.
            {
                lblAppointmentStatus.Text = "Poliklinik ve Doktor seçmelisiniz."; // Randevu durum metnini düzenler.
                lblAppointmentStatus.ForeColor = Color.Red; // Randevu durum metnini kırmızı renk yapar.
                return; // Eksik bilgi girildiği için işlem sonlandırılır.
            }
            else if (dtprDate.Checked == false || cobxTime.SelectedIndex == -1) // Tarih veya Zaman seçilmediyse koşul sağlanır.
            {
                lblAppointmentStatus.Text = "Tarih ve Saat seçmelisiniz."; // Randevu durum metnini düzenler.
                lblAppointmentStatus.ForeColor = Color.Red; // Randevu durum metnini kırmızı renk yapar.
                return; // Eksik bilgi girildiği için işlem sonlandırılır.
            }

            Appointment existingAppointment = appointmentManager.GetByPatientId(patientId); // Hastanın Id değerine göre randevu getirir.
            if (existingAppointment != null) // Hastanın zaten bir randevusu var ise koşul sağlanır.
            {
                lblAppointmentStatus.Text = "Zaten bir randevunuz var."; // Randevu durum metnini düzenler.
                lblAppointmentStatus.ForeColor = Color.Red; // Randevu durum metnini kırmızı renk yapar.
                return; // Mevcut bir randevu bulunduğu için için işlem sonlandırılır.
            }

            polyclinicId = Convert.ToInt32(cobxPolyclinics.SelectedValue); // Seçilen polikliniğin Id değerini değişkene atar.
            doctorId = Convert.ToInt32(cobxDoctors.SelectedValue); // Seçilen doktorun Id değerini değişkene atar.

            var appointments = appointmentManager.GetAll(); // Randevu listesini alır.
            int lastAppointmentId = 0; // Son randevunun Id değerini Integer olarak tuacak değişken.
            if (appointments.Any()) // Randevu listesinde randevu var ise koşul sağlanır.
            {
                lastAppointmentId = appointments.Max(a => a.Id) + 1; // Randevu listesindeki son Id değerinin bir fazlasını tutar.
            }

            Appointment appointment = new Appointment { Id = lastAppointmentId, Date = dtprDate.Text, Time = cobxTime.Text, DoctorId = doctorId, PolyclinicId = polyclinicId, PatientId = patientId }; // Randevu nesnesi oluşturur.

            appointmentManager.Add(appointment); // Randevuyu randevulara ekler.

            lblAppointmentStatus.Text = "Randevu oluşturuldu."; // Randevu durum metnini düzenler.
            lblAppointmentStatus.ForeColor = Color.Green; // Randevu durum metnini yeşil renk yapar.

            getAppointmentValues(); // Hastanın randevu bilgilerini getirir.
        }

        public void updateAppointmentValues() // Randevu bilgilerini güncelleyen metot.
        {
            tbxPolyclinic.Clear(); // Poliklinik TextBox'ındaki yazıyı siler.
            tbxDate.Clear(); // Tarih TextBox'ındaki yazıyı siler.
            tbxTime.Clear(); // Zaman TextBox'ındaki yazıyı siler.
            tbxDoctor.Clear(); // Doktor TextBox'ındaki yazıyı siler.
            getAppointmentValues(); // Hastanın randevu bilgilerini getirir.
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e) // Randevuyu İptal Et butonuna basıldığında bu metot çalışır.
        {
            DialogResult result = MessageBox.Show("Randevunuzu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // 'Evet/Hayır' seçenekleri ile uyarı mesajı oluşturur.
            if (result == DialogResult.Yes) // 'Evet' seçeneğine basıldıysa koşul sağlanır.
            {
                Appointment appointment = appointmentManager.GetById(appointmentId); // Id değerine göre istenilen randevuyu nesne olarak getirir.
                appointmentManager.Delete(appointment); // Randevuyu siler.
                updateAppointmentValues(); // Randevu bilgilerini günceller.
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Randevu bilgilerini güncelleme butonuna basıldığında bu metot çalışır.
        {
            updateAppointmentValues(); // Randevu bilgilerini günceller.
        }
    }
}
