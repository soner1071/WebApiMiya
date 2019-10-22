using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiyaYazilim.Models
{
    public class DataInfo
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }

    public class PageInfo
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<DataInfo> data { get; set; }
    }
}