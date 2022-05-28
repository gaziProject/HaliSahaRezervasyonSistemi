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

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\6ncaf\\OneDrive\\Masaüstü\\git\\Halısaha.mdb");
        // Yolu Girin Buraya

        


        private void SıralaBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            comboBox1.Text = "";
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat,Degerlendirme From Ana", baglanti);
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
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
            baglanti.Open();
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat,Degerlendirme From Ana", baglanti);
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
           
            //OleDbCommand komut1 = new OleDbCommand();
            //komut1.Connection = baglanti;
            //komut1.CommandText = ("Select Ilce From Ana");
            //OleDbDataReader oku2 = komut1.ExecuteReader();
            //while (oku2.Read())
            //{
            //    comboBox1.Items.Add(oku2["Ilce"]);
            //}
            baglanti.Close();
        }
        DataTable tbl = new DataTable();
        DataTable tbl2 = new DataTable();
        DataView Filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "Convert(id,System.String) Like '" + SahaNoTextBox.Text + "%'";
            return dv;
        }
        DataView Filtrele_ılce()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "Ilce Like '" + comboBox1.Text + "%'";
            return dv;
        }

        private void FiyatsiralaBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void FiyatsiralaBtn_Click_1(object sender, EventArgs e)
        {
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglanti;


           
            string a = "Select id,HalısahaAdı,Ilce,Fiyat,Degerlendirme From Ana Where Fiyat Between ? And ?";
            komut2.CommandText = a;
            komut2.Parameters.Add("@v1", OleDbType.Integer).Value = this.minTextBox.Text;

            komut2.Parameters.Add("@v2", OleDbType.Integer).Value = this.maxTextBox.Text;

            OleDbDataAdapter adptFiyat = new OleDbDataAdapter(komut2);
            adptFiyat.Fill(tbl2);
            dataGridView1.DataSource = tbl2;
            
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void minTextBox_MouseClick(object sender, MouseEventArgs e)
        {
                minTextBox.Text ="";
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            maxTextBox.Text = "";
        }
          
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           tbl.Clear();
            OleDbDataAdapter adpt = new OleDbDataAdapter("Select id,HalısahaAdı,Ilce,Fiyat,Degerlendirme From Ana", baglanti);
            adpt.Fill(tbl);
            dataGridView1.DataSource = tbl;
            
            Filtrele_ılce(); 
            

        }
       
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            Adres deger = new Adres();
            deger.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            deger.isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            deger.ilce = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            deger.fiyat= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            deger.degerlendirme = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Ana");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == oku["id"].ToString())
                {
                    deger.adres = oku["Adres"].ToString();
                }
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == oku["id"].ToString())
                {
                    deger.telefon = oku["Telefon"].ToString();
                }
            }
            baglanti.Close();
            
            deger.Show();
            Hide();
        }
    }
}
