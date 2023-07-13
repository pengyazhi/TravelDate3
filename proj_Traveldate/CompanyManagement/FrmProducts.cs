using projTravelDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proj_Traveldate;
using proj_Traveldate.Models;

namespace proj_Traveldate
{
    public partial class FrmProducts : Form
    {
        public FrmProducts(int c)
        {
            InitializeComponent();
            var q = CommonClass.dbContext.ProductLists.Where(p => p.CompanyID == Models.Login.ManufacturerID).Select(p => new { 產品名稱 = p.ProductName, 產品ID = p.ProductID, 類別=p.ProductTypeList.ProductType, 審核通過 = p.ExamineStatus,下架與否=p.Discontinued });
            this.dataGridView1.DataSource = q.ToList();
           var z = q.Select(p=>p.類別).Distinct();
            foreach (var p in z) 
            {
                cbbCategory.Items.Add(p);
            }

        }
      
        int ID=0;
        int TripID = 0;
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            var q = CommonClass.dbContext.ProductLists.Where(p=>p.CompanyID==Models.Login.ManufacturerID).Select(p => new {產品名稱= p.ProductName,產品ID=p.ProductID, 類別 = p.ProductTypeList.ProductType, 審核通過= p.ExamineStatus, 下架與否 = p.Discontinued });
            if(txtProductSearch.Text != "")
            this.dataGridView1.DataSource = q.Where(p=>p.產品名稱.Contains(txtProductSearch.Text)).ToList();
            else
                this.dataGridView1.DataSource=q.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string buttonName = dataGridView1.Columns[e.ColumnIndex].Name;
                switch (buttonName)
                {
                    case "btnUpdate":
                        int productID=0;
                        var q = from p in CommonClass.dbContext.ProductLists.AsEnumerable()
                                where p.ProductID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["產品ID"].Value)
                                select p;
                        foreach (var p in q) 
                        {
                            productID = p.ProductID;
                        }
                                                                          
                        FrmProductDetail f = new FrmProductDetail(productID);
                        f.Show();
                        break;
                    case "btnDelete":
                        try
                        {
                            var q2 = (from p in CommonClass.dbContext.ProductLists.AsEnumerable()
                                      where p.ProductID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["產品ID"].Value)
                                      select p).FirstOrDefault();
                            q2.Discontinued = !q2.Discontinued;
                            CommonClass.dbContext.SaveChanges();
                            this.dataGridView1.DataSource = null;
                            var q4 = CommonClass.dbContext.ProductLists.Where(p => p.CompanyID == Models.Login.ManufacturerID).Select(p => new { 產品名稱 = p.ProductName, 產品ID = p.ProductID, 類別 = p.ProductTypeList.ProductType, 審核通過 = p.ExamineStatus, 下架與否 = p.Discontinued });
                            this.dataGridView1.DataSource = q4.ToList();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message);
                        }


                        break;
                    case "btnDetail":
                        var q1 = from t in CommonClass.dbContext.Trips.AsEnumerable()
                                where t.ProductID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["產品ID"].Value)
                                select new { TripID=t.TripID,出團日期 = t.Date, 單價 = t.UnitPrice, 現在人數=t.OrderDetails.Count,最低人數 = t.MinNum, 最多人數 = t.MaxNum };
                        this.dataGridView2.DataSource = q1.ToList();
                        ID = Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["產品ID"].Value);
                        break;

                    
                }
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = CommonClass.dbContext.ProductLists.Where(p => p.CompanyID == Models.Login.ManufacturerID &&p.ProductTypeList.ProductType==cbbCategory.Text).Select(p => new { 產品名稱 = p.ProductName, 產品ID = p.ProductID, 類別 = p.ProductTypeList.ProductType, 審核通過 = p.ExamineStatus ,下架與否 = p.Discontinued });
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnNewProducts_Click(object sender, EventArgs e)
        {
            FrmProductDetail f = new FrmProductDetail();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID!=0) 
            {
            FrmTripDetailCreate f = new FrmTripDetailCreate();
            f._productID = ID;
            f.Show();
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string buttonName = dataGridView2.Columns[e.ColumnIndex].Name;
                switch (buttonName)
                {
                    case "btnUpdateTrip":
                        
                        var q = from p in CommonClass.dbContext.Trips.AsEnumerable()
                                where p.TripID == Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["TripID"].Value)
                                select p;
                        foreach (var p in q)
                        {
                            TripID = p.TripID;
                            ID = p.ProductID;
                        }
                        FrmTripDetailCreate f = new FrmTripDetailCreate(TripID);
                        f._productID =ID;
                        f._tripID = TripID;
                        f.Show();
                        break;
                    //case "btnDeleteTrip":
                    //    try
                    //    {
                    //        var q2 = from p in this.dbContent.Trips.AsEnumerable()
                    //                 where p.TripID == Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["TripID"].Value)
                    //                 select p;
                    //       if(q2.FirstOrDefault().TripStatusID == 1)
                    //        q2.FirstOrDefault().TripStatusID = 3;
                    //       else if (q2.FirstOrDefault().TripStatusID == 3)
                    //            q2.FirstOrDefault().TripStatusID = 1;
                    //        this.dbContent.SaveChanges();
                    //        this.dataGridView2.DataSource = null;
                    //        var q1 = from t in this.dbContent.Trips.AsEnumerable()
                    //                 where t.ProductID == ID
                    //                 select new { TripID = t.TripID, 出團日期 = t.Date, 單價 = t.UnitPrice, 現在人數 = t.OrderDetails.Count, 最低人數 = t.MinNum, 最多人數 = t.MaxNum, 狀態 = t.TripStatu.TripStatus };
                    //        this.dataGridView2.DataSource = q1.ToList();
                    //    }
                    //    catch (Exception a)
                    //    {
                    //        MessageBox.Show(a.Message);
                    //    }
                    //    break;



                }
            }
        }
    }
    
}
