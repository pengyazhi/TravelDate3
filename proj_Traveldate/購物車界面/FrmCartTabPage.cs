using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class FrmCartTabPage : Form
    {
        TraveldateEntities dbContext = new TraveldateEntities();
        int memberID = Models.Login.MemberID; //改ID

        List<CartItem> cis = new List<CartItem>();
        List<OrderDetail> ods = new List<OrderDetail>();
        List<Companion> comp = new List<Companion>();
        List<CouponList> coup = new List<CouponList>();
        Companion c;
        decimal productPrice = 0;
        int totalCount = 0;
        decimal totalPrice = 0;
        decimal discount = 0;
        decimal couponDiscount = 0;
        decimal earnPoints = 0;
        int ownPoint = 0;
        int usePoint = 0;
        string payment = "";
        string useCoupon = "";

        public FrmCartTabPage()
        {
            InitializeComponent();
            InitializeCart();
            //this.FormBorderStyle = FormBorderStyle.None;
            
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Enabled = false;
            }
            tabControl1.TabPages[0].Enabled = true;

            LoadCart();

            //var q = from od in dbContext.OrderDetails
            //        where od.Order.MemberID == memberID&&od.Order.IsCart ==false
            //        select new
            //        {
            //            OrderTime = od.Order.Datetime,
            //            Product = od.Trip.ProductList.ProductName,
            //            PlanName = od.Trip.ProductList.PlanName,
            //            TripID = od.TripID,
            //            odid = od.OrderDetailsID,
            //            TravelTime = od.Trip.Date,
            //            Q = od.Quantity,
            //        };

            //this.dataGridView1.DataSource = q.ToList();

        }

        //商品頁面點擊直接購買的通道
        public FrmCartTabPage(int tripID)
        {
            InitializeComponent();
            InitializeCart();
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Enabled = false;
            }
            tabControl1.TabPages[0].Enabled = true;

            LoadCart(tripID);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void btnGoBuy_Click(object sender, EventArgs e)
        {
            cis.Clear();
            this.flowLayoutPanelConfirm.Controls.Clear();
            foreach (CartItem ci in this.flowLayoutPanel1.Controls)
            {
                if (ci.checkBox)
                {
                    cis.Add(ci);
                }
            }
            tabControl1.TabPages[1].Enabled = true;
            tabControl1.TabPages[0].Enabled = false;
            tabControl1.SelectedIndex = 1;
            LoadComfirmPage();
            this.tabConfirmOrder.Show();
        }
        private void btnGoBackToCart_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Enabled = true;
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.SelectedIndex = 0;
            foreach (CartItem item in cis)
            {
                item.EnableChange();
                this.flowLayoutPanel1.Controls.Add(item);
            }
            this.tabCart.Show();
        }

        private void btnGoPay_Click(object sender, EventArgs e)
        {
            if (this.cbUseCoupon.Text != null && this.cbUseCoupon.SelectedIndex > 0)
            {
                useCoupon = this.cbUseCoupon.Text;
            }
            int.TryParse(this.txtUsePoint.Text, out usePoint);
            tabControl1.TabPages[2].Enabled = true;
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.SelectedIndex = 2;
            LoadPayment();
            this.tabPayment.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(payment == "信用卡")
            {
                if((txtc1.Text+txtc2.Text+txtc3.Text + txtc4.Text+ txtc5.Text + txtc6.Text + txtc7.Text).Length < 23)
                {
                    MessageBox.Show("請輸入正確信用卡資料");
                    return;
                }
            }

            Checkout();

        }

        void InitializeCart()
        {
            cis.Clear();
            ods.Clear();
            comp.Clear();
            coup.Clear();
            productPrice = 0;
            totalCount = 0;
            totalPrice = 0;
            discount = 0;
            couponDiscount = 0;
            ownPoint = 0;
            usePoint = 0;
        }
        


        /*
        //===================================
        public enum UserStatus
        {
            Guest = 0,
            Member = 1,
            Supplier = 2,
            Platform = 3
        }

        public UserStatus loginStatus = 0;  //預設為Guest
        public int loginID = 0;                         //登入後存ID

        private void button2_Click(object sender, EventArgs e)
        {
            //判斷 如果已經以會員身分登入
            if (loginStatus == UserStatus.Member)
            {
                //顯示購物車 之類的
            }
            else
            {
                MessageBox.Show("請先登入");
            }
        }
            //=================================
        */

        private void btnGoBack2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Enabled = true;
            tabControl1.TabPages[2].Enabled = false;
            tabControl1.SelectedIndex = 1;
            LoadComfirmPage();
            this.tabConfirmOrder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCartTabPage f = new FrmCartTabPage(11);
            f.Show();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);

            if(e.Index == tabControl1.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(page.ForeColor), e.Bounds);
                TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.BackColor);
            }
        }

        private void btnGoTop_Click(object sender, EventArgs e)
        {
            //TODO 顯示首頁
            this.Close();
        }
    }
 




}
