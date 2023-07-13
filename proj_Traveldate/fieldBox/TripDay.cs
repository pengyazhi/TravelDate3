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
    public partial class TripDay : UserControl
    {
        public TripDay()
        {
            InitializeComponent();
        }
        public TripDay(int TripDetail) 
        {
            InitializeComponent();
            var q = from t in this.dbContent.TripDetails
                    where t.TripDetailID== TripDetail
                    select t;
            
            foreach (var t in q) 
            {
                txtDetail.Text = t.TripDetail1;
                byte[] pic = t.ProductPhotoList.Photo;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(pic);
                this.picTripDetailPhoto.Image=Image.FromStream(ms);
                
            }
        }
        
            TraveldateEntities dbContent = new TraveldateEntities();    
        public string _TripDetail { get { return txtDetail.Text; }set { txtDetail.Text = value; } }
        public int _TripDay { get { return Convert.ToInt32( labTripday.Text); }set { labTripday.Text = value.ToString(); } }
        public bool _Selected { get { return chSelect.Checked;}set { chSelect.Checked = value; } }
        public int _PhotoListID { get { return Convert.ToInt32( picTripDetailPhoto.Tag); } set { picTripDetailPhoto.Tag = value; } }

        public Image _Photo { set { picTripDetailPhoto.Image = value; }}
    }
}
