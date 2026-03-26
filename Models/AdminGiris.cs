using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FligthReservationSystem
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        //giris butonu email ve sıfre alır
        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            string sifre = textBox1.Text;

            //baglantı adresı
            string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";

           
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    //  Email ve Şifre tutuyor mu sorgulanır
                    string sorgu = "SELECT * FROM Kullanicilar WHERE Email=@p1 AND Sifre=@p2 ";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", email);
                    komut.Parameters.AddWithValue("@p2", sifre);

                    SqlDataReader okuyucu = komut.ExecuteReader();

                    if (okuyucu.Read())
                    {
                        MessageBox.Show("Yönetici Girişi Başarılı! Hoşgeldiniz.");
                        this.Hide();

                        //  Admin Menusu  açılır
                        AdminAnaMenü adminPaneli = new AdminAnaMenü();
                        adminPaneli.Show();
                    }
                    else
                    {
                        MessageBox.Show("Giriş Başarısız! Bilgileriniz yanlış veya Yönetici yetkiniz yok.");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bağlantı Hatası: " + hata.Message + "\nSunucuyu kontrol edin!", "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void btnGeriDon_Click(object sender, EventArgs e) // Ana giriş menusune döner
        {
            GirisSecimFormu anaMenu = new GirisSecimFormu();
            anaMenu.Show();
            this.Close();
        }
    }
}