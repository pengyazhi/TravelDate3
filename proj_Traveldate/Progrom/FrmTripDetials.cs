using proj_Traveldate.Models;
using projTravelDate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class FrmTripDetials : Form
    {
        public FrmTripDetials()
        {
            InitializeComponent();
            LoadDayDetails();
            LoadPhoto();
        }

        private void LoadPhoto()
        {
            var d1pic = (from p in CommonClass.dbContext.ProductPhotoLists
                        from t in CommonClass.dbContext.Trips
                        from td in CommonClass.dbContext.TripDetails
                        where t.ProductID == ProductManager.ProductID && t.TripID == td.TripID && td.TripDay == 1 && td.ProductPhotoListID==p.ProductPhotoListID
                        select p.Photo).ToList();

            if (d1pic!=null)
            {
                byte[] photoBytes = d1pic.FirstOrDefault();
                if (photoBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pictureBoxD1.Image = Image.FromStream(ms);
                    }
                }
            }

            var d2pic = (from p in CommonClass.dbContext.ProductPhotoLists
                         from t in CommonClass.dbContext.Trips
                         from td in CommonClass.dbContext.TripDetails
                         where t.ProductID == ProductManager.ProductID && t.TripID == td.TripID && td.TripDay == 2 && td.ProductPhotoListID == p.ProductPhotoListID
                         select p.Photo).ToList();

            if (d2pic != null)
            {
                byte[] photoBytes = d2pic.FirstOrDefault();
                if (photoBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pictureBoxD2.Image = Image.FromStream(ms);
                    }
                }
            }

            var d3pic = (from p in CommonClass.dbContext.ProductPhotoLists
                         from t in CommonClass.dbContext.Trips
                         from td in CommonClass.dbContext.TripDetails
                         where t.ProductID == ProductManager.ProductID && t.TripID == td.TripID && td.TripDay == 3 && td.ProductPhotoListID == p.ProductPhotoListID
                         select p.Photo).ToList();

            if (d3pic != null)
            {
                byte[] photoBytes = d3pic.FirstOrDefault();
                if(photoBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pictureBoxD3.Image = Image.FromStream(ms);
                    }
                }
            }
        }
      

        private void LoadDayDetails()
        {
            //要記得寫if裡面有值才回傳的條件
          
            var d1tripdetails = (from t in CommonClass.dbContext.Trips
                                from td in CommonClass.dbContext.TripDetails
                                where t.ProductID == ProductManager.ProductID && t.TripID==td.TripID && td.TripDay == 1 
                                 select td.TripDetail1).FirstOrDefault();               

            if(d1tripdetails != null)
            {
                richTextBox1.Text = d1tripdetails.ToString();
            }

            var d2tripdetails = (from t in CommonClass.dbContext.Trips
                                 from td in CommonClass.dbContext.TripDetails
                                 where t.ProductID == ProductManager.ProductID && t.TripID == td.TripID && td.TripDay == 2
                                 select td.TripDetail1).FirstOrDefault();

            if(d2tripdetails != null)
            {
                richTextBox2.Text = d2tripdetails.ToString();
            }

            var d3tripdetails = (from t in CommonClass.dbContext.Trips
                                 from td in CommonClass.dbContext.TripDetails
                                 where t.ProductID == ProductManager.ProductID && t.TripID == td.TripID && td.TripDay == 3
                                 select td.TripDetail1).FirstOrDefault();

            if(d3tripdetails != null)
            {
                richTextBox3.Text = d3tripdetails.ToString();
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var tripDayCount = (from td in CommonClass.dbContext.TripDetails
                                join t in CommonClass.dbContext.Trips on td.TripID equals t.TripID
                                where t.ProductID == ProductManager.ProductID
                                select td.TripDay).Distinct().Count();

            if (tripDayCount == 1)
            {
                tabPage1.Enabled = true;
                tabPage2.Enabled = false;
                tabPage3.Enabled = false;
                if (e.TabPage == tabPage2||e.TabPage==tabPage3)
                {
                    e.Cancel = true;
                }
            }
            else if (tripDayCount == 2)
            {
                tabPage1.Enabled = true;
                tabPage2.Enabled = true;
                tabPage3.Enabled = false;

                if (e.TabPage == tabPage3)
                {
                    e.Cancel = true;
                }
            }
            else if (tripDayCount == 3)
            {
                tabPage1.Enabled = true;
                tabPage2.Enabled = true;
                tabPage3.Enabled = true;
            }
            else
            {
                e.Cancel = true; // Hide all tabs if tripDayCount is not 1, 2, or 3
            }
        }
    }
}
