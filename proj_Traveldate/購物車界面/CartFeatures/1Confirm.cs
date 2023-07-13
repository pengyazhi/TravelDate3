using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class FrmCartTabPage
    {
        void LoadComfirmPage()
        {
            productPrice = 0;
            totalCount = 0;
            //帶入購物車資料
            foreach (CartItem item in cis)
            {
                item.DisableChange();
                this.flowLayoutPanelConfirm.Controls.Add(item);
            }
            foreach (CartItem i in this.flowLayoutPanelConfirm.Controls)
            {
                if (i.checkBox)
                {
                    totalCount++;
                    productPrice += i.pPrice;
                }
            }
            this.lblCount2.Text = totalCount.ToString();
            this.lblTotalPrice2.Text = productPrice.ToString();
            if (totalCount < 1)
            {
                this.btnGoPay.Enabled = false;
            }

            try
            {
                //帶入會員資料
                var q = dbContext.Members.Where(m => m.MemberID == memberID).Select(m => m).First();
                this.txtMLName.Text = q.LastName;
                this.txtMFName.Text = q.FirstName;
                this.txtMPhone.Text = q.Phone;
                this.txtMIDN.Text = q.IDNumber;
                this.txtMBirth.Text = $"{q.BirthDate:d}";
                //this.dateTimePicker1.Value = DateTime.Now;

                //讀取常用旅客清單
                this.cbCompanion.Items.Clear();
                this.cbCompanion.Items.Add("自行填寫");
                var q2 = dbContext.Companions.Where(c => c.MemberID == memberID).Select(c => c);
                foreach (var c in q2)
                {
                    comp.Add(c);
                    this.cbCompanion.Items.Add(c.LastName + c.FirstName);
                }

                //讀取Coupon和點數
                this.cbUseCoupon.Items.Clear();
                this.cbUseCoupon.Items.Add("不使用優惠券");
                var q3 = from c in dbContext.Coupons
                         where c.MemberID == memberID
                         select c.CouponList;
                foreach (var c in q3)
                {
                    coup.Add(c);
                    this.cbUseCoupon.Items.Add(c.CouponName);
                }
                ownPoint = q.Discount.Value;
                this.lblOwnPoint.Text = ownPoint.ToString();

                RefreshPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //取消同訂購人功能
            this.checkSameMember.Enabled = false;
            this.checkSameMember.Visible = false;

        }

        private void checkSameMember_CheckedChanged(object sender, EventArgs e)
        {

            if (checkSameMember.Checked)
            {
                this.txtCLName.Text = this.txtMLName.Text;
                this.txtCFName.Text = this.txtMFName.Text;
                this.txtCPhone.Text = this.txtMPhone.Text;
                this.txtCIDN.Text = this.txtMIDN.Text;
                this.dateTimePicker1.Text = this.txtMBirth.Text;
                this.checkAddCompanion.Checked = false;

                this.txtCLName.ReadOnly = true;
                this.txtCFName.ReadOnly = true;
                this.txtCPhone.ReadOnly = true;
                this.txtCIDN.ReadOnly = true;
                this.dateTimePicker1.Enabled = false;
                this.checkAddCompanion.Enabled = false;
            }
            else
            {
                this.txtCLName.Text = "";
                this.txtCFName.Text = "";
                this.txtCPhone.Text = "";
                this.txtCIDN.Text = "";
                this.dateTimePicker1.Value = DateTime.Now;

                this.txtCLName.ReadOnly = false;
                this.txtCFName.ReadOnly = false;
                this.txtCPhone.ReadOnly = false;
                this.txtCIDN.ReadOnly = false;
                this.dateTimePicker1.Enabled = true;
                this.checkAddCompanion.Enabled = true;

            }

        }

        private void cbCompanion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //填入常用旅客資料
            if (cbCompanion.Text != null && cbCompanion.SelectedIndex > 0)
            {
                c = comp[cbCompanion.SelectedIndex - 1];
                this.txtCLName.Text = c.LastName;
                this.txtCFName.Text = c.FirstName;
                this.txtCPhone.Text = c.Phone;
                this.txtCIDN.Text = c.IDNumber;
                //this.txtCBirth.Text = $"{c.BirthDate:d}";
                this.dateTimePicker1.Value = c.BirthDate.Value;

                this.txtCLName.ReadOnly = true;
                this.txtCFName.ReadOnly = true;
                this.txtCPhone.ReadOnly = true;
                this.txtCIDN.ReadOnly = true;
                this.dateTimePicker1.Enabled = false;
                this.checkAddCompanion.Enabled = false;
            }
            else if (cbCompanion.SelectedIndex == 0)
            {
                this.txtCLName.Text = "";
                this.txtCFName.Text = "";
                this.txtCPhone.Text = "";
                this.txtCIDN.Text = "";
                this.dateTimePicker1.Value = DateTime.Now;

                this.txtCLName.ReadOnly = false;
                this.txtCFName.ReadOnly = false;
                this.txtCPhone.ReadOnly = false;
                this.txtCIDN.ReadOnly = false;
                this.dateTimePicker1.Enabled = true;
                this.checkAddCompanion.Enabled = true;
            }



        }


        void RefreshPrice()
        {
            discount = couponDiscount + usePoint;
            totalPrice = productPrice - discount;
            earnPoints = Math.Ceiling(totalPrice / 100);
            this.lblDiscount.Text = discount.ToString();
            this.lblTotalPrice2.Text = totalPrice.ToString();
            this.lblearnPoints2.Text = $"可獲得 {earnPoints} 點!!";
        }

        private void cbUseCoupon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選擇優惠券
            if (cbUseCoupon.Text != null && cbUseCoupon.SelectedIndex != 0)
            {
                CouponList cou = coup[cbUseCoupon.SelectedIndex - 1];
                couponDiscount = Math.Ceiling(productPrice * (1 - cou.Discount.Value));
            }
            else if (cbUseCoupon.SelectedIndex == 0)
            {
                couponDiscount = 0;
            }
            RefreshPrice();
        }

        private void txtUsePoint_TextChanged(object sender, EventArgs e)
        {
            //使用點數
            if (int.TryParse(this.txtUsePoint.Text, out usePoint) && usePoint <= ownPoint)
            {
                RefreshPrice();
            }
            else if (usePoint > ownPoint)
            {
                MessageBox.Show("超出目前持有點數");
                usePoint = ownPoint;
                this.txtUsePoint.Text = usePoint.ToString();
            }
            else
            {
                usePoint = 0;
                RefreshPrice();
            }
        }

        void AddCompanion()
        {
            if (this.checkAddCompanion.Checked&&(this.txtCLName.Text+txtCFName.Text)!="")
            {
                //勾選=>新增至常用旅客db
                Companion addc = new Companion 
                {
                    LastName = this.txtCLName.Text,
                    FirstName = this.txtCFName.Text,
                    IDNumber = this.txtCIDN.Text,
                    Phone = this.txtCPhone.Text,
                    MemberID = memberID,
                    BirthDate = this.dateTimePicker1.Value
                };
                try
                {
                    this.dbContext.Companions.Add(addc);
                    this.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                c = addc;
            }
            else if(!this.checkAddCompanion.Checked && (this.txtCLName.Text + txtCFName.Text) != "")
            {
                //未勾選=>儲存memberID
                Companion addc = new Companion
                {
                    LastName = this.txtCLName.Text,
                    FirstName = this.txtCFName.Text,
                    IDNumber = this.txtCIDN.Text,
                    Phone = this.txtCPhone.Text,
                    BirthDate = this.dateTimePicker1.Value
                };
                try
                {
                    this.dbContext.Companions.Add(addc);
                    this.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                c = addc;
            }
        }
    }
}
