using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halı_Saha_Rezervasyonu
{
    public partial class Rezervasyon_Görüntüleme : Form
    {
        public int x;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\omermmz\\source\\repos\\HaliSahaRezervasyonSistemi\\Halısaha.mdb");
        OleDbCommand komut;
        OleDbDataReader re;
        public Rezervasyon_Görüntüleme()
        {
            InitializeComponent();






        }
        public Rezervasyon_Görüntüleme(string no)
        {
            InitializeComponent();
            x = Convert.ToInt32(no);
            acilis(x);

        }
        private void acilis(int x)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("SELECT Rezervler.[id], Rezervler.[Gun], Rezervler.[Saat], Rezervler.[Halisaha] FROM Rezervler WHERE Halisaha=@no");
            komut.Parameters.AddWithValue("@no", x);
            re = komut.ExecuteReader();
            while (re.Read())
            {
                ArrayList labels = new ArrayList();
                Labels(labels);


                if (re["Saat"].ToString() == cmbsaat.Items[0].ToString())
                {
                    foreach (Label c in labels)
                    {



                        if (c.Name.Equals(re["Gun"].ToString() + 16))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;


                        }

                    }
                }

                else if (re["Saat"].ToString() == cmbsaat.Items[1].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 17))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }

                else if (re["Saat"].ToString() == cmbsaat.Items[2].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 18))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[3].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 19))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[4].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 20))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[5].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 21))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[6].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 22))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
                else if (re["Saat"].ToString() == cmbsaat.Items[7].ToString())
                {
                    foreach (Label c in labels)
                    {


                        if (c.Name.Equals(re["Gun"].ToString() + 23))
                        {
                            c.ForeColor = Color.Red;
                            c.BackColor = Color.DarkGreen;
                        }

                    }
                }
            }
            re.Close();
            baglanti.Close();

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

            string sorgu = "INSERT INTO Rezervler(Halisaha,Gun,Saat) values (@halisaha,@gun,@saat)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@halisaha", x);
            komut.Parameters.AddWithValue("@gun", cmbgun.Text.ToString());
            komut.Parameters.AddWithValue("@saat", cmbsaat.Text.ToString());
            baglanti.Open();
            int sayac = 0;
            foreach (Label l in labels)
            {
                if (l.ForeColor == Color.Red && l.BackColor == Color.DarkGreen && cmbsaat.Text.ToString() == l.Text && l.Name.IndexOf(cmbgun.Text.ToString(), 0) != -1)
                {
                    //Warning penceresi
                    sayac++;
                }

            }

            if (sayac == 0)
            {
                komut.ExecuteNonQuery();
            }

            baglanti.Close();

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