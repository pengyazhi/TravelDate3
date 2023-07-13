using proj_Traveldate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate.CompanyManagement
{
    public partial class FrmCouponDetail : Form
    {
        public FrmCouponDetail()
        {
            InitializeComponent();
            var q = CommonClass.dbContext.ProductLists.Select(c => c.ProductName);
            List<string> productname = q.ToList();
            foreach (string i in productname)
                this.cbbProduct.Items.Add(i);
            btnUpdate.Visible = false;
            
        }
        int _couponlistID;
        public FrmCouponDetail(int couponlistID)
        {
            InitializeComponent();
            btnSave.Visible = false;
            _couponlistID = couponlistID;
            
            TraveldateEntities dbContext = new TraveldateEntities();
            var q = from c in dbContext.CouponLists
                    where c.CouponListID == couponlistID
                    select c;
            foreach (var i in q) 
            {
                txtName.Text = i.CouponName;
                txtDiscount.Text=i.Discount.ToString();
                txtDetail.Text = i.Description;
                dateTimePicker1.Value = i.DueDate.Value;
                //load照片
                byte[] bytes = i.Photo;
                if (bytes != null) 
                {
                 System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                picPicture.Image=Image.FromStream(ms);
                }
                             
            }
            //load product name和選項
            var q2 = dbContext.ProductLists.Select(c => c.ProductName);
            List<string> productname = q2.ToList();
            foreach (string i in productname)
                this.cbbProduct.Items.Add(i);
            }

      

        private void flPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        string[] filenames;
        private void flPicture_DragDrop(object sender, DragEventArgs e)
        {
            filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadPictureToPanel(filenames);
        }
        void LoadPictureToPanel(string[] filenames)
        {

            foreach (string file in filenames)
            {
                //bool IsErrorImage = false;
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(file);
                p.BorderStyle = BorderStyle.Fixed3D;
                p.BackColor = Color.White;
                p.Width = 200;
                p.Height = 150;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Click += P_Click;
                this.flPicture.Controls.Add(p);
            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            picPicture.Image = ((PictureBox)sender).Image;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenames = this.openFileDialog1.FileNames;
                LoadPictureToPanel(filenames);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CouponList couponList = new CouponList();
                couponList.CouponName = txtName.Text;
                couponList.Discount = Convert.ToDecimal(txtDiscount.Text);
                couponList.Description = txtDetail.Text;
                couponList.DueDate = dateTimePicker1.Value;
                couponList.CompanyID = Models.Login.ManufacturerID;
                //儲存productID
                var q = CommonClass.dbContext.ProductLists.Where(p => p.ProductName == cbbProduct.Text).Select(p => p.ProductID);
                couponList.ProductID = q.FirstOrDefault();
                //儲存相片
                byte[] photo;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.picPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                photo = ms.GetBuffer();
                couponList.Photo = photo;
                CommonClass.dbContext.CouponLists.Add(couponList);
                CommonClass.dbContext.SaveChanges();
                MessageBox.Show("儲存成功");
                Close();
            }
            catch (Exception a) 
            {
                MessageBox.Show(a.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
 var q = from c in CommonClass.dbContext.CouponLists
                    where c.CouponListID==_couponlistID
                    select c;
            foreach (var c in q) 
            {
                c.CouponName = txtName.Text;
                c.Discount = Convert.ToDecimal(txtDiscount.Text);
                c.Description = txtDetail.Text;
                c.DueDate = dateTimePicker1.Value;
                c.CompanyID = Models.Login.ManufacturerID;
                //更新productID
                var q2 = CommonClass.dbContext.ProductLists.Where(p => p.ProductName == cbbProduct.Text).Select(p => p.ProductID);
                c.ProductID = q2.FirstOrDefault();
                //更新photo
                byte[] photo;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.picPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                photo = ms.GetBuffer();
               c.Photo = photo;
            }
            CommonClass.dbContext.SaveChanges();
                MessageBox.Show("儲存成功");
                Close();
            }
            catch (Exception a) 
            {
                MessageBox.Show(a.Message);
            }
           
            
        }
    }
}
