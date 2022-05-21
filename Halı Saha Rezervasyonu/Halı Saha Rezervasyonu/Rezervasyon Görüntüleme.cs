﻿using System;
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
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Pazar");


            comboBox2.Items.Add("16.00-17.00");
            comboBox2.Items.Add("17.00-18.00");
            comboBox2.Items.Add("18.00-19.00");
            comboBox2.Items.Add("19.00-20.00");
            comboBox2.Items.Add("20.00-21.00");
            comboBox2.Items.Add("21.00-22.00");
            comboBox2.Items.Add("22.00-23.00");
            comboBox2.Items.Add("23.00-00.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 15;
            foreach (Control c in this.Controls)
            {
                counter++;
                if (c is Label)
                {

                    if (((Label)c).Name == "pazartesi" + counter)
                    {
                        ((Label)c).Text = counter.ToString();
                    }
                }
            }
        }
    }
}
