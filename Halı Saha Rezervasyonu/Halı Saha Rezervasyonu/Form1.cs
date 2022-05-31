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
        public void loadform (object Form)
        {
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0);
            }
<<<<<<< Updated upstream
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(f);
            this.panel4.Tag = f;
            f.Show();
=======
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
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
>>>>>>> Stashed changes
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            loadform(new kayıtol());
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            loadform(new girisyap());
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            loadform(new Form3());
            MessageBox.Show("onur_arikan2002@hotmail.com mailine ulaşabilirsiniz.");
=======
            formacma(new Form3());
            MessageBox.Show("'onur_arikan2002@hotmail.com' mailine ulaşabilirsiniz.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}
