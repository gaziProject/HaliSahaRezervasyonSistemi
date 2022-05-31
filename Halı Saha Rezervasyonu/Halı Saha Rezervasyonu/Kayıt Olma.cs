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
    public partial class kayıtol : Form
    {
        public kayıtol()
        {
            InitializeComponent();
        }
        private void textclear(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textclear(item);
                }
                if (item is ComboBox)
                {
                    comboBox1.Text = null;
                }
            }
        }
          private void groupBoxkisisel_Enter(object sender, EventArgs e)
        {

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            textclear(this);
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox2.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox3.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox4.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox5.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox6.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox7.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (textBox8.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (maskedTextBox1.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (maskedTextBox2.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            if (comboBox1.Text == null)
                MessageBox.Show("Boş Bırakılamaz");
            else
            {

            }
        }
    }
}


