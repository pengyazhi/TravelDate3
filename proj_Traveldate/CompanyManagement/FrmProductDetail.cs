using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using proj_Traveldate;
using static System.Windows.Forms.LinkLabel;
using proj_Traveldate.Models;
using static System.Net.WebRequestMethods;

namespace proj_Traveldate
{
    public partial class FrmProductDetail : Form
    {
        public FrmProductDetail()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            //Load city
            var q = CommonClass.dbContext.CityLists.Select(c => c.City);
            List<string> city = q.ToList();
            foreach (string i in city)
                this.cbbCity.Items.Add(i);
            //Load Type 
            var q2 = CommonClass.dbContext.ProductTypeLists.Select(c => c.ProductType);
            List<string> type = q2.ToList();
            foreach (string i in type)
                this.cbbType.Items.Add(i);

            //loadtreeview
            var q3 = from t in CommonClass.dbContext.ProductTagDetails
                     from td in CommonClass.dbContext.ProductCategories
                     where t.ProductCategoryID == td.ProductCategoryID
                     group new
                     {
                         t.ProductTagDetailsName,
                         td.ProductCategoryName
                      } by td.ProductCategoryName into g
                     select new
                     {
                         ProductCategoryName = g.Key,
                         ProductTagDetailName = g.Select(t => t.ProductTagDetailsName),
                         ProductTagDetailCount = g.Count()
                     };

