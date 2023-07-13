//using proj_Traveldate.fieldBox;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Drawing;
//using proj_Traveldate.searchUIRev;

//namespace proj_Traveldate.Models
//{
//    internal class TEST
//    {
       
//        public TEST()
//        {
//           ddd(All_Product); 
            
//        }
//        public static List<ProductBox> ProductBoxes { get; set; } = new List<ProductBox>();
//        public  FlowLayoutPanel All_Product = new FlowLayoutPanel();
//       //public static Label label = new Label();
//        public void ddd(FlowLayoutPanel add_panel, FrmsearchUIRev frm)
//        {
//            add_panel.Controls.Clear();
//            //SetLabel();
//            CommonClass.SetProdInfo(All_Product);
//            var q1 = CommonClass.dbContext.Trips.AsEnumerable()
//               .Where(n => CommonClass.confirmedID.Contains((int)n.ProductID)).
//               GroupBy(n => n.ProductID)
//               .Select(g => new
//               {
//                   ProductID = g.Key,
//                   ProductName = g.Select(n => n.ProductList.ProductName),
//                   ProductOultine = g.Select(n => n.ProductList.Outline),
//                   ProductCity = g.Select(n => n.ProductList.CityList.City),
//                   ProductDate = g.Select(n => n.Date).Max(),
//                   ProducPriec = g.Select(n => n.UnitPrice).Min()
//               });

//            var q2 = CommonClass.dbContext.CommentLists.GroupBy(n => n.ProductID)
//                .Select(n => new
//                {
//                    ProductID = n.Key,
//                    ProductScoreAvg = n.Select(x => x.CommentScore).Average(),
//                    ProductScoreCount = n.Select(x => x.CommentScore).Distinct().Count()
//                });
//            var q3 = CommonClass.dbContext.ProductPhotoLists.GroupBy(n => n.ProductID)
//                .Select(n => new
//                {
//                    ProductID = n.Key,
//                    ProductPhoto = n.Select(x => x.Photo).FirstOrDefault()
//                });
//            var q4 = CommonClass.dbContext.ProductTagLists
//                .Where(n => n.ProductID == n.ProductList.ProductID && n.ProductTagDetailsID == n.ProductTagDetail.ProductTagDetailsID)
//                .GroupBy(n => n.ProductID)
//                .Select(n => new
//                {
//                    ProductID = n.Key,
//                    ProductTags = n.Select(x => x.ProductTagDetail.ProductTagDetailsName)
//                });


//            var query = from y in q1
//                        join x in q2 on y.ProductID equals x.ProductID
//                        join z in q3 on y.ProductID equals z.ProductID
//                        join a in q4 on y.ProductID equals a.ProductID
//                        select new
//                        {
//                            y.ProductID,
//                            y.ProductName,
//                            y.ProductOultine,
//                            y.ProductCity,
//                            y.ProductDate,
//                            y.ProducPriec,
//                            x.ProductScoreAvg,
//                            x.ProductScoreCount,
//                            z.ProductPhoto,
//                            a.ProductTags
//                        };

//            foreach (var item in query.ToList())
//            {
//                //實作productBox
//                ProductBox productBox = new ProductBox();
//                //顯示ProductPhotoLists中每個product的第一張照片
//                byte[] photos = item.ProductPhoto;/*Select(n => n.prodPic.Photo).FirstOrDefault()*/;
//                System.IO.MemoryStream ms = new System.IO.MemoryStream(photos);
//                productBox._Image = Image.FromStream(ms);
//                productBox.productPicSize = PictureBoxSizeMode.Zoom;

//                //顯示每筆product的Title
//                productBox._productTitle = item.ProductName.FirstOrDefault();
//                //顯示每筆product的Price
//                productBox._productPrice = item.ProducPriec.HasValue ? $"{item.ProducPriec.Value:c0}" : "N/A";
//                //productBox._productPrice = $"{item.ProducPriec.Value.Min():c0}";
//                //顯示每筆product的Outline
//                productBox._productOutline = item.ProductOultine.FirstOrDefault();
//                //顯示每筆product的totalCommentScore/count
//                productBox._productScore = $"{item.ProductScoreAvg} ({item.ProductScoreCount})";
//                //顯示每筆product的date
//                productBox._prodDate = item.ProductDate.Value.ToString();

//                //加入每筆product的city
//                productBox._prodCity = item.ProductCity.FirstOrDefault();
//                //加入每筆product的id
//                productBox._productID = (int)item.ProductID;
//                //加入每筆product的date
//                productBox._prodDateTag = item.ProductDate.Value;
//                //加入每筆product的tags
//                foreach (var item1 in item.ProductTags)
//                {
//                    if (!productBox._productTags.Contains(item1))
//                    {
//                        productBox._productTags.Add(item1);
//                    }
//                    else
//                    {
//                        continue;
//                    }
//                }
//                //將所有控制項放到一個List<productBoxes>之後重複使用
//                ProductBoxes.Add(productBox);
//                //全部產品資訊加到panel控制項
//                add_panel.Controls.Add(productBox);

//                frm1 = frm;
                
//                frm1.labCountProd.Text = $"{add_panel.Controls.Count}  項體驗行程";
//                frm1.panel13.Controls.Add(add_panel);
//            }
//        }

//        //private void SetLabel()
//        //{
//        //    label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
//        //    label.AutoSize = true;
//        //    label.Location = new Point(323, 22);
//        //    label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
//        //}
//    }
//}


