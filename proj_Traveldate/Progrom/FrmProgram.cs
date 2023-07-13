using projTravelDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using proj_Traveldate.Models;
using projTravelDate.Models;
using System.Reflection;

namespace proj_Traveldate
{
    public partial class FrmProgram : Form
    {
        public FrmProgram()
        {
            InitializeComponent();
            
            //ProductManager.ProductID =3;
            //MemberID = 1;
            LoadProductTitle();
            LoadProductPrice();
            LoadComment();
            LoadPlan();
            LoadDescription();
            LoadPhoto();
            LoadTripDate();
            favo = FavoriteCheck.CheckFavo(btnCollect, ProductManager.ProductID);
        }



        private List<byte[]> photoList;
        private int currentIndex = 0;
        bool favo;


        private void LoadPhoto()
        {
            photoList = CommonClass.dbContext.ProductPhotoLists
                        .Where(p => p.ProductID == ProductManager.ProductID)
                        .Select(p => p.Photo)
                        .ToList();

            if (photoList.Count > 0)
            {
                DisplayPhoto(currentIndex);
            }
            else
            {
                MessageBox.Show("No pic!!");
            }

        }
        private void DisplayPhoto(int index)
        {
            byte[] photoBytes = photoList[index];
            using (MemoryStream ms = new MemoryStream(photoBytes))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnNextPic_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= photoList.Count)
            {
                currentIndex = 0;
            }
            DisplayPhoto(currentIndex);
        }

