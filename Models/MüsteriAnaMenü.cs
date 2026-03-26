using System;
using System.Windows.Forms;

namespace FligthReservationSystem
{
    public partial class MüsteriAnaMenü : Form
    {
        private int _aktifMusteriId;
        private string _aktifAdSoyad;

       
        public MüsteriAnaMenü(int id, string adSoyad)
        {
            InitializeComponent();
            _aktifMusteriId = id;
            _aktifAdSoyad = adSoyad;
            this.Text = "Hoşgeldiniz, " + _aktifAdSoyad;
        }

  
        public MüsteriAnaMenü(int id)
        {
            InitializeComponent();
            _aktifMusteriId = id;
            _aktifAdSoyad = "Değerli Müşterimiz"; 
            this.Text = "Hoşgeldiniz";
        }

       
        public MüsteriAnaMenü()
        {
            InitializeComponent();
            _aktifMusteriId = 0;
        }

        // ucus arama butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            
            UcusAra aramaFormu = new UcusAra(_aktifMusteriId, _aktifAdSoyad);
            aramaFormu.Show();
            this.Hide();
        }

        // rezervasyon yap butonu
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (_aktifMusteriId <= 0) { MessageBox.Show("Hata: ID bulunamadı."); return; }

            RezervasyonYap rezervasyonFormu = new RezervasyonYap(_aktifMusteriId);
            rezervasyonFormu.Show();
        }

        //rezervasyon listele butonu
        private void btnRezervasyonListele_Click(object sender, EventArgs e)
        {
            if (_aktifMusteriId <= 0) { MessageBox.Show("Hata: ID bulunamadı."); return; }

            MevcutRezervasyon listelemeFormu = new MevcutRezervasyon(_aktifMusteriId);
            listelemeFormu.Show();
        }

        // rezervasyon iptal butonu
        private void btnRezervasyonIptali_Click(object sender, EventArgs e)
        {
            
            Rezervasyonİptal iptalFormu = new Rezervasyonİptal(_aktifMusteriId);
            iptalFormu.Show();
        }

        // cıkıs butonu
        private void btnCikis_Click(object sender, EventArgs e)
        {
            KullanıcıGiris kullaniciGiris = new KullanıcıGiris();
            kullaniciGiris.Show();
            this.Close();
        }
    }
}