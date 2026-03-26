namespace FligthReservationSystem
{
    partial class Rezervasyonİptal
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
            this.dgvIptalListesi = new System.Windows.Forms.DataGridView();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIptalListesi)).BeginInit();
            this.SuspendLayout();

            
            
            // lblBaslik
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33))))); 
            this.lblBaslik.Location = new System.Drawing.Point(230, 25);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(340, 41);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "REZERVASYON İPTALİ";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            // dgvIptalListesi 
            this.dgvIptalListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIptalListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvIptalListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIptalListesi.Location = new System.Drawing.Point(30, 85);
            this.dgvIptalListesi.Name = "dgvIptalListesi";
            this.dgvIptalListesi.RowHeadersWidth = 51;
            this.dgvIptalListesi.RowTemplate.Height = 29;
            this.dgvIptalListesi.Size = new System.Drawing.Size(740, 310);
            this.dgvIptalListesi.TabIndex = 0;
            this.dgvIptalListesi.ReadOnly = true;
            this.dgvIptalListesi.AllowUserToAddRows = false;
            this.dgvIptalListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            
            // btnIptalEt
            this.btnIptalEt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIptalEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43))))); 
            this.btnIptalEt.FlatAppearance.BorderSize = 0;
            this.btnIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptalEt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIptalEt.ForeColor = System.Drawing.Color.White;
            this.btnIptalEt.Location = new System.Drawing.Point(30, 415); 
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(220, 45);
            this.btnIptalEt.TabIndex = 1;
            this.btnIptalEt.Text = "❌ SEÇİLENİ İPTAL ET";
            this.btnIptalEt.UseVisualStyleBackColor = false;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);

            
            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120))))); 
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeriDon.Location = new System.Drawing.Point(20, 20); 
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(140, 35);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "← Menüye Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);

            
            // Rezervasyonİptal 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235))))); 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.dgvIptalListesi);
            this.Name = "Rezervasyonİptal"; 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon İptali";
            this.Load += new System.EventHandler(this.Rezervasyonİptal_Load); 
            ((System.ComponentModel.ISupportInitialize)(this.dgvIptalListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIptalListesi;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblBaslik;
    }
}