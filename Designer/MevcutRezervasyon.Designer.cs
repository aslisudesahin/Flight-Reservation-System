namespace FligthReservationSystem
{
    partial class MevcutRezervasyon 
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
            this.dgvRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).BeginInit();
            this.SuspendLayout();

           
            // lblBaslik
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblBaslik.Location = new System.Drawing.Point(230, 25);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(340, 41);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "MEVCUT REZERVASYONLAR";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvRezervasyonlar
            this.dgvRezervasyonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRezervasyonlar.BackgroundColor = System.Drawing.Color.White; 
            this.dgvRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyonlar.Location = new System.Drawing.Point(30, 85);
            this.dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            this.dgvRezervasyonlar.RowHeadersWidth = 51;
            this.dgvRezervasyonlar.RowTemplate.Height = 29;
            this.dgvRezervasyonlar.Size = new System.Drawing.Size(740, 350);
            this.dgvRezervasyonlar.TabIndex = 0;
            this.dgvRezervasyonlar.ReadOnly = true;
            this.dgvRezervasyonlar.AllowUserToAddRows = false;

           
            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120))))); 
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeriDon.Location = new System.Drawing.Point(20, 20); 
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(140, 35);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "← Menüye Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);

            
            // MevcutRezervasyon 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235))))); 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dgvRezervasyonlar);
            this.Name = "MevcutRezervasyon"; 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyonlarım";
            this.Load += new System.EventHandler(this.MevcutRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervasyonlar;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblBaslik;
    }
}