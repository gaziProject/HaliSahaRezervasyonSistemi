using System;
using System.Collections;
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
    public partial class Rezervasyon_Görüntüleme : Form
    {
        public Rezervasyon_Görüntüleme()
        {
            InitializeComponent();






        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Rezervasyon_Görüntüleme_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList labels = new ArrayList();
            Labels(labels);

            if (cmbsaat.Text == cmbsaat.Items[0].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 16))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }

            else if (cmbsaat.Text == cmbsaat.Items[1].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 17))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }

            else if (cmbsaat.Text == cmbsaat.Items[2].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 18))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }
            else if (cmbsaat.Text == cmbsaat.Items[3].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 19))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }
            else if (cmbsaat.Text == cmbsaat.Items[4].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 20))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }
            else if (cmbsaat.Text == cmbsaat.Items[5].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 21))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }
            else if (cmbsaat.Text == cmbsaat.Items[6].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 22))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }
            else if (cmbsaat.Text == cmbsaat.Items[7].ToString())
            {
                foreach (Label c in labels)
                {


                    if (c.Name.Equals(cmbgun.Text + 23))
                    {
                        c.ForeColor = Color.Red;
                        c.BackColor = Color.DarkGreen;
                    }

                }
            }
            else
            {
                //Warning penceresi
            }


        }
    }
}