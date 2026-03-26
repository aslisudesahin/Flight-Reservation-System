using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class UcusAra : Form
    {

        private int _aktifMusteriId;
        private string _aktifAdSoyad;
        // baglantı adresı
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";
        public UcusAra(int id, string adSoyad)
        {
            InitializeComponent();
            _aktifMusteriId = id;
            _aktifAdSoyad = adSoyad;
        }

        public UcusAra() : this(0, "Misafir")
        {
            // Zincirleme kullanıliyor
        }


       
        // tum ucuslar lıstelenır
        private void UcusAra_Load(object sender, EventArgs e)
        {
            SehirleriDoldur();
            UcuslariGetir("SELECT Id, Nereden, Nereye, Tarih,Saat, Fiyat FROM Ucuslar WHERE AktifMi = 1");
        }

        // otamtık sehırler doldurulur
        private void SehirleriDoldur()
        {
            string[] sehirler = { "Istanbul", "Ankara", "Izmir", "Antalya" };

            foreach (string sehir in sehirler)
            {
                cmbNereden.Items.Add(sehir);
                cmbNereye.Items.Add(sehir);
            }
        }
        
        // ucus arama butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT Id, UcakId, Nereden, Nereye, Tarih, Saat, Fiyat FROM Ucuslar " +
                           "WHERE Nereden = @nereden AND Nereye = @nereye AND AktifMi = 1";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@nereden", cmbNereden.Text);
                    komut.Parameters.AddWithValue("@nereye", cmbNereye.Text);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUcuslar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        //  SQL'den  ucus verıyı ceker 
        private void UcuslariGetir(string sqlSorgusu)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sqlSorgusu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Seçilen kriterlere uygun uçuş bulunamadı.", "Bilgi");
                    }

                    dgvUcuslar.DataSource = dt;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Listeleme Hatası: " + hata.Message, "Hata");
                }
            }
        }
        // gerı don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            MüsteriAnaMenü musteriMenu = new MüsteriAnaMenü(_aktifMusteriId);
            musteriMenu.Show();
            this.Close();
        }
    }
}