using proj_Traveldate.fieldBox;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proj_Traveldate.Models
{

    internal class ProductBoxManger
    {
        public ProductBoxManger()
        {
            LoadProductPicData();
        }
        public static List<ProductBox> allProductBoxes { get; set; } = new List<ProductBox>();
        public static List<ProductBox> nowProductBoxes { get; set; } = new List<ProductBox>();

        public static Label initLabel = new Label();
        public static void LoadProductPicData()
        {
            CommonClass.prodPanel.Controls.Clear();
            CommonClass.SetProdInfo(CommonClass.prodPanel);

            //先篩選出符合條件的product
            var q_product = CommonClass.dbContext.Trips.AsEnumerable()
               .Where(n => CommonClass.confirmedID.Contains((int)n.ProductID)).
               GroupBy(n => n.ProductID)
               .Select(g => new
               {
                   ProductID = g.Key,
                   ProductName = g.Select(n => n.ProductList.ProductName),
                   ProductOultine = g.Select(n => n.ProductList.Outline),
                   ProductCity = g.Select(n => n.ProductList.CityList.City).Distinct(),
                   ProductDate = g.Select(n => n.Date).Max(),
                   ProducPriec = g.Select(n => n.UnitPrice).Min(),
                   ProductType = g.Select(n => n.ProductList.ProductTypeList.ProductType).Distinct()
               });

            #region 把資料加到實作productBox
            foreach (var item in q_product.ToList())
            {
                //實作productBox
                ProductBox productBox = new ProductBox();

                //顯示ProductPhotoLists中每個product的第一張照片
                var q_photo = CommonClass.dbContext.ProductPhotoLists.Where(n => item.ProductID == n.ProductID).Select(n => n.Photo);
                byte[] photos = q_photo.FirstOrDefault();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(photos);
                productBox._Image = Image.FromStream(ms);
                productBox.productPicSize = PictureBoxSizeMode.Zoom;

                //顯示每筆product的Title
                productBox._productTitle = item.ProductName.FirstOrDefault();

                //顯示每筆product的Price(最低價格)
                productBox._productPriceText = item.ProducPriec.HasValue ? $"{item.ProducPriec.Value:c0}" : "N/A";
                productBox._productPrice = (int)item.ProducPriec;

                //顯示每筆product的Outline
                productBox._productOutline = item.ProductOultine.FirstOrDefault();

                //顯示每筆product的totalCommentScore/count
                var q_score = CommonClass.dbContext.CommentLists.Where(n => n.ProductID == item.ProductID).Select(n => n.CommentScore);
                productBox._productScore = $"{q_score.Average():0.0} ({q_score.Count()})";

                //加入每筆product的Type
                productBox._prodType = item.ProductType.FirstOrDefault();

                //顯示每筆product的date(最遠日期)
                productBox._prodDate = $"{item.ProductDate.Value:d} 前";
                productBox._prodDateTag = (DateTime)item.ProductDate;

                //加入每筆product的city
                productBox._prodCity = item.ProductCity.FirstOrDefault();
                foreach (var city in item.ProductCity)
                {
                    if (!productBox._productCitys.Contains(city))
                    {
                        productBox._productCitys.Add(city);
                    }
                }

                //加入每筆product的id
                productBox._productID = (int)item.ProductID;


                //加入每筆product的tags
                var q_tag = CommonClass.dbContext.ProductTagLists
           .Where(n => n.ProductID == item.ProductID && n.ProductTagDetailsID == n.ProductTagDetail.ProductTagDetailsID)
           .Select(n => n.ProductTagDetail.ProductTagDetailsName);
                foreach (var item1 in q_tag)
                {
                    if (!productBox._productTags.Contains(item1))
                    {
                        productBox._productTags.Add(item1);
                    }
                }
                //將所有控制項放到一個List<productBoxes>之後重複使用
                allProductBoxes.Add(productBox);
              
                //全部產品資訊加到panel控制項
                CommonClass.prodPanel.Controls.Add(productBox);

            }
            #endregion 把資料加到實作productBox
            CommonClass.SetCountProdLabel(initLabel, CommonClass.prodPanel.Controls.Count);
        }
    }
}
