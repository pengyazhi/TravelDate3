using Microsoft.Win32;
using proj_Traveldate.fieldBox;
using proj_Traveldate.searchUIRev;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace proj_Traveldate.Models
{
    public  class ProductTagManger
    {
        
        public List<TreeView> AllTreeView = new List<TreeView>();
        public ProductTagManger()
        {
            LoadCategoryData();
            LoadProductType();
            LoadProductRegion();
            RegisterTreeViewEvent();
        }
        
        private void RegisterTreeViewEvent()
        {
            foreach (var item in AllTreeView)
            {
                item.AfterCheck += TreeView_AfterCheck;
            }
        }

        //分類的header
        string header = null;
        //商品類別及標籤的TreeView&TreeNode
        public TreeView tvCategory = new TreeView();
        public TreeNode tnCategoryName = new TreeNode();
        public TreeNode tnTagName = new TreeNode();
        public List<string> tnTagNames = new List<string>();
        //服務型別及細項的TreeView&TreeNode
        public TreeView tvProductServer = new TreeView();
        public TreeNode tnProdServe = new TreeNode();
        public TreeNode tnProdServeType = new TreeNode();
        //商品提供服務地區TreeView&TreeNode
        public TreeView tvRegion = new TreeView();
        public TreeNode tnCountry = new TreeNode();
        public TreeNode tnCity = new TreeNode();
        //審核通過且上架的productID的分類
        public static IEnumerable<IGrouping<string, ProductTagList>> selectTag;
       
        public TreeView treeView ;
        public TreeNode clickedNode;
        public Label label = new Label();

        //

        public void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CommonClass.SetProdInfo(CommonClass.prodPanel) ;
            CommonClass.prodPanel.Controls.Clear();
            ProductBoxManger.nowProductBoxes.Clear();
            
            //解除綁定事件
            foreach (var treeView in AllTreeView)
            {
                treeView.AfterCheck -= TreeView_AfterCheck;
            }

            // 執行更新節點的操作
            Update(AllTreeView);
           
            // 重新綁定事件
            foreach (var treeView in AllTreeView)
            {
                treeView.AfterCheck += TreeView_AfterCheck;
            }
            UpdateTrackValue();
        }

        private void UpdateTrackValue()
        {
            IEnumerable<int> selectPrice = ProductBoxManger.nowProductBoxes.AsEnumerable().Select(p => p._productPrice);
            new TrackBarManger().LoadUnitPriceToTrackBar((IQueryable<decimal?>)selectPrice);
        }

        void Update(List<TreeView> trees)
        {
            foreach (TreeView treeView in trees)
            {
                foreach (TreeNode node in treeView.Nodes)
                {
                    if (node.Checked)
                    {
                        foreach (TreeNode child in node.Nodes)
                        {
                            child.Checked = true;
                        }
                    }
                    else
                    {
                        node.Checked = false;
                    }

                    // 檢查子節點
                    UpdateChildNodes(node);
                }
            }
            if (CommonClass.prodPanel.Controls.Count == 0)
            {
                foreach(var prodBox in ProductBoxManger.allProductBoxes)
                {
                    CommonClass.prodPanel.Controls.Add(prodBox);
                    ProductBoxManger.nowProductBoxes.Add(prodBox);
                }
                CommonClass.SetCountProdLabel(label, CommonClass.prodPanel.Controls.Count);
            }
           
        }
     
        void UpdateChildNodes(TreeNode parentNode)
        {
            
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                if (childNode.Checked)
                {
                   
                    var matchedBoxes = ProductBoxManger.allProductBoxes
                        .Where(pb => pb._productTags.Contains(childNode.Text) || pb._productCitys.Contains(childNode.Text) || pb._prodType.Contains(childNode.Text));
                    foreach (ProductBox prodBox in matchedBoxes)
                    {
                        if (!CommonClass.prodPanel.Controls.Contains(prodBox))
                        {
                            CommonClass.prodPanel.Controls.Add(prodBox);
                            ProductBoxManger.nowProductBoxes.Add(prodBox);
                        }
                    }
                }
            }
           
            CommonClass.SetCountProdLabel(label, CommonClass.prodPanel.Controls.Count);
        }

        //ProductCategory的treeView
        private void LoadCategoryData()
        {
            tvCategory.CheckBoxes = true;
            tvCategory.Dock = DockStyle.Fill;

            //篩選審核通過且上架的productID的分類
             selectTag = CommonClass.dbContext.ProductTagLists.AsEnumerable()
                //檢查 ProductLists 的 ProductID 是否包含在 ProductTagLists 中
                .Where(n => CommonClass.confirmedID.Contains((int)n.ProductID)
                && n.ProductTagDetailsID == n.ProductTagDetail.ProductTagDetailsID
                && n.ProductTagDetail.ProductCategoryID == n.ProductTagDetail.ProductCategory.ProductCategoryID)
                .GroupBy(z => z.ProductTagDetail.ProductCategory.ProductCategoryName)
                .Select(group => group);


            foreach (IGrouping<string, ProductTagList> categoryGroup in selectTag)
            {
                header = $"{categoryGroup.Key} ({categoryGroup.Select(n => n.ProductTagDetail).Distinct().Count()})";
                tnCategoryName = tvCategory.Nodes.Add(header);
                //parentNodes.Add(tnCategoryName);
                foreach (ProductTagDetail tag in categoryGroup.Select(item => item.ProductTagDetail).Distinct())
                {
                    tnTagName = tnCategoryName.Nodes.Add(tag.ProductTagDetailsName);
                    tnTagNames.Add(tag.ProductTagDetailsName); 
                }
            }
            AllTreeView.Add(tvCategory);
        }
        //ProductType的treeView
        private void LoadProductType()
        {
            this.tvProductServer.CheckBoxes = true;
            this.tvProductServer.Dock = DockStyle.Fill;

            IQueryable<string> q = CommonClass.dbContext.ProductLists.Where(n => n.ProductTypeID == n.ProductTypeList.ProductTypeID).
                GroupBy(n => n.ProductTypeList.ProductType).Select(n => n.Key);


            header = $"商品類型 ({q.Count()})";
            tnProdServe = this.tvProductServer.Nodes.Add(header);

            foreach (string t in q)
            {
                tnProdServeType = tnProdServe.Nodes.Add(t);
            }
            AllTreeView.Add(tvProductServer);
        }
        //ProductRegion的treeView
        private void LoadProductRegion()
        {
            //設置tvRegion屬性
            tvRegion.Dock = DockStyle.Fill;
            tvRegion.CheckBoxes = true;

            var q = CommonClass.dbContext.ProductLists.AsEnumerable().
                Where(
                n => CommonClass.confirmedID.Contains(n.ProductID)
                && n.CityID == n.CityList.CityID
                && n.CityList.CountryID == n.CityList.CountryList.CountryID).
                GroupBy(n => n.CityList.CountryList.Country).
                Select(g => new
                {
                    Country = g.Key,
                    City = g.Select(n => n.CityList.City).Distinct(),

                });


            foreach (var p in q)
            {
                tnCountry = tvRegion.Nodes.Add($"{p.Country} ({p.City.Count()})");

                foreach (string c in p.City)
                {
                    tnCity = tnCountry.Nodes.Add(c);
                }
            }
            AllTreeView.Add(tvRegion);
        }
    }
}
