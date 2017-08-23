using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Clients
{
    public class ClientItem
    {
        public int uid { get; set; }
        public string tstamp { get; set; }
        public string crdate { get; set; }
        public int deleted { get; set; }
        public int hidden { get; set; }
        public ClientInfo client { get; set; }
        public Account account { get; set; }
        public int role { get; set; }
        public int preferred { get; set; }
        public string token { get; set; }
        public string branch { get; set; }
        public string code { get; set; }
    }
}
