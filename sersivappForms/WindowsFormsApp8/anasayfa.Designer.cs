namespace WindowsFormsApp8
{
    partial class anasayfa
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
            this.bakimTakvimiButton = new System.Windows.Forms.Button();
            this.musteriEkleButton = new System.Windows.Forms.Button();
            this.yeniServisEkleButton = new System.Windows.Forms.Button();
            this.sonIslemlerPanel = new System.Windows.Forms.Panel();
            this.sonIslemlerListBox = new System.Windows.Forms.ListBox();
            this.sonIslemlerLabel = new System.Windows.Forms.Label();
            this.stokUyarilariPanel = new System.Windows.Forms.Panel();
            this.stokUyarilariListBox = new System.Windows.Forms.ListBox();
            this.stokUyarilariLabel = new System.Windows.Forms.Label();
            this.acikServislerPanel = new System.Windows.Forms.Panel();
            this.acikServislerCountLabel = new System.Windows.Forms.Label();
            this.acikServislerLabel = new System.Windows.Forms.Label();
            this.yaklasanBakimlarPanel = new System.Windows.Forms.Panel();
            this.yaklasanBakimlarCountLabel = new System.Windows.Forms.Label();
            this.yaklasanBakimlarLabel = new System.Windows.Forms.Label();
            this.aktifMusteriPanel = new System.Windows.Forms.Panel();
            this.aktifMusteriYuzdeLabel = new System.Windows.Forms.Label();
            this.aktifMusteriCountLabel = new System.Windows.Forms.Label();
            this.aktifMusteriLabel = new System.Windows.Forms.Label();
            this.anasayfaTitleLabel = new System.Windows.Forms.Label();
            this.sonIslemlerPanel.SuspendLayout();
            this.stokUyarilariPanel.SuspendLayout();
            this.acikServislerPanel.SuspendLayout();
            this.yaklasanBakimlarPanel.SuspendLayout();
            this.aktifMusteriPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bakimTakvimiButton
            // 
            this.bakimTakvimiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bakimTakvimiButton.FlatAppearance.BorderSize = 0;
            this.bakimTakvimiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakimTakvimiButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bakimTakvimiButton.ForeColor = System.Drawing.Color.White;
            this.bakimTakvimiButton.Location = new System.Drawing.Point(520, 500);
            this.bakimTakvimiButton.Name = "bakimTakvimiButton";
            this.bakimTakvimiButton.Size = new System.Drawing.Size(180, 50);
            this.bakimTakvimiButton.TabIndex = 17;
            this.bakimTakvimiButton.Text = "Bakým Takvimi";
            this.bakimTakvimiButton.UseVisualStyleBackColor = false;
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.musteriEkleButton.FlatAppearance.BorderSize = 0;
            this.musteriEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriEkleButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.musteriEkleButton.ForeColor = System.Drawing.Color.White;
            this.musteriEkleButton.Location = new System.Drawing.Point(285, 500);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(180, 50);
            this.musteriEkleButton.TabIndex = 16;
            this.musteriEkleButton.Text = "Müþteri Ekle";
            this.musteriEkleButton.UseVisualStyleBackColor = false;
            // 
            // yeniServisEkleButton
            // 
            this.yeniServisEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.yeniServisEkleButton.FlatAppearance.BorderSize = 0;
            this.yeniServisEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniServisEkleButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.yeniServisEkleButton.ForeColor = System.Drawing.Color.White;
            this.yeniServisEkleButton.Location = new System.Drawing.Point(50, 500);
            this.yeniServisEkleButton.Name = "yeniServisEkleButton";
            this.yeniServisEkleButton.Size = new System.Drawing.Size(180, 50);
            this.yeniServisEkleButton.TabIndex = 15;
            this.yeniServisEkleButton.Text = "Yeni Servis Ekle";
            this.yeniServisEkleButton.UseVisualStyleBackColor = false;
            // 
            // sonIslemlerPanel
            // 
            this.sonIslemlerPanel.BackColor = System.Drawing.Color.White;
            this.sonIslemlerPanel.Controls.Add(this.sonIslemlerListBox);
            this.sonIslemlerPanel.Controls.Add(this.sonIslemlerLabel);
            this.sonIslemlerPanel.Location = new System.Drawing.Point(370, 270);
            this.sonIslemlerPanel.Name = "sonIslemlerPanel";
            this.sonIslemlerPanel.Size = new System.Drawing.Size(330, 200);
            this.sonIslemlerPanel.TabIndex = 14;
            // 
            // sonIslemlerListBox
            // 
            this.sonIslemlerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sonIslemlerListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sonIslemlerListBox.FormattingEnabled = true;
            this.sonIslemlerListBox.ItemHeight = 15;
            this.sonIslemlerListBox.Items.AddRange(new object[] {
            "-EN SON YAPILAN ÝÞLEM",
            "-EN SON YAPILAN ÝÞLEM",
            "-EN SON YAPILAN ÝÞLEM",
            "-EN SON YAPILAN ÝÞLEM",
            "-EN SON YAPILAN ÝÞLEM",
            "-EN SON YAPILAN ÝÞLEM",
            "-EN SON YAPILAN ÝÞLEM"});
            this.sonIslemlerListBox.Location = new System.Drawing.Point(20, 50);
            this.sonIslemlerListBox.Name = "sonIslemlerListBox";
            this.sonIslemlerListBox.Size = new System.Drawing.Size(290, 135);
            this.sonIslemlerListBox.TabIndex = 1;
            // 
            // sonIslemlerLabel
            // 
            this.sonIslemlerLabel.AutoSize = true;
            this.sonIslemlerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sonIslemlerLabel.ForeColor = System.Drawing.Color.Gray;
            this.sonIslemlerLabel.Location = new System.Drawing.Point(15, 15);
            this.sonIslemlerLabel.Name = "sonIslemlerLabel";
            this.sonIslemlerLabel.Size = new System.Drawing.Size(83, 19);
            this.sonIslemlerLabel.TabIndex = 0;
            this.sonIslemlerLabel.Text = "Son Ýþlemler";
            // 
            // stokUyarilariPanel
            // 
            this.stokUyarilariPanel.BackColor = System.Drawing.Color.White;
            this.stokUyarilariPanel.Controls.Add(this.stokUyarilariListBox);
            this.stokUyarilariPanel.Controls.Add(this.stokUyarilariLabel);
            this.stokUyarilariPanel.Location = new System.Drawing.Point(50, 270);
            this.stokUyarilariPanel.Name = "stokUyarilariPanel";
            this.stokUyarilariPanel.Size = new System.Drawing.Size(300, 200);
            this.stokUyarilariPanel.TabIndex = 13;
            // 
            // stokUyarilariListBox
            // 
            this.stokUyarilariListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stokUyarilariListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stokUyarilariListBox.FormattingEnabled = true;
            this.stokUyarilariListBox.ItemHeight = 15;
            this.stokUyarilariListBox.Items.AddRange(new object[] {
            "X CODL Ürünü Stoðu Bitiyor Stok adeti : 14",
            "X CODL Ürünü Stoðu Bitiyor Stok adeti : 14",
            "X CODL Ürünü Stoðu Bitiyor Stok adeti : 14",
            "X CODL Ürünü Stoðu Bitiyor Stok adeti : 14",
            "X CODL Ürünü Stoðu Bitiyor Stok adeti : 14",
            "X CODL Ürünü Stoðu Bitiyor Stok adeti : 14"});
            this.stokUyarilariListBox.Location = new System.Drawing.Point(20, 50);
            this.stokUyarilariListBox.Name = "stokUyarilariListBox";
            this.stokUyarilariListBox.Size = new System.Drawing.Size(260, 135);
            this.stokUyarilariListBox.TabIndex = 1;
            // 
            // stokUyarilariLabel
            // 
            this.stokUyarilariLabel.AutoSize = true;
            this.stokUyarilariLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stokUyarilariLabel.ForeColor = System.Drawing.Color.Gray;
            this.stokUyarilariLabel.Location = new System.Drawing.Point(15, 15);
            this.stokUyarilariLabel.Name = "stokUyarilariLabel";
            this.stokUyarilariLabel.Size = new System.Drawing.Size(90, 19);
            this.stokUyarilariLabel.TabIndex = 0;
            this.stokUyarilariLabel.Text = "Stok Uyarýlarý";
            // 
            // acikServislerPanel
            // 
            this.acikServislerPanel.BackColor = System.Drawing.Color.White;
            this.acikServislerPanel.Controls.Add(this.acikServislerCountLabel);
            this.acikServislerPanel.Controls.Add(this.acikServislerLabel);
            this.acikServislerPanel.Location = new System.Drawing.Point(520, 120);
            this.acikServislerPanel.Name = "acikServislerPanel";
            this.acikServislerPanel.Size = new System.Drawing.Size(180, 120);
            this.acikServislerPanel.TabIndex = 12;
            // 
            // acikServislerCountLabel
            // 
            this.acikServislerCountLabel.AutoSize = true;
            this.acikServislerCountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.acikServislerCountLabel.Location = new System.Drawing.Point(15, 45);
            this.acikServislerCountLabel.Name = "acikServislerCountLabel";
            this.acikServislerCountLabel.Size = new System.Drawing.Size(26, 30);
            this.acikServislerCountLabel.TabIndex = 1;
            this.acikServislerCountLabel.Text = "1";
            // 
            // acikServislerLabel
            // 
            this.acikServislerLabel.AutoSize = true;
            this.acikServislerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.acikServislerLabel.ForeColor = System.Drawing.Color.Gray;
            this.acikServislerLabel.Location = new System.Drawing.Point(15, 15);
            this.acikServislerLabel.Name = "acikServislerLabel";
            this.acikServislerLabel.Size = new System.Drawing.Size(88, 19);
            this.acikServislerLabel.TabIndex = 0;
            this.acikServislerLabel.Text = "Açýk Servisler";
            // 
            // yaklasanBakimlarPanel
            // 
            this.yaklasanBakimlarPanel.BackColor = System.Drawing.Color.White;
            this.yaklasanBakimlarPanel.Controls.Add(this.yaklasanBakimlarCountLabel);
            this.yaklasanBakimlarPanel.Controls.Add(this.yaklasanBakimlarLabel);
            this.yaklasanBakimlarPanel.Location = new System.Drawing.Point(285, 120);
            this.yaklasanBakimlarPanel.Name = "yaklasanBakimlarPanel";
            this.yaklasanBakimlarPanel.Size = new System.Drawing.Size(210, 120);
            this.yaklasanBakimlarPanel.TabIndex = 11;
            // 
            // yaklasanBakimlarCountLabel
            // 
            this.yaklasanBakimlarCountLabel.AutoSize = true;
            this.yaklasanBakimlarCountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.yaklasanBakimlarCountLabel.Location = new System.Drawing.Point(15, 45);
            this.yaklasanBakimlarCountLabel.Name = "yaklasanBakimlarCountLabel";
            this.yaklasanBakimlarCountLabel.Size = new System.Drawing.Size(26, 30);
            this.yaklasanBakimlarCountLabel.TabIndex = 1;
            this.yaklasanBakimlarCountLabel.Text = "1";
            // 
            // yaklasanBakimlarLabel
            // 
            this.yaklasanBakimlarLabel.AutoSize = true;
            this.yaklasanBakimlarLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yaklasanBakimlarLabel.ForeColor = System.Drawing.Color.Gray;
            this.yaklasanBakimlarLabel.Location = new System.Drawing.Point(15, 15);
            this.yaklasanBakimlarLabel.Name = "yaklasanBakimlarLabel";
            this.yaklasanBakimlarLabel.Size = new System.Drawing.Size(165, 19);
            this.yaklasanBakimlarLabel.TabIndex = 0;
            this.yaklasanBakimlarLabel.Text = "Yaklaþan Bakýmlar (7 gün)";
            // 
            // aktifMusteriPanel
            // 
            this.aktifMusteriPanel.BackColor = System.Drawing.Color.White;
            this.aktifMusteriPanel.Controls.Add(this.aktifMusteriYuzdeLabel);
            this.aktifMusteriPanel.Controls.Add(this.aktifMusteriCountLabel);
            this.aktifMusteriPanel.Controls.Add(this.aktifMusteriLabel);
            this.aktifMusteriPanel.Location = new System.Drawing.Point(50, 120);
            this.aktifMusteriPanel.Name = "aktifMusteriPanel";
            this.aktifMusteriPanel.Size = new System.Drawing.Size(210, 120);
            this.aktifMusteriPanel.TabIndex = 10;
            // 
            // aktifMusteriYuzdeLabel
            // 
            this.aktifMusteriYuzdeLabel.AutoSize = true;
            this.aktifMusteriYuzdeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.aktifMusteriYuzdeLabel.ForeColor = System.Drawing.Color.Green;
            this.aktifMusteriYuzdeLabel.Location = new System.Drawing.Point(15, 85);
            this.aktifMusteriYuzdeLabel.Name = "aktifMusteriYuzdeLabel";
            this.aktifMusteriYuzdeLabel.Size = new System.Drawing.Size(49, 19);
            this.aktifMusteriYuzdeLabel.TabIndex = 2;
            this.aktifMusteriYuzdeLabel.Text = "+2,0%";
            // 
            // aktifMusteriCountLabel
            // 
            this.aktifMusteriCountLabel.AutoSize = true;
            this.aktifMusteriCountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.aktifMusteriCountLabel.Location = new System.Drawing.Point(15, 45);
            this.aktifMusteriCountLabel.Name = "aktifMusteriCountLabel";
            this.aktifMusteriCountLabel.Size = new System.Drawing.Size(71, 30);
            this.aktifMusteriCountLabel.TabIndex = 1;
            this.aktifMusteriCountLabel.Text = "1.234";
            // 
            // aktifMusteriLabel
            // 
            this.aktifMusteriLabel.AutoSize = true;
            this.aktifMusteriLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.aktifMusteriLabel.ForeColor = System.Drawing.Color.Gray;
            this.aktifMusteriLabel.Location = new System.Drawing.Point(15, 15);
            this.aktifMusteriLabel.Name = "aktifMusteriLabel";
            this.aktifMusteriLabel.Size = new System.Drawing.Size(88, 19);
            this.aktifMusteriLabel.TabIndex = 0;
            this.aktifMusteriLabel.Text = "Aktif Müþteri";
            // 
            // anasayfaTitleLabel
            // 
            this.anasayfaTitleLabel.AutoSize = true;
            this.anasayfaTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.anasayfaTitleLabel.Location = new System.Drawing.Point(40, 30);
            this.anasayfaTitleLabel.Name = "anasayfaTitleLabel";
            this.anasayfaTitleLabel.Size = new System.Drawing.Size(156, 45);
            this.anasayfaTitleLabel.TabIndex = 9;
            this.anasayfaTitleLabel.Text = "Anasayfa";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.bakimTakvimiButton);
            this.Controls.Add(this.musteriEkleButton);
            this.Controls.Add(this.yeniServisEkleButton);
            this.Controls.Add(this.sonIslemlerPanel);
            this.Controls.Add(this.stokUyarilariPanel);
            this.Controls.Add(this.acikServislerPanel);
            this.Controls.Add(this.yaklasanBakimlarPanel);
            this.Controls.Add(this.aktifMusteriPanel);
            this.Controls.Add(this.anasayfaTitleLabel);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.sonIslemlerPanel.ResumeLayout(false);
            this.sonIslemlerPanel.PerformLayout();
            this.stokUyarilariPanel.ResumeLayout(false);
            this.stokUyarilariPanel.PerformLayout();
            this.acikServislerPanel.ResumeLayout(false);
            this.acikServislerPanel.PerformLayout();
            this.yaklasanBakimlarPanel.ResumeLayout(false);
            this.yaklasanBakimlarPanel.PerformLayout();
            this.aktifMusteriPanel.ResumeLayout(false);
            this.aktifMusteriPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bakimTakvimiButton;
        private System.Windows.Forms.Button musteriEkleButton;
        private System.Windows.Forms.Button yeniServisEkleButton;
        private System.Windows.Forms.Panel sonIslemlerPanel;
        private System.Windows.Forms.ListBox sonIslemlerListBox;
        private System.Windows.Forms.Label sonIslemlerLabel;
        private System.Windows.Forms.Panel stokUyarilariPanel;
        private System.Windows.Forms.ListBox stokUyarilariListBox;
        private System.Windows.Forms.Label stokUyarilariLabel;
        private System.Windows.Forms.Panel acikServislerPanel;
        private System.Windows.Forms.Label acikServislerCountLabel;
        private System.Windows.Forms.Label acikServislerLabel;
        private System.Windows.Forms.Panel yaklasanBakimlarPanel;
        private System.Windows.Forms.Label yaklasanBakimlarCountLabel;
        private System.Windows.Forms.Label yaklasanBakimlarLabel;
        private System.Windows.Forms.Panel aktifMusteriPanel;
        private System.Windows.Forms.Label aktifMusteriYuzdeLabel;
        private System.Windows.Forms.Label aktifMusteriCountLabel;
        private System.Windows.Forms.Label aktifMusteriLabel;
        private System.Windows.Forms.Label anasayfaTitleLabel;
    }
}
