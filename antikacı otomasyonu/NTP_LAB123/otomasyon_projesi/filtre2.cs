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
    public partial class filtre2 : Form
    {
        public filtre2()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");

        public static string hangiFiltre;
        private void filtre2_Load(object sender, EventArgs e)
        {
            
        }

        private void tarih_aralık_barı_Scroll(object sender, EventArgs e)
        {
            Tarih_Aralığı.Text = tarih_aralık_barı.Minimum.ToString() + " - " + tarih_aralık_barı.Value.ToString() + " yy";
        }

        private void fiyat_aralık_barı_Scroll(object sender, EventArgs e)
        {
            Fiyat_Aralığı.Text = fiyat_aralık_barı.Minimum.ToString() + " - " + fiyat_aralık_barı.Value.ToString() + " TL";
        }
        tablolar tablo = new tablolar();
        private void button1_Click(object sender, EventArgs e)
        {
            if (hangiFiltre.Equals("tablo"))
            {
                tablolar tablo = new tablolar();
                tablolar.a = 1;
                tablolar.min = fiyat_aralık_barı.Minimum;
                tablolar.max = fiyat_aralık_barı.Value;
                tablo.Show();
                this.Hide();
            }
            else if (hangiFiltre.Equals("dekoratif"))
            {
                dekoratif_eşyalar dekore = new dekoratif_eşyalar();
                dekoratif_eşyalar.a= 1;
                dekoratif_eşyalar.min = fiyat_aralık_barı.Minimum;
                dekoratif_eşyalar.max = fiyat_aralık_barı.Value;
                dekore.Show();
                this.Hide();
            }
            else if (hangiFiltre.Equals("aksesuar"))
            {
                aksesuarlar aks = new aksesuarlar();
                aksesuarlar.a = 1;
                aksesuarlar.min = fiyat_aralık_barı.Minimum;
                aksesuarlar.max = fiyat_aralık_barı.Value;
                aks.Show();
                    this.Hide();
            }
            else if(hangiFiltre.Equals("heykel"))
            {
                heykeller heykel = new heykeller();
                heykeller.a = 1;
                heykeller.min = fiyat_aralık_barı.Minimum;
                heykeller.max = fiyat_aralık_barı.Value;
                heykel.Show();
                this.Hide();
            }
        }
    }
}
