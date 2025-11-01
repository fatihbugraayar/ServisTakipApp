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
            this.musteriYonetimiTitleLabel.Location = new System.Drawing.Point(53, 37);
            this.musteriYonetimiTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musteriYonetimiTitleLabel.Name = "musteriYonetimiTitleLabel";
            this.musteriYonetimiTitleLabel.Size = new System.Drawing.Size(344, 54);
            this.musteriYonetimiTitleLabel.TabIndex = 0;
            this.musteriYonetimiTitleLabel.Text = "Müþteri Yönetimi";
            // 
            // musteriArayinTextBox
            // 
            this.musteriArayinTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.musteriArayinTextBox.Location = new System.Drawing.Point(64, 111);
            this.musteriArayinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musteriArayinTextBox.Name = "musteriArayinTextBox";
            this.musteriArayinTextBox.Size = new System.Drawing.Size(399, 34);
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
            this.araButton.Location = new System.Drawing.Point(472, 111);
            this.araButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(80, 36);
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
            this.musteriEkleButton.Location = new System.Drawing.Point(64, 166);
            this.musteriEkleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(160, 37);
            this.musteriEkleButton.TabIndex = 3;
            this.musteriEkleButton.Text = "Müþteri Ekle";
            this.musteriEkleButton.UseVisualStyleBackColor = false;
            this.musteriEkleButton.Click += new System.EventHandler(this.musteriEkleButton_Click);
            // 
            // tumSehirlerComboBox
            // 
            this.tumSehirlerComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tumSehirlerComboBox.FormattingEnabled = true;
            this.tumSehirlerComboBox.Location = new System.Drawing.Point(245, 166);
            this.tumSehirlerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tumSehirlerComboBox.Name = "tumSehirlerComboBox";
            this.tumSehirlerComboBox.Size = new System.Drawing.Size(160, 36);
            this.tumSehirlerComboBox.TabIndex = 4;
            this.tumSehirlerComboBox.Text = "Tüm þehirler";
            // 
            // tumDurumlarComboBox
            // 
            this.tumDurumlarComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tumDurumlarComboBox.FormattingEnabled = true;
            this.tumDurumlarComboBox.Location = new System.Drawing.Point(428, 166);
            this.tumDurumlarComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tumDurumlarComboBox.Name = "tumDurumlarComboBox";
            this.tumDurumlarComboBox.Size = new System.Drawing.Size(160, 36);
            this.tumDurumlarComboBox.TabIndex = 5;
            this.tumDurumlarComboBox.Text = "Tüm durumlar";
            // 
            // musterilerPanel
            // 
            this.musterilerPanel.BackColor = System.Drawing.Color.White;
            this.musterilerPanel.Controls.Add(this.musterilerDataGridView);
            this.musterilerPanel.Controls.Add(this.musterilerLabel);
            this.musterilerPanel.Location = new System.Drawing.Point(64, 222);
            this.musterilerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musterilerPanel.Name = "musterilerPanel";
            this.musterilerPanel.Size = new System.Drawing.Size(667, 431);
            this.musterilerPanel.TabIndex = 6;
            // 
            // musterilerDataGridView
            // 
            this.musterilerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerDataGridView.Location = new System.Drawing.Point(27, 62);
            this.musterilerDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musterilerDataGridView.Name = "musterilerDataGridView";
            this.musterilerDataGridView.RowHeadersWidth = 51;
            this.musterilerDataGridView.Size = new System.Drawing.Size(613, 345);
            this.musterilerDataGridView.TabIndex = 1;
            // 
            // musterilerLabel
            // 
            this.musterilerLabel.AutoSize = true;
            this.musterilerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.musterilerLabel.Location = new System.Drawing.Point(20, 18);
            this.musterilerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musterilerLabel.Name = "musterilerLabel";
            this.musterilerLabel.Size = new System.Drawing.Size(116, 28);
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
            this.musteriDetayPanel.Location = new System.Drawing.Point(779, 0);
            this.musteriDetayPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musteriDetayPanel.Name = "musteriDetayPanel";
            this.musteriDetayPanel.Size = new System.Drawing.Size(400, 690);
            this.musteriDetayPanel.TabIndex = 7;
            // 
            // duzenleButton
            // 
            this.duzenleButton.BackColor = System.Drawing.Color.White;
            this.duzenleButton.FlatAppearance.BorderSize = 0;
            this.duzenleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenleButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.duzenleButton.ForeColor = System.Drawing.Color.Black;
            this.duzenleButton.Location = new System.Drawing.Point(40, 554);
            this.duzenleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duzenleButton.Name = "duzenleButton";
            this.duzenleButton.Size = new System.Drawing.Size(320, 49);
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
            this.silButton.Location = new System.Drawing.Point(40, 615);
            this.silButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(320, 49);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            // 
            // hatirlaticiLabel
            // 
            this.hatirlaticiLabel.AutoSize = true;
            this.hatirlaticiLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hatirlaticiLabel.ForeColor = System.Drawing.Color.White;
            this.hatirlaticiLabel.Location = new System.Drawing.Point(40, 431);
            this.hatirlaticiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hatirlaticiLabel.Name = "hatirlaticiLabel";
            this.hatirlaticiLabel.Size = new System.Drawing.Size(100, 28);
            this.hatirlaticiLabel.TabIndex = 3;
            this.hatirlaticiLabel.Text = "Hatýrlatýcý:";
            // 
            // iletisimLabel
            // 
            this.iletisimLabel.AutoSize = true;
            this.iletisimLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iletisimLabel.ForeColor = System.Drawing.Color.White;
            this.iletisimLabel.Location = new System.Drawing.Point(40, 308);
            this.iletisimLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iletisimLabel.Name = "iletisimLabel";
            this.iletisimLabel.Size = new System.Drawing.Size(78, 28);
            this.iletisimLabel.TabIndex = 2;
            this.iletisimLabel.Text = "Ýletiþim:";
            // 
            // urunlerLabel
            // 
            this.urunlerLabel.AutoSize = true;
            this.urunlerLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urunlerLabel.ForeColor = System.Drawing.Color.White;
            this.urunlerLabel.Location = new System.Drawing.Point(40, 185);
            this.urunlerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urunlerLabel.Name = "urunlerLabel";
            this.urunlerLabel.Size = new System.Drawing.Size(81, 28);
            this.urunlerLabel.TabIndex = 1;
            this.urunlerLabel.Text = "Ürünler:";
            // 
            // musteriAdiLabel
            // 
            this.musteriAdiLabel.AutoSize = true;
            this.musteriAdiLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.musteriAdiLabel.ForeColor = System.Drawing.Color.White;
            this.musteriAdiLabel.Location = new System.Drawing.Point(40, 62);
            this.musteriAdiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musteriAdiLabel.Name = "musteriAdiLabel";
            this.musteriAdiLabel.Size = new System.Drawing.Size(195, 46);
            this.musteriAdiLabel.TabIndex = 0;
            this.musteriAdiLabel.Text = "Öner Aytaþ";
            // 
            // MusteriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.musteriDetayPanel);
            this.Controls.Add(this.musterilerPanel);
            this.Controls.Add(this.tumDurumlarComboBox);
            this.Controls.Add(this.tumSehirlerComboBox);
            this.Controls.Add(this.musteriEkleButton);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.musteriArayinTextBox);
            this.Controls.Add(this.musteriYonetimiTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
