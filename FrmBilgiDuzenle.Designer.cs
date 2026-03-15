namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.UyeKayitCinsiyet = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.UyeKayitTelefon = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.UyeKayitSoyad = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.UyeKayitAd = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.UyeKayitSifre = new System.Windows.Forms.Label();
            this.UyeKayitTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(156, 326);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(194, 49);
            this.BtnBilgiGuncelle.TabIndex = 31;
            this.BtnBilgiGuncelle.Text = "Güncelle";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // UyeKayitCinsiyet
            // 
            this.UyeKayitCinsiyet.AutoSize = true;
            this.UyeKayitCinsiyet.Location = new System.Drawing.Point(57, 270);
            this.UyeKayitCinsiyet.Name = "UyeKayitCinsiyet";
            this.UyeKayitCinsiyet.Size = new System.Drawing.Size(93, 28);
            this.UyeKayitCinsiyet.TabIndex = 30;
            this.UyeKayitCinsiyet.Text = "Cinsiyet:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(156, 270);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(194, 36);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(156, 173);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(194, 36);
            this.MskTelefon.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(156, 225);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(194, 36);
            this.TxtSifre.TabIndex = 5;
            // 
            // UyeKayitTelefon
            // 
            this.UyeKayitTelefon.AutoSize = true;
            this.UyeKayitTelefon.Location = new System.Drawing.Point(62, 176);
            this.UyeKayitTelefon.Name = "UyeKayitTelefon";
            this.UyeKayitTelefon.Size = new System.Drawing.Size(88, 28);
            this.UyeKayitTelefon.TabIndex = 26;
            this.UyeKayitTelefon.Text = "Telefon:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(156, 79);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(194, 36);
            this.TxtSoyad.TabIndex = 2;
            // 
            // UyeKayitSoyad
            // 
            this.UyeKayitSoyad.AutoSize = true;
            this.UyeKayitSoyad.Location = new System.Drawing.Point(73, 79);
            this.UyeKayitSoyad.Name = "UyeKayitSoyad";
            this.UyeKayitSoyad.Size = new System.Drawing.Size(77, 28);
            this.UyeKayitSoyad.TabIndex = 24;
            this.UyeKayitSoyad.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(156, 37);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(194, 36);
            this.TxtAd.TabIndex = 1;
            // 
            // UyeKayitAd
            // 
            this.UyeKayitAd.AutoSize = true;
            this.UyeKayitAd.Location = new System.Drawing.Point(105, 40);
            this.UyeKayitAd.Name = "UyeKayitAd";
            this.UyeKayitAd.Size = new System.Drawing.Size(45, 28);
            this.UyeKayitAd.TabIndex = 22;
            this.UyeKayitAd.Text = "Ad:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(156, 125);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(194, 36);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // UyeKayitSifre
            // 
            this.UyeKayitSifre.AutoSize = true;
            this.UyeKayitSifre.Location = new System.Drawing.Point(88, 225);
            this.UyeKayitSifre.Name = "UyeKayitSifre";
            this.UyeKayitSifre.Size = new System.Drawing.Size(62, 28);
            this.UyeKayitSifre.TabIndex = 20;
            this.UyeKayitSifre.Text = "Şifre:";
            // 
            // UyeKayitTC
            // 
            this.UyeKayitTC.AutoSize = true;
            this.UyeKayitTC.Location = new System.Drawing.Point(9, 125);
            this.UyeKayitTC.Name = "UyeKayitTC";
            this.UyeKayitTC.Size = new System.Drawing.Size(141, 28);
            this.UyeKayitTC.TabIndex = 19;
            this.UyeKayitTC.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.BtnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(425, 412);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.UyeKayitCinsiyet);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.UyeKayitTelefon);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.UyeKayitSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.UyeKayitAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.UyeKayitSifre);
            this.Controls.Add(this.UyeKayitTC);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.Label UyeKayitCinsiyet;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label UyeKayitTelefon;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label UyeKayitSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label UyeKayitAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label UyeKayitSifre;
        private System.Windows.Forms.Label UyeKayitTC;
    }
}