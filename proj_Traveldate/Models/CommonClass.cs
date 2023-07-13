using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate.Models
{
    internal class CommonClass
    {
        //實體資料庫資料庫連線
        public static TraveldateEntities dbContext = new TraveldateEntities();

       //篩出符合條件的商品ID
        public static List<int> confirmedID = dbContext.Trips.Where(n => n.ProductList.ExamineStatus == true && n.ProductList.Discontinued == false && n.ProductID == n.ProductList.ProductID).Select(n => (int)n.ProductID).ToList();
       
          //右邊產品顯示的flowlayoutpanel
        static public FlowLayoutPanel prodPanel = new FlowLayoutPanel();
        //設置右邊產品顯示的flowlayoutpanel
        public static void SetProdInfo(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Location = new Point(110, 0);
            flowLayoutPanel.Size = new Size(630, 726);
            flowLayoutPanel.Anchor = AnchorStyles.Left/* | AnchorStyles.Right*/ | AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.AutoScroll = true;

        }
      //設置搜尋頁面上計算幾項體驗行程的lable
        public static void SetCountProdLabel(System.Windows.Forms.Label label, int controlsCount)
        {
            //System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            label.Font = new Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label.Size = new Size(196, 31);
            label.Location = new Point(323, 40);
            label.Text = $"{controlsCount}  項體驗行程";
        }
       
    }
}
