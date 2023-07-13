
using proj_Traveldate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj_Traveldate.金負責區_LoginPage_Member
{
    public partial class LoginPage_Member_會員登入 : Form
    {
        public LoginPage_Member_會員登入()
        {
            InitializeComponent();
            this.db5.Database.Log = Console.Write;
            Console.Write("xxx");
            
            this.tabControl1.SelectedIndex = 0;

            #region comboBox1 & comboBox2 &  comboBox3 &  comboBox4 & comboBox5 ，的Items.Add細項內容 2023.07.04 早
            comboBox1.Items.Add("女");
            comboBox1.Items.Add("男");
            comboBox2.Items.Add("女");
            comboBox2.Items.Add("男");
            comboBox3.Items.Add("台北市");
            comboBox3.Items.Add("新北市");
            comboBox3.Items.Add("桃園市");
            comboBox3.Items.Add("台中市");
            comboBox3.Items.Add("台南市");
            comboBox3.Items.Add("高雄市");
            comboBox3.Items.Add("新竹縣");
            comboBox3.Items.Add("苗栗縣");
            comboBox3.Items.Add("彰化縣");
            comboBox3.Items.Add("南投縣");
            comboBox3.Items.Add("雲林縣");
            comboBox3.Items.Add("嘉義縣");
            comboBox3.Items.Add("屏東縣");
            comboBox3.Items.Add("宜蘭縣");
            comboBox3.Items.Add("花蓮縣");
            comboBox3.Items.Add("台東縣");
            comboBox3.Items.Add("澎湖縣");
            comboBox3.Items.Add("金門縣");
            comboBox3.Items.Add("嫌將現");
            comboBox3.Items.Add("基隆市");
            comboBox3.Items.Add("新竹市");
            comboBox3.Items.Add("嘉義市");

            comboBox4.Items.Add("台北市");
            comboBox4.Items.Add("新北市");
            comboBox4.Items.Add("桃園市");
            comboBox4.Items.Add("台中市");
            comboBox4.Items.Add("台南市");
            comboBox4.Items.Add("高雄市");
            comboBox4.Items.Add("新竹縣");
            comboBox4.Items.Add("苗栗縣");
            comboBox4.Items.Add("彰化縣");
            comboBox4.Items.Add("南投縣");
            comboBox4.Items.Add("雲林縣");
            comboBox4.Items.Add("嘉義縣");
            comboBox4.Items.Add("屏東縣");
            comboBox4.Items.Add("宜蘭縣");
            comboBox4.Items.Add("花蓮縣");
            comboBox4.Items.Add("台東縣");
            comboBox4.Items.Add("澎湖縣");
            comboBox4.Items.Add("金門縣");
            comboBox4.Items.Add("嫌將現");
            comboBox4.Items.Add("基隆市");
            comboBox4.Items.Add("新竹市");
            comboBox4.Items.Add("嘉義市");

            //comboBox5.Items.Add("1");
            //comboBox5.Items.Add("2");
            //comboBox5.Items.Add("3");
            //comboBox5.Items.Add("4");
            //comboBox5.Items.Add("5");

            #endregion
            #region 為先註解掉的程式碼，暫時用不到 2023.07.03 早
            //顯示優惠券信息 2023.06.30 早
            //var q = from c in db5.CouponLists select new { c.CouponListID,c.CouponName ,c.Discount, c.Description, c.DueDate };
            //this.dataGridView5.DataSource =q.ToList();
            //this.dataGridView5.DataSource = this.db5.Members.First().Coupons.ToList();
            //MessageBox.Show(""+this.db5.CouponLists.First().CouponListID);
            //int memberID = 1;
            //string c5 = this.comboBox5.ValueMember = $"{this.comboBox5.Text}";
            //var q = db5.Members.Where(m => (m.MemberID).ToString() == c5.ToString()).SelectMany(member => db5.CouponLists, (member, Coupon) => new { Coupon.CouponListID, Coupon.CouponName, Coupon.Discount, Coupon.Description, Coupon.DueDate });
            //this.dataGridView5.DataSource = q.ToList();

            //顯示收藏清單 2023.06.30 早
            //var q3 = from photo in db5.ProductPhotoLists
            //             join p in db5.ProductLists
            //             on photo.ProductID equals p.ProductID
            //             select new {名稱 =  p.ProductName , 說明 = p.Description , 概述=p.Outline , photo.Photo};
            //    this.dataGridView4.DataSource =q3.ToList();
            //    this.dataGridView4.Columns[0].Frozen = true;

            //var q = db5.Members.Where(m => (m.MemberID).ToString() == c5.ToString()).SelectMany(member => db5.CouponLists, (member, Coupon) => new { Coupon.CouponListID, Coupon.CouponName, Coupon.Discount, Coupon.Description, Coupon.DueDate });

            //顯示會員訂單 2023.06.30 午
            //TraveldateEntities4 db4 = new TraveldateEntities4(); //專題資料庫

            //var q2 = from p in db5.ProductLists
            //         join f in db5.Favorites
            //         on p.ProductID equals f.ProductID
            //         where f.MemberID.ToString()==c5.ToString()
            //         select new { 名稱 = p.PlanName, 說明 = p.PlanDescription, 概述 = p.Outline };
            //this.dataGridView2.DataSource = q2.ToList();
            //this.dataGridView2.Columns[0].Frozen = true;
            #endregion
        }
        // TraveldateEntities db = new TraveldateEntities; //專題資料庫(Traveldate.dbo1)(TDModel)(TraveldateEntities)
        TraveldateEntities db5 = new TraveldateEntities(); //我自己的資料庫(Traveldate.dbo)(TDtestModel)(TraveldateEntities1)

        public int MemberID { get; private set; }

        private void button8_Click(object sender, EventArgs e)
        {//新增旅伴資料-增加
            try
            {
                string t16 = this.textBox16.Text; //{FirstName=t16 }
                string t10 = this.textBox10.Text; //{LastName=t10 }
                string c2 = this.comboBox2.Text; //{Gender=c2 }
                string dt1 = this.dateTimePicker1.Text; //{BirthDate=dt1 }
                string c3 = this.comboBox3.Text; //{City=c3 }
                string t13 = this.textBox13.Text; //{Phone=t13}
                string t15 = this.textBox15.Text; //{Email=t15}
                int cityid=0;
                //Member member = db5.Members.Add(new Member { FirstName = t16, LastName = t10, Gender = c2, BirthDate = Convert.ToDateTime(dt1), Phone = t13, Email = t15 }); //{FirstName=t16 } {LastName=t10 }{BirthDate=dt1 } {Gender=c2 } {Phone=t13}{Email=t15}
                if (comboBox3.Text != "")
                {
                    string cityname = comboBox3.Text;
                    var city = db5.CityLists.FirstOrDefault(c => c.City == cityname);
                     cityid = city.CityID;
                    // MessageBox.Show("請選擇地區");
                }
                //else
                //{
                //    string cityname = comboBox3.Text;
                //    var city = db5.CityLists.FirstOrDefault(c => c.City == cityname);
                //    int cityid = city.CityID;
                //}

                //MessageBox.Show("增加成功");
                //db5.SaveChanges();
                //基本資料設定-關於地區
                //string c55 = this.comboBox5.SelectedItem.ToString();
                //var city = db5.CityLists.Where(c => c.City == c4).Select(c => c.CityID).FirstOrDefault();
                //var m = this.db5.Members.AsEnumerable().Where(c => c.MemberID == Convert.ToInt32(comboBox5.Text)).FirstOrDefault();
                //m.CityID = city;
                #region 為先註解掉的程式碼，暫時用不到 2023.06.29
                //Regex mReg = new Regex(@"^[a-zA-Z0-9-_]+@[a-zA-Z0-9]+\.(com|com\.tw|net) $");
                //if (IsCorrectMaillFormat(t15))
                //{
                //    MessageBox.Show("成功");
                ////    Product product2 = db.Products.Add(new Product { ProductName = t15 }); //{Email=t15}
                //    db2.SaveChanges();
                //}
                //else
                //{
                //    MessageBox.Show("不成功");
                //    //    //MessageBox.Show("E-Mail格式有誤，請依照格式輸入 :\r\n" +
                //    //    //                                    "1. 長度可為 8 至 16 個字元長度\r\n" +
                //    //    //                                    "2. 可包含數字 (0-9) 或英文大小寫字母 (a-z A-Z) 或特殊符號(- _ )字元 ) ，\r\n" +
                //    //    //                                    "1. 須為@結尾");
                //        this.textBox15.Text = "";
                //        this.textBox15.Focus();
                //}
                //if (((IsCorrectMaillFormat(textBox15.Text))
                //{
                //    //    this.textBox15.Text = "";
                //    //    this.textBox1.Focus();
                //    //    MessageBox.Show("E-Mail格式有誤，請依照格式輸入 :\r\n" +
                //    //                                        "1. E-Mail長度可為 8 至 16 個字元長度\r\n" +
                //    //                                        "2. E-Mail可包含數字 (0-9) 或英文大小寫字母 (a-z A-Z) 或特殊符號(-_)字元 ) ，\r\n" +
                //    //                                        "1. E-Mail須為@結尾");
                //}
                //else
                //{
                //}

                //MessageBox.Show("E-Mail格式有誤，請依照格式輸入 :\r\n" +
                //                                    "1. E-Mail長度可為 8 至 16 個字元長度\r\n" +
                //                                    "2. E-Mail可包含數字 (0-9) 或英文大小寫字母 (a-z A-Z) 或特殊符號(-_)字元 ) ，\r\n" +
                //                                    "1. E-Mail須為@結尾");
                //Product product2 = db.Products.Add(new Product { ProductName = t15 }); //{Email=t15}
                //db.SaveChanges();


                //try
                //{

                //}
                //catch (Exception ex){MessageBox.Show(ex.Message);}
                #endregion

                //db5.Members.Add(m);

                if (t16 != "" && t10 != "" && c2 != "" && (cityid.ToString()) != "" && t13 != "")
                {
                    Member m = new Member
                    {
                        FirstName = t16,
                        LastName = t10,
                        Gender = c2,
                        BirthDate = Convert.ToDateTime(dt1),
                        CityID = cityid,
                        Phone = t13,
                        Email = t15
                    };
                        db5.Members.Add(m);
                        db5.SaveChanges();
                        MessageBox.Show("增加成功");
                }
                else
                {
                        MessageBox.Show("*號為必填欄位");
                }
            } 
            catch(Exception ex) {MessageBox.Show(ex.Message);}
        }

        #region 先暫時不用
        public class textData
        {
         public   string Text { set; get; }
       }

       ;
        //private void textBox9_TextChanged(object sender, EventArgs e)
        //{
        //    label23.Text = "";
        //    string l23 = textBox9.Text;
        //    label23.Text += l23;
        //    //MessageBox.Show("儲存成功");
        //    //dataGridView1.DataSource = db.Products.ToList();
        //    dataGridView1.DataSource = l23.ToList();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            //KKday.mod
            //NorthwindEntities db = new NorthwindEntities();

            //dataGridView1.DataSource = db.Products.ToList();
            //db.Products.Add(new Product { ProductName = "ddd", Discontinued = true });
            //db.SaveChanges();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {//聯絡 E-mail
            //if(IsCorrectMaillFormat(textBox15.Text))
            //{
            //    string t15 = this.textBox15.Text; //{Email=t15}
            //    Product product = db.Products.Add(new Product { ProductName = t15 }); //{FirstName=t16 } {LastName=t10 } {Gender=c2 } {Country=c3 }
            //}
            //else
            //{
            //    MessageBox.Show("E-Mail格式有誤，請依照格式輸入 :\r\n" +
            //                                        "1. E-Mail長度可為 8 至 16 個字元長度\r\n" +
            //                                        "2. E-Mail可包含數字 (0-9) 或英文大小寫字母 (a-z A-Z) 或特殊符號(-_)字元 ) ，\r\n" +
            //                                        "1. E-Mail須為@結尾");
            //}
            //MessageBox.Show("E-Mail格式有誤，請依照格式輸入 :\r\n" +
            //                                    "1. E-Mail長度可為 8 至 16 個字元長度\r\n" +
            //                                    "2. E-Mail可包含數字 (0-9) 或英文大小寫字母 (a-z A-Z) 或特殊符號(-_)字元 ) ，\r\n" +
            //                                    "1. E-Mail須為@結尾");
        }
        //bool IsCorrectMaillFormat(string Mail)
        //{
        //    return Regex.IsMatch(Mail, @"^[a-zA-Z0-9_-]+(@)+(\.com|com\.tw|net) $");
        //    //    //string str = @"^[a-zA-Z0-9-_]+@[a-zA-Z0-9]+\.(com|com\.tw|net) $";
        //    //    //Regex mReg = new Regex(str);
        //    //    //if(mReg.IsMatch(Mail))
        //    //    //{
        //    //    //    MessageBox.Show("儲存成功");
        //    //    //    //string t15 = this.textBox15.Text; //{Email=t15}
        //    //    //    //Product product2 = db.Products.Add(new Product { ProductName = t15 }); //{Email=t15}
        //    //    //    //db.SaveChanges();
        //    //    //    //return true;

        //    //    //}
        //    //    //else
        //    //    //{
        //    //    //    MessageBox.Show("儲存失敗");
        //    //    //    //MessageBox.Show("E-Mail格式有誤，請依照格式輸入 :\r\n" +
        //    //    //    //                                    "1. 長度可為 8 至 16 個字元長度\r\n" +
        //    //    //    //                                    "2. 可包含數字 (0-9) 或英文大小寫字母 (a-z A-Z) 或特殊符號(- _ )字元 ) ，\r\n" +
        //    //    //    //                                    "1. 須為@結尾");
        //    //    //    return false;
        //    //    //}
        //}
        #endregion
        private void button7_Click(object sender, EventArgs e)
        {//基本資料設定-儲存
            string t9 = this.textBox9.Text; //{FirstName=t9}
            string t2 = this.textBox2.Text; //{LastName=t2}
            string c1 = this.comboBox1.Text; //{Gender=c1 }
            string dt2 = this.dateTimePicker2.Text; //{BirthDate=dt2 }
            string c4 = this.comboBox4.Text; //{City=c4 }
            string t6 = this.textBox6.Text; //{Phone=t6} 
            string t7 = this.textBox7.Text; //{Email=t7}
            string c5 = this.comboBox5.ValueMember = $"{Models.Login.MemberID}";
            
            try
            {
                var q = from m1 in db5.Members where m1.MemberID == Models.Login.MemberID select m1;
                foreach (var mm in q)
                {
                    mm.LastName = t2;
                }
                var q1 = from m1 in db5.Members where m1.MemberID == Models.Login.MemberID select m1;
                foreach (var mm in q1)
                {
                    mm.FirstName = t9;
                }
                var q2 = from m1 in db5.Members where m1.MemberID == Models.Login.MemberID select m1;
                foreach (var mm in q2)
                {
                    mm.Gender = c1;
                }
                var q3 = from m1 in db5.Members where m1.MemberID == Models.Login.MemberID select m1;
                foreach (var mm in q3)
                {
                    mm.BirthDate = Convert.ToDateTime(dt2);
                }

                //string c55 = this.comboBox5.SelectedItem.ToString() ;
                var city = db5.CityLists.Where(c => c.City == c4).Select(c => c.CityID).FirstOrDefault();
                var m = this.db5.Members.AsEnumerable().Where(c => c.MemberID == Models.Login.MemberID).FirstOrDefault();
                m.CityID = city;
                //db5.SaveChanges();

                var q5 = from m1 in db5.Members where m1.MemberID == Models.Login.MemberID select m1;
                foreach (var mm in q5)
                {
                    mm.Phone = t6;
                }
                var q6 = from m1 in db5.Members where m1.MemberID == Models.Login.MemberID select m1;
                foreach (var mm in q6)
                {
                    mm.Email = t7;
                }
                #region 為先註解掉的程式碼，暫時用不到 2023.06.29
                //if (c5 == db2.Members)
                //Member member = db2.Members.FirstOrDefault();

                //if ((Convert.ToInt32( c5).Equals (member.MemberID ))  )
                //{
                //    member.LastName = t2;
                //}
                #endregion
                db5.SaveChanges();
                MessageBox.Show("修改成功");
                //var photo2 = db5.Members.FirstOrDefault(m => m.MemberID == 1);
                //if (photo2 != null)
                //{
                //    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                //    {
                //        this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //        photo2.Photo =Convert.ToBase64String (ms.ToArray() );
                //    }
                //}
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}          
        }

        private void button6_Click(object sender, EventArgs e)
        {//變更密碼
            string t25 = this.textBox25.Text; //{Password=t25}
            string t26 = this.textBox26.Text; //{doubleCheck Password=t26}
            string c5 = this.comboBox5.ValueMember = $"{Models.Login.MemberID}";

            var q = from m in db5.Members where m.MemberID == Models.Login.MemberID select m;
            foreach (var mm in q)
            {
                mm.Password = t25;
            }

            if (t25 == t26)
            {
                db5.SaveChanges();
                MessageBox.Show("密碼已變更成功");
            }
            else 
            {
                MessageBox.Show("新密碼與確認新密碼內容不相符");
                this.textBox26.Clear();
                this.textBox26.Focus();
            }
        }
        private System.Windows.Forms.ToolTip toolTip;
        private void LoginPage_Member_會員登入_Load(object sender, EventArgs e)
        {//Form一進來
            try 
            {
                label24.Click += Label24_Click; ; //tabPage0 基本資料設定
                label9.Click += Label9_Click; //tabPage1 密碼更改
                label10.Click += Label10_Click; //tabPage2 優惠券清單
                label11.Click += Label11_Click; //tabPage3 新增旅伴資料
                label12.Click += Label12_Click; //tabPage4 收藏清單
                label13.Click += Label13_Click;  //tabPage5 會員訂單

                //comboBox5.SelectedIndexChanged += ComboBox5_SelectedIndexChanged; //combobox選擇Member ID :1~5 

                this.splitContainer1.Panel1Collapsed = true;


                //新加的評論按鈕
                //依會員ID顯示相對應的歷史訂單 
                var selectHisOrders = db5.OrderDetails.Where(n => n.Order.IsCart == false && n.Order.MemberID.ToString() == Models.Login.MemberID.ToString()).AsEnumerable()
                    .Select(n => new
                    {
                        ProductID = n.Trip.ProductID,
                        商品名稱 = n.Trip.ProductList.ProductName,
                        訂購日期 = $"{n.Order.Datetime:d}",
                        行程日期 = n.Trip.Date,
                        商品敘述 = n.Trip.ProductList.PlanName
                    }).ToList();
                dataGridView2.DataSource = selectHisOrders;
                dataGridView2.Columns[1].Frozen = true;
                //新加的評論按鈕

                // string c5 = this.comboBox5.ValueMember=comboBox5.Text /*= $"{Models.Login.MemberID}"*/;
                string c5 = this.comboBox5.ValueMember = $"{Models.Login.MemberID}";

                //顯示優惠券信息 2023.07.03 早
                var q1 = from m in db5.Members
                         join c in db5.Coupons
                         on m.MemberID equals c.MemberID
                         join cl in db5.CouponLists
                         on c.CouponListID equals cl.CouponListID
                         where m.MemberID == Models.Login.MemberID
                         select new { cl.CouponListID, cl.CouponName, cl.Discount, cl.Description, cl.DueDate };
                this.dataGridView5.DataSource = q1.ToList();

                //顯示收藏清單 2023.07.03 早
                var q22=
                    from m in db5.Members
                    join f in db5.Favorites
                   on m.MemberID equals f.MemberID
                   join pl in db5.ProductLists
                   on f.ProductID equals pl.ProductID
                    where m.MemberID == Models.Login.MemberID
                    select new { 名稱 = pl.ProductName, 說明 = pl.Description, 概述 = pl.Outline };
                this.dataGridView4.DataSource = q22.Distinct(). ToList();

                // this.dataGridView4.Columns[0].Frozen = true;
                //顯示會員訂單 2023.07.03 早

                //0705早註解
                //var q3 = from p  in  db5.ProductLists
                //         join f in  db5.Favorites 
                //         on p.ProductID equals  f.ProductID
                //         join pp in db5.ProductPhotoLists
                //         on f.ProductID equals pp.ProductID
                //         where f.MemberID.ToString() == c5.ToString()
                //         select new { 名稱 = p.PlanName, 說明 = p.PlanDescription, 概述 = p.Outline };

                //this.dataGridView2.DataSource = q3.Distinct().ToList();
                //0705早註解

                //this.dataGridView2.Columns[0].Frozen = true;

                //顯示會員基本資料信息2023.07.04 午
                var memberdata = db5.Members.AsEnumerable().Where(c => c.MemberID == Models.Login.MemberID).FirstOrDefault();
                if (memberdata != null)
                {
                    textBox9.Text = memberdata.FirstName;
                    textBox2.Text = memberdata.LastName;
                    comboBox1.Text = memberdata.Gender;
                    dateTimePicker2.Text = memberdata.BirthDate.ToString();

                    comboBox4.Text = memberdata.CityID.ToString();
                    //string cb = comboBox4.Text;
                    //var city = db5.CityLists.Where(c => c.City == comboBox4.Text).Select(c => c.CityID).FirstOrDefault();
                    //var m = this.db5.CityLists.AsEnumerable(). Where(c => c.CityID == Convert.ToInt32(comboBox4.Text));
                    var city = db5.CityLists.AsEnumerable().FirstOrDefault(c => c.CityID == Convert.ToInt32(comboBox4.Text));
                    comboBox4.Text = city.City;

                    textBox6.Text = memberdata.Phone;
                    textBox7.Text = memberdata.Email;

                    var member = db5.Members.AsEnumerable().FirstOrDefault(m => m.MemberID == Models.Login.MemberID);
                    if (member != null && member.Photo != null)
                    {
                        byte[] imagebytes = member.Photo;
                        System.Drawing.Image image;
                        using (MemoryStream ms = new MemoryStream(imagebytes))
                        {
                            image = System.Drawing.Image.FromStream(ms);
                        }
                        pictureBox1.Image = image;
                    }
                    label37.Text = "嗨~歡迎 " + textBox2.Text + textBox9.Text + " 用戶";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } //Load此行結束

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedMemberID =Convert.ToInt32( comboBox5.SelectedValue);
            //string DBLastName = GetMemberBinder(selectedMemberID);
        }
        void GetMemberIDFromDB (string memberID)
        {
            //var q = from m in db5.Members where (m.MemberID).ToString() == ((c5.ToString())) select m;
            //foreach (var mm in q1)
            //{
            //    mm.FirstName = t9;
            //}
        }
        #region 點擊連動到 tabPage程式碼 2023.06.29
        private void Label13_Click(object sender, EventArgs e)
        {//點擊連動到 tabPage5 會員訂單
            this.tabControl1.SelectedTab = this.會員訂單;
        }
        private void Label12_Click(object sender, EventArgs e)
        {//點擊連動到 tabPage4 收藏清單
            this.tabControl1.SelectedTab = this.收藏清單;
        }
        private void Label11_Click(object sender, EventArgs e)
        {//點擊連動到 tabPage3 新增旅伴資料
            this.tabControl1.SelectedTab = this.新增旅伴資料;
        }
        private void Label10_Click(object sender, EventArgs e)
        {//點擊連動到 tabPage2 優惠券清單
            this.tabControl1.SelectedTab = this.優惠券清單;
        }
        private void Label9_Click(object sender, EventArgs e)
        {//點擊連動到 tabPage1 密碼更改
            this.tabControl1.SelectedTab = this.密碼更改;
        }        
        private void Label24_Click(object sender, EventArgs e)
        {//點擊連動到 tabPage0 基本資料設定
            this.tabControl1.SelectedTab = this.基本資料設定;
        }
        #endregion
                private void button9_Click(object sender, EventArgs e)
        {//從檔案夾修改個人照片(相機圖示)
            try 
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.Image = System.Drawing.Image.FromFile(this.openFileDialog1.FileName);
                    //filenames = this.openFileDialog1.FileNames;
                    //LoadPictureToPanel(filenames);
                }
                var photo = db5.Members.Where(pp => pp.MemberID == Models.Login.MemberID);
                if (photo != null)
                {
                    using (System.IO.MemoryStream ms = new MemoryStream())
                    {
                        byte[] bytes;
                        this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        //photo.Photo =(ms.ToArray()).ToString();
                        bytes = ms.GetBuffer();
                        // byte[] bytes = File.ReadAllBytes(file);
                        var q = this.db5.Members.AsEnumerable().Where(m => m.MemberID == Models.Login.MemberID);
                        foreach (var p in q)
                        {
                            p.Photo = bytes;
                        }
                        db5.SaveChanges();
                        Thread.Sleep(2000);
                        MessageBox.Show("圖片修改成功");
                    }
                }
                else
                {
                    MessageBox.Show("修改不成功");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}

        } //btn9此行結束
        #region 修改照片部分已寫在btn [ 相機圖示 ]，先選擇MemberID-點擊 [ 相機圖示] -從檔案找照片-按確定後-修改後的照片會直接儲存Member資料庫所對應的MemberID的Photo欄位 2023.07.04 午
        private void button10_Click(object sender, EventArgs e)
        {//修改照片
         //using (db5)
         //{
         //    var photo = db5.Members.Where(pp => pp.MemberID ==Convert.ToInt32( comboBox5.Text));
         //    if (photo != null)
         //    {
         //        using (System.IO.MemoryStream ms = new MemoryStream())
         //        {
         //            byte[] bytes;
         //            this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
         //            //photo.Photo =(ms.ToArray()).ToString();
         //            bytes = ms.GetBuffer();
         //            // byte[] bytes = File.ReadAllBytes(file);
         //            var q = this.db5.Members.AsEnumerable().Where(m => m.MemberID == Convert.ToInt32(comboBox5.Text));
         //            foreach (var p in q)
         //            {
         //                p.Photo = bytes;
         //            }
         //            db5.SaveChanges();
         //            MessageBox.Show("修改成功");
         //        }
         //    }
         //else
         //{
         //    MessageBox.Show("修改不成功");
         //}

            //}
            #endregion
            #region 為先註解掉的程式碼，暫時用不到 2023.07.04
            //string c5 = this.comboBox5.ValueMember = $"{this.comboBox5.Text}";
            //using(TraveldateEntities5 db5=new TraveldateEntities5())
            //    {
            //        //byte[] bytes;
            //        //System.IO.MemoryStream ms= new System.IO.MemoryStream();
            //        //this.pictureBox1.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            //        //bytes=ms.GetBuffer();
            //        foreach(string file in filenames)
            //        {
            //            Member member=new Member();
            //            byte[]bytes = File.ReadAllBytes(file);
            //            member.Photo = bytes;
            //        db5.Members.Add(member);
            //        }
            //        db5.SaveChanges();
            //    }
            //void LoadPictureToPanel(string[]filenames)
            //    {
            //        foreach(string file in filenames)
            //        {
            //            PictureBox pictureBox = new PictureBox();
            //            pictureBox.Image= System.Drawing.Image.FromFile(file);
            //            this.flowLayoutPanel1.Controls.Add(pictureBox);
            //        }
            //    }

            //    db5.SaveChanges();
            //int memberid = 1;
            //byte[] imageBytes = File.ReadAllBytes("path/to/Image.png");
            //var member=db5.Members.FirstOrDefault(m=>m.MemberID == memberid);
            //if(member != null)
            //{
            //    member.Photo = imageBytes;
            #endregion
        }
        #region 顯示(優惠券信息/收藏清單/會員訂單) 透過combobox5選擇對應Member ID顯示對應信息 2023.07.03 早 。comboBox5_SelectedIndexChanged_1 的程式碼已經移到Load裡面去了 2023.07.05 午
        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // //新加的評論按鈕
           // //依會員ID顯示相對應的歷史訂單 
           // var selectHisOrders = db5.OrderDetails.Where(n => n.Order.IsCart == false && n.Order.MemberID.ToString() == Models.Login.MemberID.ToString()).AsEnumerable()
           //     .Select(n => new
           //     {
           //         ProductID = n.Trip.ProductID,
           //         商品名稱 = n.Trip.ProductList.ProductName,
           //         訂購日期 = $"{n.Order.Datetime:d}",
           //         行程日期 = n.Trip.Date,
           //         商品敘述 = n.Trip.ProductList.PlanName
           //     }).ToList();
           // dataGridView2.DataSource = selectHisOrders;
           // dataGridView2.Columns[1].Frozen = true;
           // //新加的評論按鈕

           //// string c5 = this.comboBox5.ValueMember=comboBox5.Text /*= $"{Models.Login.MemberID}"*/;
           // string c5 = this.comboBox5.ValueMember =  $"{Models.Login.MemberID}";

           // //顯示優惠券信息 2023.07.03 早
           // var q1 = from m in db5.Members
           //          join c in db5.Coupons
           //          on m.MemberID equals c.MemberID
           //          join cl in db5.CouponLists
           //          on c.CouponListID equals cl.CouponListID
           //          where m.MemberID.ToString() == c5.ToString()
           //          select new { cl.CouponListID,cl.CouponName,cl.Discount,cl.Description,cl.DueDate };
           // this.dataGridView5.DataSource = q1.ToList();
           // //顯示收藏清單 2023.07.03 早
           // var q2 = from photo in db5.ProductPhotoLists
           //          join p in db5.ProductLists
           //          on photo.ProductID equals p.ProductID
           //          select new { 名稱 = p.ProductName, 說明 = p.Description, 概述 = p.Outline, photo.Photo };
           // this.dataGridView4.DataSource = q2.Distinct().ToList();
           // // this.dataGridView4.Columns[0].Frozen = true;
           // //顯示會員訂單 2023.07.03 早

           // //0705早註解
           // //var q3 = from p  in  db5.ProductLists
           // //         join f in  db5.Favorites 
           // //         on p.ProductID equals  f.ProductID
           // //         join pp in db5.ProductPhotoLists
           // //         on f.ProductID equals pp.ProductID
           // //         where f.MemberID.ToString() == c5.ToString()
           // //         select new { 名稱 = p.PlanName, 說明 = p.PlanDescription, 概述 = p.Outline };

           // //this.dataGridView2.DataSource = q3.Distinct().ToList();
           // //0705早註解

           // //this.dataGridView2.Columns[0].Frozen = true;

           // //顯示會員基本資料信息2023.07.04 午
           // var memberdata = db5.Members.AsEnumerable().Where(c => c.MemberID == Models.Login.MemberID).FirstOrDefault();
           // if (memberdata != null)
           // {
           //     textBox9.Text = memberdata.FirstName;
           //     textBox2.Text = memberdata.LastName;
           //     comboBox1.Text= memberdata.Gender;
           //     dateTimePicker2.Text=memberdata.BirthDate.ToString();

           //     comboBox4.Text = memberdata.CityID.ToString();
           //     //string cb = comboBox4.Text;
           //     //var city = db5.CityLists.Where(c => c.City == comboBox4.Text).Select(c => c.CityID).FirstOrDefault();
           //     //var m = this.db5.CityLists.AsEnumerable(). Where(c => c.CityID == Convert.ToInt32(comboBox4.Text));
           //     var city = db5.CityLists.AsEnumerable().FirstOrDefault(c => c.CityID == Convert.ToInt32(comboBox4.Text));
           //     comboBox4.Text= city.City ;

           //     textBox6.Text = memberdata.Phone;
           //     textBox7.Text = memberdata.Email;

           //     var member=db5.Members.AsEnumerable() .FirstOrDefault(m=>m.MemberID == Models.Login.MemberID);
           //     if(member != null &&member.Photo!=null)
           //     {
           //         byte[] imagebytes = member.Photo;
           //         System.Drawing.Image image;
           //         using(MemoryStream ms=new MemoryStream(imagebytes))
           //         {
           //             image= System.Drawing.Image.FromStream(ms);
           //         }
           //         pictureBox1.Image = image;
           //     }

           //     label37.Text = "嗨~歡迎 " + textBox2.Text + textBox9.Text+ " 用戶";
           // }
        }
        #endregion

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string productName = dataGridView2.Rows[e.RowIndex].Cells["商品名稱"].Value.ToString();
                int productID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ProductID"].Value);
                FrmComment frm = new FrmComment();
                frm.labProdName.Text = productName;
                frm.Tag = productID;
                frm.Show();
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.tabControl1.Appearance = TabAppearance.FlatButtons;
            //tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            //Color tabselectedBackColor = Color.IndianRed;
            //Color tabselectedForeColor = Color.White;

            //Graphics g = e.Graphics;

            //tabPage5= tabControl1.TabPages[e.Index];
            //Rectangle_tab
        }
    }
}
    

