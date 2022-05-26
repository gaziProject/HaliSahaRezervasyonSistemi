using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halı_Saha_Rezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form aktifform = null;
        private void formacma (Form ekran)
        {
            if (aktifform != null)
            {
                aktifform.Close();
            }
            aktifform = ekran;
            ekran.TopLevel = false;
            ekran.FormBorderStyle = FormBorderStyle.None;
            ekran.Dock = DockStyle.Fill;
            panelForm.Controls.Add(ekran);
            panelForm.Tag = ekran;
            ekran.BringToFront();
            ekran.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            formacma(new girisyap());
        }

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            formacma(new kayıtol());
        }
    }
}
