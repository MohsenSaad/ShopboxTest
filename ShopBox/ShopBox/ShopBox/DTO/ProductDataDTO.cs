using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.DTO
{
   public class ProductDataDTO :BindableBase
    {
        private int _uid;
        public int uid
        {
            get { return _uid; }
            set { SetProperty(ref _uid, value); }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _stock_price;
        public int stock_price {
            get { return _stock_price; }
            set { SetProperty(ref _stock_price, value); }
        }

        private double _selling_price;

        public double selling_price {
            get { return _selling_price; }
            set { SetProperty(ref _selling_price, value); } }
    }
}
