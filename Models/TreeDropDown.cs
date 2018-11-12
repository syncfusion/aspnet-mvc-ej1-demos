using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Models
{
    public class TreeDropDown
    {
        public int id { get; set; }
        public int pid { get; set; }
        public string name { get; set; }
        public bool hasChild { get; set; }
        public bool expanded { get; set; }
        public string spriteCss { get; set; }
    }
}