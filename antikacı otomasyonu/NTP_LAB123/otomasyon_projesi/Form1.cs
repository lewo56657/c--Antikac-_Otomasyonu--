using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Data.Sql;

namespace proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");
        DataTable veri_tabanı_tabloları = new DataTable();
       
 
            private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Kullanıcı_Kayıt k1 = new Kullanıcı_Kayıt();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Kullanıcı_Kayıt kayıt = new Kullanıcı_Kayıt();

            kayıt.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            


            try
            {
                bağlantı.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                veri_tabanı_tabloları.Clear();
                SqlCommand komut2 = new SqlCommand("select * from kullanicilar",bağlantı);
                da.SelectCommand = komut2;
                da.Fill(veri_tabanı_tabloları);
                komut2.ExecuteNonQuery();
                bağlantı.Close();
                for (int i = 0; i < veri_tabanı_tabloları.Rows.Count; i++)
                {
                    if (veri_tabanı_tabloları.Rows[i][1].ToString().Equals(E_MAİL.Text))
                    {
                        MessageBox.Show("Bu mail adresi zaten kayıtlı","Başarısız");
                        return;
                    }
                    

                }
                bağlantı.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO kullanicilar(kullanici_ismi,kullanici_email,kullanici_sifre) values('" + kullanici_ismi1.Text + "','" + E_MAİL.Text + "','" + İLKŞİFRE.Text + "')", bağlantı);
                komut.ExecuteNonQuery();
                bağlantı.Close();
                MessageBox.Show("İŞlem hatasız tamamlandı");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                
            }

            

        }

        private void KULLANICI_GİRİŞ_Load(object sender, EventArgs e)
        {

        }

        private void YENİŞİFRETEKRAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanici_ismi1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
