using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models
{
   public class UserAccount
    {
        public Account account { get; set; }
        public string accessToken { get; set; }
        public int crdate { get; set; }
        public int tstamp { get; set; }
        public string crdate_formatted { get; set; }
        public string tstamp_formatted { get; set; }
    }

    public class Account
    {
        public int uid { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string mobile { get; set; }
        public string title { get; set; }
        public string code { get; set; }
        public int verified_time { get; set; }
    }
}
