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

namespace Emlak
{
    public partial class Form2 : Form
    {

        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\tugay\source\repos\Emlak\Emlak\Emlak.accdb"); 
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public Form2()
        {
            InitializeComponent();
        }

        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Emlak", baglanti);
            adtr.Fill(ds, "Emlak");
            dataGridView1.DataSource = ds.Tables["Emlak"];
            adtr.Dispose();
            baglanti.Close();
        }



        private void KayitEkleme_Click(object sender, EventArgs e)
        {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into Emlak(ID,il_ilce,adres,daire_no,kat_sayisi,m2,oda_sayisi,bina_yasi,fiyat) Values ('" + SiraTxt.Text + "','" + İlTxt.Text + "','" + AdresTxt.Text + "','" + DaireTxt.Text + "','" + KatTxt.Text + "','" + M2Txt.Text + "','" + OdaTxt.Text + "','" + BinaYasTxt.Text + "','" + FiyatTxt.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı"); 
                ds.Clear();
                listele();
           
        }

        private void KayitSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Delete from Emlak where ID=" + GüncellemeSilTxt.Text + "";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            ds.Clear();
            listele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void KayitGüncelleme_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Emlak set il_ilce ='" + İlTxt.Text + "',adres='" + AdresTxt.Text + "',daire_no='" + DaireTxt.Text + "',kat_sayisi='" + KatTxt.Text + "',m2='" + M2Txt.Text + "',oda_sayisi='" + OdaTxt.Text + "',bina_yasi='" + BinaYasTxt.Text + "',fiyat='" + FiyatTxt.Text + "'where ID=" + GüncellemeSilTxt.Text + "";
            komut.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            listele();
        }

        private void KayitArama_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\tugay\source\repos\Emlak\Emlak\Emlak.accdb");
            adtr = new OleDbDataAdapter("Select * from Emlak where ID like '" + GüncellemeSilTxt.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adtr.Fill(ds, "Emlak");
            dataGridView1.DataSource = ds.Tables["Emlak"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SiraTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            İlTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AdresTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DaireTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            KatTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            M2Txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            OdaTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            BinaYasTxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            FiyatTxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
