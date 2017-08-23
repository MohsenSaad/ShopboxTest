using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Clients
{
    public class ClientInfo
    {
        public int uid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string url_name { get; set; }
        public string description { get; set; }
        public ClientLogo logo { get; set; }
        public ClientImage image { get; set; }
      
        public string website { get; set; }
        public string account_no { get; set; }
        public string reg_no { get; set; }
        public ClientAddress address { get; set; }
        public string tstamp { get; set; }
        public string crdate { get; set; }
        public int deleted { get; set; }
        public int hidden { get; set; }
        public int webshop { get; set; }
        public string vat_no { get; set; }
        public string opening_hours { get; set; }
        public object tags { get; set; }
        public int accept_mobilepay { get; set; }
        public int tax { get; set; }
        public int automatic_reporting { get; set; }
        public int show_image { get; set; }
        public int branch_count { get; set; }
        public int next_product_weight { get; set; }
        public int next_tag_weight { get; set; }
        public string language { get; set; }
        public int locale_format { get; set; }
        public string infrasec_id { get; set; }
        public int? client_type_uid { get; set; }
        public string locale { get; set; }
        public int currency { get; set; }
        public string number_of_courses { get; set; }
        public object pin_required { get; set; }
        public List<ClientTax> taxes { get; set; }
    }
}
