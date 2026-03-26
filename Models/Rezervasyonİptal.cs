using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class Rezervasyonİptal : Form
    {
        // baglantı adresıı
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";
        private int _aktifMusteriId;

        
        public Rezervasyonİptal(int musteriId)
        {
            InitializeComponent();
            _aktifMusteriId = musteriId;

            // ID sıfır ise formu kapatır
            if (_aktifMusteriId <= 0)
            {
                MessageBox.Show("Lütfen önce sisteme giriş yapınız.", "Güvenlik Hatası");
                this.Close();
            }
        }

        public Rezervasyonİptal() : this(0) { }

        private void Rezervasyonİptal_Load(object sender, EventArgs e)
        {
            if (_aktifMusteriId > 0)
            {
                RezervasyonlariListele();
            }
        }

        // rezervasyonalrı lısteleme
        private void RezervasyonlariListele()
        {
            string sorgu = @"SELECT R.Id, U.Nereden, U.Nereye, U.Tarih, R.KoltukNo, U.Fiyat, R.Durum 
                           FROM Rezervasyonlar R 
                           JOIN Ucuslar U ON R.UcusId = U.Id 
                           WHERE R.MusteriId = @musteriId AND R.Durum = 'Aktif'";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@musteriId", _aktifMusteriId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                      MessageBox.Show("Aktif rezervasyonunuz bulunmamaktadır.", "Bilgi");
                    }

                    dgvIptalListesi.DataSource = dt;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Listeleme Hatası: " + hata.Message, "Hata");
                }
            }
        }

        // iptal et butonu
        
        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (dgvIptalListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz bir rezervasyonu seçiniz.", "Uyarı");
                return;
            }

            try
            {
                int rezervasyonId = Convert.ToInt32(dgvIptalListesi.SelectedRows[0].Cells["Id"].Value);

                DialogResult sonuc = MessageBox.Show($"Rezervasyon ID: {rezervasyonId} iptal edilecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (sonuc == DialogResult.Yes)
                {
                    using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                    {
                        baglanti.Open();

                        string ucusBulSorgu = "SELECT UcusId FROM Rezervasyonlar WHERE Id = @rid";
                        SqlCommand kmtBul = new SqlCommand(ucusBulSorgu, baglanti);
                        kmtBul.Parameters.AddWithValue("@rid", rezervasyonId);
                        object ucusIdObj = kmtBul.ExecuteScalar();

                        if (ucusIdObj != null)
                        {
                            int ucusId = Convert.ToInt32(ucusIdObj);

                            string iptalSorgu = "UPDATE Rezervasyonlar SET Durum = 'Iptal' WHERE Id = @rid";
                            SqlCommand kmtIptal = new SqlCommand(iptalSorgu, baglanti);
                            kmtIptal.Parameters.AddWithValue("@rid", rezervasyonId);
                            kmtIptal.ExecuteNonQuery();

                            string kapasiteArttirSorgu = "UPDATE Ucuslar SET Kapasite = Kapasite + 1 WHERE Id = @uid AND Kapasite < 150";
                            SqlCommand kmtKapasite = new SqlCommand(kapasiteArttirSorgu, baglanti);
                            kmtKapasite.Parameters.AddWithValue("@uid", ucusId);
                            kmtKapasite.ExecuteNonQuery();

                            MessageBox.Show("İşlem Başarılı!.");
                            RezervasyonlariListele(); // Tabloy yenılenır
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        // gerı don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            MüsteriAnaMenü musteriMenu = new MüsteriAnaMenü(_aktifMusteriId, "Kullanıcı");
            musteriMenu.Show();
        }
    }
}