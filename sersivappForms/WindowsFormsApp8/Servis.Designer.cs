namespace WindowsFormsApp8
{
    partial class Servis
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBoxMusteriler = new System.Windows.Forms.GroupBox();
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            this.IsimSoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunIsmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detaylar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cmbDurumlar = new System.Windows.Forms.ComboBox();
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtMusteriArayin = new System.Windows.Forms.TextBox();
            this.lblServisler = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.btnFisYazdir = new System.Windows.Forms.Button();
            this.lblKayitOlusturma = new System.Windows.Forms.Label();
            this.lblSonrakiBakim = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblParcaMaliyeti = new System.Windows.Forms.Label();
            this.lblIscilikUcreti = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblServisTarihi = new System.Windows.Forms.Label();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.lblIslem = new System.Windows.Forms.Label();
            this.lblSorumlu = new System.Windows.Forms.Label();
            this.lblCihaz = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblServisNo = new System.Windows.Forms.Label();
            this.lblServisDetay = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.groupBoxMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.groupBoxMusteriler);
            this.leftPanel.Controls.Add(this.cmbDurumlar);
            this.leftPanel.Controls.Add(this.cmbSehirler);
            this.leftPanel.Controls.Add(this.btnMusteriEkle);
            this.leftPanel.Controls.Add(this.btnAra);
            this.leftPanel.Controls.Add(this.txtMusteriArayin);
            this.leftPanel.Controls.Add(this.lblServisler);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(550, 600);
            this.leftPanel.TabIndex = 0;
            // 
            // groupBoxMusteriler
            // 
            this.groupBoxMusteriler.Controls.Add(this.dataGridViewMusteriler);
            this.groupBoxMusteriler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBoxMusteriler.Location = new System.Drawing.Point(33, 188);
            this.groupBoxMusteriler.Name = "groupBoxMusteriler";
            this.groupBoxMusteriler.Size = new System.Drawing.Size(477, 384);
            this.groupBoxMusteriler.TabIndex = 6;
            this.groupBoxMusteriler.TabStop = false;
            this.groupBoxMusteriler.Text = "Müþteriler:";
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AllowUserToAddRows = false;
            this.dataGridViewMusteriler.AllowUserToDeleteRows = false;
            this.dataGridViewMusteriler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.IsimSoyisim,
                this.UrunIsmi,
                this.Detaylar});
            this.dataGridViewMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.ReadOnly = true;
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(471, 356);
            this.dataGridViewMusteriler.TabIndex = 0;
            // 
            // IsimSoyisim
            // 
            this.IsimSoyisim.HeaderText = "Ýsim Soyisim";
            this.IsimSoyisim.Name = "IsimSoyisim";
            this.IsimSoyisim.ReadOnly = true;
            this.IsimSoyisim.Width = 150;
            // 
            // UrunIsmi
            // 
            this.UrunIsmi.HeaderText = "Ürün Ýsmi";
            this.UrunIsmi.Name = "UrunIsmi";
            this.UrunIsmi.ReadOnly = true;
            this.UrunIsmi.Width = 150;
            // 
            // Detaylar
            // 
            this.Detaylar.HeaderText = "Detaylar";
            this.Detaylar.Name = "Detaylar";
            this.Detaylar.ReadOnly = true;
            this.Detaylar.Text = "Profili Görüntüle >";
            this.Detaylar.UseColumnTextForLinkValue = true;
            this.Detaylar.Width = 120;
            // 
            // cmbDurumlar
            // 
            this.cmbDurumlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbDurumlar.FormattingEnabled = true;
            this.cmbDurumlar.Location = new System.Drawing.Point(344, 135);
            this.cmbDurumlar.Name = "cmbDurumlar";
            this.cmbDurumlar.Size = new System.Drawing.Size(166, 29);
            this.cmbDurumlar.TabIndex = 5;
            this.cmbDurumlar.Text = "Tüm durumlar";
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Location = new System.Drawing.Point(172, 135);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(166, 29);
            this.cmbSehirler.TabIndex = 4;
            this.cmbSehirler.Text = "Tüm þehirler";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Location = new System.Drawing.Point(33, 135);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(121, 29);
            this.btnMusteriEkle.TabIndex = 3;
            this.btnMusteriEkle.Text = "Müþteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(435, 88);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 29);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // txtMusteriArayin
            // 
            this.txtMusteriArayin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMusteriArayin.Location = new System.Drawing.Point(33, 88);
            this.txtMusteriArayin.Name = "txtMusteriArayin";
            this.txtMusteriArayin.Size = new System.Drawing.Size(396, 29);
            this.txtMusteriArayin.TabIndex = 1;
            this.txtMusteriArayin.Text = "Müþteri Arayýn ....";
            // 
            // lblServisler
            // 
            this.lblServisler.AutoSize = true;
            this.lblServisler.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblServisler.Location = new System.Drawing.Point(25, 25);
            this.lblServisler.Name = "lblServisler";
            this.lblServisler.Size = new System.Drawing.Size(155, 45);
            this.lblServisler.TabIndex = 0;
            this.lblServisler.Text = "Servisler";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.rightPanel.Controls.Add(this.btnFisYazdir);
            this.rightPanel.Controls.Add(this.lblKayitOlusturma);
            this.rightPanel.Controls.Add(this.lblSonrakiBakim);
            this.rightPanel.Controls.Add(this.lblToplamTutar);
            this.rightPanel.Controls.Add(this.lblParcaMaliyeti);
            this.rightPanel.Controls.Add(this.lblIscilikUcreti);
            this.rightPanel.Controls.Add(this.lblAciklama);
            this.rightPanel.Controls.Add(this.lblServisTarihi);
            this.rightPanel.Controls.Add(this.lblDurumu);
            this.rightPanel.Controls.Add(this.lblIslem);
            this.rightPanel.Controls.Add(this.lblSorumlu);
            this.rightPanel.Controls.Add(this.lblCihaz);
            this.rightPanel.Controls.Add(this.lblMusteri);
            this.rightPanel.Controls.Add(this.lblServisNo);
            this.rightPanel.Controls.Add(this.lblServisDetay);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.ForeColor = System.Drawing.Color.White;
            this.rightPanel.Location = new System.Drawing.Point(550, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(250, 600);
            this.rightPanel.TabIndex = 1;
            // 
            // btnFisYazdir
            // 
            this.btnFisYazdir.BackColor = System.Drawing.Color.White;
            this.btnFisYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFisYazdir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFisYazdir.ForeColor = System.Drawing.Color.Black;
            this.btnFisYazdir.Location = new System.Drawing.Point(31, 460);
            this.btnFisYazdir.Name = "btnFisYazdir";
            this.btnFisYazdir.Size = new System.Drawing.Size(184, 40);
            this.btnFisYazdir.TabIndex = 14;
            this.btnFisYazdir.Text = "Fiþ yazdýr";
            this.btnFisYazdir.UseVisualStyleBackColor = false;
            // 
            // lblKayitOlusturma
            // 
            this.lblKayitOlusturma.AutoSize = true;
            this.lblKayitOlusturma.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKayitOlusturma.Location = new System.Drawing.Point(28, 417);
            this.lblKayitOlusturma.Name = "lblKayitOlusturma";
            this.lblKayitOlusturma.Size = new System.Drawing.Size(201, 17);
            this.lblKayitOlusturma.TabIndex = 13;
            this.lblKayitOlusturma.Text = "Kayýt Oluþturma Zamaný xx.xx.xxxx";
            // 
            // lblSonrakiBakim
            // 
            this.lblSonrakiBakim.AutoSize = true;
            this.lblSonrakiBakim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSonrakiBakim.Location = new System.Drawing.Point(28, 390);
            this.lblSonrakiBakim.Name = "lblSonrakiBakim";
            this.lblSonrakiBakim.Size = new System.Drawing.Size(182, 17);
            this.lblSonrakiBakim.TabIndex = 12;
            this.lblSonrakiBakim.Text = "Bir Sonraki Bakým Tarihi : Xx.xx.xxxx";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblToplamTutar.Location = new System.Drawing.Point(28, 363);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(116, 17);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "Toplam Tutar: xxx?";
            // 
            // lblParcaMaliyeti
            // 
            this.lblParcaMaliyeti.AutoSize = true;
            this.lblParcaMaliyeti.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblParcaMaliyeti.Location = new System.Drawing.Point(28, 336);
            this.lblParcaMaliyeti.Name = "lblParcaMaliyeti";
            this.lblParcaMaliyeti.Size = new System.Drawing.Size(120, 17);
            this.lblParcaMaliyeti.TabIndex = 10;
            this.lblParcaMaliyeti.Text = "Parça Maliyeti: xxx?";
            // 
            // lblIscilikUcreti
            // 
            this.lblIscilikUcreti.AutoSize = true;
            this.lblIscilikUcreti.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblIscilikUcreti.Location = new System.Drawing.Point(28, 309);
            this.lblIscilikUcreti.Name = "lblIscilikUcreti";
            this.lblIscilikUcreti.Size = new System.Drawing.Size(104, 17);
            this.lblIscilikUcreti.TabIndex = 9;
            this.lblIscilikUcreti.Text = "Ýþçilik Ücreti : xxx?";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAciklama.Location = new System.Drawing.Point(28, 282);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(165, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açýklama : xalsdþaskdlþasd";
            // 
            // lblServisTarihi
            // 
            this.lblServisTarihi.AutoSize = true;
            this.lblServisTarihi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblServisTarihi.Location = new System.Drawing.Point(28, 255);
            this.lblServisTarihi.Name = "lblServisTarihi";
            this.lblServisTarihi.Size = new System.Drawing.Size(141, 17);
            this.lblServisTarihi.TabIndex = 7;
            this.lblServisTarihi.Text = "Servis tarihi : xx.xx.xxxx";
            // 
            // lblDurumu
            // 
            this.lblDurumu.AutoSize = true;
            this.lblDurumu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDurumu.Location = new System.Drawing.Point(28, 228);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(124, 17);
            this.lblDurumu.TabIndex = 6;
            this.lblDurumu.Text = "Durumu : Beklemede";
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblIslem.Location = new System.Drawing.Point(28, 201);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(84, 17);
            this.lblIslem.TabIndex = 5;
            this.lblIslem.Text = "Ýþlem: Bakým";
            // 
            // lblSorumlu
            // 
            this.lblSorumlu.AutoSize = true;
            this.lblSorumlu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSorumlu.Location = new System.Drawing.Point(28, 174);
            this.lblSorumlu.Name = "lblSorumlu";
            this.lblSorumlu.Size = new System.Drawing.Size(167, 17);
            this.lblSorumlu.TabIndex = 4;
            this.lblSorumlu.Text = "Sorumlu : Fatih buðra ayar";
            // 
            // lblCihaz
            // 
            this.lblCihaz.AutoSize = true;
            this.lblCihaz.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCihaz.Location = new System.Drawing.Point(28, 147);
            this.lblCihaz.Name = "lblCihaz";
            this.lblCihaz.Size = new System.Drawing.Size(112, 17);
            this.lblCihaz.TabIndex = 3;
            this.lblCihaz.Text = "Cihaz : Buzdolabý";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMusteri.Location = new System.Drawing.Point(28, 120);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(122, 17);
            this.lblMusteri.TabIndex = 2;
            this.lblMusteri.Text = "Müþteri : öner Aytaþ";
            // 
            // lblServisNo
            // 
            this.lblServisNo.AutoSize = true;
            this.lblServisNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblServisNo.Location = new System.Drawing.Point(26, 78);
            this.lblServisNo.Name = "lblServisNo";
            this.lblServisNo.Size = new System.Drawing.Size(67, 25);
            this.lblServisNo.TabIndex = 1;
            this.lblServisNo.Text = "#1231";
            // 
            // lblServisDetay
            // 
            this.lblServisDetay.AutoSize = true;
            this.lblServisDetay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblServisDetay.Location = new System.Drawing.Point(25, 35);
            this.lblServisDetay.Name = "lblServisDetay";
            this.lblServisDetay.Size = new System.Drawing.Size(160, 32);
            this.lblServisDetay.TabIndex = 0;
            this.lblServisDetay.Text = "Servis Detay";
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Servis";
            this.Text = "Servis";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.groupBoxMusteriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblServisler;
        private System.Windows.Forms.TextBox txtMusteriArayin;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ComboBox cmbSehirler;
        private System.Windows.Forms.ComboBox cmbDurumlar;
        private System.Windows.Forms.GroupBox groupBoxMusteriler;
        private System.Windows.Forms.DataGridView dataGridViewMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsimSoyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunIsmi;
        private System.Windows.Forms.DataGridViewLinkColumn Detaylar;
        private System.Windows.Forms.Label lblServisDetay;
        private System.Windows.Forms.Label lblServisNo;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblCihaz;
        private System.Windows.Forms.Label lblSorumlu;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.Label lblServisTarihi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblIscilikUcreti;
        private System.Windows.Forms.Label lblParcaMaliyeti;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblSonrakiBakim;
        private System.Windows.Forms.Label lblKayitOlusturma;
        private System.Windows.Forms.Button btnFisYazdir;
    }
}
