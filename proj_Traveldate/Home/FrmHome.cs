
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projTravelDate.Models;
using proj_Traveldate.金負責區_LoginPage_Member;
using proj_Traveldate.searchUIRev;
using proj_Traveldate.Models;
using proj_Traveldate.fieldBox;

namespace proj_Traveldate
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            if (Models.Login.MemberID >= 1)
            {
              Member matchemployees = dbContext.Members.FirstOrDefault(c => c.MemberID == Models.Login.MemberID);
            label24.Text = matchemployees.FirstName+"~ 您好";
            }

        }

        TraveldateEntities dbContext = new TraveldateEntities();

        public Form currentForm = null;

        public void OpenFormInPanel(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Show();
        }


        public void FrmMain_Resize(object sender, EventArgs e)
        {
            int xP = 0;
            int yP = 0;
            UpdateControlPosition(xP, yP);
        }

        public void UpdateControlPosition(int xP, int yP)
        {
            int x = (int)(this.Width * xP / 10);
            int y = (int)(this.Width * yP / 10);

        }




        public void label28_Click(object sender, EventArgs e)
        {

            Contact contact = new Contact();
            ShowFrm(contact);


        }




        public void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (Models.Login.MemberID != 0)
            {
                LoginPage_Member_會員登入 f = new LoginPage_Member_會員登入();
                ShowFrm(f);
            }
            else
            {
                Login contact = new Login();      
                contact.Show();
            }
           
        }

        private void label13_Click(object sender, EventArgs e)
        {
            FrmHome homePage = new FrmHome();
            this.Hide();


            homePage.ShowDialog();

            this.Close();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            FrmCartTabPage frm = new FrmCartTabPage();
            ShowFrm(frm);
        }

        private void label26_Click(object sender, EventArgs e)
        {

            if (Models.Login.MemberID != 0)
            {
                MessageBox.Show("你已是會員");
            }
            else
            {

                Register contact = new Register();
                ShowFrm(contact);
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
          
        }

        private void label25_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 2;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 1;
            FrmProgram frm = new FrmProgram();        
            ShowFrm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            //ProductBoxManger.nowProductBoxes.Clear();
            var q = from p in dbContext.ProductLists
                    where p.ProductName.Contains(textBox1.Text)
                    select p.ProductID;
            List<int> project = q.ToList();

            foreach (var pb in ProductBoxManger.allProductBoxes)
            {
                if (project.Contains(pb._productID))
                {
                    ProductBoxManger.nowProductBoxes.Add(pb);
                }
            }


            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
            //var qq = ProductBoxManger.AllProductBoxes._productID.Contains(project);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmHome homePage = new FrmHome();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductCitys.Contains("花蓮縣"))
                ProductManager.ProductCitys.Add("花蓮縣");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);

        }

        private void label25_Click_1(object sender, EventArgs e)
        {
            if(Models.Login.MemberID != 0)
            {
                LoginPage_Member_會員登入 frm= new LoginPage_Member_會員登入();
                ShowFrm(frm);
            }
            else
            {
                MessageBox.Show("請登入");
                Login contact = new Login();
                contact.Show();
            }
        }

        private void label24_Click_1(object sender, EventArgs e)
        {
            if (Models.Login.MemberID != 0)
            {
                LoginPage_Member_會員登入 frm = new LoginPage_Member_會員登入();
                ShowFrm(frm);
            }
            else
            {
                Login contact = new Login();
                contact.Show();
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            if (Models.Login.MemberID != 0)
            {
                LoginPage_Member_會員登入 frm = new LoginPage_Member_會員登入();
                ShowFrm(frm);
            }
            else
            {
                Login contact = new Login();
                contact.Show();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductTags.Contains("水上活動"))
                ProductManager.ProductTags.Add("水上活動");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FrmCartTabPage frm = new FrmCartTabPage();
            ShowFrm(frm);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 3;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 23;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 25;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 53;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 24;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductManager.ProductID = 46;
            FrmProgram frm = new FrmProgram();
            ShowFrm(frm);
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            FrmCartTabPage frm = new FrmCartTabPage();
            ShowFrm(frm);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            if (Models.Login.MemberID != 0)
            {
                LoginPage_Member_會員登入 frm = new LoginPage_Member_會員登入();
                ShowFrm(frm);
            }
            else
            {
                MessageBox.Show("請登入");
                Login contact = new Login();
                ShowFrm(contact);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //    if (Models.Login.MemberID != 0)
            //    {
            //        FrmHomePage f = new FrmHomePage();
            //        f.TopLevel = false;
            //        f.FormBorderStyle = FormBorderStyle.None;
            //        f.Dock = DockStyle.Fill;
            //        splitContainer2.Panel1.Controls.Clear();
            //        splitContainer2.Panel1.Controls.Add(f);    
            //        f.Show();


            //    }
            //else
            //{
            //MessageBox.Show("請登入");
                ManufacturerLogin contact = new ManufacturerLogin();       
                contact.Show();
            //}
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            ShowFrm(contact);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductTags.Contains("遠足&登山"))
                ProductManager.ProductTags.Add("遠足&登山");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductTags.Contains("展覽"))
                ProductManager.ProductTags.Add("展覽");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductTags.Contains("景點門票"))
                ProductManager.ProductTags.Add("景點門票");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductTags.Contains("水族館&動物園"))
                ProductManager.ProductTags.Add("水族館&動物園");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductTags.Contains("冒險&極限運動"))
                ProductManager.ProductTags.Add("冒險&極限運動");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void Hot_btn_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            // ProductBoxManger.nowProductBoxes.Clear();

            if (!ProductManager.ProductCitys.Contains("新北市"))
                ProductManager.ProductCitys.Add("新北市");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductCitys.Contains("澎湖縣"))
                ProductManager.ProductCitys.Add("澎湖縣");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductCitys.Contains("宜蘭縣"))
                ProductManager.ProductCitys.Add("宜蘭縣");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ClearAllList_and_LoadData();
            if (!ProductManager.ProductCitys.Contains("南投縣"))
                ProductManager.ProductCitys.Add("南投縣");
            FrmSearch frm = new FrmSearch();
            ShowFrm(frm);
        }
        //清空存放商品資訊的List並實作新的
        void ClearAllList_and_LoadData()
        {
            ProductManager.ProductTags.Clear();
            ProductManager.ProductCitys.Clear();
            ProductBoxManger.nowProductBoxes.Clear();
            ProductBoxManger.allProductBoxes.Clear();
            //建立表單前先將產品實作
            ProductBoxManger loadAllProds = new ProductBoxManger();
        }
        //打開要放在splitContainer2.Panel1內全螢幕的form
        void ShowFrm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            splitContainer2.Panel1.Controls.Clear();
            splitContainer2.Panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}