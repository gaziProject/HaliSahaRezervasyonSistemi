using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Halı_Saha_Rezervasyonu
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            if (textBox1 == textBox2)
            {
                şifreyenileme yeni = new şifreyenileme();
                yeni.Show();
                yeni.BringToFront();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ile mail eşleşmiyor!!!");
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }
    }
}
