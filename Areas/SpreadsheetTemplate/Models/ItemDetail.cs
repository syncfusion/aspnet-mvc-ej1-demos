using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Areas.SpreadsheetTemplate.Models
{
    public class ItemDetail
    {
        public string DATE { get; set; }
        public string ITEM { get; set; }
        public int AMOUNT { get; set; }
        public int CHECK { get; set; }
        public string REMARKS { get; set; }
    }

    public class paymentDetail
    {
        public string DATE { get; set; }
        public string ITEM { get; set; }
        public int COST { get; set; }
        public int ODOM { get; set; }
        public string REMARKS { get; set; }
    }
}