namespace FligthReservationSystem
{
    partial class GirisSecimFormu
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
            lblSecimBaslik = new Label();
            btnAdminGiris = new Button();
            btnKullaniciGiris = new Button();
            btnKayıtOl = new Button();
            SuspendLayout();
            
            // lblSecimBaslik
            lblSecimBaslik.Anchor = AnchorStyles.Top;
            lblSecimBaslik.AutoSize = true;
            lblSecimBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSecimBaslik.ForeColor = Color.FromArgb(44, 29, 33);
            lblSecimBaslik.Location = new Point(154, 62);
            lblSecimBaslik.Name = "lblSecimBaslik";
            lblSecimBaslik.Size = new Size(497, 46);
            lblSecimBaslik.TabIndex = 0;
            lblSecimBaslik.Text = "UÇUŞ REZERVASYON SİSTEMİ";
            lblSecimBaslik.TextAlign = ContentAlignment.MiddleCenter;
 
            // btnAdminGiris 
            btnAdminGiris.BackColor = Color.FromArgb(146, 108, 120);
            btnAdminGiris.FlatAppearance.BorderSize = 0;
            btnAdminGiris.FlatStyle = FlatStyle.Flat;
            btnAdminGiris.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAdminGiris.ForeColor = Color.White;
            btnAdminGiris.Location = new Point(275, 160);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(250, 65);
            btnAdminGiris.TabIndex = 1;
            btnAdminGiris.Text = "👨‍💻 Admin Girişi";
            btnAdminGiris.UseVisualStyleBackColor = false;
            btnAdminGiris.Click += btnAdminGiris_Click;
         
            // btnKullaniciGiris
            btnKullaniciGiris.BackColor = Color.FromArgb(93, 61, 63);
            btnKullaniciGiris.FlatAppearance.BorderSize = 0;
            btnKullaniciGiris.FlatStyle = FlatStyle.Flat;
            btnKullaniciGiris.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKullaniciGiris.ForeColor = Color.White;
            btnKullaniciGiris.Location = new Point(275, 240);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(250, 65);
            btnKullaniciGiris.TabIndex = 2;
            btnKullaniciGiris.Text = "👤 Kullanıcı Girişi";
            btnKullaniciGiris.UseVisualStyleBackColor = false;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
             
            // btnKayıtOl 
            btnKayıtOl.BackColor = Color.FromArgb(73, 51, 57);
            btnKayıtOl.FlatAppearance.BorderSize = 0;
            btnKayıtOl.FlatStyle = FlatStyle.Flat;
            btnKayıtOl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKayıtOl.ForeColor = Color.WhiteSmoke;
            btnKayıtOl.Location = new Point(300, 340);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(200, 50);
            btnKayıtOl.TabIndex = 3;
            btnKayıtOl.Text = "✨ Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = false;
            btnKayıtOl.Click += btnKayıtOl_Click;
            
            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 231, 235);
            ClientSize = new Size(800, 480);
            Controls.Add(btnKayıtOl);
            Controls.Add(btnKullaniciGiris);
            Controls.Add(btnAdminGiris);
            Controls.Add(lblSecimBaslik);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Seçimi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSecimBaslik;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnKayıtOl;
    }
}