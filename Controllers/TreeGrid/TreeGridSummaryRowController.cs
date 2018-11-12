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
        // GET: /TreeGridSummaryRow/

        public ActionResult TreeGridSummaryRow()
        {
            var data = this.getSummaryRowData();
            ViewBag.datasource = data;
            return View();
        }

        private List<SummaryRowData> getSummaryRowData()
        {

            List<SummaryRowData> DataCollection = new List<SummaryRowData>();

            SummaryRowData Parent1 = new SummaryRowData()
            {
               FreightID = "CX2389NK",
               FreightName= "Maersk Edibles Co.",
               TotalUnits= 598,
               TotalCosts= 27838,
               UnitWeight= 241,
               Children = new List<SummaryRowData>()
            };

            SummaryRowData Child1 = new SummaryRowData()
            {
               FreightID= "QW4567OP",
               FreightName= "Chang",
               TotalUnits= 123,
               TotalCosts= 3400,
               UnitWeight= 50,
            };

            SummaryRowData Child2 = new SummaryRowData()
            {
                FreightID= "QW3458BH",
                FreightName= "Aniseed Syrup",
                TotalUnits= 89,
                TotalCosts= 5900,
                UnitWeight= 87,
            };
            SummaryRowData Child3 = new SummaryRowData()
            {
                 FreightID= "QW8967OH",
                 FreightName= "Chef Anton's Cajun Seasoning",
                 TotalUnits= 46,
                 TotalCosts= 9578,
                 UnitWeight= 54,
                            
            };

            SummaryRowData Child4 = new SummaryRowData()
            {
                FreightID= "QW6549NJ",
                FreightName= "Chef Anton's Gumbo Mix",
                TotalUnits= 340,
                TotalCosts= 8960,
                UnitWeight= 50,

            };

            Parent1.Children.Add(Child1);
            Parent1.Children.Add(Child2);
            Parent1.Children.Add(Child3);
            Parent1.Children.Add(Child4);

            SummaryRowData Parent2 = new SummaryRowData()
            {
                FreightID= "DW8954IO",
                FreightName= "Aeon fitness inc.",
                TotalUnits= 1720,
                TotalCosts= 24367,
                UnitWeight= 296,
                Children = new List<SummaryRowData>()

            };
            SummaryRowData Child5 = new SummaryRowData()
            {
                FreightID= "UF5647YH",
                FreightName= "Reebox CrossFit Back Bay",
                TotalUnits= 600,
                TotalCosts= 8700,
                UnitWeight= 73,

            };
            SummaryRowData Child6 = new SummaryRowData()
            {
                 FreightID= "UF1290LK",
                 FreightName= "The Green Microgym",
                 TotalUnits= 569,
                 TotalCosts= 8765,
                 UnitWeight= 90,

            };

            SummaryRowData Child7 = new SummaryRowData()
            {               
                FreightID= "UF8956KU",
                FreightName= "DeFranco's",
                TotalUnits= 456,
                TotalCosts= 4589,
                UnitWeight= 68,

            };

            SummaryRowData Child8 = new SummaryRowData()
            {
               FreightID= "UF7464JK",
               FreightName= "Westside Barbell",
               TotalUnits= 95,
               TotalCosts= 2313,
               UnitWeight= 65,
            };

            Parent2.Children.Add(Child5);
            Parent2.Children.Add(Child6);
            Parent2.Children.Add(Child7);
            Parent2.Children.Add(Child8);

            SummaryRowData Parent3 = new SummaryRowData()
            {
               FreightID= "EJ9456KN",
               FreightName= "Sun technologies inc",
               TotalUnits= 331,
               TotalCosts= 22933,
               UnitWeight= 192,
               Children = new List<SummaryRowData>()

            };
            SummaryRowData Child9 = new SummaryRowData()
            {
               FreightID= "GH2367OP",
               FreightName= "Haier Group",
               TotalUnits= 78,
               TotalCosts= 6789,
               UnitWeight= 23,

            };

            SummaryRowData Child10 = new SummaryRowData()
            {
                FreightID= "GH4309TH",
                FreightName= "Panda Electronics",
                TotalUnits= 90,
                TotalCosts= 8999,
                UnitWeight= 48,

            };
            SummaryRowData Child11 = new SummaryRowData()
            {
                FreightID= "GH3494SD",
                FreightName= "Jiangsu Etern",
                TotalUnits= 36,
                TotalCosts= 4356,
                UnitWeight= 56,

            };

            SummaryRowData Child12 = new SummaryRowData()
            {
                FreightID= "GH3213FR",
                FreightName= "Zhejiang Fuchunjiang",
                TotalUnits= 127,
                TotalCosts= 2789,
                UnitWeight= 65,

            };

            Parent3.Children.Add(Child9);
            Parent3.Children.Add(Child10);
            Parent3.Children.Add(Child11);
            Parent3.Children.Add(Child12);
           
            DataCollection.Add(Parent1);
            DataCollection.Add(Parent2);
            DataCollection.Add(Parent3);

            return DataCollection;

        }

        public class SummaryRowData
        {
            public string FreightID { get; set; }
            public string FreightName { get; set; }
            public int TotalUnits { get; set; }
            public int TotalCosts { get; set; }
            public int UnitWeight { get; set; }            
            public List<SummaryRowData> Children { get; set; }

        }
    }
}
