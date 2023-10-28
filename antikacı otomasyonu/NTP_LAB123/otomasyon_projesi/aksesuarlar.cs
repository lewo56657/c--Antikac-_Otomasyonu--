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
    public partial class aksesuarlar : Form
    {
        public aksesuarlar()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source=SAFFET\\SQLEXPRESS;Initial Catalog=yeni_antikacı;Integrated Security=True");
        public static int a = 0;
        public static int min;
        public static int max;

        public void aksesuar_listele(int min, int max)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("select * from AKSESUARLAR1 Where Fiyati between @min and @max", bağlantı);
            komut.Parameters.AddWithValue("@min", min);
            komut.Parameters.AddWithValue("@max", max);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Yapiliş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Fiyati"].ToString());
                Aksesuar_Listesi.Items.Add(ekle);
            }
            bağlantı.Close();


        }
        public void aksesuar_listele()
        {
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
                Aksesuar_Listesi.Items.Add(ekle);
            }
            bağlantı.Close();
        }

        #region
        private void button1_Click(object sender, EventArgs e)
        {
            HEYKEL1 uruntanıtım= new HEYKEL1();
            uruntanıtım.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HEYKEL1 uruntanıtım = new HEYKEL1();
            uruntanıtım.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HEYKEL1 uruntanıtım = new HEYKEL1();
            uruntanıtım.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HEYKEL1 uruntanıtım = new HEYKEL1();
            uruntanıtım.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HEYKEL1 uruntanıtım = new HEYKEL1();
            uruntanıtım.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HEYKEL1 uruntanıtım = new HEYKEL1();
            uruntanıtım.Show();
        }
        #endregion
        int yeniid2 = 0;
        private void aksesuarlar_Load(object sender, EventArgs e)
        {
            if (a == 0)
            {
                aksesuar_listele();
            }
            else
            {
                aksesuar_listele(min,max);
            }

        }

        private void Aksesuar_Listesi_DoubleClick(object sender, EventArgs e)
        {
            HEYKEL1 tanıtım = new HEYKEL1();
            //HEYKEL1.foto = "C:\\Users\\90552\\Downloads\\Documents\\aksesuar.jpg";
            yeniid2 = int.Parse(Aksesuar_Listesi.SelectedItems[0].SubItems[0].Text);
            tanıtım.tanıtım_ismi.Text = Aksesuar_Listesi.SelectedItems[0].SubItems[1].Text;
            tanıtım.tanıtım_yapılış_tarihi.Text = Aksesuar_Listesi.SelectedItems[0].SubItems[2].Text;
            tanıtım.Tanıtım_fiyatı.Text = Aksesuar_Listesi.SelectedItems[0].SubItems[3].Text;
            tanıtım.Show();
        }

        private void Aksesuar_Listesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtre2 filtrele = new filtre2();
            filtre2.hangiFiltre = "aksesuar";
            filtrele.Show();
        }

    }
}
