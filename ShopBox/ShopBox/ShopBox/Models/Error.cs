using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models
{
   public class Error
    {
        public string name { get; set; }
        public string message { get; set; }
        public int code { get; set; }
        public int status { get; set; }
        public string type { get; set; }
    }
    public class ErrorRootObject
    {
        public Error error { get; set; }
    }
}
