using proj_Traveldate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate
{
    public partial class EmployeesManage : Form
    {
        public EmployeesManage()
        {
            InitializeComponent();
        }
        TraveldateEntities dbContext = new TraveldateEntities();

       

        private void EmployeesManage_Load(object sender, EventArgs e)
        {
            //讓下拉表單吃到資料庫的內容
            var query = from a in dbContext.Companies
                        select new
                        {
                            cpName = a.CompanyName,
                            cpID= a.CompanyID,
                        };
            comboBox1.Items.AddRange(query.Select(a => a.cpName).ToArray());

            //文字顯示登入者是誰
            Employee matchemployees = dbContext.Employees.FirstOrDefault(c => c.EmployeeID == Models.Login.EmployeeID);
            label3.Text = matchemployees.FirstName+"歡迎登入，這"+matchemployees.EmployeeAccount+"的管理平台";

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string companyName = comboBox1.SelectedItem.ToString();  // 選中的公司名稱定義字串
            var company = dbContext.Companies.FirstOrDefault(c => c.CompanyName == companyName);

            if (company != null)
            {
                int companyID = company.CompanyID;
                var productList = dbContext.ProductLists.ToList();  
                var filteredList = productList.Where(p => p.CompanyID == companyID).ToList();
                dataGridView1.DataSource = filteredList;
            }
            else
            {
                MessageBox.Show("沒有對應的資料~");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox2.Text=="已審核" && dataGridView1.DataSource != null)
            {
                MessageBox.Show("顯示審核的");
                string companyName = comboBox1.SelectedItem.ToString();
                var company = dbContext.Companies.FirstOrDefault(c => c.CompanyName == companyName);
                int companyID = company.CompanyID;
                var productList = dbContext.ProductLists.ToList();
                var filteredList = productList.Where(p => p.CompanyID == companyID && p.ExamineStatus == true).ToList();
                dataGridView1.DataSource = filteredList;





            }
            else if (comboBox2.Text=="未審核" && dataGridView1.DataSource != null)
            {
                MessageBox.Show("顯示未審核的");
                string companyName = comboBox1.SelectedItem.ToString();
                var company = dbContext.Companies.FirstOrDefault(c => c.CompanyName == companyName);
                int companyID = company.CompanyID;
                var productList = dbContext.ProductLists.ToList();
                var filteredList = productList.Where(p => p.CompanyID == companyID && p.ExamineStatus == false).ToList();
                dataGridView1.DataSource = filteredList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<int> selectedValues = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // 检查每行的复选框列是否被选中
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["btnSelect"] as DataGridViewCheckBoxCell;
                if (checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {
                    // 获取选中行的某个特定列的值
                    DataGridViewCell dataCell = row.Cells["ProductID"];
                    int value = (int)dataCell.Value;

                    // 将值添加到列表中
                    selectedValues.Add(value);

                    var q = from p in dbContext.ProductLists
                            where selectedValues.Contains(p.ProductID)
                            select p;
                    foreach (var i in q)
                    {
                        i.ExamineStatus = true;
                        i.Discontinued = true;
                    }
                    dbContext.SaveChanges();
                    MessageBox.Show("審核已通過");
                }
                else { /*MessageBox.Show("請選擇"); */}
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            var PDLT = from a in dbContext.ProductLists
                       where a.ProductName.Contains(searchText)
                       select new
                       {
                           ProductID = a.ProductID,
                           CompanyID = a.CompanyID,
                           ProductName = a.ProductName,
                           CityID = a.CityID,
                           Description = a.Description,
                           ProductTypeID = a.ProductTypeID,
                           ExamineStatus = a.ExamineStatus,
                           PlanName = a.PlanName,
                           PlanDescription = a.PlanDescription,
                           Discontinued = a.Discontinued,
                           Outline = a.Outline
                           //補上少的
                       };

            dataGridView1.DataSource = PDLT.ToList();
        }
    }
}
