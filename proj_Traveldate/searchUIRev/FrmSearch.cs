using proj_Traveldate.fieldBox;
using proj_Traveldate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projTravelDate.Models;

namespace proj_Traveldate.searchUIRev
{
    public partial class FrmSearch : Form
    {
        ProductTagManger productTagManger = new ProductTagManger();
        DateTimeManger timeManger = new DateTimeManger();        
        Label labCountProd = new Label();
        TrackBarManger trackBarManger = new TrackBarManger();

        public FrmSearch()
        {
            InitializeComponent();
            
            this.panel1.VerticalScroll.Enabled = true;

            foreach(TreeView tv in productTagManger.AllTreeView)
            {
                tv.AfterCheck += tv_AfterCheck;
            }
          // TrackBarManger.LoadUnitPriceToTrackBar();
            LoadControls();
           
            
            if (ProductBoxManger.nowProductBoxes.Count > 0)
            {
                SelectProdFromHomeSearch();
            }
            if (ProductManager.ProductCitys.Count > 0)
            {
                SelectProdFromHomeCity();
            }
            if (ProductManager.ProductTags.Count > 0)
            {
                SelectProdFromHomeTag();
            }
            //LoadUnitPriceToTrackBar();
           
        }

        private void SelectProdFromHomeTag()
        {
            ClearAndSet();
            foreach (string tag in ProductManager.ProductTags)
            {
                var selectedProd = ProductBoxManger.allProductBoxes.Where(n => n._productTags.Contains(tag)).ToList();
                foreach (var p in selectedProd)
                {
                    CommonClass.prodPanel.Controls.Add(p);
                    ProductBoxManger.nowProductBoxes.Add(p);
                }
            }
            AddContols();
        }
        private void SelectProdFromHomeCity()
        {
            ClearAndSet();
            foreach (string tag in ProductManager.ProductCitys)
            {
                var selectedProd = ProductBoxManger.allProductBoxes.Where(n => n._productCitys.Contains(tag)).ToList();
                foreach (var p in selectedProd)
                {
                    CommonClass.prodPanel.Controls.Add(p);
                    ProductBoxManger.nowProductBoxes.Add(p);
                }
            }
            AddContols();
        }
        private void SelectProdFromHomeSearch()
        {
            ClearAndSet();
            foreach (ProductBox p in ProductBoxManger.nowProductBoxes)
            {
                CommonClass.prodPanel.Controls.Add(p);
            }
            AddContols();
        }
        private void LoadControls()
        {
            panel4.Controls.Add(productTagManger.tvCategory);
            panel8.Controls.Add(productTagManger.tvProductServer);
            panel10.Controls.Add(productTagManger.tvRegion);
            panel5.Controls.Add(timeManger.startTime);
            panel5.Controls.Add(timeManger.endTime);
            panel13.Controls.Add(CommonClass.prodPanel);
            panel11.Controls.Add(ProductBoxManger.initLabel);
            panel9.Controls.Add(trackBarManger.lblSmall);
            panel9.Controls.Add(trackBarManger.lblLarge);
            
            panel6.Controls.Add(trackBarManger.tbLarge);
            panel6.Controls.Add(trackBarManger.tbSmall);
        }

        public void tv_AfterCheck(object sender, TreeViewEventArgs e)
        {
            panel13.Controls.Clear();
            panel13.Controls.Add(CommonClass.prodPanel);
           
            panel11.Controls.Clear();
            panel11.Controls.Add(productTagManger.label);

        }

        private void FrmsearchUIRev_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            var q = ProductBoxManger.nowProductBoxes.OrderBy(n => n._prodDateTag);
            Display(q);
        }

        private void btnSortByComment_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<ProductBox> q = ProductBoxManger.nowProductBoxes.OrderByDescending(n => n._productScore);
            Display(q);
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            IOrderedEnumerable<ProductBox> q = ProductBoxManger.nowProductBoxes.OrderBy(n =>n._productPrice);
            Display(q);
        }
        void Display(IOrderedEnumerable<ProductBox> q)
        {
            panel13.Controls.Clear();
            CommonClass.SetProdInfo(CommonClass.prodPanel);
            CommonClass.prodPanel.Controls.Clear();
            foreach (ProductBox p in q)
            {
                CommonClass.prodPanel.Controls.Add(p);
            }
            panel13.Controls.Add(CommonClass.prodPanel);
        }
      

        //public  string UnitPriceMax { get { return label6.Text; } set {label6.Text = value; } }
        //public  string UnitPriceMin { get { return label4.Text; } set { label4.Text = value; } }

        //private void LoadUnitPriceToTrackBar()
        //{
        //    //從畫面上有的商品抓價格區間
        //    var selectPrice = ProductBoxManger.nowProductBoxes.AsEnumerable().Select(p => p._productPrice);
        //    //var selectPrice = CommonClass.dbContext.Trips.Where(n => CommonClass.confirmedID.Contains(n.ProductID)).Select(n => n.UnitPrice);
        //    //取單價最高/最低
        //    UnitPriceMax = selectPrice.Max().ToString();
        //    UnitPriceMin = selectPrice.Min().ToString();

        //    //設置TrackBar屬性
        //    trackBar1.Maximum = trackBar2.Maximum = Convert.ToInt32(UnitPriceMax);
        //    trackBar1.Minimum = trackBar2.Minimum = Convert.ToInt32(UnitPriceMin);
        //    trackBar1.Value = Convert.ToInt32(UnitPriceMin);
        //    trackBar2.Value = Convert.ToInt32(UnitPriceMax);
        //    label4.Text = UnitPriceMin.ToString();
        //    label6.Text = UnitPriceMax.ToString();
        //}

        //internal void tbSmall_Scroll(object sender, EventArgs e)
        //{
        //    if (trackBar1.Value > trackBar2.Value)
        //    {
        //        trackBar1.Value = trackBar2.Value;
        //        label4.Text = trackBar1.Value.ToString();
        //    }
        //    else
        //    {
        //        label4.Text = trackBar1.Value.ToString();
        //    }

        //    CommonClass.SetCountProdLabel(ProductBoxManger.initLabel, CommonClass.prodPanel.Controls.Count);
        //}

        //private void tbLarge_Scroll(object sender, EventArgs e)
        //{
        //    if (trackBar1.Value > trackBar2.Value)
        //    {
        //        trackBar2.Value = trackBar1.Value;
        //        label6.Text = trackBar2.Value.ToString();
        //    }
        //    else
        //    {
        //        label6.Text = trackBar2.Value.ToString();
        //    }
        //}
        void ClearAndSet()
        {
            panel11.Controls.Clear();
            panel13.Controls.Clear();
            CommonClass.prodPanel.Controls.Clear();
            CommonClass.SetProdInfo(CommonClass.prodPanel);
        }
        void AddContols()
        {
            panel13.Controls.Add(CommonClass.prodPanel);
            CommonClass.SetCountProdLabel(labCountProd, CommonClass.prodPanel.Controls.Count);
            panel11.Controls.Add(labCountProd);
        }
    }
}
