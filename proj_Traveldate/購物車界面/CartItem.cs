using proj_Traveldate.Models;
using projTravelDate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }

        TraveldateEntities dbContext = new TraveldateEntities();
        OrderDetail item;
        public int odid = 0;
        public int tripid = 0;
        public int pdid = 0;
        FrmCartTabPage form;
        bool favo;  //is favorite item=>true
        public string planName = "";
        public CartItem(OrderDetail od,FrmCartTabPage f)
        {
            InitializeComponent();

            item = od;
            form = f;
            planName = item.Trip.ProductList.PlanName;

            if ( planName.Length > 23)
            {
                this.lblPName.Text = planName.Substring(0, 23) + "...";
            }
            else
            {
                this.lblPName.Text = item.Trip.ProductList.PlanName;
            }
            this.lblPData.Text = $"{item.Trip.Date:d}";
            this.unitPrice = item.Trip.UnitPrice.Value;
            this.pQuantity = item.Quantity.Value;
            this.pPrice = unitPrice * pQuantity;
            this.odid = item.OrderDetailsID;
            this.tripid = item.TripID.Value;
            this.pdid = item.Trip.ProductID;


            //產生CartItem時=>抓Product photo
            var qp = from p in dbContext.ProductPhotoLists
                     where p.ProductID == item.Trip.ProductID
                     select p.Photo;
            try
            {
                if (qp.Any())
                {
                    MemoryStream ms = new MemoryStream(qp.First());
                    this.pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.lblPID.Text = (item.Trip.ProductID + " " + item.TripID);
            this.lblPID.Visible = false;

            
            favo = FavoriteCheck.CheckFavo(btnAddFavo, item.Trip.ProductID);

        }



        private void btnminus_Click(object sender, EventArgs e)
        {
            //將數量減一
            if (this.pQuantity>1)
            {
                this.pQuantity -= 1;
            }
            else
            {
                //如果已經是最後一個 詢問是否刪除
                if(MessageBox.Show("要刪除這項商品嗎？","確認視窗",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    DeleteThis();
                }
            }
            //重新計算單項總價及合計總價
            CalculatePriceAndUpdate();
            form.CalculateTotalPrice();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            //將數量加一
            this.pQuantity += 1;

            //重新計算單項總價及合計總價
            CalculatePriceAndUpdate();
            form.CalculateTotalPrice();
        }

        private void btnAddFavo_Click(object sender, EventArgs e)
        {
            favo = FavoriteCheck.CheckFavo(btnAddFavo, item.Trip.ProductID);
            //加入最愛
            FavoriteCheck.AddRemoveFavo(favo, item.Trip.ProductID);

            favo = FavoriteCheck.CheckFavo(btnAddFavo, item.Trip.ProductID);

        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            //刪除這個cartitem
            DeleteThis();
        }

        public void CalculatePriceAndUpdate()
        {
            try
            {
            //更改數量=>更改顯示價格
            pPrice = (unitPrice*pQuantity);

            //-+按鈕更改數量=>更新購物車db
            var qedit = this.dbContext.OrderDetails.Where(od => od.OrderDetailsID == item.OrderDetailsID).Select(od => od).FirstOrDefault();
            if (qedit == null) return;
            qedit.Quantity = pQuantity;
            this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //單價
        private decimal unitPrice;
        public int pQuantity
        {
            //數量
            get
            {
                if (int.TryParse(lblquantity.Text, out int quantity))
                {
                    return quantity;
                }
                else return 0;
            }
            set { this.lblquantity.Text = value.ToString(); }
         }
        public decimal pPrice
        {
            //總價
            get
            {
                    return unitPrice* pQuantity;
            }
            set { this.lblPrice.Text = value.ToString(); }
        }
        public bool checkBox
        {
            get { return this.checkBox1.Checked; }
            set { this.checkBox1.Checked = value;}
        }
        public void DeleteThis()
        {
            try
            {
            //在畫面中移除+購物車db刪除這筆資料
            var qdele = this.dbContext.OrderDetails.Where(od => od.OrderDetailsID == item.OrderDetailsID).Select(od => od).FirstOrDefault();
            if (qdele == null) return;
            this.dbContext.OrderDetails.Remove(qdele);
            this.dbContext.SaveChanges();
            Controls.Remove(this);
            this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //改變勾選狀態時重新計算總價
            if (form != null)
            {
                form.CalculateTotalPrice();
            }
        }

        public void DisableChange()
        {
            //使所有內容無法修改
            this.checkBox1.Enabled = false;
            this.checkBox1.Visible = false;
            this.btnAddFavo.Enabled = false;
            this.btnAddFavo.Visible = false;
            this.btnDele.Enabled = false;
            this.btnDele.Visible = false;
            this.btnplus.Enabled = false;
            this.btnminus.Enabled = false;
        }

        public void EnableChange()
        {
            //使所有內容無法修改
            this.checkBox1.Enabled = true;
            this.checkBox1.Visible = true;
            this.btnAddFavo.Enabled = true;
            this.btnAddFavo.Visible = true;
            this.btnDele.Enabled = true;
            this.btnDele.Visible = true;
            this.btnplus.Enabled = true;
            this.btnminus.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenProductPage();
        }

        private void lblPName_Click(object sender, EventArgs e)
        {
            OpenProductPage();
        }

        void OpenProductPage()
        {
            //點擊標題/圖片=>跳至商品頁面
            ProductManager.ProductID = pdid;
            FrmProgram f = new FrmProgram();
            f.Show();
        }

        



        //======================================

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //using (var path = GetRoundRectagle(bounds, this.Radius))
            //    this.Region = new Region(path);

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
