using proj_Traveldate.Models;
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
    public partial class FrmTripDetailCreate : Form
    {
        public int _productID { get; set; }
        public int _tripID { get; set; }
        public FrmTripDetailCreate()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }
        public FrmTripDetailCreate(int tripID) 
        {
            InitializeComponent();
            btnNewTripDetail.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            var q=from t  in CommonClass.dbContext.Trips
                  where t.TripID == tripID
                  select t;
            foreach (var t in q) 
            {
                dateTripDate.Value = t.Date.Value;
                txtUnitPrice.Text=t.UnitPrice.ToString();
                nuMinNum.Value=t.MinNum.Value;
                nuMaxNum.Value=t.MaxNum.Value;
                nuDays.Value=t.TripDetails.Count;
                int i = 1;
                foreach (var detail in t.TripDetails)
                {
                    TripDay f = new TripDay(detail.TripDetailID);
                    f.Tag = detail.TripDetailID;
                    f._TripDay = i;
                    f._PhotoListID = (int)detail.ProductPhotoListID;
                    i++;
                    this.flTripDetail.Controls.Add(f);
                }
            }
        }
        
        private void btnNewTripDetail_Click(object sender, EventArgs e)
        {
            this.flTripDetail.Controls.Clear();
            for (int i = 0; i < nuDays.Value; i++) 
            {
            TripDay t = new TripDay();
                t._TripDay = i + 1;
                t._Selected = false;
                this.flTripDetail.Controls.Add(t);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (TripDay t in flTripDetail.Controls) 
            {
            if (t._Selected) 
                {
               flTripDetail.Controls.Remove(t);
                    for (int i = 0; i < flTripDetail.Controls.Count; i++) 
                    {
                        TripDay tripDay = (TripDay)flTripDetail.Controls[i];
                        tripDay._TripDay = i + 1;
                        tripDay.Refresh();
                    }
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
            
            //存入Trip
            Trip trip = new Trip();
            trip.ProductID = _productID;
            trip.Date = dateTripDate.Value;
            trip.UnitPrice = Convert.ToInt32( txtUnitPrice.Text);
            trip.MinNum = (int)nuMinNum.Value;
            trip.MaxNum = (int)nuMaxNum.Value;
            //trip.TripStatusID = 2;
                CommonClass.dbContext.Trips.Add(trip);
            CommonClass.dbContext.SaveChanges();
                //存入TripDetail
                var q = CommonClass.dbContext.Trips.AsEnumerable().Select(x => x.TripID).LastOrDefault();
                foreach (TripDay t in flTripDetail.Controls) 
            {
            TripDetail tripDetail = new TripDetail();
          
            tripDetail.TripID = q;
                tripDetail.TripDetail1 = t._TripDetail;
                tripDetail.TripDay = t._TripDay;
                tripDetail.ProductPhotoListID = t._PhotoListID;
                    CommonClass.dbContext.TripDetails.Add(tripDetail);
            }
               CommonClass.dbContext.SaveChanges();
                MessageBox.Show("儲存成功");
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            
         }
        void LoadProductPhoto() 
        {
            var q2 = from pic in CommonClass.dbContext.ProductPhotoLists
                     where pic.ProductID == _productID
                     select new { Photo = pic.Photo, PhotoListID = pic.ProductPhotoListID };
            foreach (var pic in q2)
            {
                if (pic != null)
                {
                    byte[] bytes = pic.Photo;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromStream(ms);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Height = 100;
                    pictureBox.Width = 150;
                    pictureBox.Tag = pic.PhotoListID;
                    pictureBox.Click += PictureBox_Click;
                    flPicture.Controls.Add(pictureBox);
                }
               
            }
        }
        private void FrmTripDetailCreate_Load(object sender, EventArgs e)
        {
            LoadProductPhoto();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                object photoListID = pictureBox.Tag;

                foreach (TripDay t in flTripDetail.Controls)
                {
                    if (t._Selected)
                    {
                        t._PhotoListID =Convert.ToInt32( photoListID);
                        t._Photo = pictureBox.Image;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                //更新Trip
                var trip = CommonClass.dbContext.Trips.Where(t=>t.TripID==_tripID).FirstOrDefault();
                                
                trip.Date = dateTripDate.Value;
                trip.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                trip.MinNum = (int)nuMinNum.Value;
                trip.MaxNum = (int)nuMaxNum.Value;
                //trip.TripStatusID = 2;
               // CommonClass.dbContext.SaveChanges();
                //更新TripDetail
                var td = CommonClass.dbContext.TripDetails.Where(t => t.TripID == _tripID);
                
                
                foreach (TripDay t in flTripDetail.Controls)
                {
                    foreach (var tripDetail in td.Where(n => n.TripDetailID == (int)t.Tag)) 
                    {
                    tripDetail.TripDetail1 = t._TripDetail;
                    tripDetail.TripDay = t._TripDay;
                    tripDetail.ProductPhotoListID = t._PhotoListID;
                     }       
                }
                CommonClass.dbContext.SaveChanges();
                MessageBox.Show("儲存成功");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
