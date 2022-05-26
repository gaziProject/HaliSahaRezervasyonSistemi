using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Halı_Saha_Rezervasyonu
{
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\yibif\\Desktop\\github gazi proje\\HaliSahaRezervasyonSistemi\\Halısaha.mdb");
        // Yolu Girin Buraya
        
        private void goruntule()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Ana");
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                
            }
            baglanti.Close();
        }


        private void SıralaBtn_Click(object sender, EventArgs e)
        {
            goruntule();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Rezervasyon_Görüntüleme rezervasyon_Görüntüleme = new Rezervasyon_Görüntüleme();
            rezervasyon_Görüntüleme.Show();
            Hide();
        }

        private void SahaNoTextBox_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void Arama_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat,Degerlendirme From Ana", baglanti);
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
            goruntule();
        }
        DataTable tbl = new DataTable();
        DataView Filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "Convert(id,System.String) Like '" + SahaNoTextBox.Text + "%'";
            return dv;
        }
    }
}
