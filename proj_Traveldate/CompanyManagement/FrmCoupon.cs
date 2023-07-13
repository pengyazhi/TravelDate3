using proj_Traveldate.CompanyManagement;
using proj_Traveldate.Models;
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
    public partial class FrmCoupon : Form
    {
        public FrmCoupon(int companyID)
        {
            InitializeComponent();
            var q = from c in CommonClass.dbContext.CouponLists
                    where c.CompanyID == Models.Login.ManufacturerID
                    select new { 優惠券ID = c.CouponListID, 優惠券名稱 = c.CouponName, 折扣 = c.Discount, 詳情 = c.Description, 使用期限 = c.DueDate };
            dataGridView1.DataSource = q.ToList();

        }
        
        
        private void btnNewCoupon_Click(object sender, EventArgs e)
        {
            FrmCouponDetail f = new FrmCouponDetail();
            f.Show();
        }

        private void btnCouponSearch_Click(object sender, EventArgs e)
        {
            var q = from c in CommonClass.dbContext.CouponLists
                    where c.CompanyID == Models.Login.ManufacturerID
                    select new { 優惠券ID = c.CouponListID, 優惠券名稱 = c.CouponName, 折扣 = c.Discount, 詳情 = c.Description, 使用期限 = c.DueDate };
            this.dataGridView1.DataSource = q.Where(c => c.優惠券名稱.Contains(txtCouponSearch.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string buttonName = dataGridView1.Columns[e.ColumnIndex].Name;
                switch (buttonName)
                {
                    case "btnUpdate":
                        
                        int couponlistID=0 ;
                        int check = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["優惠券ID"].Value);
                        var q = from p in CommonClass.dbContext.Coupons.AsEnumerable()
                        
                                where p.CouponListID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["優惠券ID"].Value)
                                select p;
                        foreach (var p in q)
                        {
                            couponlistID = p.CouponListID;
                        }

                        FrmCouponDetail f = new FrmCouponDetail(couponlistID);
                        f.Show();



                        break;
                    case "btnHeldMember":
                        var q2 = from c in CommonClass.dbContext.Coupons.AsEnumerable()
                                 where c.CouponListID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["優惠券ID"].Value)
                                 group c by c.MemberID into g
                                 select new { 會員ID = g.Key, 持有數量 = g.Count() };
                        this.dataGridView2.DataSource = q2.ToList();
                        this.dataGridView1.Tag = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["優惠券ID"].Value);

                        break;
                    case "btnNoMember":
                        var q3 = from c in CommonClass.dbContext.Coupons.AsEnumerable()
                                 group c by c.MemberID into g
                                 select new { 會員ID = g.Key,優惠券ID=g.Select(c=>c.CouponListID)};
                        this.dataGridView2.DataSource = q3.SkipWhile(c=>c.優惠券ID.Contains(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["優惠券ID"].Value))).ToList();
                        this.dataGridView1.Tag = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["優惠券ID"].Value);
                        break;


                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string buttonName = dataGridView2.Columns[e.ColumnIndex].Name;
                switch (buttonName)
                {
                    case "btnDistribute":
                        try
                        {
                            Coupon coupon = new Coupon();
                            coupon.MemberID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["會員ID"].Value);
                            coupon.CouponListID = (int)this.dataGridView1.Tag;
                            CommonClass.dbContext.Coupons.Add(coupon);
                            CommonClass.dbContext.SaveChanges();
                            dataGridView2.Refresh();
                        }
                        catch (Exception a) 
                        {
                            MessageBox.Show(a.Message);
                        }
                                          
                        break;
                }
            }
        }
    }
}
