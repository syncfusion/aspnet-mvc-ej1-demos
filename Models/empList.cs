using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleBrowser.Models
{
    public class empList
    {
        public string text { get; set; }
        public string eimg { get; set; }
        public string status { get; set; }
        public string country { get; set; }
        public static List<empList> GetEmpList()
        {
            List<empList> emp = new List<empList>();
            emp.Add(new empList { text = "Natalie", eimg = "1", status = "Available", country = "USA" });
            emp.Add(new empList { text = "John Linden", eimg = "2", status = "Available", country = "USA" });
            emp.Add(new empList { text = "Erik Linden", eimg = "3", status = "Available", country = "England" });
            emp.Add(new empList { text = "Leverling", eimg = "4", status = "Available", country = "England" });
            emp.Add(new empList { text = "Suyama", eimg = "5", status = "Available", country = "USA" });
            return emp;
        }
    }
}