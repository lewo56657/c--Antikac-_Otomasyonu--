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
    public partial class Kullanıcı_Bilgileri : Form
    {
        public Kullanıcı_Bilgileri()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public static string mail;
        public static string isim;
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                Kullanıcı_Kayıt yeni_kayıt = new Kullanıcı_Kayıt();
                bağlantı.Open();
                SqlCommand güncelleme = new SqlCommand("Update  kullanicilar set kullanici_ismi= @isim,kullanici_email=@yenimail Where  kullanici_email= @eskimail", bağlantı);
                güncelleme.Parameters.AddWithValue("@isim", kullanıcı_isim_bilgisi.Text);
                güncelleme.Parameters.AddWithValue("@yenimail", kullanıcı_email_bilgisi.Text);
                güncelleme.Parameters.AddWithValue("@eskimail", mail);
                güncelleme.ExecuteNonQuery();
                bağlantı.Close();
                MessageBox.Show("Güncellendi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString()); ;
                throw;
            }
            
            //Database db = new Database();
            //db.exceuteData("Update  kullanicilar set kullanici_ismi='" + kullanıcı_isim_bilgisi.Text + "',kullanici_email='" + kullanıcı_email_bilgisi.Text + "' Where  kullanici_ismi= " + yeni_kayıt.kayıt_emaili.Text + "", " ");
            //MessageBox.Show("bilgileriniz başarıyla güncellendi");







        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgileriniz güncellendi");
        }

        private void bilgilerimiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {           



            kullanıcı_bilgileri_güncelleme .Visible= true;
            kullanıcı_email_bilgisi.Enabled = true;
            kullanıcı_isim_bilgisi.Enabled=true;

        }

        private void kullanıcı_isim_bilgisi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Kullanıcı_Bilgileri_Load(object sender, EventArgs e)
        {
            kullanıcı_isim_bilgisi.Text = isim;
            kullanıcı_email_bilgisi.Text = mail;
            
         
        }
    }
}
