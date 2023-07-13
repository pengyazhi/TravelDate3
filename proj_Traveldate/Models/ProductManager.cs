using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTravelDate.Models
{
    internal class ProductManager
    {
        public static int ProductID;
        public static List<string> ProductTags { get; set; } = new List<string>();
        public static List <string> ProductCitys { get; set;} = new List<string>();

    }
}
