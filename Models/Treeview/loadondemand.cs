using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace MVCSampleBrowser.Models
{
    public class loadondemand
    {
        public int id { get; set; }
        public int? pid { get; set; }
        public string name { get; set; }
        public bool? hasChild { get; set; }
        public bool? expanded { get; set; }
        public bool? ischecked { get; set; }
        public bool? selected { get; set; }
        public string spriteCss { get; set; }
    }

    }