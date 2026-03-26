namespace FligthReservationSystem
{
    partial class UcusEkle
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
            lblNereden = new Label();
            lblNereye = new Label();
            lblTarih = new Label();
            lblSaat = new Label();
            lblFiyat = new Label();
            lblUcakId = new Label();
            txtNereden = new TextBox();
            txtNereye = new TextBox();
            dtpTarih = new DateTimePicker();
            dtpSaat = new DateTimePicker();
            txtFiyat = new TextBox();
            txtUcakId = new TextBox();
            chkSezon = new CheckBox();
            btnUcusEkle = new Button();
            btnGeriDon = new Button();
            SuspendLayout();

            // lblBaslik
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(44, 29, 33);
            lblBaslik.Location = new Point(187, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(223, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "YENİ UÇUŞ EKLE";

            // lblNereden
            lblNereden.AutoSize = true;
            lblNereden.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNereden.Location = new Point(50, 80);
            lblNereden.Name = "lblNereden";
            lblNereden.Size = new Size(94, 25);
            lblNereden.TabIndex = 1;
            lblNereden.Text = "Nereden:";

            // lblNereye 
            lblNereye.AutoSize = true;
            lblNereye.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNereye.Location = new Point(50, 120);
            lblNereye.Name = "lblNereye";
            lblNereye.Size = new Size(80, 25);
            lblNereye.TabIndex = 3;
            lblNereye.Text = "Nereye:";

            // lblTarih
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTarih.Location = new Point(50, 160);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(60, 25);
            lblTarih.TabIndex = 5;
            lblTarih.Text = "Tarih:";

            // lblSaat 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSaat.Location = new Point(50, 200);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(55, 25);
            lblSaat.TabIndex = 13;
            lblSaat.Text = "Saat:";

            // lblFiyat 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFiyat.Location = new Point(50, 240);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(59, 25);
            lblFiyat.TabIndex = 7;
            lblFiyat.Text = "Fiyat:";

            // lblUcakId 
            lblUcakId.AutoSize = true;
            lblUcakId.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUcakId.Location = new Point(50, 280);
            lblUcakId.Name = "lblUcakId";
            lblUcakId.Size = new Size(80, 25);
            lblUcakId.TabIndex = 11;
            lblUcakId.Text = "Uçak ID:";

            // txtNereden
            txtNereden.Font = new Font("Segoe UI", 11F);
            txtNereden.Location = new Point(160, 77);
            txtNereden.Name = "txtNereden";
            txtNereden.Size = new Size(250, 32);
            txtNereden.TabIndex = 2;

            // txtNereye 
            txtNereye.Font = new Font("Segoe UI", 11F);
            txtNereye.Location = new Point(160, 117);
            txtNereye.Name = "txtNereye";
            txtNereye.Size = new Size(250, 32);
            txtNereye.TabIndex = 4;

            // dtpTarih 
            dtpTarih.Font = new Font("Segoe UI", 11F);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(160, 157);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 32);
            dtpTarih.TabIndex = 6;

            // dtpSaat 
            dtpSaat.Font = new Font("Segoe UI", 11F);
            dtpSaat.Format = DateTimePickerFormat.Time;
            dtpSaat.ShowUpDown = true;
            dtpSaat.Location = new Point(160, 197);
            dtpSaat.Name = "dtpSaat";
            dtpSaat.Size = new Size(250, 32);
            dtpSaat.TabIndex = 14;

            // txtFiyat 
            txtFiyat.Font = new Font("Segoe UI", 11F);
            txtFiyat.Location = new Point(160, 237);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(250, 32);
            txtFiyat.TabIndex = 8;

            // txtUcakId
            txtUcakId.Font = new Font("Segoe UI", 11F);
            txtUcakId.Location = new Point(160, 277);
            txtUcakId.Name = "txtUcakId";
            txtUcakId.Size = new Size(250, 32);
            txtUcakId.TabIndex = 12;

            // chkSezon
            chkSezon.AutoSize = true;
            chkSezon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chkSezon.ForeColor = Color.FromArgb(73, 51, 57);
            chkSezon.Location = new Point(430, 239);
            chkSezon.Name = "chkSezon";
            chkSezon.Size = new Size(195, 29);
            chkSezon.TabIndex = 15;
            chkSezon.Text = "Yüksek Sezon mu?";
            chkSezon.UseVisualStyleBackColor = true;

            // btnUcusEkle
            btnUcusEkle.BackColor = Color.FromArgb(73, 51, 57);
            btnUcusEkle.FlatAppearance.BorderSize = 0;
            btnUcusEkle.FlatStyle = FlatStyle.Flat;
            btnUcusEkle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnUcusEkle.ForeColor = Color.White;
            btnUcusEkle.Location = new Point(160, 330);
            btnUcusEkle.Name = "btnUcusEkle";
            btnUcusEkle.Size = new Size(250, 50);
            btnUcusEkle.TabIndex = 9;
            btnUcusEkle.Text = "➕ UÇUŞU KAYDET";
            btnUcusEkle.UseVisualStyleBackColor = false;
            btnUcusEkle.Click += btnUcusEkle_Click;

            // btnGeriDon 
            btnGeriDon.BackColor = Color.FromArgb(146, 108, 120);
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGeriDon.ForeColor = Color.WhiteSmoke;
            btnGeriDon.Location = new Point(28, 20);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(120, 35);
            btnGeriDon.TabIndex = 10;
            btnGeriDon.Text = "← Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;

            // UcusEkle 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 231, 235);
            ClientSize = new Size(741, 450);
            Controls.Add(lblBaslik);
            Controls.Add(lblNereden);
            Controls.Add(lblNereye);
            Controls.Add(lblTarih);
            Controls.Add(lblSaat);
            Controls.Add(lblFiyat);
            Controls.Add(lblUcakId);
            Controls.Add(txtNereden);
            Controls.Add(txtNereye);
            Controls.Add(dtpTarih);
            Controls.Add(dtpSaat);
            Controls.Add(txtFiyat);
            Controls.Add(txtUcakId);
            Controls.Add(chkSezon);
            Controls.Add(btnUcusEkle);
            Controls.Add(btnGeriDon);
            Name = "UcusEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uçuş Ekleme İşlemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblNereden;
        private System.Windows.Forms.Label lblNereye;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUcakId;
        private System.Windows.Forms.TextBox txtNereden;
        private System.Windows.Forms.TextBox txtNereye;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUcakId;
        private System.Windows.Forms.CheckBox chkSezon;
        private System.Windows.Forms.Button btnUcusEkle;
        private System.Windows.Forms.Button btnGeriDon;
    }
}