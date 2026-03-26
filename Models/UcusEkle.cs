using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class UcusEkle : Form
    {
        // baglantı adresı
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";

        public UcusEkle()
        {
            InitializeComponent();
        }

        // ucus ekleme yapılır
       
        private void btnUcusEkle_Click(object sender, EventArgs e)
        {
            // Verileri formdan alır
            string nereden = txtNereden.Text;
            string nereye = txtNereye.Text;
            string fiyatText = txtFiyat.Text;
            string ucakIdText = txtUcakId.Text;
            DateTime tarih = dtpTarih.Value.Date;
            string saat = dtpSaat.Value.ToString("HH:mm");
            bool isHighSeason = chkSezon.Checked;

            decimal fiyat;
            int ucakId;

            if (string.IsNullOrWhiteSpace(nereden) ||
                string.IsNullOrWhiteSpace(nereye) ||
                !decimal.TryParse(fiyatText, out fiyat) ||
                !int.TryParse(ucakIdText, out ucakId))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz ve doğru formatta girin.", "Hata");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    string kontrolSorgu = "SELECT COUNT(*) FROM Ucuslar WHERE UcakId = @pUId AND Tarih = @pTar AND Saat = @pSaat AND AktifMi = 1";
                    SqlCommand kontrolKomutu = new SqlCommand(kontrolSorgu, baglanti);
                    kontrolKomutu.Parameters.AddWithValue("@pUId", ucakId);
                    kontrolKomutu.Parameters.AddWithValue("@pTar", tarih);
                    kontrolKomutu.Parameters.AddWithValue("@pSaat", saat);

                    int mevcutUcusSayisi = (int)kontrolKomutu.ExecuteScalar();

                    if (mevcutUcusSayisi > 0)
                    {
                        MessageBox.Show("HATA: Seçilen uçak bu tarih ve saatte zaten başka bir uçuşta görevli!", "Uçak Çakışması");
                        return;
                    }

                    string sorgu = "INSERT INTO Ucuslar (Nereden, Nereye, Fiyat, Tarih, Saat, UcakId, AktifMi, IsHighSeason, Kapasite) " +
                                   "VALUES (@p1, @p2, @p3, @p4, @pSaat, @p5, @p6, @p7, @p8)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", nereden);
                    komut.Parameters.AddWithValue("@p2", nereye);
                    komut.Parameters.AddWithValue("@p3", fiyat);
                    komut.Parameters.AddWithValue("@p4", tarih);
                    komut.Parameters.AddWithValue("@pSaat", saat);
                    komut.Parameters.AddWithValue("@p5", ucakId);
                    komut.Parameters.AddWithValue("@p6", true);
                    komut.Parameters.AddWithValue("@p7", isHighSeason);
                    komut.Parameters.AddWithValue("@p8", 150);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Uçuş başarıyla eklendi.", "Başarılı");

                    // Temizlik kısmı
                    txtNereden.Clear();
                    txtNereye.Clear();
                    txtFiyat.Clear();
                    txtUcakId.Clear();
                    chkSezon.Checked = false;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("SQL Hatası: " + hata.Message, "Hata");
                }
            }
        }

        // geri don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AdminAnaMenü adminMenu = new AdminAnaMenü();
            adminMenu.Show();
            this.Close();
        }
    }
}