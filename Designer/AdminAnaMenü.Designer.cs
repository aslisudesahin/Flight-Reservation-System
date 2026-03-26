namespace FligthReservationSystem
{
    partial class AdminAnaMenü
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBaslik = new Label();
            btnUcusEkle = new Button();
            btnUcakEkle = new Button();
            btnUcakListele = new Button();
            btnUcusSil = new Button();
            btnUcusGuncelle = new Button();
            btnKullaniciYonetim = new Button();
            btnGeriDon = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Anchor = AnchorStyles.Top;
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(44, 29, 33);
            lblBaslik.Location = new Point(131, 24);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(379, 41);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "ADMİN YÖNETİM PANELİ";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUcusEkle
            // 
            btnUcusEkle.BackColor = Color.FromArgb(146, 108, 120);
            btnUcusEkle.FlatAppearance.BorderSize = 0;
            btnUcusEkle.FlatStyle = FlatStyle.Flat;
            btnUcusEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUcusEkle.ForeColor = Color.White;
            btnUcusEkle.Location = new Point(180, 80);
            btnUcusEkle.Name = "btnUcusEkle";
            btnUcusEkle.Size = new Size(300, 45);
            btnUcusEkle.TabIndex = 1;
            btnUcusEkle.Text = "➕ Uçuş Ekle";
            btnUcusEkle.UseVisualStyleBackColor = false;
            btnUcusEkle.Click += btnUcusEkle_Click;
            // 
            // btnUcakEkle
            // 
            btnUcakEkle.BackColor = Color.FromArgb(146, 108, 120);
            btnUcakEkle.FlatAppearance.BorderSize = 0;
            btnUcakEkle.FlatStyle = FlatStyle.Flat;
            btnUcakEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUcakEkle.ForeColor = Color.White;
            btnUcakEkle.Location = new Point(180, 135);
            btnUcakEkle.Name = "btnUcakEkle";
            btnUcakEkle.Size = new Size(300, 45);
            btnUcakEkle.TabIndex = 2;
            btnUcakEkle.Text = "✈️ Uçak Ekle";
            btnUcakEkle.UseVisualStyleBackColor = false;
            btnUcakEkle.Click += btnUcakEkle_Click;
            // 
            // btnUcakListele
            // 
            btnUcakListele.BackColor = Color.FromArgb(146, 108, 120);
            btnUcakListele.FlatAppearance.BorderSize = 0;
            btnUcakListele.FlatStyle = FlatStyle.Flat;
            btnUcakListele.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUcakListele.ForeColor = Color.White;
            btnUcakListele.Location = new Point(180, 190);
            btnUcakListele.Name = "btnUcakListele";
            btnUcakListele.Size = new Size(300, 45);
            btnUcakListele.TabIndex = 3;
            btnUcakListele.Text = "📋 Uçakları Listele";
            btnUcakListele.UseVisualStyleBackColor = false;
            btnUcakListele.Click += btnUcakListele_Click;
            // 
            // btnUcusSil
            // 
            btnUcusSil.BackColor = Color.FromArgb(129, 92, 94);
            btnUcusSil.FlatAppearance.BorderSize = 0;
            btnUcusSil.FlatStyle = FlatStyle.Flat;
            btnUcusSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUcusSil.ForeColor = Color.White;
            btnUcusSil.Location = new Point(180, 245);
            btnUcusSil.Name = "btnUcusSil";
            btnUcusSil.Size = new Size(300, 45);
            btnUcusSil.TabIndex = 4;
            btnUcusSil.Text = "🗑️ Uçuş Sil";
            btnUcusSil.UseVisualStyleBackColor = false;
            btnUcusSil.Click += btnUcusSil_Click;
            // 
            // btnUcusGuncelle
            // 
            btnUcusGuncelle.BackColor = Color.FromArgb(146, 108, 120);
            btnUcusGuncelle.FlatAppearance.BorderSize = 0;
            btnUcusGuncelle.FlatStyle = FlatStyle.Flat;
            btnUcusGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUcusGuncelle.ForeColor = Color.White;
            btnUcusGuncelle.Location = new Point(180, 300);
            btnUcusGuncelle.Name = "btnUcusGuncelle";
            btnUcusGuncelle.Size = new Size(300, 45);
            btnUcusGuncelle.TabIndex = 5;
            btnUcusGuncelle.Text = "🔄 Uçuş Güncelle";
            btnUcusGuncelle.UseVisualStyleBackColor = false;
            btnUcusGuncelle.Click += btnUcusGuncelle_Click;
            // 
            // btnKullaniciYonetim
            // 
            btnKullaniciYonetim.BackColor = Color.FromArgb(129, 92, 94);
            btnKullaniciYonetim.FlatAppearance.BorderSize = 0;
            btnKullaniciYonetim.FlatStyle = FlatStyle.Flat;
            btnKullaniciYonetim.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKullaniciYonetim.ForeColor = Color.White;
            btnKullaniciYonetim.Location = new Point(180, 355);
            btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            btnKullaniciYonetim.Size = new Size(300, 45);
            btnKullaniciYonetim.TabIndex = 6;
            btnKullaniciYonetim.Text = "👥 Kullanıcı Yönetimi";
            btnKullaniciYonetim.UseVisualStyleBackColor = false;
            btnKullaniciYonetim.Click += btnKullaniciYonetim_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(73, 51, 57);
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriDon.ForeColor = Color.WhiteSmoke;
            btnGeriDon.Location = new Point(240, 420);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(180, 35);
            btnGeriDon.TabIndex = 7;
            btnGeriDon.Text = "GİRİŞ EKRANINA DÖN";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // AdminAnaMenü
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 231, 235);
            ClientSize = new Size(660, 520);
            Controls.Add(lblBaslik);
            Controls.Add(btnGeriDon);
            Controls.Add(btnKullaniciYonetim);
            Controls.Add(btnUcusGuncelle);
            Controls.Add(btnUcusSil);
            Controls.Add(btnUcakListele);
            Controls.Add(btnUcakEkle);
            Controls.Add(btnUcusEkle);
            Name = "AdminAnaMenü";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Yönetim Merkezi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnUcusEkle;
        private System.Windows.Forms.Button btnUcakEkle;
        private System.Windows.Forms.Button btnUcakListele; 
        private System.Windows.Forms.Button btnUcusSil;
        private System.Windows.Forms.Button btnUcusGuncelle;
        private System.Windows.Forms.Button btnKullaniciYonetim;
        private System.Windows.Forms.Button btnGeriDon;
    }
}