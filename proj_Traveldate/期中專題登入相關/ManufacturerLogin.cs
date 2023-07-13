
using proj_Traveldate;
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

namespace proj_Traveldate
{
    public partial class ManufacturerLogin : Form
    {
        public ManufacturerLogin()
        {
            InitializeComponent();
            textBox1.MouseClick += TextBox1_MouseClick;
            textBox2.MouseClick += TextBox2_MouseClick;
        }
        TraveldateEntities dbContext = new TraveldateEntities();

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "請輸入帳號")
            {
                textBox1.Text = string.Empty; // 清空 TextBox 的文字}
            }

            else if (textBox2.Text == string.Empty)
            {
                textBox2.Text += "請輸入密碼";
            }
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "請輸入密碼")
            {
                textBox2.Text = string.Empty; // 清空 TextBox 的文字}
            }

            else if(textBox1.Text == string.Empty)
            {
                textBox1.Text += "請輸入帳號";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("撥打客服0982634020");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ManufacturerRegister Mrrr = new ManufacturerRegister();
            Mrrr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //檢查兩者是否都對應
            string phone = textBox1.Text;
            string password = textBox2.Text;

            Company matchedMember = dbContext.Companies.FirstOrDefault(c => c.Tax_ID_Number == phone && c.Password == password);

            if (matchedMember != null)
            {
                int companyID = matchedMember.CompanyID;
                Models.Login.ManufacturerID = companyID;

                //MessageBox.Show("給你過，CompanyID: " + companyID);
                //縮起此表單 看要到誰那
                MessageBox.Show("歡迎"+matchedMember.CompanyName+"企業登入");
                FrmHomePage frm =   new FrmHomePage();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("帳號或密碼不匹配");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " "; // 清空textBox1的內容
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear(); // 清空textBox1的內容
        }

        private void ManufacturerLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = "請輸入帳號";
            textBox2.Text = "請輸入密碼";

        }


    }
}
