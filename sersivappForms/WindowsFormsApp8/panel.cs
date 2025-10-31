using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class panel : UserControl
    {
        public panel()
        {
            InitializeComponent();
        }

        private void anasayfaButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                mainForm.openChildForm(new anasayfa());
            }
        }

        private void musteriYonetimiButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                mainForm.openChildForm(new MusteriYonetimi());
            }
        }

        private void urunBakimButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                mainForm.openChildForm(new UrunBakim());
            }
        }

        private void servisButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                mainForm.openChildForm(new Servis());
            }
        }
    }
}
