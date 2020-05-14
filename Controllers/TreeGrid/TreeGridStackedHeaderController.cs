#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        // GET: /Default/

        public ActionResult TreeGridStackedHeader()
        {
            var data = this.getShipmentData();
            ViewBag.datasource = data;
            return View();
        }
        private List<ShipmentData> getShipmentData()
        {

            List<ShipmentData> DataCollection = new List<ShipmentData>();

            ShipmentData Parent1 = new ShipmentData()
            {
                ID = "1",
                Name = "Order 1",
                Units = 1395,
                UnitPrice = 47,
                Price=13366,
                Children = new List<ShipmentData>()
            };

            ShipmentData Child1 = new ShipmentData()
            {
                ID = "1.1",
                Name = "Mackerel",
                Category = "Frozen seafood",
                Units = 235,
                UnitPrice = 12,
                Price=2820
            };

            ShipmentData Child2 = new ShipmentData()
            {
                ID = "1.2",
                Name = "Yellowfin Tuna",
                Category = "Frozen seafood",
                Units = 324,
                UnitPrice = 8,
                Price = 2592
            };
            ShipmentData Child3 = new ShipmentData()
            {
                ID = "1.3",
                Name = "Herrings",
                Category = "Frozen seafood",
                Units = 488,
                UnitPrice = 11,
                Price = 5268
            };
            ShipmentData Child4 = new ShipmentData()
            {
                ID = "1.4",
                Name = "Preserved Olives",
                Category = "Edible",
                Units = 125,
                UnitPrice = 9,
                Price = 1125
            };
            ShipmentData Child5 = new ShipmentData()
            {
                ID = "1.5",
                Name = " Sweet corn Frozen ",
                Category = "Edible",
                Units = 223,
                UnitPrice = 7,
                Price = 1561
            };         
            Parent1.Children.Add(Child1);
            Parent1.Children.Add(Child2);
            Parent1.Children.Add(Child3);
            Parent1.Children.Add(Child4);
            Parent1.Children.Add(Child5);

            ShipmentData Parent2 = new ShipmentData()
            {
                ID = "2",
                Name = "Order 2",
                Units = 1944,
                UnitPrice = 58,
                Price = 21233,
                Children = new List<ShipmentData>()
            };

            ShipmentData Child6 = new ShipmentData()
            {
                ID = "2.1",
                Name = "Tilapias",
                Category = "Frozen seafood",
                Units = 278,
                UnitPrice = 15,
                Price = 4170
            };

            ShipmentData Child7 = new ShipmentData()
            {
                ID = "2.2",
                Name = "White Shrimp",
                Category = "Frozen seafood",
                Units = 560,
                UnitPrice = 7,
                Price = 3920
            };
            ShipmentData Child8 = new ShipmentData()
            {
                ID = "2.3",
                Name = "Fresh Cheese",
                Category = "Dairy",
                Units = 323,
                UnitPrice = 12,
                Price = 3876
            };
            ShipmentData Child9 = new ShipmentData()
            {
                ID = "2.4",
                Name = "Blue Veined Cheese",
                Category = "Dairy",
                Units = 370,
                UnitPrice = 15,
                Price = 5550
            };
            ShipmentData Child10 = new ShipmentData()
            {
                ID = "2.5",
                Name = "Butter",
                Category = "Dairy",
                Units = 413,
                UnitPrice = 9,
                Price = 3717
            };  

            Parent2.Children.Add(Child6);
            Parent2.Children.Add(Child7);
            Parent2.Children.Add(Child8);
            Parent2.Children.Add(Child9);
            Parent2.Children.Add(Child10);

            ShipmentData Parent3 = new ShipmentData()
            {
                ID = "3",
                Name = "Order 3",
                Units = 1944,
                UnitPrice = 58,
                Price = 21233,
                Children = new List<ShipmentData>()
            };

            ShipmentData Child11 = new ShipmentData()
            {
                ID = "3.1",
                Name = "Lead glassware",
                Category = "Solid crystals",
                Units = 542,
                UnitPrice = 6,
                Price = 3252
            };

            ShipmentData Child12 = new ShipmentData()
            {
                ID = "3.2",
                Name = "Pharmaceutical Glassware",
                Category = "Solid crystals",
                Units = 324,
                UnitPrice = 11,
                Price = 3564
            };
            ShipmentData Child13 = new ShipmentData()
            {
                ID = "3.3",
                Name = "Glass beads",
                Category = "Solid crystals",
                Units = 254,
                UnitPrice = 16,
                Price = 4064
            };

            Parent3.Children.Add(Child11);
            Parent3.Children.Add(Child12);
            Parent3.Children.Add(Child13);

            DataCollection.Add(Parent1);
            DataCollection.Add(Parent2);
            DataCollection.Add(Parent3);

            return DataCollection;

        }

        public class ShipmentData
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Units { get; set; }
            public string Category { get; set; }
            public int UnitPrice { get; set; }
            public int Price { get; set; }
            public List<ShipmentData> Children { get; set; }

        }
    }
}
