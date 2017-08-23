using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Clients
{
    public class ClientAccount
    {
        public int uid { get; set; }
        public string tstamp { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string crdate { get; set; }
        public int deleted { get; set; }
        public string title { get; set; }
        public int verified_time { get; set; }
        public int hidden_account { get; set; }
        public string mobile { get; set; }
        public int hidden { get; set; }
        public int partner { get; set; }
        public string code { get; set; }
        public int role { get; set; }
    }
}
