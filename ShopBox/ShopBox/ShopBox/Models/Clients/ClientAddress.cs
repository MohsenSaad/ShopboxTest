﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Models.Clients
{
    public class ClientAddress
    {
        public int uid { get; set; }
        public string street_name { get; set; }
        public string map_lat { get; set; }
        public string map_long { get; set; }
        public int country { get; set; }
        public string tstamp { get; set; }
        public string crdate { get; set; }
        public int deleted { get; set; }
        public int hidden { get; set; }
        public string zip_code { get; set; }
        public string note { get; set; }
        public string city_name { get; set; }
        public string cc_name { get; set; }
        public string name { get; set; }
    }
}
