using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class ürün_sil : Form
    {
        public ürün_sil()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            urun_ismi1.Clear();
            urun_yapiliş_tarihi.Clear();
            ürün_fiyati.Clear();
        }

        private void ürün_sil_Load(object sender, EventArgs e)
        {
            temizle();
        }
        /// <summary>
        /// ///////////
        /// </summary>
          int id = 0;
        string mesaj;
        public static string mesaj1;
        private void silme_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");
            try
            {

                bağlantı.Open();
                int a = 0;
                Ana_Menu silinecek_tablo = new Ana_Menu();
                Database db = new Database();
                MessageBox.Show(silinecek_tablo.tablolarToolStripMenuItem.Selected.ToString()+1.ToString(),"seçili"); ;
                SqlCommand komutlar = new SqlCommand();
                if (mesaj1.Equals("tablolar"))
                {
                    
                    a = 0;
                }
                else if (mesaj1.Equals("heykeller"))
                {
                    a = 1;
                }
                else if (mesaj1.Equals("dekoratif"))
                {
                    a = 2;
                }
                else{
                    a = 3;
                }
                switch (a)
                {
                    case 0:
                        mesaj = "Delete  from Tablolar Where Adi = @adi";
                        goto case 4; 
                    case 1:
                        mesaj = "Delete  from HEYKELLER1 Where Adi = @adi";
                        goto case 4;
                    case 2:
                        mesaj = "Delete  from DEKORATİF_ESYALAR Where Adi = @adi";
                        goto case 4; 
                    case 3:
                        mesaj = "Delete  from AKSESUARLAR1 Where Adi = @adi";
                        goto case 4;
                    case 4:
                        komutlar = new SqlCommand(mesaj,bağlantı);
                        komutlar.Parameters.AddWithValue("@adi",urun_ismi1.Text);
                        komutlar.ExecuteNonQuery();
                        bağlantı.Close();
                        break;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
           
          
                 MessageBox.Show("ürün silindi");

        }
        
        private void silinecek_urunler_DoubleClick(object sender, EventArgs e)
        {
         
            
            id = int.Parse(silinecek_urunler.SelectedItems[0].SubItems[0].Text);
           urun_ismi1.Text=silinecek_urunler.SelectedItems[0].SubItems[1].Text;
           urun_yapiliş_tarihi.Text = silinecek_urunler.SelectedItems[0].SubItems[2].Text;
           ürün_fiyati.Text = silinecek_urunler.SelectedItems[0].SubItems[3].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void silinecek_urunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
