using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class AdminAnaMenü : Form
    {
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";

        public AdminAnaMenü()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdminAnaMenü_Load);
        }

        private void AdminAnaMenü_Load(object sender, EventArgs e)
        {
            GecmisUcuslariTemizle();
        }

        // gecmıs ucuslar temızlenır
        private void GecmisUcuslariTemizle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    string rezSilSorgu = @"DELETE FROM Rezervasyonlar WHERE UcusId IN (SELECT Id FROM Ucuslar WHERE Tarih < @bugun)";
                    SqlCommand kmtRezSil = new SqlCommand(rezSilSorgu, baglanti);
                    kmtRezSil.Parameters.AddWithValue("@bugun", DateTime.Today);
                    kmtRezSil.ExecuteNonQuery();

                    string ucusSilSorgu = "DELETE FROM Ucuslar WHERE Tarih < @bugun";
                    SqlCommand kmtUcusSil = new SqlCommand(ucusSilSorgu, baglanti);
                    kmtUcusSil.Parameters.AddWithValue("@bugun", DateTime.Today);
                    kmtUcusSil.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hata olursa sessiz kalır
                }
            }
        }


        // ucus ekleme butonu
        private void btnUcusEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcusEkle ucusEkleFormu = new UcusEkle();
            ucusEkleFormu.Show();
        }

        // ucak ekleme butonu
        private void btnUcakEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcakEkle ucakEkleFormu = new UcakEkle(); 
            ucakEkleFormu.Show();
        }

        // ucus sil butonu
        private void btnUcusSil_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcusSil ucusSilFormu = new UcusSil();
            ucusSilFormu.Show();
        }

        // ucak listeleme butonu
        private void btnUcakListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcakListele listele = new UcakListele();
            listele.Show();
        }
        
        //ucus gunvelleme butonu
        private void btnUcusGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcusGüncelle ucusGuncelleFormu = new UcusGüncelle();
            ucusGuncelleFormu.Show();
        }

        //kullanıcı yonetım butonu
        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullanıcıGöster kullaniciYonetimFormu = new KullanıcıGöster();
            kullaniciYonetimFormu.Show();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            adminGiris.Show();
            this.Close();
        }
    }
}