
using proj_Traveldate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj_Traveldate
{
    public partial class Login : Form
    {
        public Login()
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

            else if (textBox1.Text == string.Empty)
            {
                textBox1.Text += "請輸入帳號";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            ManufacturerLogin form2 = new ManufacturerLogin();
            form2.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
            string password = textBox2.Text;

            Member matchedMember = dbContext.Members.FirstOrDefault(c => c.Phone == phone && c.Password == password);
            Employee matchemployees = dbContext.Employees.FirstOrDefault(c =>c.EmployeeAccount==phone && c.EmployeePassword == password);



            if (matchedMember != null)
            {
                int memberID = matchedMember.MemberID;
                string LName = matchedMember.LastName;
                string FName = matchedMember.FirstName;

                Models.Login.MemberID = memberID;
                MessageBox.Show(LName+ FName + "， 歡迎登入 ");
                //縮起此表單 看要到誰那
               FrmHome rrr = new FrmHome();

                this.Hide();
                rrr.Show();
            }
            else if (matchemployees != null)//公司員工登入部分
            {
                int employeesID = matchemployees.EmployeeID;
                Models.Login.EmployeeID = employeesID;
                MessageBox.Show("您是第" + employeesID+"號管理員，歡迎登入");
                //縮起此表單 看要到誰那
                EmployeesManage em = new EmployeesManage();
                em.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("帳號或密碼不匹配");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("撥打客服0982634020");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register rrr = new Register();
            rrr.Show();
            this.Hide();
        }




    }
}
