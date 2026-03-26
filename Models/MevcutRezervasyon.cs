using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class MevcutRezervasyon : Form
    {   
        // baglantı adresi
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";
        private int _aktifMusteriId;

        public MevcutRezervasyon(int musteriId)
        {
            InitializeComponent();
            _aktifMusteriId = musteriId;
        }

        public MevcutRezervasyon() : this(0) { }

        private void MevcutRezervasyon_Load(object sender, EventArgs e)
        {
            if (_aktifMusteriId <= 0)
            {
                MessageBox.Show("Listeleme Hatası: Kullanıcı ID'si alınamadı.");
                this.Close();
                return;
            }

            RezervasyonlariListele();
        }

        // rezervasyon listeleme kısmı
        private void RezervasyonlariListele()
        {
            // veritabanıdan cekılecek bılgıler
            string sorgu = @"SELECT R.Id, U.Nereden, U.Nereye, U.Tarih,U.Saat, R.KoltukNo, R.OdenenFiyat, R.Durum 
                             FROM Rezervasyonlar R 
                             JOIN Ucuslar U ON R.UcusId = U.Id 
                             WHERE R.MusteriId = @mid AND R.Durum = 'Aktif'";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@mid", _aktifMusteriId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRezervasyonlar.DataSource = dt;
                }
                catch (SqlException ex)
                {
                 
                    if (ex.Message.Contains("Invalid column name"))
                    {
                        MessageBox.Show("HATA: Veritabanında eksik sütun var!\n\n" +
                                        "Lütfen veritabanına 'Durum', 'OdenenFiyat' sütunlarını eklediğinden emin ol.\n" +
                                        "Teknik Hata: " + ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı Hatası: " + ex.Message);
                    }
                }
            }
        }

        //gerı don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            MüsteriAnaMenü menu = new MüsteriAnaMenü(_aktifMusteriId);
            menu.Show();
        }
    }
}