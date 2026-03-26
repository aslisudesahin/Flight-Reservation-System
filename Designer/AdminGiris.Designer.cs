namespace FligthReservationSystem
{
    partial class AdminGiris
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
            textBox1 = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            lblSifre = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            btnAdminGiris = new System.Windows.Forms.Button();
            lblBaslik = new System.Windows.Forms.Label();
            btnGeriDon = new System.Windows.Forms.Button();
            SuspendLayout();
             
            // textBox1 (Şifre Alanı) 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox1.Location = new System.Drawing.Point(290, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(280, 34);
            textBox1.TabIndex = 2;
            textBox1.PasswordChar = '*';
           
            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(44, 29, 33);
            lblEmail.Location = new System.Drawing.Point(180, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(74, 30);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-Mail";
             
            // lblSifre 
            lblSifre.AutoSize = true;
            lblSifre.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblSifre.ForeColor = System.Drawing.Color.FromArgb(44, 29, 33);
            lblSifre.Location = new System.Drawing.Point(180, 210);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new System.Drawing.Size(57, 30);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre";
       
            // textBox2 (E-Mail Alanı)
            textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox2.Location = new System.Drawing.Point(290, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(280, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
           
            // btnAdminGiris
            btnAdminGiris.BackColor = System.Drawing.Color.FromArgb(146, 108, 120);
            btnAdminGiris.FlatAppearance.BorderSize = 0;
            btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdminGiris.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnAdminGiris.ForeColor = System.Drawing.Color.White;
            btnAdminGiris.Location = new System.Drawing.Point(290, 290);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new System.Drawing.Size(280, 60);
            btnAdminGiris.TabIndex = 3;
            btnAdminGiris.Text = "🔑 GİRİŞ YAP";
            btnAdminGiris.UseVisualStyleBackColor = false;
            btnAdminGiris.Click += btnAdminGiris_Click;
             
            // lblBaslik
            lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblBaslik.ForeColor = System.Drawing.Color.FromArgb(44, 29, 33);
            lblBaslik.Location = new System.Drawing.Point(305, 40);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new System.Drawing.Size(251, 41);
            lblBaslik.TabIndex = 5;
            lblBaslik.Text = "YÖNETİCİ GİRİŞİ";
            lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // btnGeriDon 
            btnGeriDon.BackColor = System.Drawing.Color.FromArgb(93, 61, 63);
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnGeriDon.Location = new System.Drawing.Point(20, 20);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(120, 35);
            btnGeriDon.TabIndex = 4;
            btnGeriDon.Text = "← Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
             
            // AdminGiris
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 231, 235);
            ClientSize = new System.Drawing.Size(800, 480);
            Controls.Add(btnGeriDon);
            Controls.Add(lblBaslik);
            Controls.Add(btnAdminGiris);
            Controls.Add(textBox2);
            Controls.Add(lblSifre);
            Controls.Add(lblEmail);
            Controls.Add(textBox1);
            Name = "AdminGiris";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Yönetici Girişi";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGeriDon;
    }
}