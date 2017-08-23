using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Products
{
    public class ProductInfo
    {
        public int uid { get; set; }
        public string name { get; set; }
        public int stock_price { get; set; }
        public double selling_price { get; set; }
        public ProductImage image { get; set; }
        public string code { get; set; }
        public int quantity { get; set; }
        public int client { get; set; }
        public string crdate { get; set; }
        public string tstamp { get; set; }
        public int deleted { get; set; }
        public int hidden { get; set; }
        public int weight { get; set; }
        public string color { get; set; }
        public int tax { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string web_shop_show { get; set; }
        public int? tag { get; set; }
        public object integration { get; set; }
        public object preparation_time { get; set; }
        public ProductTag tag0 { get; set; }
        public int not_kitchen { get; set; }
        public List<object> product_variances { get; set; }
        public int is_favourite { get; set; }
        public ProductTax tax0 { get; set; }
        public ProductUnit unit { get; set; }
    }
}
