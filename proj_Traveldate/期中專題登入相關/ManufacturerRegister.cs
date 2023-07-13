
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.Entity;
using proj_Traveldate;

namespace proj_Traveldate
{
    public partial class ManufacturerRegister : Form
    {
        public ManufacturerRegister()
        {
            InitializeComponent();
        }
        TraveldateEntities dbContext = new TraveldateEntities();



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //以下來增加判斷方式

            bool isTax_ID_Number = false;
            bool isCompanyName = false;
            bool isCountry = false;
            bool isCity = false;
            bool isPostalCode = false;
            bool isAddress = false;
            bool isPhone = false;
            bool isURL = false;
            bool isPrincipal = false;
            bool isContact = false;
            bool isTitle = false;
            bool isEmail = false;
            bool isPassword = false;
            bool isServerDescription = false;

            //公司名稱部分
            string CompanyName = textBox1.Text;
            if (!string.IsNullOrEmpty(CompanyName))
            {
                isCompanyName = true;
            }
            else
            {
                MessageBox.Show("公司名稱需要填寫哦~");
            }
            //公司統一編號部分
            string Tax_ID_Number = textBox2.Text;
            //檢查資料庫是中是否有輸入過相同的Tax_ID_Number
            bool isDuplicate = dbContext.Companies.Any(c => c.Tax_ID_Number == Tax_ID_Number);
            //判斷兩者都成立才給過XD
            if (!string.IsNullOrEmpty(Tax_ID_Number)&& !isDuplicate)
            {
                isTax_ID_Number = true;
            }
            else
            {
                MessageBox.Show("請填寫貴公司正確統一編號。如有被使用過請聯絡客服");
            }
            //國家部分
            string Country = comboBox1.Text;
            if (!string.IsNullOrEmpty(Country))
            {
                isCountry = true;
            }
            else
            {
                MessageBox.Show("國家需要填寫哦~");
            }
            //地區部分
            string City = comboBox2.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(City))
            {
                isCity = true;
            }
            else
            {
                MessageBox.Show("請選地區");
            }

            //郵遞區號部分
            string PostalCode = textBox7.Text;
            if (!string.IsNullOrEmpty(PostalCode))
            {
                isPostalCode = true;
            }
            else
            {
                MessageBox.Show("郵遞區號需要填寫哦~");
            }
            //地址部分
            string Address = textBox3.Text;
            if (!string.IsNullOrEmpty(Address))
            {
                isAddress = true;
            }
            else
            {
                MessageBox.Show("地址需要填寫哦~");
            }
            //電話部分
            string Phone = textBox5.Text;
            if (!string.IsNullOrEmpty(Phone))
            {
                isPhone = true;
            }
            else
            {
                MessageBox.Show("電話需要填寫哦~");
            }
            //網址部分
            string URL = textBox4.Text;
            if (!string.IsNullOrEmpty(URL))
            {
                isURL = true;
            }
            else
            {
                MessageBox.Show("公司網址需要填寫哦~");
            }
            //負責人部分
            string Principal = textBox9.Text;
            if (!string.IsNullOrEmpty(Principal))
            {
                isPrincipal = true;
            }
            else
            {
                MessageBox.Show("負責人需要填寫哦~");
            }
            //聯絡人部分
            string Contact = textBox10.Text;
            if (!string.IsNullOrEmpty(Contact))
            {
                isContact = true;
            }
            else
            {
                MessageBox.Show("聯絡人需要填寫哦~");
            }
            //職稱部分
            string Title = textBox12.Text;
            if (!string.IsNullOrEmpty(Title))
            {
                isTitle = true;
            }
            else
            {
                MessageBox.Show("職稱需要填寫哦~");
            }
            //EMAIL部分
            string Email = textBox6.Text;
            if (!string.IsNullOrEmpty(Email))
            {
                isEmail = true;
            }
            else
            {
                MessageBox.Show("Email需要填寫哦~");
            }
            //密碼部分
            string Password = textBox8.Text;
            if (!string.IsNullOrEmpty(Password))
            {
                isPassword = true;
            }
            else
            {
                MessageBox.Show("Password需要填寫哦~");
            }
            //服務概述部分
            string ServerDescription = textBox11.Text;
            if (!string.IsNullOrEmpty(ServerDescription))
            {
                isServerDescription = true;
            }
            else
            {
                MessageBox.Show("服務概述需要填寫哦~");
            }

            // 检查各個条件的验证结果
            if (isTax_ID_Number == true &&
                isCompanyName == true &&
                isCountry == true &&
                isCity == true &&
                isPostalCode == true &&
                isAddress == true &&
                isPhone == true &&
                isURL == true &&
                isPrincipal == true &&
                isContact == true &&
                isTitle == true &&
                isEmail == true &&
                isPassword == true &&
                isServerDescription == true 
                )

            {
                //// 從 ComboBox 取得縣市名稱
                //string cityName = comboBox2.Text;
                //var city = dbContext.CityList.FirstOrDefault(c => c.City == cityName);
                //int cityID = city.CityID;
                
                
                Company db = new Company()
                       {
                    CompanyName = textBox1.Text,
                    Tax_ID_Number = textBox2.Text,
                    Country = comboBox1.SelectedItem.ToString(),
                    City = comboBox2.Text,
                    PostalCode = textBox7.Text,
                    Address = textBox3.Text,
                    Phone = textBox5.Text,
                    URL = textBox4.Text,
                    Principal = textBox9.Text,
                    Contact = textBox10.Text,
                    Title = textBox12.Text,
                    Email = textBox6.Text,
                    Password = textBox8.Text,
                    ServerDescription = textBox11.Text,
                   };
                this.dbContext.Companies.Add(db);
                this.dbContext.SaveChanges();
                MessageBox.Show("註冊成功");
            }















        }

        private void ManufacturerRegister_Load(object sender, EventArgs e)
        {
            //以下是讓comboBox2吃到CityList裡面的City內容
            var query = from a in dbContext.CityLists
                        select new
                        {
                            City = a.City,
                            CityID = a.CityID
                        };
            comboBox2.Items.AddRange(query.Select(a => a.City).ToArray());



            //以下是預設選取國家第一個
            if (comboBox1.Items.Count > 0)
            {
                // 設置選取第一個項目
                comboBox1.SelectedIndex = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManufacturerLogin lg = new ManufacturerLogin();
            lg.Show();
            this.Hide();
        }
    }
}
