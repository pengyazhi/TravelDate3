using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using proj_Traveldate.Models;

namespace proj_Traveldate
{
    public partial class FrmAnalysis : Form
    {
        public FrmAnalysis()
        {
            InitializeComponent();
            

            var q1 = CommonClass.dbContext.ProductLists.Where(t => t.CompanyID == Models.Login.ManufacturerID).Select(p => p.CityList.City);
            List<string> city = q1.Distinct().ToList();
            foreach (string i in city)
                this.cbbProductArea.Items.Add(i);

            var q2 = CommonClass.dbContext.ProductLists.Where(c => c.CompanyID == Models.Login.ManufacturerID).Select(p => p.ProductTypeList.ProductType);
            List<string> type = q2.Distinct().ToList();
            foreach (string i in type)
                this.cbbCategory.Items.Add(i);
        }
        

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            //年齡分布
            DateTime currentDate = DateTime.Now;
            var q = from member in CommonClass.dbContext.OrderDetails.AsEnumerable()
                                 let age = currentDate.Year - member.Order.Member.BirthDate.Value.Year
                                 where member.Trip.ProductList.ProductTypeList.ProductType==cbbCategory.Text&&member.Trip.Date>dateFrom.Value&& member.Trip.Date < dateTo.Value
                    group member by age / 10 into ageGroup
                                 orderby ageGroup.Key
                                 select new
                                 {
                                     AgeRange = $"{ageGroup.Key * 10}-{ageGroup.Key * 10 + 9}",
                                     Members = ageGroup.Count()
                                 };
              Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            foreach (var group in q)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = group.AgeRange;
                dataPoint.YValues = new double[] { group.Members };
                series.Points.Add(dataPoint);
            }
                  
            chart1.Series.Add(series);
           
            
            //性別分布
            var q2 = from m in CommonClass.dbContext.OrderDetails.AsEnumerable()
                     where m.Trip.ProductList.ProductTypeList.ProductType == cbbCategory.Text && m.Trip.Date > dateFrom.Value && m.Trip.Date < dateTo.Value
                     group m by m.Order.Member.Gender into g
                     select new { gender = g.Key, count = g.Count() };
             Series series2 = new Series();
            series2.ChartType = SeriesChartType.Pie;
            foreach (var group in q2)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = group.gender;
                dataPoint.YValues = new double[] { group.count };
                series2.Points.Add(dataPoint);
            }
              chart2.Series.Add(series2);
            //時間分布
            var q3 = from p in CommonClass.dbContext.OrderDetails.AsEnumerable()
                     where p.Trip.ProductList.ProductTypeList.ProductType == cbbCategory.Text && p.Trip.Date > dateFrom.Value && p.Trip.Date < dateTo.Value
                     group p by new {p.Trip.Date.Value.Year, p.Trip.Date.Value.Month} into g
                     select new { Year = g.Key.Year,Month= g.Key.Month, count = g.Count() };
            Series series3 = new Series();
            series3.ChartType = SeriesChartType.Column;
            foreach (var group in q3)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = $"{group.Year}-{group.Month}";
                dataPoint.YValues = new double[] { group.count };
                series3.Points.Add(dataPoint);
            }
            chart3.Series.Add(series3);
        }

        private void cbbProductArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            //年齡分布
            DateTime currentDate = DateTime.Now;
            var q = from member in CommonClass.dbContext.OrderDetails.AsEnumerable()
                    let age = currentDate.Year - member.Order.Member.BirthDate.Value.Year
                    where member.Trip.ProductList.CityList.City == cbbProductArea.Text && member.Trip.Date > dateFrom.Value && member.Trip.Date < dateTo.Value
                    group member by age / 10 into ageGroup
                    orderby ageGroup.Key
                    select new
                    {
                        AgeRange = $"{ageGroup.Key * 10}-{ageGroup.Key * 10 + 9}",
                        Members = ageGroup.Count()
                    };
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            foreach (var group in q)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = group.AgeRange;
                dataPoint.YValues = new double[] { group.Members };
                series.Points.Add(dataPoint);
            }
             chart1.Series.Add(series);
            //性別分布
            var q2 = from m in CommonClass.dbContext.OrderDetails.AsEnumerable()
                     where m.Trip.ProductList.CityList.City == cbbProductArea.Text && m.Trip.Date > dateFrom.Value && m.Trip.Date < dateTo.Value
                     group m by m.Order.Member.Gender into g
                     select new { gender = g.Key, count = g.Count() };
            Series series2 = new Series();
            series2.ChartType = SeriesChartType.Pie;
            foreach (var group in q2)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = group.gender;
                dataPoint.YValues = new double[] { group.count };
                series2.Points.Add(dataPoint);
            }
            chart2.Series.Add(series2);
            //時間分布
            var q3 = from p in CommonClass.dbContext.OrderDetails.AsEnumerable()
                     where p.Trip.ProductList.CityList.City == cbbProductArea.Text && p.Trip.Date > dateFrom.Value && p.Trip.Date < dateTo.Value
                     group p by new { p.Trip.Date.Value.Year, p.Trip.Date.Value.Month } into g
                     select new { Year = g.Key.Year, Month = g.Key.Month, count = g.Count() };
            Series series3 = new Series();
            series3.ChartType = SeriesChartType.Column;
            foreach (var group in q3)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = $"{group.Year}-{group.Month}";
                dataPoint.YValues = new double[] { group.count };
                series3.Points.Add(dataPoint);
            }
            chart3.Series.Add(series3);
        }
    }
}
