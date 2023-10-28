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
using System.Linq.Expressions;

namespace proje2
{
    public partial class YÖNETİCİ_GİRİŞİ : Form
    {
        public YÖNETİCİ_GİRİŞİ()
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
                SqlCommand komut2 = new SqlCommand("select * from yoneticiler", bağlantı);
                da.SelectCommand = komut2;
                da.Fill(veri_tabanı_tabloları);
                komut2.ExecuteNonQuery();
                bağlantı.Close();
                for (int i = 0; i < veri_tabanı_tabloları.Rows.Count; i++)
                {
                    if (veri_tabanı_tabloları.Rows[i][0].ToString().Equals(yönetici_ismi1.Text) && veri_tabanı_tabloları.Rows[i][1].ToString().Equals(yönetici_şifresi1.Text) && veri_tabanı_tabloları.Rows[i][2].ToString().Equals(yönetici_giriş_kodu.Text))
                    {
                        Ana_Menu menü = new Ana_Menu();
                        menü.Show();
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Değerler Yanlıştır ", "UYARI !");
                        return;
                    }


                }

              

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
