using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace proj_Traveldate.Models
{
    public class DateTimeManger
    {
        internal DateTimeManger() 
        {
            LoadDateTimePicker();
        }
        public DateTimePicker startTime = new DateTimePicker();
        public DateTimePicker endTime = new DateTimePicker();
        private void LoadDateTimePicker()
        {
            //設置dateTime屬性
            startTime.Width = endTime.Width = 125;
            startTime.Height = endTime.Height = 25;
            startTime.Location = new Point(10, 28);
            endTime.Location = new Point(175, 28);



            DateTime maxDate = CommonClass.dbContext.Trips.AsEnumerable().Where(n => CommonClass.confirmedID.Contains((int)n.ProductID))
                .Select(n => n.Date.Value).Max();
            startTime.MinDate = endTime.MinDate = DateTime.Now;
            startTime.MaxDate = endTime.MaxDate = maxDate;
            //設置dateTimePicker的事件
            startTime.ValueChanged += StartTime_ValueChanged;
            endTime.ValueChanged += EndTime_ValueChanged;
         }

        //設置dateTimePicker的選擇邏輯
        private void StartTime_ValueChanged(object sender, EventArgs e)
        {
            if (startTime.Value > endTime.Value)
            {
                MessageBox.Show("開始時間不能大於結束時間,請重新選擇日期");
                startTime.Value = endTime.Value;
            }
        }
        private void EndTime_ValueChanged(object sender, EventArgs e)
        {
            if (startTime.Value > endTime.Value)
            {
                MessageBox.Show("開始時間不能大於結束時間,請重新選擇日期");
                endTime.Value = startTime.Value;
            }
        }
    }
}
