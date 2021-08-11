#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCSampleBrowser.Models
{
    public class ProductDataContext
    {
        public class ProductDetails
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
            public int UnitsOnOrder { get; set; }
        }
        public List<ProductDetails> GetProductData
        {
            get
            {
                Random r = new Random();
                List<ProductDetails> details = new List<ProductDetails>();
                string[] pname = new string[]{"Chai", "Chang", "Aniseed Syrup,Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread",
                "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce", "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora"};
                for (int i = 1; i < 11; i++)
                {
                    ProductDetails[] data = new ProductDetails[11];
                    var value = r.Next(1, 30);
                    data[i] = new ProductDetails() { ProductID = i, ProductName = pname[i], UnitPrice = Convert.ToInt16(value * 0.5 + i), UnitsInStock = Convert.ToInt16(value * 3), UnitsOnOrder = Convert.ToInt16((value * 5)) };
                    details.Add(data[i]);
                }
                return details;
            }
        }
    }
}
