using proj_Traveldate.Models;
using projTravelDate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj_Traveldate.fieldBox
{
    public partial class ProductBox : UserControl
    {
        public ProductBox()
        {
            InitializeComponent();
        }
       
        public Image _Image { get { return picBoxProduct.Image; } set { picBoxProduct.Image = value; } }
        public PictureBoxSizeMode productPicSize { get { return picBoxProduct.SizeMode; } set { picBoxProduct.SizeMode = value; } }
        public string _productTitle { get { return labTitle.Text; } set { labTitle.Text = value; } }
        public string _productOutline { get { return labOutline.Text; } set { labOutline.Text = value; } }
        public string _productPriceText { get { return labPrice.Text; }set { labPrice.Text = value; } }
        public int _productPrice { get; set; } 
        public string _productScore { get { return labScore.Text; } set { labScore.Text = value; } }
        public int _productID { get; set; }
        public string _prodDate { get { return labDueDate.Text; } set { labDueDate.Text = value; } } 
        public DateTime _prodDateTag { get; set; }
        public string _prodCity { get; set; }
        public string _prodType { get; set; }
      
        public List<string> _productCitys { get; set; } = new List<string>();
        public List<string> _productTags { get; set; } = new List<string>();

        private void ProductBox_Click(object sender, EventArgs e)
        {
            var q = sender as ProductBox;
           ProductManager.ProductID = q._productID ;
            FrmProgram f = new FrmProgram();
            f.Show();
        }
    }
}
