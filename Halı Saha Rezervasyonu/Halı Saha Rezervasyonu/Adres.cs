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
        public string isim, telefon, ilce, fiyat, id;
        public Adres(string isim, string telefon,string ilce, string fiyat, string id)
        {
            this.isim = isim;
            this.telefon = telefon;
            this.ilce = ilce;
            this.fiyat = fiyat;
            this.id = id; 
        }

        private void Adres_Load(object sender, EventArgs e)
        {
            idlabel.Text = id;
            halısahaadı_label.Text = isim;
            telefonlabel.Text = telefon;
            ilcelabel.Text = ilce; 
            fiyatlabel.Text = fiyat;

        }
    }
}
