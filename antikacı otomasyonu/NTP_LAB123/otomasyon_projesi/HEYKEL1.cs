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
    public partial class HEYKEL1 : Form
    {
        public HEYKEL1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Database DB = new Database();
            DB.exceuteData("insert into sepet1 values ('"+tanıtım_ismi.Text+"','"+ tanıtım_yapılış_tarihi.Text+ "',"+ Convert.ToInt32(Tanıtım_fiyatı.Text)+ ")", "");
            MessageBox.Show("Sepete Eklendi");
            
        }
        public static string foto;
        private void HEYKEL1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = foto;
        }
    }
}
