using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class sepet : Form
    {
        Database DB = new Database();
        public void listele()
        {
            Database db = new Database();
            DataTable tbl = new DataTable();
            sepet sepetim = new sepet();

            tbl.Clear();
            tbl = db.readData("select * from sepet1", "");

            sepet_listesi.Rows.Clear();

            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                sepet_listesi.Rows.Add(1);
                sepet_listesi.Rows[i].Cells[0].Value = i;
                sepet_listesi.Rows[i].Cells[1].Value = tbl.Rows[i][0];
                sepet_listesi.Rows[i].Cells[2].Value = tbl.Rows[i][1];
                sepet_listesi.Rows[i].Cells[3].Value = tbl.Rows[i][2];

            }
            ürün_sayısı.Text = (sepet_listesi.RowCount - 1).ToString();
            DataTable dt2 = new DataTable();
            dt2 = DB.readData("SELECT SUM(Fiyati) FROM sepet1", "");
            
            Toplam_fiyat.Text = dt2.Rows[0][0].ToString();
            if (Toplam_fiyat.Text.Equals(""))
            {
                Toplam_fiyat.Text = "0";
            }

        }




        public string toplamf;
        public sepet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sepet_Load(object sender, EventArgs e)
        {
            listele();
            


        }
      // SELECT SUM() FROM table_name
        private void geçmişSparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DB.exceuteData("DELETE  From sepet1","Sepetinizdeki Ürünler Silindi");
           listele();

        }

        private void geçmişSparişlerimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Toplam_fiyat_TextChanged(object sender, EventArgs e)
        {
          //  Toplam_fiyat.Text = toplamf.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş Alındı");
        }
    }
}
