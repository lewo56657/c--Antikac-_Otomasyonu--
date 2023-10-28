using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class ürün_kayıt : Form
    {
        public ürün_kayıt()
        {
            InitializeComponent();
        }
        Ana_Menu menü= new Ana_Menu();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database DB= new Database();
           
            for (int i = 0; i < 1000; i++)
            {
                 if (eklenecek_ürün_kategorisi.Text=="Tablo")
                  {
                DB.exceuteData("insert into Tablolar values ('"+ i+"','" + Eklenecek_ürün_ismi.Text + "','" + Eklenecek_ürün_yapılış_tarihi.Text + "'," + Convert.ToInt32(Eklenecek_ürün_fiyatı.Text) + ")", "");
                    break;

                 }
                if (eklenecek_ürün_kategorisi.Text =="Dekoratif Eşya")
                {
                    DB.exceuteData("insert into DEKORATİF_ESYALAR values ('" + i + "','" + Eklenecek_ürün_ismi.Text + "','" + Eklenecek_ürün_yapılış_tarihi.Text + "'," + Convert.ToInt32(Eklenecek_ürün_fiyatı.Text) + ")", "");
                    break;

                }
                if (eklenecek_ürün_kategorisi.Text =="Heykel")
                {
                    DB.exceuteData("insert into Heykeller1 values ('" + i + "','" + Eklenecek_ürün_ismi.Text + "','" + Eklenecek_ürün_yapılış_tarihi.Text + "'," + Convert.ToInt32(Eklenecek_ürün_fiyatı.Text) + ")", "");
                    break;

                }
                if (eklenecek_ürün_kategorisi.Text=="Aksesuar")
                {

                    DB.exceuteData("insert into AKSESUARLAR1 values ('" + i + "','" + Eklenecek_ürün_ismi.Text + "','" + Eklenecek_ürün_yapılış_tarihi.Text + "'," + Convert.ToInt32(Eklenecek_ürün_fiyatı.Text) + ")", "");
                    break;

                }


            }
           
          
          
            MessageBox.Show("Ürün başarıyla eklendi");
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
