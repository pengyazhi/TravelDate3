using proj_Traveldate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate.金負責區_LoginPage_Member
{
    public partial class FrmComment : Form
    {
        public FrmComment()
        {
            InitializeComponent();
        }

        private void btnSaveComment_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtComment.Text == ""||comboBoxScore.Text=="")
            {
                MessageBox.Show("請輸入評論");
            }
            else
            {
                string title = txtTitle.Text;
                string content = txtComment.Text;
                int score = Convert.ToInt32(comboBoxScore.Text);
                int prodID = Convert.ToInt32(Tag);
                //LoginPage_Member_會員登入 loginPage_Member = new LoginPage_Member_會員登入();
               // int memberID = 1;
                int memberID = Models.Login.MemberID;
                DateTime now = DateTime.Now;
                //insert資料到db
                try
                {
                    var newComment = new CommentList
                    {
                        Title = title,
                        Content = content,
                        CommentScore = score,
                        ProductID = prodID,//TODO 出現INSERT錯誤
                        MemberID = memberID,
                        Date = now,
                    };
                    CommonClass.dbContext.CommentLists.Add(newComment);
                    CommonClass.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("謝謝您的評論");
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此次評論將不會保留");
            if(DialogResult == DialogResult.OK)
            {
                Close();
            }
            
        }
    }
}
