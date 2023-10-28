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
    public partial class şifremi_unuttum : Form
    {
        public şifremi_unuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");

            try
            {
                bağlantı.Open();
                string komut = "UPDATE  kullanicilar SET kullanici_sifre=@sifre where kullanici_email = @email";
                SqlCommand command = new SqlCommand(komut, bağlantı);
                command.Parameters.AddWithValue("@sifre", Yeni_şifre_tekrar.Text);
                command.Parameters.AddWithValue("@email", Değiştirilecek_email.Text);
                command.ExecuteNonQuery();
                bağlantı.Close();
                MessageBox.Show("şifreniz başarıyla güncellendi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Kullanıcı_Kayıt kullanıcı = new Kullanıcı_Kayıt();
            kullanıcı.Show();
            this.Hide();
            //Database DB = new Database();
            //DB.exceuteData ("UPDATE  kullanicilar SET kullanici_sifresi='" + Yeni_şifre_tekrar.Text + "' WHERE kullanici_email ='" + Değiştirilecek_email.Text + "'","");
             
        }

        private void şifremi_unuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