        private void btnPrePic_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = photoList.Count - 1;
            }
            DisplayPhoto(currentIndex);
        }

        private void LoadDescription()
        {
            var productDescription = CommonClass.dbContext.ProductLists.Where(p => p.ProductID == ProductManager.ProductID).Select(p => p.Description).FirstOrDefault();
            if (productDescription != null)
            {
                label7.Text = productDescription.ToString();
            }
        }

        private void LoadPlan()
        {
            //Load 方案名稱
            var planName = CommonClass.dbContext.ProductLists.Where(p => p.ProductID == ProductManager.ProductID).Select(p => p.PlanName).FirstOrDefault();
            if (planName != null)
            {
                labH1.Text = planName.ToString();
            }
            
            //Load 方案內容
            var planDescription = CommonClass.dbContext.ProductLists.Where(p => p.ProductID == ProductManager.ProductID).Select(p => p.PlanDescription).FirstOrDefault();
            if (planDescription != null)
            {
                label1.Text = planDescription.ToString();
            }
        }

        private void LoadProductPrice()
        {
            if (CommonClass.dbContext.Trips.Any(p => p.ProductID == ProductManager.ProductID))
            {
                //Load 價格
                var productPrice = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(t => t.UnitPrice).FirstOrDefault();
                labProPrice.Text = productPrice.ToString();
                labPrice.Text = productPrice.ToString();
                
                //Load 狀態
                if (CommonClass.dbContext.Trips.All(t => t.ProductID == ProductManager.ProductID && t.MaxNum == 0))
                {
                    labStatus.Text = "售完";
                    labStatus.ForeColor = Color.Gray;
                }
                else if (!CommonClass.dbContext.Trips.Any(t => t.ProductID == ProductManager.ProductID && t.Date >= DateTime.Now))
                {
                    labStatus.ForeColor = Color.Gray;                    
                    labStatus.Text = "已截止";
                }
                else
                {
                    labStatus.Text = "熱賣中";
                }
            }
        }
        private void LoadProductTitle()
        {
            //Load 大標題
            var productNames = CommonClass.dbContext.ProductLists.Where(p => p.ProductID == ProductManager.ProductID).Select(p => p.ProductName).FirstOrDefault();
            if (productNames != null)
            {
                labTitle.Text = productNames.ToString();
            }

            //Load 大綱小標
            var productOutline = CommonClass.dbContext.ProductLists.Where(p => p.ProductID == ProductManager.ProductID).Select(p => p.Outline).FirstOrDefault();
            if (productOutline != null)
            {
                labDescription.Text = productOutline.ToString();
            }
           
        }


        private List<string> Content;
        private List<string> Title;
        private List<string> LastName;
        private List<DateTime?> Date;
        private List<string> Gender;
        private List<int?> ComScore;
        private List<byte[]> MemPic;
        int curIndex = 0;

        private void LoadComment()
        {
            //todo
            Content = CommonClass.dbContext.CommentLists.Where(p => p.ProductID == ProductManager.ProductID).Select(c => c.Content).ToList();
            Title = CommonClass.dbContext.CommentLists.Where(p => p.ProductID == ProductManager.ProductID).Select(c => c.Title).ToList();
            var q1 = from c in CommonClass.dbContext.CommentLists
                     join m in CommonClass.dbContext.Members on c.MemberID equals m.MemberID
                     where c.ProductID == ProductManager.ProductID
                     select m.LastName;
            LastName = q1.ToList();
            Date = CommonClass.dbContext.CommentLists.Where(p => p.ProductID == ProductManager.ProductID).Select(c => c.Date).ToList();
            var q2 = from c in CommonClass.dbContext.CommentLists
                     from m in CommonClass.dbContext.Members
                     where c.ProductID == ProductManager.ProductID
                     where c.MemberID == m.MemberID
                     select m.Gender;
            Gender = q2.ToList();
            ComScore = CommonClass.dbContext.CommentLists.Where(p => p.ProductID == ProductManager.ProductID).Select(c => c.CommentScore).ToList();
            
            var q3 = from c in CommonClass.dbContext.CommentLists
                     from m in CommonClass.dbContext.Members
                     where c.ProductID == ProductManager.ProductID
                     where c.MemberID == m.MemberID
                     select m.Photo;
            MemPic = q3.ToList();

            DisplayComment(curIndex);
        }

        private void DisplayComment(int curIndex)
        {
            if (curIndex >= 0 && curIndex < Content.Count)
            {
                label10.Text = Content[curIndex];
                label13.Text = Title[curIndex];
                labMemName.Text = LastName[curIndex];

                if (MemPic[curIndex] != null)
                {
                    byte[] photoBytes = MemPic[curIndex];
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pictureBox7.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox7.Image = Properties.Resources.user;
                }


                if (Date[curIndex] != null)
                {
                    string dateString = Date[curIndex].ToString();
                    if (DateTime.TryParse(dateString, out DateTime date))
                    {
                        label12.Text = date.ToString("yyyy-MM-dd");
                    }
                }

                MaleORFemale();
                StarShow();
            }
        }

        private void StarShow()
        {
            flowLayoutPanel1.Controls.Clear();
            int star = (int)ComScore[curIndex];
            if (star == 1)
            {
                ShowStarYellowPic();

                for (int i = 0; i < 4; i++)
                {
                    ShowStarPic();
                }
            }
            else if (star == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    ShowStarYellowPic();
                }
                for (int i = 0; i < 3; i++)
                {
                    ShowStarPic();
                }
            }
            else if (star == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    ShowStarYellowPic();
                }
                for (int i = 0; i < 2; i++)
                {
                    ShowStarPic();
                }
            }
            else if (star == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    ShowStarYellowPic();
                }
                for (int i = 0; i < 1; i++)
                {
                    ShowStarPic();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    ShowStarYellowPic();
                }
            }
        }

        private void ShowStarPic()
        {
            PictureBox starImage = new PictureBox();
            starImage.Image = Properties.Resources.starRate;
            starImage.SizeMode = PictureBoxSizeMode.AutoSize;
            flowLayoutPanel1.Controls.Add(starImage);
        }

        private void ShowStarYellowPic()
        {
            PictureBox starYellowImage = new PictureBox();
            starYellowImage.Image = Properties.Resources.staryellow;
            starYellowImage.SizeMode = PictureBoxSizeMode.AutoSize;
            flowLayoutPanel1.Controls.Add(starYellowImage);
        }

        private void MaleORFemale()
        {
            string s = Gender[curIndex];
            if (s == "女")
            {
                labMemName.Text = LastName[curIndex] + " 小姐";
            }
            else if (s == "男")
            {
                labMemName.Text = LastName[curIndex] + " 先生";
            }
            else
            {
                labMemName.Text = LastName[curIndex];
            }
        }


        private void btnPreComment_Click(object sender, EventArgs e)
        {
            curIndex--;
            if (curIndex < Content.Count) { curIndex = 0; }
            DisplayComment(curIndex);
        }


        private void btnCommentNext_Click(object sender, EventArgs e)
        {
            curIndex++;
            if (curIndex >= Content.Count) { curIndex = 0; }
            DisplayComment(curIndex);
        }

        //修改資料庫裡的照片
        private void button8_Click(object sender, EventArgs e)  //修改資料庫裡的照片
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                //var pic = CommonClass.dbContext.ProductPhotoLists.FirstOrDefault(p => p.ProductPhotoListID == 10);
                var pic = CommonClass.dbContext.Members.FirstOrDefault(m=>m.MemberID == 2);

                if (pic != null)
                {
                    pic.Photo = imageBytes;
                    CommonClass.dbContext.SaveChanges();

                    MessageBox.Show("图片更新成功");
                }
            }
        }

        bool IsProgram = true;

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (IsProgram)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
            IsProgram = !IsProgram;
        }

        private void btnChoosePlan_Click(object sender, EventArgs e)
        {
            Control targetControl = btnTripDetails;
            ScrollControlIntoView(targetControl);
        }

        private void LoadTripDate()
        {
            if (CommonClass.dbContext.Trips.Any(p => p.ProductID == ProductManager.ProductID))
            {
                flowLayoutPanel2.Controls.Clear();

                var tripDateChoose = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(p => p.ProductID).ToList();
                //同一個productID有幾個tripID就流出幾個按鈕
                //在按鈕上呈現每個tripID的資料
                var tripDate = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(t => t.Date).ToList();
                var tripDatePrice = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(t => t.UnitPrice).ToList();

                var tripMaxNums = CommonClass.dbContext.Trips.Where(t => t.ProductID == ProductManager.ProductID).Select(t => t.MaxNum).ToList();

                for (int i = 0; i < tripDateChoose.Count; i++)
                {

                    GroupBox groupBox = new GroupBox();
                    groupBox.Size = new Size(140, 126);

                    Button button = new Button();
                    button.Location = new Point(13, 17);
                    button.Size = new Size(114, 73);
                    button.Text = tripDate[i].Value.ToString("MM/dd");

                    DateTime currentDate = DateTime.Now.Date;
                    int maxNum = (int)tripMaxNums[i];

                    if (maxNum == 0)
                    {
                        button.Enabled = false;
                        button.BackColor = Color.IndianRed;
                        button.ForeColor = Color.Gray;
                    }
                    else if (tripDate[i].Value.Date < currentDate)
                    {
                        button.Enabled = false;
                        button.BackColor = Color.DarkGray;
                        button.ForeColor = Color.Gainsboro;
                    }
                    else
                    {
                        button.BackColor = Color.LightSteelBlue;
                        button.ForeColor = Color.Black;
                    }

                    button.Click += Button_Click;
                    groupBox.Controls.Add(button);

                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Location = new Point(27, 93);
                    label.Size = new Size(86, 24);
                    if (maxNum == 0)
                    {
                        label.Text = "售完";
                        label.ForeColor = Color.IndianRed;
                    }
                    else if (tripDate[i].Value.Date < currentDate)
                    {
                        label.Text = "已截止";
                        label.ForeColor = Color.Gray;
                    }
                    else
                    {
                        label.ForeColor = Color.Green;
                        label.Text = "熱賣中";
                    }

                    groupBox.Controls.Add(label);

                    flowLayoutPanel2.Controls.Add(groupBox);
                }
            }
        }

        private Button selectedButton = null;
        private DateTime selectedDateTime = DateTime.MinValue;
        private Trip selectedTrip;

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (selectedButton == clickedButton)
            {
                // 取消選取按鈕
                clickedButton.FlatAppearance.BorderColor = SystemColors.Control;
                clickedButton.FlatAppearance.BorderSize = 1;
                clickedButton.FlatStyle = FlatStyle.Standard;
                selectedButton = null;
                var productPrice = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(t => t.UnitPrice).FirstOrDefault();
                labPrice.Text = productPrice.ToString();
                labNum.Text = "1";
                num = 1;
                selectedDateTime = DateTime.MinValue;
            }
            else
            {
                // 先取消先前選取的按鈕的紅框
                if (selectedButton != null)
                {
                    selectedButton.FlatAppearance.BorderColor = SystemColors.Control;
                    selectedButton.FlatAppearance.BorderSize = 1;
                    selectedButton.FlatStyle = FlatStyle.Standard;
                    labNum.Text = "1";
                    num = 1;
                    selectedDateTime = DateTime.MinValue;
                }

                // 選取新按鈕，顯示紅框
                clickedButton.FlatAppearance.BorderColor = Color.Red;
                clickedButton.FlatAppearance.BorderSize = 2;
                clickedButton.FlatStyle = FlatStyle.Flat;
                selectedButton = clickedButton;

                //選取的日期
                string selectedDate = clickedButton.Text;

                if (DateTime.TryParseExact(selectedDate, "MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out selectedDateTime))
                {
                    selectedTrip = CommonClass.dbContext.Trips.FirstOrDefault(t => t.ProductID == ProductManager.ProductID && t.Date == selectedDateTime);

                    if (selectedTrip != null)
                    {
                        decimal unitPrice = (decimal)selectedTrip.UnitPrice;
                        labPrice.Text = unitPrice.ToString();
                    }
                }
            }
        }


        int num = 1;

        private void btnAddnum_Click(object sender, EventArgs e)
        {
            if (selectedDateTime != DateTime.MinValue)
            {
                num++;
                labNum.Text = num.ToString();

                var selectedTrip = CommonClass.dbContext.Trips.FirstOrDefault(t => t.ProductID == ProductManager.ProductID && t.Date == selectedDateTime);

                if (selectedTrip != null)
                {
                    decimal unitPrice = (decimal)selectedTrip.UnitPrice;
                    decimal totalPrice = unitPrice * num;
                    labPrice.Text = totalPrice.ToString();
                }
            }
        }

        private void btnMinusnum_Click(object sender, EventArgs e)
        {
            if (num > 1)
            {
                num--;
                labNum.Text = num.ToString();
                if (selectedDateTime != null)
                {
                    var selectedTrip = CommonClass.dbContext.Trips.FirstOrDefault(t => t.ProductID == ProductManager.ProductID && t.Date == selectedDateTime);

                    if (selectedTrip != null)
                    {
                        decimal unitPrice = (decimal)selectedTrip.UnitPrice;
                        decimal totalPrice = unitPrice * num;
                        labPrice.Text = totalPrice.ToString();
                    }
                }
            }
        }

        private void btnRechoose_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedButton = null;
            selectedDateTime = DateTime.MinValue;
            // 重設所有按鈕的外框顏色
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    if (groupBox.Controls.Count > 0 && groupBox.Controls[0] is Button button)
                    {
                        button.FlatAppearance.BorderColor = SystemColors.Control;
                        button.FlatAppearance.BorderSize = 1;
                        button.FlatStyle = FlatStyle.Standard;
                    }
                }
            }

            var productPrice = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(t => t.UnitPrice).FirstOrDefault();
            labPrice.Text = productPrice.ToString();
            labNum.Text = "1";
            num = 1;
        }


        private void btnGOCart_Click(object sender, EventArgs e)
        {
            if (selectedDateTime != DateTime.MinValue)
            {
                if (Models.Login.MemberID != 0)
                {
                    //  如果Orders裡面有符合此會員的memberID及他的iscart = 1，則代表他有使用過購物車(EX: memberID = 1的，他有使用過，Orderid = 2 && ISCART == 1)
                    //  要確認他的orderdetails裡面是否已有相同的tripID(orderID = 2的是否有o.TripID == tripID)，如果有數量就加一，沒有就在新增一筆
                    if (CommonClass.dbContext.Orders.Any(o => o.MemberID == Models.Login.MemberID && o.IsCart == true))
                    {
                        int tripID = selectedTrip.TripID; // 取得選取的旅行的 TripID

                        if (CommonClass.dbContext.OrderDetails.Any(o => o.TripID == tripID && o.Order.MemberID == Models.Login.MemberID && o.Order.IsCart == true))
                        {
                            OrderDetail od = CommonClass.dbContext.OrderDetails.FirstOrDefault(o => o.TripID == tripID && o.Order.MemberID == Models.Login.MemberID && o.Order.IsCart == true);
                            od.Quantity += num;         // 更新數量
                        }
                        else
                        {
                            int cartOrderID = CommonClass.dbContext.Orders.FirstOrDefault(o => o.MemberID == Models.Login.MemberID && o.IsCart == true).OrderID;
                            OrderDetail newOrderDetail = new OrderDetail
                            {
                                Quantity = num,
                                TripID = tripID,
                                OrderID = cartOrderID
                            };
                            CommonClass.dbContext.OrderDetails.Add(newOrderDetail);
                        }
                        CommonClass.dbContext.SaveChanges();
                        MessageBox.Show("已加入購物車");
                    }
                    else  //代表此會員沒有用過購物車
                    {
                        Order newCartOrder = new Order
                        {
                            MemberID = (int)Models.Login.MemberID,
                            IsCart = true
                        };

                        CommonClass.dbContext.Orders.Add(newCartOrder);
                        CommonClass.dbContext.SaveChanges();

                        //取得新建購物車訂單的 OrderID
                        int newCartOrderID = newCartOrder.OrderID;

                        //用此 MemberID 新增一筆資料到 OrderDetails
                        OrderDetail newOrderDetail = new OrderDetail
                        {
                            Quantity = num,
                            TripID = selectedTrip.TripID,
                            OrderID = newCartOrderID
                        };

                        CommonClass.dbContext.OrderDetails.Add(newOrderDetail);
                        CommonClass.dbContext.SaveChanges();
                        MessageBox.Show("已加入購物車");
                    }

                    //清空選取的日期和數量
                    ClearAll();
                }
                else
                {
                    //跳轉到會員登入頁面
                    ClearAll();
                    MessageBox.Show("請先登入會員");
                }
            }
            else
            {
                MessageBox.Show("請選擇日期");
            }
        }

        private void ClearAll()
        {
            selectedButton.FlatAppearance.BorderColor = SystemColors.Control;
            selectedButton.FlatAppearance.BorderSize = 1;
            selectedButton.FlatStyle = FlatStyle.Standard;
            var productPrice = CommonClass.dbContext.Trips.Where(p => p.ProductID == ProductManager.ProductID).Select(t => t.UnitPrice).FirstOrDefault();
            labPrice.Text = productPrice.ToString();
            labNum.Text = "1";
            num = 1;
            selectedDateTime = DateTime.MinValue;
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (selectedDateTime != DateTime.MinValue)
            {
                if (Models.Login.MemberID != 0)
                {
                    //  如果Orders裡面有符合此會員的memberID及他的iscart = 1，則代表他有使用過購物車(EX: memberID = 1的，他有使用過，Orderid = 2 && ISCART == 1)
                    //  要確認他的orderdetails裡面是否已有相同的tripID(orderID = 2的是否有o.TripID == tripID)，如果有數量就加一，沒有就在新增一筆
                    if (CommonClass.dbContext.Orders.Any(o => o.MemberID == Models.Login.MemberID && o.IsCart == true))
                    {
                        int tripID = selectedTrip.TripID; // 取得選取的旅行的 TripID

                        if (CommonClass.dbContext.OrderDetails.Any(o => o.TripID == tripID && o.Order.MemberID == Models.Login.MemberID && o.Order.IsCart == true))
                        {
                            OrderDetail od = CommonClass.dbContext.OrderDetails.FirstOrDefault(o => o.TripID == tripID && o.Order.MemberID == Models.Login.MemberID && o.Order.IsCart == true);
                            od.Quantity += num;         //更新數量
                        }
                        else
                        {
                            int cartOrderID = CommonClass.dbContext.Orders.FirstOrDefault(o => o.MemberID == Models.Login.MemberID && o.IsCart == true).OrderID;
                            OrderDetail newOrderDetail = new OrderDetail
                            {
                                Quantity = num,
                                TripID = tripID,
                                OrderID = cartOrderID
                            };
                            CommonClass.dbContext.OrderDetails.Add(newOrderDetail);
                        }
                        CommonClass.dbContext.SaveChanges();
                    }
                    else  //代表此會員沒有用過購物車
                    {
                        Order newCartOrder = new Order
                        {
                            MemberID = (int)Models.Login.MemberID,
                            IsCart = true
                        };

                        CommonClass.dbContext.Orders.Add(newCartOrder);
                        CommonClass.dbContext.SaveChanges();

                        //取得新建購物車訂單的 OrderID
                        int newCartOrderID = newCartOrder.OrderID;

                        //用此 MemberID 新增一筆資料到 OrderDetails
                        OrderDetail newOrderDetail = new OrderDetail
                        {
                            Quantity = num,
                            TripID = selectedTrip.TripID,
                            OrderID = newCartOrderID
                        };

                        CommonClass.dbContext.OrderDetails.Add(newOrderDetail);
                        CommonClass.dbContext.SaveChanges();
                    }

                    //清空選取的日期和數量
                    ClearAll();

                    FrmCartTabPage frm = new FrmCartTabPage(selectedTrip.TripID);
                    frm.Show();  //todo開form到主panel
                }
                else
                {
                    //跳轉到會員登入頁面
                    ClearAll();
                    MessageBox.Show("請先登入會員");
                }
            }
            else
            {
                MessageBox.Show("請先選擇日期");
            }
        }

        private void btnTripDetails_Click(object sender, EventArgs e)
        {
            FrmTripDetials f = new FrmTripDetials();
            f.Show();
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            if (Models.Login.MemberID == 0)
            {
                MessageBox.Show("請先登入會員");
                return;
            }
            favo = FavoriteCheck.CheckFavo(btnCollect, ProductManager.ProductID);
            //加入最愛
            FavoriteCheck.AddRemoveFavo(favo, ProductManager.ProductID);

            favo = FavoriteCheck.CheckFavo(btnCollect, ProductManager.ProductID);
        }
    }
}

