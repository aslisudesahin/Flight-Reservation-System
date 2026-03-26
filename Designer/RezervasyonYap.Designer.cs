namespace FligthReservationSystem
{
    partial class RezervasyonYap
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
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUcuslar = new System.Windows.Forms.DataGridView();
            this.pnlKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblFiyatBaslik = new System.Windows.Forms.Label();
            this.lblGuncelFiyat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKupon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
        
            // cmbNereden 
            this.cmbNereden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(30, 50);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(150, 31);
            this.cmbNereden.TabIndex = 0;
             
            // cmbNereye 
            this.cmbNereye.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(200, 50);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(150, 31);
            this.cmbNereye.TabIndex = 1;
            
            // label1 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereden:";

            // label2 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(200, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereye:";
           
            // btnAra
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(550, 45);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 40);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Uçuş Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
          
            // dtpTarih
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(370, 51);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(150, 30);
            this.dtpTarih.TabIndex = 5;
            
            // label3 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(370, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih:";
        
            // dgvUcuslar
            this.dgvUcuslar.AllowUserToAddRows = false;
            this.dgvUcuslar.AllowUserToDeleteRows = false;
            this.dgvUcuslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcuslar.BackgroundColor = System.Drawing.Color.White;
            this.dgvUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcuslar.Location = new System.Drawing.Point(30, 100);
            this.dgvUcuslar.MultiSelect = false;
            this.dgvUcuslar.Name = "dgvUcuslar";
            this.dgvUcuslar.ReadOnly = true;
            this.dgvUcuslar.RowHeadersVisible = false;
            this.dgvUcuslar.RowHeadersWidth = 51;
            this.dgvUcuslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcuslar.Size = new System.Drawing.Size(620, 150);
            this.dgvUcuslar.TabIndex = 7;
            this.dgvUcuslar.SelectionChanged += new System.EventHandler(this.dgvUcuslar_SelectionChanged);
            

            // pnlKoltuklar 
            this.pnlKoltuklar.AutoScroll = true;
            this.pnlKoltuklar.BackColor = System.Drawing.Color.White;
            this.pnlKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKoltuklar.Location = new System.Drawing.Point(670, 50);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(340, 550);
            this.pnlKoltuklar.TabIndex = 8;
            
            // groupBox1
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.groupBox1.Location = new System.Drawing.Point(30, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yolcu Bilgileri (Güvenlik Kontrolü)";
           
            // txtTelefon
            this.txtTelefon.Location = new System.Drawing.Point(150, 100);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 30);
            this.txtTelefon.TabIndex = 5;
            
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon:";
             
            // txtTC 
            this.txtTC.Location = new System.Drawing.Point(150, 65);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 30);
            this.txtTC.TabIndex = 3;
 
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "TC Kimlik No:";
             
            // txtAdSoyad
            this.txtAdSoyad.Location = new System.Drawing.Point(150, 30);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 30);
            this.txtAdSoyad.TabIndex = 1;
             
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad Soyad:";
          
            // btnRezervasyonYap
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(30, 540);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(300, 55);
            this.btnRezervasyonYap.TabIndex = 10;
            this.btnRezervasyonYap.Text = "ÖDEME YAP VE BİTİR";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            
            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnGeriDon.Location = new System.Drawing.Point(350, 540);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(150, 55);
            this.btnGeriDon.TabIndex = 11;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
         
            // lblFiyatBaslik
            this.lblFiyatBaslik.AutoSize = true;
            this.lblFiyatBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFiyatBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblFiyatBaslik.Location = new System.Drawing.Point(30, 490);
            this.lblFiyatBaslik.Name = "lblFiyatBaslik";
            this.lblFiyatBaslik.Size = new System.Drawing.Size(193, 32);
            this.lblFiyatBaslik.TabIndex = 12;
            this.lblFiyatBaslik.Text = "ÖDENECEK NET:";
            
            // lblGuncelFiyat
            this.lblGuncelFiyat.AutoSize = true;
            this.lblGuncelFiyat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGuncelFiyat.ForeColor = System.Drawing.Color.Crimson;
            this.lblGuncelFiyat.Location = new System.Drawing.Point(230, 485);
            this.lblGuncelFiyat.Name = "lblGuncelFiyat";
            this.lblGuncelFiyat.Size = new System.Drawing.Size(113, 37);
            this.lblGuncelFiyat.TabIndex = 13;
            this.lblGuncelFiyat.Text = "0,00 TL";
            
            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(30, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kupon Kodu:";
           
            // txtKupon
            this.txtKupon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKupon.Location = new System.Drawing.Point(150, 442);
            this.txtKupon.Name = "txtKupon";
            this.txtKupon.Size = new System.Drawing.Size(200, 30);
            this.txtKupon.TabIndex = 15;
            this.txtKupon.TextChanged += new System.EventHandler(this.txtKupon_TextChanged);
             
            // RezervasyonYap 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1020, 620);
            this.Controls.Add(this.txtKupon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGuncelFiyat);
            this.Controls.Add(this.lblFiyatBaslik);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.dgvUcuslar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Name = "RezervasyonYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Ekranı";
            this.Load += new System.EventHandler(this.RezervasyonYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUcuslar;
        private System.Windows.Forms.FlowLayoutPanel pnlKoltuklar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblFiyatBaslik;
        private System.Windows.Forms.Label lblGuncelFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKupon;
    }
}