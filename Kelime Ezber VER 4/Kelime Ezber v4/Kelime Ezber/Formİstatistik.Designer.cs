﻿namespace Kelime_Ezber
{
    partial class Formİstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formİstatistik));
            this.lblToplamSkor = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblTestSayii = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblHavuzSayisi = new System.Windows.Forms.Label();
            this.lblOgrenilenSayisi = new System.Windows.Forms.Label();
            this.lblTestKelimeSayisi = new System.Windows.Forms.Label();
            this.lblOgenilceklerSayi = new System.Windows.Forms.Label();
            this.lblİstatistikler = new System.Windows.Forms.Label();
            this.cmbZamanAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgrenilenYil = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbZamanYil = new System.Windows.Forms.ComboBox();
            this.lblOgrenilenAy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamSkor
            // 
            this.lblToplamSkor.AutoSize = true;
            this.lblToplamSkor.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamSkor.Location = new System.Drawing.Point(244, 287);
            this.lblToplamSkor.Name = "lblToplamSkor";
            this.lblToplamSkor.Size = new System.Drawing.Size(110, 16);
            this.lblToplamSkor.TabIndex = 25;
            this.lblToplamSkor.Text = "Toplam Skor:";
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 11);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 37);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblTestSayii
            // 
            this.lblTestSayii.AutoSize = true;
            this.lblTestSayii.Location = new System.Drawing.Point(9, 250);
            this.lblTestSayii.Name = "lblTestSayii";
            this.lblTestSayii.Size = new System.Drawing.Size(93, 13);
            this.lblTestSayii.TabIndex = 10;
            this.lblTestSayii.Text = "Girilen Test Sayısı:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(7, 218);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(107, 13);
            this.lblYanlis.TabIndex = 9;
            this.lblYanlis.Text = "Toplam yanlış cevap:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(10, 188);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(108, 13);
            this.lblDogru.TabIndex = 8;
            this.lblDogru.Text = "Toplam doğru cevap:";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(7, 287);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(129, 13);
            this.lblZaman.TabIndex = 7;
            this.lblZaman.Text = "Testte geçirdiğiniz zaman:";
            // 
            // lblHavuzSayisi
            // 
            this.lblHavuzSayisi.AutoSize = true;
            this.lblHavuzSayisi.Location = new System.Drawing.Point(8, 76);
            this.lblHavuzSayisi.Name = "lblHavuzSayisi";
            this.lblHavuzSayisi.Size = new System.Drawing.Size(122, 13);
            this.lblHavuzSayisi.TabIndex = 6;
            this.lblHavuzSayisi.Text = "Havuzdaki kelime sayısı:";
            // 
            // lblOgrenilenSayisi
            // 
            this.lblOgrenilenSayisi.AutoSize = true;
            this.lblOgrenilenSayisi.Location = new System.Drawing.Point(9, 161);
            this.lblOgrenilenSayisi.Name = "lblOgrenilenSayisi";
            this.lblOgrenilenSayisi.Size = new System.Drawing.Size(116, 13);
            this.lblOgrenilenSayisi.TabIndex = 5;
            this.lblOgrenilenSayisi.Text = "Öğrenilen kelime sayısı:";
            // 
            // lblTestKelimeSayisi
            // 
            this.lblTestKelimeSayisi.AutoSize = true;
            this.lblTestKelimeSayisi.Location = new System.Drawing.Point(9, 131);
            this.lblTestKelimeSayisi.Name = "lblTestKelimeSayisi";
            this.lblTestKelimeSayisi.Size = new System.Drawing.Size(109, 13);
            this.lblTestKelimeSayisi.TabIndex = 3;
            this.lblTestKelimeSayisi.Text = "Testteki kelime sayısı:";
            // 
            // lblOgenilceklerSayi
            // 
            this.lblOgenilceklerSayi.AutoSize = true;
            this.lblOgenilceklerSayi.Location = new System.Drawing.Point(8, 101);
            this.lblOgenilceklerSayi.Name = "lblOgenilceklerSayi";
            this.lblOgenilceklerSayi.Size = new System.Drawing.Size(128, 13);
            this.lblOgenilceklerSayi.TabIndex = 1;
            this.lblOgenilceklerSayi.Text = "Öğrenilecek kelime sayısı:";
            // 
            // lblİstatistikler
            // 
            this.lblİstatistikler.AutoSize = true;
            this.lblİstatistikler.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİstatistikler.Location = new System.Drawing.Point(179, 12);
            this.lblİstatistikler.Name = "lblİstatistikler";
            this.lblİstatistikler.Size = new System.Drawing.Size(149, 37);
            this.lblİstatistikler.TabIndex = 0;
            this.lblİstatistikler.Text = "İstatistikler";
            // 
            // cmbZamanAy
            // 
            this.cmbZamanAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZamanAy.FormattingEnabled = true;
            this.cmbZamanAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbZamanAy.Location = new System.Drawing.Point(306, 98);
            this.cmbZamanAy.Name = "cmbZamanAy";
            this.cmbZamanAy.Size = new System.Drawing.Size(71, 21);
            this.cmbZamanAy.TabIndex = 26;
            this.cmbZamanAy.SelectedIndexChanged += new System.EventHandler(this.cmbZamanAy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Bir zaman seçin";
            // 
            // lblOgrenilenYil
            // 
            this.lblOgrenilenYil.AutoSize = true;
            this.lblOgrenilenYil.Location = new System.Drawing.Point(287, 175);
            this.lblOgrenilenYil.Name = "lblOgrenilenYil";
            this.lblOgrenilenYil.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenilenYil.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblİstatistikler);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 63);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // cmbZamanYil
            // 
            this.cmbZamanYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZamanYil.FormattingEnabled = true;
            this.cmbZamanYil.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cmbZamanYil.Location = new System.Drawing.Point(383, 98);
            this.cmbZamanYil.Name = "cmbZamanYil";
            this.cmbZamanYil.Size = new System.Drawing.Size(71, 21);
            this.cmbZamanYil.TabIndex = 34;
            this.cmbZamanYil.SelectedIndexChanged += new System.EventHandler(this.cmbZamanYil_SelectedIndexChanged);
            // 
            // lblOgrenilenAy
            // 
            this.lblOgrenilenAy.AutoSize = true;
            this.lblOgrenilenAy.Location = new System.Drawing.Point(287, 138);
            this.lblOgrenilenAy.Name = "lblOgrenilenAy";
            this.lblOgrenilenAy.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenilenAy.TabIndex = 35;
            // 
            // Formİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(491, 330);
            this.Controls.Add(this.lblOgrenilenAy);
            this.Controls.Add(this.cmbZamanYil);
            this.Controls.Add(this.lblOgrenilenYil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZamanAy);
            this.Controls.Add(this.lblToplamSkor);
            this.Controls.Add(this.lblTestSayii);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblOgenilceklerSayi);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblTestKelimeSayisi);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblOgrenilenSayisi);
            this.Controls.Add(this.lblHavuzSayisi);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formİstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.Formİstatistik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamSkor;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblTestSayii;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblHavuzSayisi;
        private System.Windows.Forms.Label lblOgrenilenSayisi;
        private System.Windows.Forms.Label lblTestKelimeSayisi;
        private System.Windows.Forms.Label lblOgenilceklerSayi;
        private System.Windows.Forms.Label lblİstatistikler;
        private System.Windows.Forms.ComboBox cmbZamanAy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOgrenilenYil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbZamanYil;
        private System.Windows.Forms.Label lblOgrenilenAy;
    }
}