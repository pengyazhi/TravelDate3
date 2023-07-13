using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class FrmCartTabPage
    {
        List<GroupBox> gblist;
        void LoadPayment()
        {
            this.flowLayoutPanelPay.Controls.Clear();
            //LoadPayment
            var qpay = from p in dbContext.PaymentLists
                       select p;

            try
            {
                foreach (var item in qpay)
                {
                    RadioButton rb = new RadioButton();
                    rb.Width = this.flowLayoutPanelPay.Width;
                    rb.Height = this.flowLayoutPanelPay.Height / qpay.Count() - 20;
                    rb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    rb.Text = item.Payment;
                    this.flowLayoutPanelPay.Controls.Add(rb);
                    if (flowLayoutPanelPay.Controls.Count == 1)
                    {
                        rb.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            gblist = new List<GroupBox>() { gbCredit, gbBank, gbjko, gbLINE };

            this.btnPay.Enabled = false;
        }

        private void btnPayNext_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in flowLayoutPanelPay.Controls)
            {
                if (rb.Checked)
                {
                    payment = rb.Text;
                }
            }
            switch (payment)
            {
                case "信用卡":
                    foreach(GroupBox gb in gblist)
                    {
                        gb.Visible = false;
                    }
                    this.gbCredit.Visible = true;
                    break;
                case "銀行轉帳":
                    string acc = "";
                    Random rnd = new Random();
                    for (int i = 0; i < 16; i++)
                    {
                        acc += rnd.Next(0, 10).ToString();
                    }
                    this.lblBankAcc.Text = $"轉帳帳號：{acc}";
                    this.lblBankPrice.Text = $"轉帳金額：{totalPrice}";
                    this.lblDue.Text = $"有效期限：{DateTime.Now.AddDays(1):f}";
                    foreach (GroupBox gb in gblist)
                    {
                        gb.Visible = false;
                    }
                    this.gbBank.Visible = true;
                    break;
                case "LINE Pay":
                    foreach (GroupBox gb in gblist)
                    {
                        gb.Visible = false;
                    }
                    this.gbLINE.Visible = true;
                    break;
                case "街口支付":
                    foreach (GroupBox gb in gblist)
                    {
                        gb.Visible = false;
                    }
                    this.gbjko.Visible = true;
                    break;

            }

            this.btnPay.Enabled = true;
        }

        void Checkout()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                    TraveldateEntities dbContext2 = new TraveldateEntities();

                    List<int> odids = new List<int>();
                    foreach (CartItem item in cis)
                    {
                        //將購物車內品項的OrderDetailsID存成List
                        odids.Add(item.odid);
                    }

                    // 新增常用旅伴
                    AddCompanion();

                    // 在db找出odid有出現在 cis 裡的資料(找出購物車裡這次要購買的品項)
                    var qod = from od in dbContext2.OrderDetails
                              where odids.Contains(od.OrderDetailsID)
                              select od;

                    //取得使用CouponID
                    var qcp = from cp in dbContext2.Coupons
                              where cp.CouponList.CouponName == useCoupon
                              select cp;

                    //取得使用的PaymentID
                    var qp = from p in dbContext2.PaymentLists
                             where p.Payment == payment
                             select p.PaymentID;

                try
                {
                    //檢查商品數量是否足夠
                    foreach (CartItem ci in cis)
                    {
                        var sold = (from od in dbContext2.OrderDetails
                                    where od.TripID == ci.tripid
                                    select od.Quantity).Sum();
                        var max = (from t in dbContext2.Trips
                                   where t.TripID == ci.tripid
                                   select t.MaxNum).First();
                        if (max - sold < ci.pQuantity)
                        {
                            MessageBox.Show($"「{ci.planName}」數量不足，請重新選購");
                            return;
                        }
                    }

                // 建立新的order (MemberID, Datetime, PaymentID, IsCart) 記住oder id
                Order newOrder = new Order()
                    {
                        MemberID = memberID,
                        Datetime = DateTime.Now,
                        Discount = usePoint,
                        PaymentID = qp.First(),
                        IsCart = false
                    };
                    if (qcp.Any())
                    {
                        newOrder.CouponListID = qcp.First().CouponListID;
                    }
                    dbContext2.Orders.Add(newOrder);

                    // 將上述資料的order id改為新建立的order的id
                    // (OrderID(改), Quantity(維持), CouponID(新增), StatusID(新增), TripID(維持))
                    foreach (OrderDetail item in qod)
                    {
                        item.OrderID = newOrder.OrderID;
                        item.StatusID = 3;
                        //紀錄Companion
                        if (c != null)
                        {
                            CompanionList complist = new CompanionList()
                            {
                                OrderDetailsID = item.OrderDetailsID,
                                CompanionID = c.CompanionID
                            };
                            dbContext2.CompanionLists.Add(complist);
                        }

                    }

                    // 刪除使用優惠券 扣除點數 獲得點數
                    if (qcp.Any())
                    {
                    dbContext2.Coupons.Remove(qcp.First());
                    }
                    dbContext2.Members.Where(m => m.MemberID == memberID).
                        Select(m => m).First().Discount = Decimal.ToInt16(ownPoint - usePoint + earnPoints);

                    dbContext2.SaveChanges();
                    ts.Complete();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tabControl1.TabPages[3].Enabled = true;
                tabControl1.TabPages[2].Enabled = false;
                tabControl1.SelectedIndex = 3;
                this.tabOrderSuccess.Show();


            }
        }

    }
}
