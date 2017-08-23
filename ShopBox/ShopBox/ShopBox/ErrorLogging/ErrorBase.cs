using ShopBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.ErrorLogging
{
   public class ErrorBase
    {
        public ErrorBase()
        {
        }

        public Error error { get; set; }
    }
}
