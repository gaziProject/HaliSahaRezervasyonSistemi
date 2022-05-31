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
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Italic);
            textBox2.PasswordChar = '*';

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            //Giriş için kontroller yapılacak
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sol taraftaki menüden kaydınızı yaptırınız.");
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            sifremiunuttum yeni = new sifremiunuttum();
            yeni.Show();
            yeni.BringToFront();
        }
    }
}
