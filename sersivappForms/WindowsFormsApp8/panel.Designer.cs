namespace WindowsFormsApp8
{
    partial class panel
    {
        // ... (diğer kodlar aynı kalacak) ...

        private void InitializeComponent()
        {
            this.servisOSLabel = new System.Windows.Forms.Label();
            this.pulseCareLabel = new System.Windows.Forms.Label();
            this.anasayfaButton = new System.Windows.Forms.Button();
            this.musteriYonetimiButton = new System.Windows.Forms.Button();
            this.urunBakimButton = new System.Windows.Forms.Button();
            this.servisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servisOSLabel
            // 
            this.servisOSLabel.AutoSize = true;
            this.servisOSLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.servisOSLabel.ForeColor = System.Drawing.Color.White;
            this.servisOSLabel.Location = new System.Drawing.Point(35, 75);
            this.servisOSLabel.Name = "servisOSLabel";
            this.servisOSLabel.Size = new System.Drawing.Size(66, 19);
            this.servisOSLabel.TabIndex = 7;
            this.servisOSLabel.Text = "Servis OS";
            // 
            // pulseCareLabel
            // 
            this.pulseCareLabel.AutoSize = true;
            this.pulseCareLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.pulseCareLabel.ForeColor = System.Drawing.Color.White;
            this.pulseCareLabel.Location = new System.Drawing.Point(30, 30);
            this.pulseCareLabel.Name = "pulseCareLabel";
            this.pulseCareLabel.Size = new System.Drawing.Size(165, 37);
            this.pulseCareLabel.TabIndex = 6;
            this.pulseCareLabel.Text = "PULSECARE";
            // 
            // anasayfaButton
            // 
            this.anasayfaButton.FlatAppearance.BorderSize = 0;
            this.anasayfaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.anasayfaButton.ForeColor = System.Drawing.Color.White;
            this.anasayfaButton.Location = new System.Drawing.Point(0, 140);
            this.anasayfaButton.Name = "anasayfaButton";
            this.anasayfaButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.anasayfaButton.Size = new System.Drawing.Size(250, 40);
            this.anasayfaButton.TabIndex = 12;
            this.anasayfaButton.Text = "Anasayfa";
            this.anasayfaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anasayfaButton.UseVisualStyleBackColor = true;
            this.anasayfaButton.Click += new System.EventHandler(this.anasayfaButton_Click);
            // 
            // musteriYonetimiButton
            // 
            this.musteriYonetimiButton.FlatAppearance.BorderSize = 0;
            this.musteriYonetimiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriYonetimiButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.musteriYonetimiButton.ForeColor = System.Drawing.Color.White;
            this.musteriYonetimiButton.Location = new System.Drawing.Point(0, 190);
            this.musteriYonetimiButton.Name = "musteriYonetimiButton";
            this.musteriYonetimiButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.musteriYonetimiButton.Size = new System.Drawing.Size(250, 40);
            this.musteriYonetimiButton.TabIndex = 13;
            this.musteriYonetimiButton.Text = "Müşteri Yönetimi";
            this.musteriYonetimiButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriYonetimiButton.UseVisualStyleBackColor = true;
            this.musteriYonetimiButton.Click += new System.EventHandler(this.musteriYonetimiButton_Click);
            // 
            // urunBakimButton
            // 
            this.urunBakimButton.FlatAppearance.BorderSize = 0;
            this.urunBakimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunBakimButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urunBakimButton.ForeColor = System.Drawing.Color.White;
            this.urunBakimButton.Location = new System.Drawing.Point(0, 240);
            this.urunBakimButton.Name = "urunBakimButton";
            this.urunBakimButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.urunBakimButton.Size = new System.Drawing.Size(250, 40);
            this.urunBakimButton.TabIndex = 14;
            this.urunBakimButton.Text = "Ürün bakım";
            this.urunBakimButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urunBakimButton.UseVisualStyleBackColor = true;
            this.urunBakimButton.Click += new System.EventHandler(this.urunBakimButton_Click);
            // 
            // servisButton
            // 
            this.servisButton.FlatAppearance.BorderSize = 0;
            this.servisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servisButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.servisButton.ForeColor = System.Drawing.Color.White;
            this.servisButton.Location = new System.Drawing.Point(0, 290);
            this.servisButton.Name = "servisButton";
            this.servisButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.servisButton.Size = new System.Drawing.Size(250, 40);
            this.servisButton.TabIndex = 15;
            this.servisButton.Text = "Servis";
            this.servisButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servisButton.UseVisualStyleBackColor = true;
            this.servisButton.Click += new System.EventHandler(this.servisButton_Click);
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.servisButton);
            this.Controls.Add(this.urunBakimButton);
            this.Controls.Add(this.musteriYonetimiButton);
            this.Controls.Add(this.anasayfaButton);
            this.Controls.Add(this.servisOSLabel);
            this.Controls.Add(this.pulseCareLabel);
            this.Name = "panel";
            this.Size = new System.Drawing.Size(250, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label servisOSLabel;
        private System.Windows.Forms.Label pulseCareLabel;
        private System.Windows.Forms.Button anasayfaButton;
        private System.Windows.Forms.Button musteriYonetimiButton;
        private System.Windows.Forms.Button urunBakimButton;
        private System.Windows.Forms.Button servisButton;
    }
}