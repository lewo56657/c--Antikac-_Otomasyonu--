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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje2
{
    public partial class Ana_Menu : Form
    {
        public Ana_Menu()
        {
            InitializeComponent();
        }
        
        SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");
        DataTable veri_tabanı_tabloları = new DataTable();
          
       
        ürün_sil silme = new ürün_sil();
        Kullanıcı_Bilgileri bilgi = new Kullanıcı_Bilgileri();


        private void button1_Click(object sender, EventArgs e)
        {
             heykeller heykel= new heykeller();           
             heykel.Show();
             this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablolar tablo = new tablolar();
            tablo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dekoratif_eşyalar dekoratif = new dekoratif_eşyalar();  
           dekoratif.Show();
            this.Hide();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aksesuarlar aksesuar= new aksesuarlar();
            aksesuar.Show();
            this.Hide();
        }

        private void sepetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sepet sepetim = new sepet();
          
            sepetim.Show();
        }

        private void hesabımToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void bilgilerimiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanıcı_Bilgileri bilgiler = new Kullanıcı_Bilgileri();
            Kullanıcı_Kayıt kaydedilen = new Kullanıcı_Kayıt();

            bilgiler.kullanıcı_isim_bilgisi.Text = kaydedilen.kayıt_ismi.Text;
            bilgiler.kullanıcı_email_bilgisi.Text = kaydedilen.kayıt_emaili.Text;
            bilgiler.Show();
           
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            ürün_kayıt yeni_ürün = new ürün_kayıt();
            
            yeni_ürün.Show();

        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void tablolarToolStripMenuItem_Click(object sender, EventArgs e)//tamam
        {
            ürün_sil.mesaj1 = "tablolar";
            silme.silinecek_urunler.Items.Clear();
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select * from Tablolar", bağlantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Fiyati"].ToString());
                silme.silinecek_urunler.Items.Add(ekle);
            }
            bağlantı.Close();

            silme.ShowDialog();
            

        }

        private void heykellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ürün_sil.mesaj1 = "heykeller";
            silme.silinecek_urunler.Items.Clear();
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select * from HEYKELLER1", bağlantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Fiyati"].ToString());
                silme.silinecek_urunler.Items.Add(ekle);
            }
            bağlantı.Close();
            silme.ShowDialog();
           
        }

        private void dekoratifEşyalarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ürün_sil.mesaj1 = "dekoratif";
            silme.silinecek_urunler.Items.Clear();
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select * from DEKORATİF_ESYALAR", bağlantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Fiyati"].ToString());
                silme.silinecek_urunler.Items.Add(ekle);
            }
            bağlantı.Close();
            silme.ShowDialog();
          
        }

        private void aksesuarlarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ürün_sil.mesaj1 = "aksesuarlar";

            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select * from AKSESUARLAR1", bağlantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Fiyati"].ToString());
                silme.silinecek_urunler.Items.Add(ekle);
            }
            bağlantı.Close();
            silme.ShowDialog();

        
        }

        private void Ana_Menu_Load(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İlk_Form kayıt = new İlk_Form();
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Hesabınızdan çıkmak istersiniz miydi?","Çıkış yap",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                kayıt.Show();
                this.Hide();
            }
            
        }

        //private void aksesuarlarToolStripMenuItem_Click(object sender, EventArgs e)// tamam
        //{

        //    bağlantı.Open();
        //    SqlCommand komut = new SqlCommand("select * from AKSESUARLAR1 ", bağlantı);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        ListViewItem ekle = new ListViewItem();
        //        ekle.Text = oku["ıd"].ToString();
        //        ekle.SubItems.Add(oku["Adi"].ToString());
        //        ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
        //        ekle.SubItems.Add(oku["Fiyati"].ToString());
        //        silme.silinecek_urunler.Items.Add(ekle);

        //    }
        //    bağlantı.Close();
        //    silme.Show();

        //}

        //private void dekoratifeşyalarToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    bağlantı.Open();
        //    SqlCommand komut = new SqlCommand("select * from DEKORATİF_ESYALAR", bağlantı);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        ListViewItem ekle = new ListViewItem();
        //        ekle.Text = oku["ıd"].ToString();
        //        ekle.SubItems.Add(oku["Adi"].ToString());
        //        ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
        //        ekle.SubItems.Add(oku["Fiyati"].ToString());
        //        silme.silinecek_urunler.Items.Add(ekle);

        //    }
        //    bağlantı.Close();
        //    silme.Show();
        //}

        //private void aksesuarlarToolStripMenuItem1_Click(object sender, EventArgs e) // heykeller
        //{

        //    bağlantı.Open();
        //    SqlCommand komut = new SqlCommand("select * from HEYKELLER1", bağlantı);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        ListViewItem ekle = new ListViewItem();
        //        ekle.Text = oku["ıd"].ToString();
        //        ekle.SubItems.Add(oku["Adi"].ToString());
        //        ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
        //        ekle.SubItems.Add(oku["Fiyati"].ToString());
        //        silme.silinecek_urunler.Items.Add(ekle);

        //    }
        //    bağlantı.Close();
        //    silme.Show();

        //}
    }
}
