
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Branches
{
    public class Filter
    {
        public int uid { get; set; }
        public string name { get; set; }
        public int client { get; set; }
        public int @default { get; set; }
        public int crdate { get; set; }
        public int tstamp { get; set; }
        public string crdate_formatted { get; set; }
        public string tstamp_formatted { get; set; }
    }

    public class CashRegister
    {
        public int uid { get; set; }
        public string name { get; set; }
        public int branch { get; set; }
        public int terminal_enabled { get; set; }
        public object fiscal_register { get; set; }
        public int package { get; set; }
        public int filter_uid { get; set; }
        public int crdate { get; set; }
        public int tstamp { get; set; }
        public string crdate_formatted { get; set; }
        public string tstamp_formatted { get; set; }
        public Filter filter { get; set; }
    }

    public class Zone0
    {
        public int uid { get; set; }
        public string country_code { get; set; }
        public string zone_name { get; set; }
    }

    public class Data
    {
        public int uid { get; set; }
        public string name { get; set; }
        public string branch_pin { get; set; }
        public int cash_count { get; set; }
        public int client { get; set; }
        public object address { get; set; }
        public object phone { get; set; }
        public object email { get; set; }
        public int time_zone { get; set; }
        public object custom_receipt_text { get; set; }
        public int crdate { get; set; }
        public int tstamp { get; set; }
        public string crdate_formatted { get; set; }
        public string tstamp_formatted { get; set; }
        public List<CashRegister> cash_registers { get; set; }
        public Zone0 zone0 { get; set; }
    }

    public class BranchRootObject
    {
        public List<Data> data { get; set; }
    }
}