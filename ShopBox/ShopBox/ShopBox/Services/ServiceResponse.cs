using ShopBox.ErrorLogging;
using ShopBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Services
{

    /// <summary>
    /// ServiceResponse is a class to recive the response from the service
    /// </summary>
    public class ServiceResponse
    {
        public bool Success { get; set; }
       
        public ErrorBase ErrorObject { get; set; }
        public object ResponseObject { get; set; }
    }

 

}
