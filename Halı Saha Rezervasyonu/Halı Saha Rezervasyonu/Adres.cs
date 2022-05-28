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
    public partial class Adres : Form
    {
        public Adres()
        {
            InitializeComponent();
        }
        
        public string isim, degerlendirme, ilce, fiyat, id,adres,telefon;

        private void rezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon_Görüntüleme ac = new Rezervasyon_Görüntüleme();
            ac.Show();
            Hide();
        }

        private void Adres_Load(object sender, EventArgs e)
        {
            idlabel.Text = id;
            halısahaadı_label.Text = isim;
            degerlendirmelabel.Text = degerlendirme;
            ilcelabel.Text = ilce; 
            fiyatlabel.Text = fiyat;
            adreslabel.Text = adres;
            telefonlabel.Text = telefon;

        }
    }
}
