namespace FligthReservationSystem
{
    partial class UcusAra
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
            this.lblNereden = new System.Windows.Forms.Label();
            this.lblNereye = new System.Windows.Forms.Label();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvUcuslar = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).BeginInit();
            this.SuspendLayout();

           

           
            // lblBaslik
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33))))); 
            this.lblBaslik.Location = new System.Drawing.Point(300, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(209, 41);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "UÇUŞ ARAMA";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
 
            // lblNereden 
            this.lblNereden.AutoSize = true;
            this.lblNereden.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNereden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblNereden.Location = new System.Drawing.Point(50, 85);
            this.lblNereden.Name = "lblNereden";
            this.lblNereden.Size = new System.Drawing.Size(86, 23);
            this.lblNereden.TabIndex = 1;
            this.lblNereden.Text = "Nereden:";

             
            // cmbNereden
            this.cmbNereden.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(50, 110);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(180, 33);
            this.cmbNereden.TabIndex = 2;
            this.cmbNereden.Text = "Kalkış Yeri Seçin";

            
            // lblNereye
            this.lblNereye.AutoSize = true;
            this.lblNereye.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNereye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.lblNereye.Location = new System.Drawing.Point(240, 85);
            this.lblNereye.Name = "lblNereye";
            this.lblNereye.Size = new System.Drawing.Size(70, 23);
            this.lblNereye.TabIndex = 3;
            this.lblNereye.Text = "Nereye:";

            
            // cmbNereye
            this.cmbNereye.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(240, 110);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(180, 33);
            this.cmbNereye.TabIndex = 4;
            this.cmbNereye.Text = "Varış Yeri Seçin";

             
            // dtpTarih 
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpTarih.Location = new System.Drawing.Point(430, 110);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(220, 32);
            this.dtpTarih.TabIndex = 5;
            
            // btnAra
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(94))))); 
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(660, 107);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 38);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "🔎 ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);

            
            // dgvUcuslar
            this.dgvUcuslar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUcuslar.BackgroundColor = System.Drawing.Color.White; 
            this.dgvUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcuslar.Location = new System.Drawing.Point(30, 170);
            this.dgvUcuslar.Name = "dgvUcuslar";
            this.dgvUcuslar.RowHeadersWidth = 51;
            this.dgvUcuslar.RowTemplate.Height = 29;
            this.dgvUcuslar.Size = new System.Drawing.Size(740, 270);
            this.dgvUcuslar.TabIndex = 7;
            this.dgvUcuslar.ReadOnly = true;
            this.dgvUcuslar.AllowUserToAddRows = false;

            
            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(51)))), ((int)(((byte)(57))))); 
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeriDon.Location = new System.Drawing.Point(20, 20);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(140, 35);
            this.btnGeriDon.TabIndex = 8;
            this.btnGeriDon.Text = "← Menüye Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);

            
            // Ucus ara 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235))))); 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dgvUcuslar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.lblNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.lblNereden);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçuş Arama ve Listeleme";
            this.Load += new System.EventHandler(this.UcusAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblNereden;
        private System.Windows.Forms.Label lblNereye;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvUcuslar;
        private System.Windows.Forms.Button btnGeriDon;
    }
}