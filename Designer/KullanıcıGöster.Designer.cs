namespace FligthReservationSystem
{
    partial class KullanıcıGöster
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
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnRolDegistir = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();


             
            // lblBaslik
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33))))); // Koyu Bordo/Kahve
            this.lblBaslik.Location = new System.Drawing.Point(230, 25);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(340, 41);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "YÖNETİCİ - KULLANICILAR";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            // dgvKullanicilar
            this.dgvKullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(30, 85);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 29;
            this.dgvKullanicilar.Size = new System.Drawing.Size(740, 310);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

             
            // btnRolDegistir 
            this.btnRolDegistir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnRolDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120))))); // Açık Bordo
            this.btnRolDegistir.FlatAppearance.BorderSize = 0;
            this.btnRolDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolDegistir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRolDegistir.ForeColor = System.Drawing.Color.White;
            this.btnRolDegistir.Location = new System.Drawing.Point(30, 415);
            this.btnRolDegistir.Name = "btnRolDegistir";
            this.btnRolDegistir.Size = new System.Drawing.Size(250, 45);
            this.btnRolDegistir.TabIndex = 1;
            this.btnRolDegistir.Text = "🔄 ROL DEĞİŞTİR";
            this.btnRolDegistir.UseVisualStyleBackColor = false;
            this.btnRolDegistir.Click += new System.EventHandler(this.btnRolDegistir_Click);

            
            // btnKullaniciSil
            this.btnKullaniciSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnKullaniciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43))))); // Kırmızı/Bordo (Silme vurgusu)
            this.btnKullaniciSil.FlatAppearance.BorderSize = 0;
            this.btnKullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciSil.Location = new System.Drawing.Point(300, 415);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(220, 45);
            this.btnKullaniciSil.TabIndex = 2;
            this.btnKullaniciSil.Text = "🗑️ KULLANICIYI SİL";
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);

            
            // btnGeriDon
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120))))); // Açık Bordo
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeriDon.Location = new System.Drawing.Point(20, 20);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(120, 35);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "← Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);

             
            // kullanıcı yonetım formu 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.btnRolDegistir);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönetimi";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button btnRolDegistir;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblBaslik;
    }
}