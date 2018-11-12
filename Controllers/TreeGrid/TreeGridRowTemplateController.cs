using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridRowTemplate/

        public ActionResult TreeGridRowTemplate()
        {
            var data = this.getRowData();
            ViewBag.datasource = data;
            return View();
        }

        private List<RowData> getRowData()
        {

            List<RowData> DataCollection = new List<RowData>();

            RowData Record1 = new RowData()
            {
                Name = "Robert King",
                FullName = "Robert King",
                Designation = "Chief Executive Officer",
                EmployeeID = "EMP001",
                Address = "507 - 20th Ave. E.Apt. 2A, Seattle",
                Contact = "(206) 555-9857",
                Country = "USA",
                DOB = "2/15/1963",
                DOJ = "5/1/1983",
                Children = new List<RowData>()
            };

            RowData parent = new RowData()
            {
                Name = "David william",
                FullName = "David william",
                Designation = "Vice President",
                EmployeeID = "EMP004",
                Address = "722 Moss Bay Blvd., Kirkland",
                Country = "USA",
                Contact = "(206) 555-3412",
                DOB = "5/20/1971",
                DOJ = "1/5/1991",
                Children = new List<RowData>()
            };

            RowData Child1 = new RowData()
           {
               Name = "Nancy Davolio",
               FullName = "Nancy Davolio",
               Designation = "Marketing Executive",
               EmployeeID = "EMP035",
               Address = "4110 Old Redmond Rd., Redmond",
               Country = "USA",
               Contact = "(206) 555-8122",
               DOB = "3/19/1966",
               DOJ = "1/5/1986",
               Children = new List<RowData>()
           };
            RowData Child2 = new RowData()
           {
               Name = "Romey Wilson",
               FullName = "Romey Wilson",
               Designation = "Sales Executive",
               EmployeeID = "EMP039",
               Address = "7 Houndstooth Rd., London",
               Country = "UK",
               Contact = "(71) 555-3690",
               DOB = "02/02/1980",
               DOJ = "1/5/2000",
               Children = new List<RowData>()
           };

            RowData InnerChild1 = new RowData()
           {
               Name = "Andrew Fuller",
               FullName = "Andrew Fuller",
               Designation = "Sales Representative",
               EmployeeID = "EMP045",
               Address = "14 Garrett Hill, London",
               Country = "UK",
               Contact = "(71) 555-4848",
               DOB = "9/20/1980",
               DOJ = "1/5/2000",
           };

            RowData InnerChild2 = new RowData()
           {
               Name = "Anne Dodsworth",
               FullName = "Anne Dodsworth",
               Designation = "Sales Representative",
               EmployeeID = "EMP091",
               Address = "4726 - 11th Ave. N.E., Seattle",
               Country = "USA",
               Contact = "(206) 555-1189",
               DOB = "10/19/1989",
               DOJ = "1/5/2009",

           };
            RowData InnerChild3 = new RowData()
           {
               Name = "Michael Suyama",
               FullName = "Michael Suyama",
               Designation = "Sales Representative",
               EmployeeID = "EMP110",
               Address = "Coventry House Miner Rd., London",
               Country = "UK",
               Contact = "(71) 555-3636",
               DOB = "11/02/1987",
               DOJ = "1/5/2007",

           };
            RowData InnerChild4 = new RowData()
           {
               Name = "Janet Leverling",
               FullName = "Janet Leverling",
               Designation = "Sales Coordinator",
               EmployeeID = "EMP131",
               Address = "Edgeham Hollow Winchester Way, London",
               Country = "UK",
               Contact = "(71) 555-3636",
               DOB = "11/06/1990",
               DOJ = "1/5/2010",
           };

            RowData InnerChild5 = new RowData()
           {
               Name = "Margaret Peacock",
               FullName = "Margaret Peacock",
               Designation = "Sales Representative",
               EmployeeID = "EMP213",
               Address = "4726 - 11th Ave. N.E., California",
               Country = "USA",
               Contact = "(206) 555-1989",
               DOB = "01/21/1986",
               DOJ = "1/5/2006",
           };

            RowData InnerChild6 = new RowData()
           {
               Name = "Laura Callahan",
               FullName = "Laura Callahan",
               Designation = "Sales Coordinator",
               EmployeeID = "EMP201",
               Address = "Coventry House Miner Rd., London",
               Country = "UK",
               Contact = "(71) 555-2222",
               DOB = "12/01/1990",
               DOJ = "1/5/2010"
           };
            RowData InnerChild7 = new RowData()
           {
               Name = "Steven Buchanan",
               FullName = "Steven Buchanan",
               Designation = "Sales Representative",
               EmployeeID = "EMP197",
               Address = "200 Lincoln Ave, Salinas, CA 93901",
               Country = "USA",
               Contact = "(831) 758-7408",
               DOB = "03/23/1987",
               DOJ = "1/5/2007"

           };
            RowData InnerChild8 = new RowData()
           {
               Name = "Tedd Lawson",
               FullName = "Tedd Lawson",
               Designation = "Sales Representative",
               EmployeeID = "EMP167",
               Address = "200 Lincoln Ave, Salinas, CA 93901",
               Country = "USA",
               Contact = "(831) 758-7368 ",
               DOB = "08/09/1989",
               DOJ = "1/5/2009"
           };

            Record1.Children.Add(parent);
            parent.Children.Add(Child1);
            parent.Children.Add(Child2);
            Child1.Children.Add(InnerChild1);
            Child1.Children.Add(InnerChild2);
            Child1.Children.Add(InnerChild3);
            Child1.Children.Add(InnerChild4);

            Child2.Children.Add(InnerChild5);
            Child2.Children.Add(InnerChild6);
            Child2.Children.Add(InnerChild7);
            Child2.Children.Add(InnerChild8);
            DataCollection.Add(Record1);
            
            return DataCollection;

        }

        public class RowData
        {
            public string Name { get; set; }
            public string FullName { get; set; }
            public string Designation { get; set; }
            public string EmployeeID { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
            public string DOB { get; set; }
            public string DOJ { get; set; }
            public string Country { get; set; }
            public List<RowData> Children { get; set; }

        }

    }
}
