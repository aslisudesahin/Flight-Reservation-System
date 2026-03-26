namespace FligthReservationSystem
{
    partial class UcusGüncelle
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dgvUcuslar = new System.Windows.Forms.DataGridView();
            this.txtNereden = new System.Windows.Forms.TextBox();
            this.txtNereye = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblUcusId = new System.Windows.Forms.Label();
            this.lblNereden = new System.Windows.Forms.Label();
            this.lblNereye = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.chkSezon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).BeginInit();
            this.SuspendLayout();

            // lblBaslik 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblBaslik.Location = new System.Drawing.Point(300, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(250, 37);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "UÇUŞ GÜNCELLEME";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvUcuslar 
            this.dgvUcuslar.AllowUserToAddRows = false;
            this.dgvUcuslar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUcuslar.BackgroundColor = System.Drawing.Color.White;
            this.dgvUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcuslar.Location = new System.Drawing.Point(20, 200);
            this.dgvUcuslar.Name = "dgvUcuslar";
            this.dgvUcuslar.ReadOnly = true;
            this.dgvUcuslar.RowHeadersWidth = 51;
            this.dgvUcuslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcuslar.Size = new System.Drawing.Size(760, 250);
            this.dgvUcuslar.TabIndex = 6;
            this.dgvUcuslar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUcuslar_CellClick);

            // txtNereden 
            this.txtNereden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNereden.Location = new System.Drawing.Point(30, 120);
            this.txtNereden.Name = "txtNereden";
            this.txtNereden.Size = new System.Drawing.Size(110, 30);
            this.txtNereden.TabIndex = 1;

            // txtNereye 
            this.txtNereye.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNereye.Location = new System.Drawing.Point(150, 120);
            this.txtNereye.Name = "txtNereye";
            this.txtNereye.Size = new System.Drawing.Size(110, 30);
            this.txtNereye.TabIndex = 2;

            // dtpTarih 
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(270, 120);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(120, 30);
            this.dtpTarih.TabIndex = 3;

            // dtpSaat  
            this.dtpSaat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Location = new System.Drawing.Point(400, 120);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.Size = new System.Drawing.Size(90, 30);
            this.dtpSaat.TabIndex = 13;

            // txtFiyat
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFiyat.Location = new System.Drawing.Point(500, 120);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(80, 30);
            this.txtFiyat.TabIndex = 4;

            // chkSezon
            this.chkSezon.AutoSize = true;
            this.chkSezon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkSezon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.chkSezon.Location = new System.Drawing.Point(590, 125);
            this.chkSezon.Name = "chkSezon";
            this.chkSezon.Size = new System.Drawing.Size(120, 24);
            this.chkSezon.TabIndex = 15;
            this.chkSezon.Text = "Yüksek Sezon";
            this.chkSezon.UseVisualStyleBackColor = true;

            // btnGuncelle 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(715, 120);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 30);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeriDon.Location = new System.Drawing.Point(20, 10);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(120, 30);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "← Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);

            // lblUcusId
            this.lblUcusId.AutoSize = true;
            this.lblUcusId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUcusId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblUcusId.Location = new System.Drawing.Point(30, 55);
            this.lblUcusId.Name = "lblUcusId";
            this.lblUcusId.Size = new System.Drawing.Size(85, 23);
            this.lblUcusId.TabIndex = 8;
            this.lblUcusId.Text = "Seçili ID: ";

            // lblNereden
            this.lblNereden.AutoSize = true;
            this.lblNereden.Location = new System.Drawing.Point(30, 95);
            this.lblNereden.Name = "lblNereden";
            this.lblNereden.Size = new System.Drawing.Size(66, 20);
            this.lblNereden.TabIndex = 9;
            this.lblNereden.Text = "Nereden";

            // lblNereye
            this.lblNereye.AutoSize = true;
            this.lblNereye.Location = new System.Drawing.Point(150, 95);
            this.lblNereye.Name = "lblNereye";
            this.lblNereye.Size = new System.Drawing.Size(56, 20);
            this.lblNereye.TabIndex = 10;
            this.lblNereye.Text = "Nereye";

            // lblTarih
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(270, 95);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(40, 20);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "Tarih";

            // lblSaat 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(400, 95);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(38, 20);
            this.lblSaat.TabIndex = 14;
            this.lblSaat.Text = "Saat";

            // lblFiyat 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(500, 95);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(40, 20);
            this.lblFiyat.TabIndex = 12;
            this.lblFiyat.Text = "Fiyat";

            // UcusGüncelle 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.chkSezon);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblNereye);
            this.Controls.Add(this.lblNereden);
            this.Controls.Add(this.lblUcusId);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtNereye);
            this.Controls.Add(this.txtNereden);
            this.Controls.Add(this.dgvUcuslar);
            this.Name = "UcusGüncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçuş Güncelleme";
            this.Load += new System.EventHandler(this.UcusGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvUcuslar;
        private System.Windows.Forms.TextBox txtNereden;
        private System.Windows.Forms.TextBox txtNereye;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblUcusId;
        private System.Windows.Forms.Label lblNereden;
        private System.Windows.Forms.Label lblNereye;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.CheckBox chkSezon;
    }
}