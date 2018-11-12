
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace MVCSampleBrowser.Models
{
    public class template
    {
        public int id { get; set; }
        public int pid { get; set; }
        public int imgId { get; set; }
        public string name { get; set; }
        public bool hasChild { get; set; }
        public bool expanded { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
    }
}