using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class FrmCartTabPage
    {
        public void LoadCart()
        {
            //MemberID==xxx && isCart == true
            //放到cartitem
            var q = from od in dbContext.OrderDetails.AsEnumerable()
                    where (od.Order.MemberID == memberID) && (od.Order.IsCart == true)
                    select od;

            try
            {
                foreach (var item in q)
                {
                    ods.Add(item);

                    this.flowLayoutPanel1.Controls.Add(new CartItem(item, this));
                }

                CalculateTotalPrice();
                if (this.flowLayoutPanel1.Controls.Count < 1)
                {
                    this.btnGoBuy.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void LoadCart(int tripID)
        {
            try
            {
            //MemberID==xxx && isCart == true
            //放到cartitem
            var q = from od in dbContext.OrderDetails.AsEnumerable()
                    where (od.Order.MemberID == memberID) && (od.Order.IsCart == true)
                    select od;

            foreach (var item in q)
            {
                ods.Add(item);

                this.flowLayoutPanel1.Controls.Add(new CartItem(item, this));
            }

            foreach(CartItem c in flowLayoutPanel1.Controls)
            {
                if(c.tripid != tripID)
                {
                    c.checkBox = false;
                }
            }

            CalculateTotalPrice();
            if (this.flowLayoutPanel1.Controls.Count < 1)
            {
                this.btnGoBuy.Enabled = false;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //全選OR全不選

            if (checkBoxAll.Checked)
            {
                foreach (CartItem i in this.flowLayoutPanel1.Controls)
                {
                    i.checkBox = true;
                }
            }
            else
            {
                foreach (CartItem i in this.flowLayoutPanel1.Controls)
                {
                    i.checkBox = false;
                }
            }
        }

        private void btnDeleChecked_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除已選商品嗎？", "確認視窗", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //刪除已選項目
                //因為遍歷刪除問題 先將購物車內的東西存到list
                List<CartItem> list = new List<CartItem>();
                foreach (CartItem i in this.flowLayoutPanel1.Controls)
                {
                    list.Add(i);
                }
                //判斷是否勾選 勾選者刪除
                for (int j = list.Count - 1; j >= 0; j--)
                {
                    if (list[j].checkBox)
                    {
                        try
                        {
                            //勾選刪除=>更新購物車db
                            var qdele = this.dbContext.OrderDetails.AsEnumerable().Where(od => od.OrderDetailsID == list[j].odid).Select(od => od).FirstOrDefault();
                            if (qdele == null) return;
                            this.dbContext.OrderDetails.Remove(qdele);
                            this.dbContext.SaveChanges();
                            //自list中移除
                            list.RemoveAt(j);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                //清空容器並將處理完的items加回容器
                this.flowLayoutPanel1.Controls.Clear();
                foreach (CartItem i in list)
                {
                    this.flowLayoutPanel1.Controls.Add(i);
                }
            }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            //容器內項目增加時重新計算總價
            CalculateTotalPrice();
        }
        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            //容器內項目減少時重新計算總價
            CalculateTotalPrice();
        }

        public void CalculateTotalPrice()
        {
            //計算個數及總價
            decimal totalPrice_cart = 0;
            int totalCount_cart = 0;
            if (this.flowLayoutPanel1.Controls.Count > 0)
            {
                foreach (CartItem i in this.flowLayoutPanel1.Controls)
                {
                    if (i.checkBox)
                    {
                        totalCount_cart++;
                        totalPrice_cart += i.pPrice;
                    }
                }
            }
            earnPoints = Math.Ceiling(totalPrice_cart / 100);
            this.lblCount.Text = totalCount_cart.ToString();
            this.lblTotalPrice.Text = totalPrice_cart.ToString();
            this.lblearnPoints.Text = $"可獲得 {earnPoints} 點!!";
            if (totalCount_cart == 0)
            {
                this.btnGoBuy.Enabled = false;
            }
            else
            {
                this.btnGoBuy.Enabled = true;
            }
        }
    }
}
