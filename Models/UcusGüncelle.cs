using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class UcusGüncelle : Form
    {
        //baglantı adresi
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";
        private int _seciliUcusId = -1; // guncellenecek ucusuun Id'sini tutar

        public UcusGüncelle()
        {
            InitializeComponent();
        }

        private void UcusGüncelle_Load(object sender, EventArgs e)
        {
            UcuslariListele();
            lblUcusId.Text = "Seçili ID: --";
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
        // DataGridViewde satır tıklandıgında Textboxları ve CheckBox'ı doldurur
        private void dgvUcuslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUcuslar.Rows[e.RowIndex];

                _seciliUcusId = Convert.ToInt32(row.Cells["Id"].Value);
                lblUcusId.Text = "Seçili ID: " + _seciliUcusId.ToString();

                txtNereden.Text = row.Cells["Nereden"].Value.ToString();
                txtNereye.Text = row.Cells["Nereye"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();

                
                if (row.Cells["IsHighSeason"].Value != DBNull.Value)
                {
                    chkSezon.Checked = Convert.ToBoolean(row.Cells["IsHighSeason"].Value);
                }
                else
                {
                    chkSezon.Checked = false;
                }

                if (DateTime.TryParse(row.Cells["Tarih"].Value.ToString(), out DateTime tarih))
                {
                    dtpTarih.Value = tarih;
                }

                if (row.Cells["Saat"].Value != null)
                {
                    string saatStr = row.Cells["Saat"].Value.ToString();
                    try
                    {
                        dtpSaat.Value = DateTime.Parse(saatStr);
                    }
                    catch
                    {
                        // Format hatası olursa varsayılan kalır
                    }
                }
            }
        }

        // Guncelle butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliUcusId == -1)
            {
                MessageBox.Show("Lütfen önce listeden bir uçuş seçiniz.", "Uyarı");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Fiyat alanı sayısal bir değer olmalıdır.", "Hata");
                return;
            }

            
            string sorgu = @"UPDATE Ucuslar SET Nereden = @p1, Nereye = @p2, Tarih = @p3, Saat = @pSaat, Fiyat = @p4, IsHighSeason = @p6 WHERE Id = @p5";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", txtNereden.Text);
                    komut.Parameters.AddWithValue("@p2", txtNereye.Text);
                    komut.Parameters.AddWithValue("@p3", dtpTarih.Value.Date);
                    komut.Parameters.AddWithValue("@pSaat", dtpSaat.Value.ToString("HH:mm"));
                    komut.Parameters.AddWithValue("@p4", fiyat);
                    komut.Parameters.AddWithValue("@p5", _seciliUcusId);
                    komut.Parameters.AddWithValue("@p6", chkSezon.Checked); 

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Uçuş bilgileri  başarıyla güncellendi.", "Başarılı");
                    UcuslariListele();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Güncelleme Hatası: " + hata.Message, "Hata");
                }
            }
        }

        // Geri don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAnaMenü adminMenu = new AdminAnaMenü();
            adminMenu.Show();
        }
    }
}