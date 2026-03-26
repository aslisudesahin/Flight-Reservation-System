using System;
using System.Windows.Forms;
using System.Drawing; 

namespace FligthReservationSystem
{
    partial class MüsteriAnaMenü
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnRezervasyonListele = new System.Windows.Forms.Button();
            this.btnRezervasyonIptali = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();

            
            // lblBaslik 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lblBaslik.Location = new System.Drawing.Point(235, 31);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(183, 41);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ANA MENÜ";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

           
            // btnAra 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(180, 100);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(300, 60);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "🔎 Uçuş Ara / Listele";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);

            // btnRezervasyonYap
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnRezervasyonYap.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(180, 175);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(300, 60);
            this.btnRezervasyonYap.TabIndex = 2;
            this.btnRezervasyonYap.Text = "🎫 Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);

            
            // btnRezervasyonListele
            this.btnRezervasyonListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(108)))), ((int)(((byte)(120)))));
            this.btnRezervasyonListele.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonListele.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonListele.Location = new System.Drawing.Point(180, 250);
            this.btnRezervasyonListele.Name = "btnRezervasyonListele";
            this.btnRezervasyonListele.Size = new System.Drawing.Size(300, 60);
            this.btnRezervasyonListele.TabIndex = 3;
            this.btnRezervasyonListele.Text = "📅 Rezervasyonlarımı Listele";
            this.btnRezervasyonListele.UseVisualStyleBackColor = false;
            this.btnRezervasyonListele.Click += new System.EventHandler(this.btnRezervasyonListele_Click);

            
            // btnRezervasyonIptali
            this.btnRezervasyonIptali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnRezervasyonIptali.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonIptali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonIptali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonIptali.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonIptali.Location = new System.Drawing.Point(180, 325);
            this.btnRezervasyonIptali.Name = "btnRezervasyonIptali";
            this.btnRezervasyonIptali.Size = new System.Drawing.Size(300, 60);
            this.btnRezervasyonIptali.TabIndex = 4;
            this.btnRezervasyonIptali.Text = "❌ Rezervasyon İptal";
            this.btnRezervasyonIptali.UseVisualStyleBackColor = false;
            this.btnRezervasyonIptali.Click += new System.EventHandler(this.btnRezervasyonIptali_Click);

             
            // btnCikis 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCikis.Location = new System.Drawing.Point(400, 420);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(180, 35);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

 
            // MüsteriAnaMenü 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(660, 480);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRezervasyonIptali);
            this.Controls.Add(this.btnRezervasyonListele);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.btnAra);
            this.Name = "MüsteriAnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ana Menüsü";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnRezervasyonListele;
        private System.Windows.Forms.Button btnRezervasyonIptali;
        private System.Windows.Forms.Button btnCikis;
    }
}