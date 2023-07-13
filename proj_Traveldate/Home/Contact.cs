using proj_Traveldate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class Contact : Form
    {

        public Contact()
        {
            InitializeComponent();
        }



        public void label3_Click(object sender, EventArgs e)
        {

            FrmHome homePage = new FrmHome();

            // 設定其他表單的父控制項為 Panel
 
            homePage.FormBorderStyle = FormBorderStyle.None;
            homePage.Dock = DockStyle.Fill;
            homePage.splitContainer2.Panel1.Controls.Clear();
           
            homePage.Show();

        }
    }
}
