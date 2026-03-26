using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FligthReservationSystem
{
    public partial class UcusSil : Form
    {
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";

        public UcusSil()
        {
            InitializeComponent();
        }

        private void UcusSil_Load(object sender, EventArgs e)
        {
            UcuslariListele();
        }

        // ucuslar listelenır
        private void UcuslariListele()
        {
            string sorgu = "SELECT Id, UcakId, Nereden, Nereye, Tarih, Saat, Fiyat FROM Ucuslar WHERE AktifMi = 1";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUcuslar.DataSource = dt;

                    if (dgvUcuslar.Columns.Contains("Id"))
                    {
                        dgvUcuslar.Columns["Id"].HeaderText = "Uçuş No";
                        dgvUcuslar.Columns["Id"].Visible = true; 
                    }

                    if (dgvUcuslar.Columns.Contains("UcakId"))
                    {
                        dgvUcuslar.Columns["UcakId"].HeaderText = "Uçak ID";
                        dgvUcuslar.Columns["UcakId"].Visible = true;
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
        }
        
        // ucus sılme butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUcuslar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir uçuş seçin!");
                return;
            }

            int ucusId = Convert.ToInt32(dgvUcuslar.SelectedRows[0].Cells["Id"].Value);

            DialogResult sonuc = MessageBox.Show("Bu uçuş silindiğinde ona ait TÜM rezervasyon kayıtları (iptal edilenler dahil) veritabanından temizlenecektir. Emin misiniz?", "Kritik Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True"))
                {
                    try
                    {
                        baglanti.Open();

                        string rezTemizleSorgu = "DELETE FROM Rezervasyonlar WHERE UcusId = @uid";
                        SqlCommand rezKomut = new SqlCommand(rezTemizleSorgu, baglanti);
                        rezKomut.Parameters.AddWithValue("@uid", ucusId);
                        rezKomut.ExecuteNonQuery();

                        string ucusSilSorgu = "DELETE FROM Ucuslar WHERE Id = @id";
                        SqlCommand ucusKomut = new SqlCommand(ucusSilSorgu, baglanti);
                        ucusKomut.Parameters.AddWithValue("@id", ucusId);

                        int silinenSatir = ucusKomut.ExecuteNonQuery();

                        if (silinenSatir > 0)
                        {
                            MessageBox.Show("Uçuş ve bağlı  kayıtlar başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UcuslariListele(); // Tabloyu yenılenıer
                        }
                        else
                        {
                            MessageBox.Show("Uçuş bulunamadı veya silinemedi.", "Hata");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //gerı don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AdminAnaMenü adminMenu = new AdminAnaMenü();
            adminMenu.Show();
            this.Hide(); 
        }
    }
}