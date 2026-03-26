using System;
using System.Windows.Forms;

namespace FligthReservationSystem
{
    public partial class GirisSecimFormu : Form
    {
        public GirisSecimFormu()
        {
            InitializeComponent();
        }

        // Admin Giriþ Butonu 
        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGiris adminForm = new AdminGiris();
            adminForm.Show();
        }

        // Kullanýcý Giriþ Butonu 
        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullanýcýGiris kullaniciForm = new KullanýcýGiris();
            kullaniciForm.Show();
        }

        // Kayýt Ol Butonu 
        private void btnKayýtOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayýtOl kayitForm = new KayýtOl();
            kayitForm.Show();
        }

        private void lblSecimBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}