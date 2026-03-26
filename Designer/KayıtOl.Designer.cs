namespace FligthReservationSystem
{
    partial class KayıtOl
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
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            
            // btnKayitOl
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(310, 420);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(180, 55);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            
            // lblUserName
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblUserName.Location = new System.Drawing.Point(180, 290);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 30);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Email";

            // lblSifre 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblSifre.Location = new System.Drawing.Point(180, 350);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(57, 30);
            this.lblSifre.TabIndex = 12;
            this.lblSifre.Text = "Şifre";
            
            // textBox1 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Location = new System.Drawing.Point(310, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 34);
            this.textBox1.TabIndex = 4;
             
            // textBox2
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(310, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(250, 34);
            this.textBox2.TabIndex = 5;
            
            // lblBaslik 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblBaslik.Location = new System.Drawing.Point(310, 30);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(178, 41);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ KAYIT";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeriDon.Location = new System.Drawing.Point(20, 20);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(120, 35);
            this.btnGeriDon.TabIndex = 7;
            this.btnGeriDon.Text = "← Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(180, 110);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(105, 30);
            this.lblAdSoyad.TabIndex = 8;
            this.lblAdSoyad.Text = "Ad Soyad";
             
            // txtAdSoyad
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAdSoyad.Location = new System.Drawing.Point(310, 107);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(250, 34);
            this.txtAdSoyad.TabIndex = 1;
            
            // lblTC 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblTC.Location = new System.Drawing.Point(180, 170);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(72, 30);
            this.lblTC.TabIndex = 9;
            this.lblTC.Text = "TC No";
  
            // txtTC
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTC.Location = new System.Drawing.Point(310, 167);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(250, 34);
            this.txtTC.TabIndex = 2;
            
            // lblTel
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblTel.Location = new System.Drawing.Point(180, 230);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(82, 30);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Telefon";
            
            // txtTel 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTel.Location = new System.Drawing.Point(310, 227);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(250, 34);
            this.txtTel.TabIndex = 3;
 
            // KayıtOl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnKayitOl);
            this.Name = "KayıtOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblTC;
        public System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.TextBox txtTel;
    }
}