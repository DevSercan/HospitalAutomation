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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        public int doctorId; // Mevcut doktorun Id değerini tutar.
        private void DoctorForm_Load(object sender, EventArgs e) // Sayfa yüklendiğinde bu metot otomatik olarak çalışır.
        {

        }
        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e) // Mevcut form (Doktor formu) kapatıldığında bu metot çalışır.
        {
            LoginForm loginForm = new LoginForm(); // Giriş formunu nesne olarak tanımlar.
            loginForm.Show(); // Giriş formunu görünür hale getirir.
        }
    }
}