            foreach (var t in q3)
            {
                string header = $"{t.ProductCategoryName}({t.ProductTagDetailCount})";
                TreeNode node = treeView1.Nodes.Add(header);
                foreach (var item in t.ProductTagDetailName)
                {
                    TreeNode childnodes = node.Nodes.Add(item);
                }
            }
        }
        int productID;
        public FrmProductDetail(int p)
        {
            InitializeComponent();
            productID= p;
            btnSaveToEntity.Visible = false;
            TraveldateEntities dbContext = new TraveldateEntities();
            //Load Type
            var q2 = dbContext.ProductTypeLists.Select(c => c.ProductType);
            List<string> type = q2.ToList();
            foreach (string i in type)
                this.cbbType.Items.Add(i);
            //Load city
            var q5 = dbContext.CityLists.Select(c => c.City);
            List<string> city = q5.ToList();
            foreach (string i in city)
                this.cbbCity.Items.Add(i);

            //Loadtextbox資料
            var q = from pd in dbContext.ProductLists
                    where pd.ProductID == p
                    select pd;
            
            foreach (var pd in q) 
            {
                try 
                {
                    string[] lines = pd.Outline.Split(new[] { "\n\n" }, StringSplitOptions.None);
                    txtOutline1.Text = lines[0].Replace("◎", string.Empty);
                    txtOutline2.Text = lines[1].Replace("◎", string.Empty);
                    txtOutline3.Text = lines[2].Replace("◎", string.Empty);
                    txtProductName.Text = pd.ProductName;
                    cbbCity.Text = pd.CityList.City;
                    txtDetails.Text = pd.Description;
                    txtPlanName.Text = pd.PlanName;
                    txtPlanDetail.Text = pd.PlanDescription;
                }
                catch (Exception) 
                {
                txtOutline1.Text=pd.Outline;
                    txtProductName.Text = pd.ProductName;
                    cbbCity.Text = pd.CityList.City;
                    txtDetails.Text = pd.Description;
                    txtPlanName.Text = pd.PlanName;
                    txtPlanDetail.Text = pd.PlanDescription;
                }
                
                
            }
            //load照片
            var q4 = from pic in dbContext.ProductPhotoLists
                     where pic.ProductID == p
                     select pic.Photo;
            foreach (var pic in q4) 
            {
                if (pic != null) 
                {
                byte[] bytes = pic;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Height = 100;
                pictureBox.Width = 150;
                flowLayoutPanel1.Controls.Add(pictureBox);
                }
                
            }
            //load空白Treeview
            var q3 = from t in dbContext.ProductTagDetails
                     from td in dbContext.ProductCategories
                     where t.ProductCategoryID == td.ProductCategoryID
                     group new
                     {
                         t.ProductTagDetailsName,
                         td.ProductCategoryName
                     } by td.ProductCategoryName into g
                     select new
                     {
                         ProductCategoryName = g.Key,
                         ProductTagDetailName = g.Select(t => t.ProductTagDetailsName),
                         ProductTagDetailCount = g.Count()
                     };

            foreach (var t in q3)
            {
                string header = $"{t.ProductCategoryName}({t.ProductTagDetailCount})";
                TreeNode node = treeView1.Nodes.Add(header);
                foreach (var item in t.ProductTagDetailName)
                {
                    TreeNode childnodes = node.Nodes.Add(item);
                }
            }
            //將選項打勾
            
            var q6 = dbContext.ProductTagLists.Where(c => c.ProductID == productID).Select(t => t.ProductTagDetail.ProductTagDetailsName);
            foreach (var item in q6) 
            {
                originalList.Add(item);
                CheckNodes(treeView1.Nodes, item);
            }


        }

        
        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = this.openFileDialog1.FileNames;
                int count = filenames.Count;
                foreach (string f in files)
                {
                    filenames.Add(f);
                }
                LoadPictureToPanel(filenames, count);
            }
        }
        private void btnSaveToEntity_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList productList = new ProductList();
                productList.CompanyID = Models.Login.ManufacturerID;
                productList.ProductName = txtProductName.Text;
                productList.Description = txtDetails.Text;
                productList.PlanName = txtPlanName.Text;
                productList.PlanDescription = txtPlanDetail.Text;
                productList.ExamineStatus = false;
                productList.Outline = "◎" + txtOutline1.Text+"\n\n"+ "◎" + txtOutline2.Text + "\n\n"+ "◎" + txtOutline3.Text ;
                var q1 = from city in CommonClass.dbContext.CityLists
                         where city.City == cbbCity.Text
                         select city.CityID;
                productList.CityID = q1.FirstOrDefault();
                var q2 = from type in CommonClass.dbContext.ProductTypeLists
                         where type.ProductType == cbbType.Text
                         select type.ProductTypeID;
                productList.ProductTypeID = q2.FirstOrDefault();
                CommonClass.dbContext.ProductLists.Add(productList);
               
                CommonClass.dbContext.SaveChanges();
                //找Treeview Checkbox有打勾的項目

                foreach (TreeNode node in treeView1.Nodes)
                {
                    CheckChildNodes(node);
                }
                var q3 = from tag in CommonClass.dbContext.ProductTagDetails
                         from check in checkedItems
                         where tag.ProductTagDetailsName == check
                         select tag.ProductTagDetailsID;
                var q4 = CommonClass.dbContext.ProductLists.AsEnumerable().Select(n => n.ProductID).LastOrDefault();
                foreach (var i in q3)
                {
                    ProductTagList tagList = new ProductTagList();
                    tagList.ProductID = q4;
                    tagList.ProductTagDetailsID = i;
                    CommonClass.dbContext.ProductTagLists.Add(tagList);
                }

                //儲存相片
                
                foreach (string file in filenames)
                {
                    ProductPhotoList photoList = new ProductPhotoList();
                    photoList.ProductID = q4;
                    byte[] bytes = System.IO.File.ReadAllBytes(file);
                    photoList.Photo = bytes;
                    CommonClass.dbContext.ProductPhotoLists.Add(photoList);
                }

                CommonClass.dbContext.SaveChanges();
                MessageBox.Show("儲存成功");
                Close();
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }

            }
            
        void CheckChildNodes(TreeNode parentNode)
        {
            // 檢查parentNode的Checkbox是否被勾選
            if (parentNode.Checked)
            {
                // 將打勾的資料儲存起來
                checkedItems.Add(parentNode.Text);
            }

            // 遍歷子節點
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                CheckChildNodes(childNode);
            }
         }
        List<string> checkedItems = new List<string>();
        List<string> originalList = new List<string>();
        List<string> filenames= new List<string>();
        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            int count = filenames.Count;
            foreach (string f in files) 
            {
            filenames.Add(f);
            }
            LoadPictureToPanel(filenames,count);
        }
        void LoadPictureToPanel(List<string> filenames,int skip) 
        {
            
            foreach (string file in filenames.Skip(skip))
            {
                
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(file);
                p.BorderStyle = BorderStyle.Fixed3D;
                p.BackColor = Color.White;
                p.Width = 200;
                p.Height = 150;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                this.flowLayoutPanel1.Controls.Add(p);
            }
        }
        void CheckNodes(TreeNodeCollection nodes, string targetNodeText)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == targetNodeText)
                {
                    node.Checked = true;
                    //return; // 如果只有一個目標節點，可加上 return 提升效能
                }

                CheckNodes(node.Nodes, targetNodeText); // 遞迴處理子節點
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
var q = from p in CommonClass.dbContext.ProductLists
                    where p.ProductID==productID
                    select p;
            foreach (var p in q) 
            {
                p.CompanyID = Models.Login.ManufacturerID;
                p.ProductName = txtProductName.Text;
                p.Description = txtDetails.Text;
                p.PlanName = txtPlanName.Text;
                p.PlanDescription = txtPlanDetail.Text;
                p.ExamineStatus = false;
                p.Outline = "◎" + txtOutline1.Text + "\n" + "◎" + txtOutline2.Text + "\n" + "◎" + txtOutline3.Text + "\n";
                var q1 = from city in CommonClass.dbContext.CityLists
                         where city.City == cbbCity.Text
                         select city.CityID;
                p.CityID = q1.FirstOrDefault();
                var q2 = from type in CommonClass.dbContext.ProductTypeLists
                         where type.ProductType == cbbType.Text
                         select type.ProductTypeID;
                p.ProductTypeID = q2.FirstOrDefault();
                //找Treeview Checkbox有打勾的項目

                foreach (TreeNode node in treeView1.Nodes)
                {
                    CheckChildNodes(node);
                }
                //新增的tag
                var addedData = checkedItems.Except(originalList);
                var q3 = from tag in CommonClass.dbContext.ProductTagDetails
                         from check in addedData
                         where tag.ProductTagDetailsName == check
                         select tag.ProductTagDetailsID;
                
                foreach (var i in q3)
                {
                    ProductTagList tagList = new ProductTagList();
                    tagList.ProductID = productID;
                    tagList.ProductTagDetailsID = i;
                    CommonClass.dbContext.ProductTagLists.Add(tagList);
                }
                //刪除的tag
                var deletedData = originalList.Except(checkedItems);
                var q5 = from tag in CommonClass.dbContext.ProductTagLists
                         from check in deletedData
                         where tag.ProductTagDetail.ProductTagDetailsName == check
                         select tag;
                              
                if (q5 == null) return;
                foreach (var item in q5) 
                {
                    CommonClass.dbContext.ProductTagLists.Remove(item);
                }
                                         
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
