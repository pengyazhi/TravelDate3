using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Traveldate.Models
{
    internal class RegionManger
    {
        //public TreeView tvRegion = new TreeView();
        //public TreeNode tnCountry = new TreeNode();
        //public TreeNode tnCity = new TreeNode();
        //public RegionManger ()
        //{
        //    //設置tvRegion屬性
        //    tvRegion.Dock = DockStyle.Fill;
        //    tvRegion.CheckBoxes = true;

        //    var q = CommonClass.dbContext.ProductLists.AsEnumerable().
        //        Where(
        //        n => CommonClass.ConfirmedProductID().Contains(n.ProductID)
        //        && n.CityID == n.CityList.CityID
        //        && n.CityList.CountryID == n.CityList.CountryList.CountryID).
        //        GroupBy(n => n.CityList.CountryList.Country).
        //        Select(g=> new 
        //        {
        //            Country = g.Key,
        //            City = g.Select(n=>n.CityList.City).Distinct(),
                    
        //        });
           

        //    foreach (var p in q)
        //    {
        //        tnCountry = tvRegion.Nodes.Add($"{p.Country} ({p.City.Count()})");
        //        foreach (string c in p.City)
        //        {
        //            tnCity = tnCountry.Nodes.Add(c);
        //        }
        //    }
        //}
    }
}
