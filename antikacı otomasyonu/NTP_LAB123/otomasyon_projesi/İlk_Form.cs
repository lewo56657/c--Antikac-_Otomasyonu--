using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace proje2
{
    public partial class İlk_Form : Form
    {
        public İlk_Form()
        {
            InitializeComponent();
          
        }
       Ana_Menu menü= new Ana_Menu();
       Form1 kullanıcı_girişi = new Form1();
        YÖNETİCİ_GİRİŞİ yönetici_giriş = new YÖNETİCİ_GİRİŞİ();
        
      
        private void button1_Click(object sender, EventArgs e)
        {
         kullanıcı_girişi.Show();
            
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            yönetici_giriş.Show();
          

        }
    }
}
