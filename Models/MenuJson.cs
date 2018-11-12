using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Models
{
    public class MenuJson
    {
        public string mtext { get; set; }
        public string sprite { get; set; }
        public int pid { get; set; }
        public string parent { get; set; }
    }

    public class GroupJson
    {
        public string text { get; set; }
        public string contentType { get; set; }
        public string selected { get; set; }
    }
}