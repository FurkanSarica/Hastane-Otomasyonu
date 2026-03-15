namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.UyeKayitSoyad = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.UyeKayitAd = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.UyeKayitTC = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.UyeKayitSifre = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(161, 73);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(194, 36);
            this.TxtSoyad.TabIndex = 31;
            // 
            // UyeKayitSoyad
            // 
            this.UyeKayitSoyad.AutoSize = true;
            this.UyeKayitSoyad.Location = new System.Drawing.Point(78, 73);
            this.UyeKayitSoyad.Name = "UyeKayitSoyad";
            this.UyeKayitSoyad.Size = new System.Drawing.Size(77, 28);
            this.UyeKayitSoyad.TabIndex = 30;
            this.UyeKayitSoyad.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(161, 31);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(194, 36);
            this.TxtAd.TabIndex = 29;
            // 
            // UyeKayitAd
            // 
            this.UyeKayitAd.AutoSize = true;
            this.UyeKayitAd.Location = new System.Drawing.Point(110, 34);
            this.UyeKayitAd.Name = "UyeKayitAd";
            this.UyeKayitAd.Size = new System.Drawing.Size(45, 28);
            this.UyeKayitAd.TabIndex = 28;
            this.UyeKayitAd.Text = "Ad:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(161, 115);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(194, 36);
            this.MskTC.TabIndex = 27;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // UyeKayitTC
            // 
            this.UyeKayitTC.AutoSize = true;
            this.UyeKayitTC.Location = new System.Drawing.Point(14, 115);
            this.UyeKayitTC.Name = "UyeKayitTC";
            this.UyeKayitTC.Size = new System.Drawing.Size(141, 28);
            this.UyeKayitTC.TabIndex = 26;
            this.UyeKayitTC.Text = "TC Kimlik No:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(161, 199);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(194, 36);
            this.TxtSifre.TabIndex = 33;
            // 
            // UyeKayitSifre
            // 
            this.UyeKayitSifre.AutoSize = true;
            this.UyeKayitSifre.Location = new System.Drawing.Point(88, 202);
            this.UyeKayitSifre.Name = "UyeKayitSifre";
            this.UyeKayitSifre.Size = new System.Drawing.Size(62, 28);
            this.UyeKayitSifre.TabIndex = 32;
            this.UyeKayitSifre.Text = "Şifre:";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(161, 156);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(194, 36);
            this.CmbBrans.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Branş:";
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(161, 252);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(194, 47);
            this.BtnBilgiGuncelle.TabIndex = 36;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(413, 328);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.UyeKayitSifre);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.UyeKayitSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.UyeKayitAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.UyeKayitTC);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label UyeKayitSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label UyeKayitAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label UyeKayitTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label UyeKayitSifre;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBilgiGuncelle;
    }
}