using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class KullanıcıGöster : Form
    {
        // baglantı adresı
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";
        public KullanıcıGöster()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            KullanicilariListele();
        }

        // Kullanıcı ve rol listeleme
        private void KullanicilariListele()
        {
            string sorgu = "SELECT Id, AdSoyad, Email, Rol, TcNo, Telefon FROM Kullanicilar";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKullanicilar.DataSource = dt;

                    // sifre sutununu guvenlik icin gizlenır
                    if (dgvKullanicilar.Columns.Contains("Sifre"))
                    {
                        dgvKullanicilar.Columns["Sifre"].Visible = false;
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Listeleme Hatası: " + hata.Message, "Hata");
                }
            }
        }

        // Rol degistir butonu
        private void btnRolDegistir_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen rolünü değiştirmek istediğiniz bir kullanıcı seçin.", "Uyarı");
                return;
            }

            DataGridViewRow row = dgvKullanicilar.SelectedRows[0];
            int userId = Convert.ToInt32(row.Cells["Id"].Value);
            string mevcutRol = row.Cells["Rol"].Value.ToString();

            // Yeni rolü belirler
            string yeniRol = (mevcutRol == "Admin") ? "Musteri" : "Admin";

            DialogResult sonuc = MessageBox.Show($"{mevcutRol} rolündeki kullanıcının rolünü '{yeniRol}' olarak değiştirmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                string sorgu = "UPDATE Kullanicilar SET Rol = @rol WHERE Id = @id";

                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@rol", yeniRol);
                        komut.Parameters.AddWithValue("@id", userId);
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Rol başarıyla güncellendi.", "Başarılı");
                        KullanicilariListele(); 
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Rol Değiştirme Hatası: " + hata.Message, "Hata");
                    }
                }
            }
        }

        // Kullanıcı sil butonu
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kullanıcı seçin.", "Uyarı");
                return;
            }

            int userId = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["Id"].Value);

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    
                    // once veritabanına sorulur "Bu kullanıcının rezervasyonu var mı"
                    string kontrolSorgu = "SELECT COUNT(*) FROM Rezervasyonlar WHERE MusteriId = @id";
                    SqlCommand kmtKontrol = new SqlCommand(kontrolSorgu, baglanti);
                    kmtKontrol.Parameters.AddWithValue("@id", userId);

                    
                    int rezervasyonSayisi = (int)kmtKontrol.ExecuteScalar();

                    if (rezervasyonSayisi > 0)
                    {
                       //eger rezervasyonu varsa uyarı verır
                        MessageBox.Show("DİKKAT: Bu kullanıcının aktif rezervasyonları bulunmaktadır!\n\nÖnce rezervasyonlarını iptal etmeniz gerekmektedir. Kullanıcı silinemez.", "İşlem Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return; // Metodu burada bitir, silme koduna geçme.
                    }

                   
                    // eger rezervasyonu yoksa burası çalışır
                    DialogResult sonuc = MessageBox.Show($"Kullanıcı ID: {userId} kalıcı olarak silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        string silSorgu = "DELETE FROM Kullanicilar WHERE Id = @id";
                        SqlCommand kmtSil = new SqlCommand(silSorgu, baglanti);
                        kmtSil.Parameters.AddWithValue("@id", userId);
                        kmtSil.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı");
                        KullanicilariListele(); 
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message, "Hata");
                }
            }
        }

        // Geri don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AdminAnaMenü adminMenu = new AdminAnaMenü();
            adminMenu.Show();
            this.Close();
        }
    }
}