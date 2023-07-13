using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proj_Traveldate;

namespace proj_Traveldate
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
           // Models.Login.ManufacturerID = 1;
        }
        //public static int companyID= 1;
        

       public void FrmShow(Form f) 
        {
            this.splitContainer2.Panel2.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProducts f = new FrmProducts(Models.Login.ManufacturerID);
            FrmShow(f);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
             FrmAnalysis f = new FrmAnalysis();
            FrmShow(f);
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            FrmCoupon f = new FrmCoupon(Models.Login.ManufacturerID);
            FrmShow(f);
        }

        private void btnCompanyProfile_Click(object sender, EventArgs e)
        {
            FrmCompanyProfile f = new FrmCompanyProfile();
            FrmShow(f);
        }
    }
}
