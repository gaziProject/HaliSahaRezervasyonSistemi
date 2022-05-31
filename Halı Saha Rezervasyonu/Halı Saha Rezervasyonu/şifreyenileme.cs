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
    public partial class şifreyenileme : Form
    {
        public şifreyenileme()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Regular);
            textBox1.PasswordChar = '*';
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style ^ FontStyle.Regular);
            textBox2.PasswordChar = '*';

        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            //şifre update
            MessageBox.Show("Şifreniz güncellenmiştir.");
            this.Close();
        }
    }
}
