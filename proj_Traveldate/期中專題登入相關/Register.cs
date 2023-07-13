
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlTypes;
using System.Drawing.Imaging;

using proj_Traveldate;

namespace proj_Traveldate
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        TraveldateEntities dbContext = new TraveldateEntities();

        byte[] imag;



        private void button2_Click(object sender, EventArgs e)
        {



            //以下來增加判斷方式

            bool isNameValid=false;
            bool isGenderValid = false;
            bool isIdNumberValid = false;
            bool isBirthValid=false;
            bool isCityValid=false;
            bool isPhoneValid=false;
            bool isEmailValid=false;
            bool isPasswordValid=false;
            bool isPhotoValid=false;
            
            //姓名部分
            string lastName = textBox1.Text;
            string firstName = textBox2.Text;

            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName))
            {
                isNameValid = true;
            }
            else
            {
                MessageBox.Show("姓和名都要填寫哦");
            }


            // 性別部分
            string selectedGender = comboBox1.SelectedItem?.ToString();  // 使用空值传递运算符 "?." 进行空值检查
            if (!string.IsNullOrEmpty(selectedGender) && (selectedGender == "男生" || selectedGender == "女生"))
            {
                isGenderValid = true;
            }
            else
            {
                MessageBox.Show("請選擇性別");
            }

            // 身分證部分
            string idNumber = textBox3.Text;
            string pattern = @"^[A-Z][0-9]{9}$"; // 正規表達式模式
            //檢查是否有存過了
            bool isDuplicate = dbContext.Members.Any(c => c.IDNumber == idNumber);
            if (Regex.IsMatch(idNumber, pattern)&& !isDuplicate)
            {
                isIdNumberValid = true;
            }
            else
            {
                MessageBox.Show("請輸入大寫身分證英文+後九碼數字，如有註冊過請聯絡客服");
            }

            //出生日期部分
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime today = DateTime.Today;

            if (selectedDate <= today)
            {
                isBirthValid = true;
            }
            else
            {
                MessageBox.Show("您還未出生，請輸入您真正的生日");
            }

            //地區部分
            string selectedCityID = comboBox2.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCityID))
            {
                isCityValid = true;
            }
            else
            {
                MessageBox.Show("請選地區");
            }

            //手機驗證部分
            string phone = textBox5.Text;
            string phonepattern = @"^[0-0][9-9][0-9]{8}$"; // 正規表達式模式
            if (Regex.IsMatch(phone, phonepattern))
            {
                isPhoneValid = true;
            }
            else
            {
                MessageBox.Show("請輸入正確規格的手機號碼");
            }
            //驗證電子郵件格式
            string email = textBox6.Text.Trim();
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            if (Regex.IsMatch(email, emailPattern))
            {
                isEmailValid = true;
            }
            else
            {
                MessageBox.Show("請輸入正確的電子郵件格式");
            }

            //密碼驗證(至少四碼
            string Password = textBox8.Text;


            if (Password.Length >= 4)
            {
                isPasswordValid = true;
            }
            else
            {
                MessageBox.Show("密碼至少4位");
            }

            //判斷有無圖片@@

            if (pictureBox1.Image == null)
            {
                isPhotoValid = true;

            }
            else
            {
                isPhotoValid = true;
                //圖片轉值部分
                byte[] imageData;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat); // 保存图像为原始格式
                    imageData = memoryStream.ToArray(); // 将内存流中的图像数据转换为字节数组
                }
                imag = imageData;

            }


            // 检查各個条件的验证结果
            if (isGenderValid == true && 
                isIdNumberValid == true&&
                isNameValid== true&&  
                isBirthValid == true &&
                isCityValid == true &&
                isPhoneValid == true &&
                isEmailValid == true &&
                isPasswordValid== true &&
                isPhotoValid == true 
                )

            {
                // 從 ComboBox 取得縣市名稱
                string cityName = comboBox2.Text; 
                var city = dbContext.CityLists.FirstOrDefault(c => c.City == cityName);
                int cityID = city.CityID;



                Member db = new Member
                {
                    LastName = textBox1.Text,
                    FirstName = textBox2.Text,
                    Gender = comboBox1.SelectedItem.ToString(),
                    IDNumber = textBox3.Text,
                    BirthDate = dateTimePicker1.Value,
                    CityID = cityID,
                    Phone = textBox5.Text,
                    Email = textBox6.Text,
                    Password = textBox8.Text,
                    LevelID = 1,
                    Discount = 0,
                    Photo = imag

                };
                this.dbContext.Members.Add(db);
                this.dbContext.SaveChanges();
                MessageBox.Show("註冊成功");

                Login lg = new Login();
                lg.Show();
                this.Hide();
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            //以下是讓comboBox2吃到CityList裡面的City內容
            var query = from a in dbContext.CityLists
                        select new
                        {
                            City = a.City,
                            CityID = a.CityID
                        };
            comboBox2.Items.AddRange(query.Select(a => a.City).ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // 将图像文件加载到 pictureBox1
                pictureBox1.Image = Image.FromFile(filePath);
            }






        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
