using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FligthReservationSystem
{
    public partial class RezervasyonYap : Form
    {
        //baglantı adresi
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";
        private int _aktifMusteriId;
        private string _secilenKoltuk = "";
        private bool _isBusiness = false;
        private decimal _hamFiyat = 0;
        private int _secilenUcusKapasitesi = 0;
        private DateTime _secilenUcusTarihi;

        
        public RezervasyonYap(int musteriId)
        {
            InitializeComponent();
            _aktifMusteriId = musteriId;
        }

        public RezervasyonYap() : this(0) { }

       // rezervasayon yap butonu
        private void RezervasyonYap_Load(object sender, EventArgs e)
        {
            if (_aktifMusteriId <= 0)
            {
                MessageBox.Show("Güvenlik Uyarısı: Kullanıcı girişi doğrulanmadı.");
                this.Close();
                return;
            }

            SehirleriDoldur();
            KoltuklariOlustur(150);
            UcuslariGetir("SELECT * FROM Ucuslar WHERE AktifMi = 1");
            lblGuncelFiyat.Text = "0,00 TL";
        }

        // arama listesine otomatik sehırler doldurulur
        private void SehirleriDoldur()
        {
            cmbNereden.Items.Clear(); cmbNereye.Items.Clear();
            string[] sehirler = { "Istanbul", "Ankara", "Izmir", "Antalya", "Trabzon", "Gaziantep" };
            cmbNereden.Items.AddRange(sehirler);
            cmbNereye.Items.AddRange(sehirler);
        }

        // koltuk panelı 
        private void KoltuklariOlustur(int sayi)
        {
            pnlKoltuklar.Controls.Clear();
            pnlKoltuklar.AutoScroll = true;

            for (int i = 1; i <= sayi; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Size = new Size(45, 45);
                btn.Margin = new Padding(2);
                btn.FlatStyle = FlatStyle.Flat;

                if (i <= 30)
                {
                    btn.BackColor = Color.Gold;
                    btn.Tag = "Business";
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.Tag = "Ekonomi";
                }

                btn.Click += Koltuk_Click;
                pnlKoltuklar.Controls.Add(btn);
            }
        }

        //koltuk secımı yapılır
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (tiklanan.BackColor == Color.Red) return;

            foreach (Control ctrl in pnlKoltuklar.Controls)
            {
                if (ctrl is Button b)
                {
                    if (b.BackColor == Color.Green)
                        b.BackColor = (b.Tag.ToString() == "Business") ? Color.Gold : Color.White;
                }
            }

            tiklanan.BackColor = Color.Green;
            _secilenKoltuk = tiklanan.Text;
            _isBusiness = (tiklanan.Tag.ToString() == "Business");
            DinamikFiyatHesapla();
        }

        // koltuk durumu duzenlenır
        private void DoluKoltuklariIsaretle(int ucusId)
        {
            foreach (Control ctrl in pnlKoltuklar.Controls)
            {
                if (ctrl is Button btn)
                {
                    int koltukNo = int.Parse(btn.Text);
                    btn.Enabled = true;
                    btn.BackColor = (koltukNo <= 30) ? Color.Gold : Color.White;
                }
            }
            _secilenKoltuk = "";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT KoltukNo FROM Rezervasyonlar WHERE UcusId = @uid AND Durum = 'Aktif'";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@uid", ucusId);

                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        string doluNo = dr["KoltukNo"].ToString();
                        foreach (Control ctrl in pnlKoltuklar.Controls)
                        {
                            if (ctrl is Button btn && btn.Text == doluNo)
                            {
                                btn.BackColor = Color.Red;
                                btn.Enabled = false;
                                break;
                            }
                        }
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koltuk durumu yüklenirken hata: " + ex.Message);
                }
            }
        }

        // tanımlanan kuponu bir kullanıcı bır kez kulllanabılır . Kupon kullanılma durumu kontrol edılır
        private bool KuponDahaOnceKullanildiMi(string kuponKodu)
        {
            bool kullanilmis = false;
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT COUNT(*) FROM Rezervasyonlar WHERE MusteriId = @mid AND KuponKodu = @kupon";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@mid", _aktifMusteriId);
                    komut.Parameters.AddWithValue("@kupon", kuponKodu);

                    int sayi = (int)komut.ExecuteScalar();
                    if (sayi > 0) kullanilmis = true;
                }
                catch { kullanilmis = false; }
            }
            return kullanilmis;
        }

        // dımaık fıyatlandırma yapılır
        private void DinamikFiyatHesapla()
        {
            if (_hamFiyat <= 0 || string.IsNullOrEmpty(_secilenKoltuk)) return;

            bool sezonDurumu = false;
            if (dgvUcuslar.SelectedRows.Count > 0 && dgvUcuslar.Columns.Contains("IsHighSeason"))
            {
                var cell = dgvUcuslar.SelectedRows[0].Cells["IsHighSeason"];
                if (cell != null && cell.Value != DBNull.Value)
                {
                    sezonDurumu = Convert.ToBoolean(cell.Value);
                }
            }

            Flight geciciUcus = new Flight(0, "", "", "", _secilenUcusTarihi, TimeSpan.Zero, _secilenUcusKapasitesi, 0, _hamFiyat, sezonDurumu);
            Reservation hesaplayici = new Reservation(0, geciciUcus, _aktifMusteriId, _secilenKoltuk);

            string kuponKodu = txtKupon.Text.Trim().ToUpper();
            if (kuponKodu == "FINAL100")
            {
                if (KuponDahaOnceKullanildiMi("FINAL100"))
                {
                    MessageBox.Show("Bu kuponu kullandınız.");
                    kuponKodu = "";
                }
            }

            hesaplayici.CalculateFinalPrice(kuponKodu);
            lblGuncelFiyat.Text = hesaplayici.TotalPrice.ToString("N2") + " TL";
        }

        private void txtKupon_TextChanged(object sender, EventArgs e) { DinamikFiyatHesapla(); }

        private void dgvUcuslar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUcuslar.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvUcuslar.SelectedRows[0];
            try
            {
                _hamFiyat = Convert.ToDecimal(row.Cells["Fiyat"].Value);
                _secilenUcusTarihi = Convert.ToDateTime(row.Cells["Tarih"].Value);
                _secilenUcusKapasitesi = Convert.ToInt32(row.Cells["Kapasite"].Value);
                DoluKoltuklariIsaretle(Convert.ToInt32(row.Cells["Id"].Value));
                DinamikFiyatHesapla();
            }
            catch { }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Ucuslar WHERE AktifMi = 1";
            if (!string.IsNullOrEmpty(cmbNereden.Text)) sorgu += $" AND Nereden = '{cmbNereden.Text}'";
            if (!string.IsNullOrEmpty(cmbNereye.Text)) sorgu += $" AND Nereye = '{cmbNereye.Text}'";
            UcuslariGetir(sorgu);
        }

        // ucuslar tablosu vertabanından cekılır
        private void UcuslariGetir(string sql)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUcuslar.DataSource = dt;

                    if (dgvUcuslar.Columns.Contains("IsHighSeason"))
                    {
                        dgvUcuslar.Columns["IsHighSeason"].Visible = false;
                    }

                    if (dgvUcuslar.Columns.Contains("AktifMi"))
                    {
                        dgvUcuslar.Columns["AktifMi"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uçuşlar listelenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // rezervasyon yap butonu
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (dgvUcuslar.SelectedRows.Count == 0 || string.IsNullOrEmpty(_secilenKoltuk)) return;

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    decimal sonFiyat = decimal.Parse(lblGuncelFiyat.Text.Replace("TL", "").Trim());

                    string kayitSorgu = @"INSERT INTO Rezervasyonlar (MusteriId, UcusId, KoltukNo, YolcuAdSoyad, YolcuTc, YolcuTel, OdenenFiyat, Durum, OlusturmaTarihi) 
                                          VALUES (@mid, @uid, @kno, @ad, @tc, @tel, @fiyat, 'Aktif', GETDATE())";

                    SqlCommand kmtKayit = new SqlCommand(kayitSorgu, baglanti);
                    kmtKayit.Parameters.AddWithValue("@mid", _aktifMusteriId > 0 ? _aktifMusteriId : 1002);
                    kmtKayit.Parameters.AddWithValue("@uid", dgvUcuslar.SelectedRows[0].Cells["Id"].Value);
                    kmtKayit.Parameters.AddWithValue("@kno", _secilenKoltuk);
                    kmtKayit.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                    kmtKayit.Parameters.AddWithValue("@tc", txtTC.Text);
                    kmtKayit.Parameters.AddWithValue("@tel", txtTelefon.Text);
                    kmtKayit.Parameters.AddWithValue("@fiyat", sonFiyat);

                    kmtKayit.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon Başarılı! Ödenen Tutar: " + lblGuncelFiyat.Text);
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e) { this.Close(); }
    } 
} 