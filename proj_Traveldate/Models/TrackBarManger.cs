using proj_Traveldate.searchUIRev;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate.Models
{
    public class TrackBarManger
    {
        public TrackBarManger()
        {
            //取得全部商品的價格
            IQueryable<decimal?> selectPrice = CommonClass.dbContext.Trips.Where(n => CommonClass.confirmedID.Contains(n.ProductID)).Select(n => n.UnitPrice);
            LoadUnitPriceToTrackBar(selectPrice);
        }

        public TrackBar tbSmall = new TrackBar();
        public TrackBar tbLarge = new TrackBar();
        public Label lblSmall = new Label();
        public Label lblLarge = new Label();
        public decimal? UnitPriceMax { get; set; }
        public decimal? UnitPriceMin { get; set; }

        public void LoadUnitPriceToTrackBar(IQueryable<decimal?> selectPrice)
        {
            //取得全部商品的價格
            //var selectPrice = CommonClass.dbContext.Trips.Where(n => CommonClass.confirmedID.Contains(n.ProductID)).Select(n => n.UnitPrice);
            //var selectPrice = ProductBoxManger.nowProductBoxes.AsEnumerable().Select(p => p._productPrice);
            //取單價最高/最低
            UnitPriceMax = selectPrice.Max();
            UnitPriceMin = selectPrice.Min();
            //設置TrackBar屬性
            tbSmall.Dock = tbLarge.Dock = DockStyle.Top;
            tbSmall.TickStyle = tbLarge.TickStyle = TickStyle.None;
            tbSmall.Maximum = tbLarge.Maximum = (int)UnitPriceMax;
            tbSmall.Minimum = tbLarge.Minimum = (int)UnitPriceMin;
            tbSmall.Value = (int)UnitPriceMin;
            tbLarge.Value = (int)UnitPriceMax;
            //設置設置TrackBar事件
            tbSmall.Scroll += tbSmall_Scroll;
            tbLarge.Scroll += tbLarge_Scroll;
            //設置顯示金額的label
            lblLarge.Size=lblSmall.Size = new System.Drawing.Size(40, 16);
            lblLarge.Location = new System.Drawing.Point(231, 9);
            lblSmall.Location = new System.Drawing.Point(49, 9);
            lblSmall.Text = UnitPriceMin.ToString();
            lblLarge.Text = UnitPriceMax.ToString();
        }
       
        internal void tbSmall_Scroll(object sender, EventArgs e)
        {
   
            if (tbSmall.Value > tbLarge.Value)
            {
                tbSmall.Value = tbLarge.Value;
                lblSmall.Text = tbSmall.Value.ToString();
            }
            else
            {
                lblSmall.Text = tbSmall.Value.ToString();
            }
          
        }

        private void tbLarge_Scroll(object sender, EventArgs e)
        {
      
            if (tbSmall.Value > tbLarge.Value)
            {
                tbLarge.Value = tbSmall.Value;
                lblLarge.Text = tbLarge.Value.ToString();
            }
            else
            {
                lblLarge.Text = tbLarge.Value.ToString();
            }
           
        }
    }
}
