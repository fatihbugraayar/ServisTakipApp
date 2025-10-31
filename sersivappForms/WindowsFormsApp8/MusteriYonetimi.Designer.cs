namespace WindowsFormsApp8
{
    partial class MusteriYonetimi
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
            this.musteriYonetimiTitleLabel = new System.Windows.Forms.Label();
            this.musteriArayinTextBox = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.musteriEkleButton = new System.Windows.Forms.Button();
            this.tumSehirlerComboBox = new System.Windows.Forms.ComboBox();
            this.tumDurumlarComboBox = new System.Windows.Forms.ComboBox();
            this.musterilerPanel = new System.Windows.Forms.Panel();
            this.musterilerDataGridView = new System.Windows.Forms.DataGridView();
            this.musterilerLabel = new System.Windows.Forms.Label();
            this.musteriDetayPanel = new System.Windows.Forms.Panel();
            this.duzenleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.hatirlaticiLabel = new System.Windows.Forms.Label();
            this.iletisimLabel = new System.Windows.Forms.Label();
            this.urunlerLabel = new System.Windows.Forms.Label();
            this.musteriAdiLabel = new System.Windows.Forms.Label();
            this.musterilerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDataGridView)).BeginInit();
            this.musteriDetayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriYonetimiTitleLabel
            // 
            this.musteriYonetimiTitleLabel.AutoSize = true;
            this.musteriYonetimiTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.musteriYonetimiTitleLabel.Location = new System.Drawing.Point(40, 30);
            this.musteriYonetimiTitleLabel.Name = "musteriYonetimiTitleLabel";
            this.musteriYonetimiTitleLabel.Size = new System.Drawing.Size(295, 45);
            this.musteriYonetimiTitleLabel.TabIndex = 0;
            this.musteriYonetimiTitleLabel.Text = "Müþteri Yönetimi";
            // 
            // musteriArayinTextBox
            // 
            this.musteriArayinTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.musteriArayinTextBox.Location = new System.Drawing.Point(48, 90);
            this.musteriArayinTextBox.Name = "musteriArayinTextBox";
            this.musteriArayinTextBox.Size = new System.Drawing.Size(300, 29);
            this.musteriArayinTextBox.TabIndex = 1;
            this.musteriArayinTextBox.Text = "Müþteri Arayýn ....";
            // 
            // araButton
            // 
            this.araButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.araButton.FlatAppearance.BorderSize = 0;
            this.araButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.araButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.araButton.ForeColor = System.Drawing.Color.White;
            this.araButton.Location = new System.Drawing.Point(354, 90);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(60, 29);
            this.araButton.TabIndex = 2;
            this.araButton.Text = "ara";
            this.araButton.UseVisualStyleBackColor = false;
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.musteriEkleButton.FlatAppearance.BorderSize = 0;
            this.musteriEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriEkleButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.musteriEkleButton.ForeColor = System.Drawing.Color.White;
            this.musteriEkleButton.Location = new System.Drawing.Point(48, 135);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(120, 30);
            this.musteriEkleButton.TabIndex = 3;
            this.musteriEkleButton.Text = "Müþteri Ekle";
            this.musteriEkleButton.UseVisualStyleBackColor = false;
            // 
            // tumSehirlerComboBox
            // 
            this.tumSehirlerComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tumSehirlerComboBox.FormattingEnabled = true;
            this.tumSehirlerComboBox.Location = new System.Drawing.Point(184, 135);
            this.tumSehirlerComboBox.Name = "tumSehirlerComboBox";
            this.tumSehirlerComboBox.Size = new System.Drawing.Size(121, 29);
            this.tumSehirlerComboBox.TabIndex = 4;
            this.tumSehirlerComboBox.Text = "Tüm þehirler";
            // 
            // tumDurumlarComboBox
            // 
            this.tumDurumlarComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tumDurumlarComboBox.FormattingEnabled = true;
            this.tumDurumlarComboBox.Location = new System.Drawing.Point(321, 135);
            this.tumDurumlarComboBox.Name = "tumDurumlarComboBox";
            this.tumDurumlarComboBox.Size = new System.Drawing.Size(121, 29);
            this.tumDurumlarComboBox.TabIndex = 5;
            this.tumDurumlarComboBox.Text = "Tüm durumlar";
            // 
            // musterilerPanel
            // 
            this.musterilerPanel.BackColor = System.Drawing.Color.White;
            this.musterilerPanel.Controls.Add(this.musterilerDataGridView);
            this.musterilerPanel.Controls.Add(this.musterilerLabel);
            this.musterilerPanel.Location = new System.Drawing.Point(48, 180);
            this.musterilerPanel.Name = "musterilerPanel";
            this.musterilerPanel.Size = new System.Drawing.Size(500, 350);
            this.musterilerPanel.TabIndex = 6;
            // 
            // musterilerDataGridView
            // 
            this.musterilerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerDataGridView.Location = new System.Drawing.Point(20, 50);
            this.musterilerDataGridView.Name = "musterilerDataGridView";
            this.musterilerDataGridView.Size = new System.Drawing.Size(460, 280);
            this.musterilerDataGridView.TabIndex = 1;
            // 
            // musterilerLabel
            // 
            this.musterilerLabel.AutoSize = true;
            this.musterilerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.musterilerLabel.Location = new System.Drawing.Point(15, 15);
            this.musterilerLabel.Name = "musterilerLabel";
            this.musterilerLabel.Size = new System.Drawing.Size(96, 21);
            this.musterilerLabel.TabIndex = 0;
            this.musterilerLabel.Text = "Müþteriler:";
            // 
            // musteriDetayPanel
            // 
            this.musteriDetayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.musteriDetayPanel.Controls.Add(this.duzenleButton);
            this.musteriDetayPanel.Controls.Add(this.silButton);
            this.musteriDetayPanel.Controls.Add(this.hatirlaticiLabel);
            this.musteriDetayPanel.Controls.Add(this.iletisimLabel);
            this.musteriDetayPanel.Controls.Add(this.urunlerLabel);
            this.musteriDetayPanel.Controls.Add(this.musteriAdiLabel);
            this.musteriDetayPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.musteriDetayPanel.Location = new System.Drawing.Point(584, 0);
            this.musteriDetayPanel.Name = "musteriDetayPanel";
            this.musteriDetayPanel.Size = new System.Drawing.Size(300, 561);
            this.musteriDetayPanel.TabIndex = 7;
            // 
            // duzenleButton
            // 
            this.duzenleButton.BackColor = System.Drawing.Color.White;
            this.duzenleButton.FlatAppearance.BorderSize = 0;
            this.duzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenleButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.duzenleButton.ForeColor = System.Drawing.Color.Black;
            this.duzenleButton.Location = new System.Drawing.Point(30, 450);
            this.duzenleButton.Name = "duzenleButton";
            this.duzenleButton.Size = new System.Drawing.Size(240, 40);
            this.duzenleButton.TabIndex = 5;
            this.duzenleButton.Text = "Düzenle";
            this.duzenleButton.UseVisualStyleBackColor = false;
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.White;
            this.silButton.FlatAppearance.BorderSize = 0;
            this.silButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.silButton.ForeColor = System.Drawing.Color.Black;
            this.silButton.Location = new System.Drawing.Point(30, 500);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(240, 40);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            // 
            // hatirlaticiLabel
            // 
            this.hatirlaticiLabel.AutoSize = true;
            this.hatirlaticiLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hatirlaticiLabel.ForeColor = System.Drawing.Color.White;
            this.hatirlaticiLabel.Location = new System.Drawing.Point(30, 350);
            this.hatirlaticiLabel.Name = "hatirlaticiLabel";
            this.hatirlaticiLabel.Size = new System.Drawing.Size(78, 21);
            this.hatirlaticiLabel.TabIndex = 3;
            this.hatirlaticiLabel.Text = "Hatýrlatýcý:";
            // 
            // iletisimLabel
            // 
            this.iletisimLabel.AutoSize = true;
            this.iletisimLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iletisimLabel.ForeColor = System.Drawing.Color.White;
            this.iletisimLabel.Location = new System.Drawing.Point(30, 250);
            this.iletisimLabel.Name = "iletisimLabel";
            this.iletisimLabel.Size = new System.Drawing.Size(63, 21);
            this.iletisimLabel.TabIndex = 2;
            this.iletisimLabel.Text = "Ýletiþim:";
            // 
            // urunlerLabel
            // 
            this.urunlerLabel.AutoSize = true;
            this.urunlerLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urunlerLabel.ForeColor = System.Drawing.Color.White;
            this.urunlerLabel.Location = new System.Drawing.Point(30, 150);
            this.urunlerLabel.Name = "urunlerLabel";
            this.urunlerLabel.Size = new System.Drawing.Size(65, 21);
            this.urunlerLabel.TabIndex = 1;
            this.urunlerLabel.Text = "Ürünler:";
            // 
            // musteriAdiLabel
            // 
            this.musteriAdiLabel.AutoSize = true;
            this.musteriAdiLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.musteriAdiLabel.ForeColor = System.Drawing.Color.White;
            this.musteriAdiLabel.Location = new System.Drawing.Point(30, 50);
            this.musteriAdiLabel.Name = "musteriAdiLabel";
            this.musteriAdiLabel.Size = new System.Drawing.Size(162, 37);
            this.musteriAdiLabel.TabIndex = 0;
            this.musteriAdiLabel.Text = "Öner Aytaþ";
            // 
            // MusteriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.musteriDetayPanel);
            this.Controls.Add(this.musterilerPanel);
            this.Controls.Add(this.tumDurumlarComboBox);
            this.Controls.Add(this.tumSehirlerComboBox);
            this.Controls.Add(this.musteriEkleButton);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.musteriArayinTextBox);
            this.Controls.Add(this.musteriYonetimiTitleLabel);
            this.Name = "MusteriYonetimi";
            this.Text = "MusteriYonetimi";
            this.musterilerPanel.ResumeLayout(false);
            this.musterilerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDataGridView)).EndInit();
            this.musteriDetayPanel.ResumeLayout(false);
            this.musteriDetayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musteriYonetimiTitleLabel;
        private System.Windows.Forms.TextBox musteriArayinTextBox;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Button musteriEkleButton;
        private System.Windows.Forms.ComboBox tumSehirlerComboBox;
        private System.Windows.Forms.ComboBox tumDurumlarComboBox;
        private System.Windows.Forms.Panel musterilerPanel;
        private System.Windows.Forms.Label musterilerLabel;
        private System.Windows.Forms.DataGridView musterilerDataGridView;
        private System.Windows.Forms.Panel musteriDetayPanel;
        private System.Windows.Forms.Label musteriAdiLabel;
        private System.Windows.Forms.Label urunlerLabel;
        private System.Windows.Forms.Label iletisimLabel;
        private System.Windows.Forms.Label hatirlaticiLabel;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button duzenleButton;
    }
}
