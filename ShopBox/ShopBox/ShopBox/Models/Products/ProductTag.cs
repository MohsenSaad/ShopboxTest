using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Products
{
    public class ProductTag
    {
        public int uid { get; set; }
        public string name { get; set; }
        public int client { get; set; }
        public string crdate { get; set; }
        public string tstamp { get; set; }
        public int hidden { get; set; }
        public int deleted { get; set; }
        public ProductImage image { get; set; }
        public int weight { get; set; }
        public int not_kitchen { get; set; }
        public string color { get; set; }
    }
}
