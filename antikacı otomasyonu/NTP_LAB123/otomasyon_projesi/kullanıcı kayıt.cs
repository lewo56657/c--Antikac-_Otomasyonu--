using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace proje2
{
    public partial class Kullanıcı_Kayıt : Form
    {
        public Kullanıcı_Kayıt()
        {
            InitializeComponent();
        }

        SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");
        DataTable veri_tabanı_tabloları = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bağlantı.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                veri_tabanı_tabloları.Clear();
                SqlCommand komut2 = new SqlCommand("select * from kullanicilar", bağlantı);
                da.SelectCommand = komut2;
                da.Fill(veri_tabanı_tabloları);
                komut2.ExecuteNonQuery();
                bağlantı.Close();
                Ana_Menu menü = new Ana_Menu();
                Kullanıcı_Bilgileri.mail = kayıt_emaili.Text;
                Kullanıcı_Bilgileri.isim = kayıt_ismi.Text;
                int v;
                for ( v=0 ; v < veri_tabanı_tabloları.Rows.Count; v++)
                {
                    if (veri_tabanı_tabloları.Rows[v][0].ToString().Equals(kayıt_ismi.Text) && veri_tabanı_tabloları.Rows[v][1].ToString().Equals(kayıt_emaili.Text) && veri_tabanı_tabloları.Rows[v][2].ToString().Equals(textBox3.Text) && textBox5.Text.Equals(textBox3.Text))
                    {
                             
                         menü.ürünEkleToolStripMenuItem.Visible = false;
                        menü.ürünSilToolStripMenuItem.Visible = false;
                         menü.Show();
                         this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Değerler Yanlıştır","Uyarı !");
                        return;
                    }


                }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            şifremi_unuttum yenişifre= new şifremi_unuttum();
            yenişifre.Show(); 
        }

        private void Kullanıcı_Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
