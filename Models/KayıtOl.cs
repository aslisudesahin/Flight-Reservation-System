using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        // Veritabanı baglantı adresi
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTC.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text))   
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı baglantısını kurar 
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO Kullanicilar (AdSoyad, TCNo, Telefon, Email, Sifre) VALUES (@p1, @p2, @p3, @p4, @p5)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@p2", txtTC.Text);
                        komut.Parameters.AddWithValue("@p3", txtTel.Text);
                        komut.Parameters.AddWithValue("@p4", textBox1.Text);
                        komut.Parameters.AddWithValue("@p5", textBox2.Text);

                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla oluşturuldu! Ana menüye yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                          KullanıcıGiris giris = new KullanıcıGiris();
                           giris.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt oluşturulamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // gerı don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            
            GirisSecimFormu giris = new GirisSecimFormu();
            giris.Show();
            this.Close();
        }

        // dıger kayıt için gırılen bılgıler temızlenır
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtTC.Clear();
            txtTel.Clear();
            textBox1.Clear();
            textBox2.Clear();
            txtAdSoyad.Focus();
        }
    }
}