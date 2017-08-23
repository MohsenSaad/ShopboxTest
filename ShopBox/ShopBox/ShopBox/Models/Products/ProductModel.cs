using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Products
{
    public class ProductModel
    {
        public ObservableCollection<ProductInfo> products { get; set; }
    }
}
