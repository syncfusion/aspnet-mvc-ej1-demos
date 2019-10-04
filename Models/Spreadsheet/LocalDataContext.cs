#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace MVCSampleBrowser.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel;
    public class OrderItemsDataContext
    {
        public IEnumerable<object> GetAllRecords()
        {
            var orders = (from ord in new NorthwindDataContext().Orders.Take(200)
                          select new { OrderID = ord.OrderID, CustomerID = ord.CustomerID, EmployeeID = ord.EmployeeID, ShipName = ord.ShipName, ShipCity = ord.ShipCity, ShipAddress = ord.ShipAddress });

            return orders;
        }

        public IEnumerable<object> GetPrintRecords()
        {
            var orders = (from ord in new NorthwindDataContext().Orders.Take(200)
                          select new { ShipName = ord.ShipName, ShipAddress = ord.ShipAddress, ShipCity = ord.ShipCity, ShipPostalCode = ord.ShipPostalCode });

            return orders;
        }

        public IEnumerable<object> GetProductDetails()
        {
            var products = (from product in new NorthwindDataContext().Products.Take(200)
                            select new { ProductID = product.ProductID, ProductName = product.ProductName, CategoryID = product.CategoryID, QuantityPerUnit = product.QuantityPerUnit, UnitPrice = product.UnitPrice, UnitsInStock = product.UnitsInStock });

            return products;
        }

        public IEnumerable<object> GetSignalRRecords()
        {
            var orders = (from ord in new NorthwindDataContext().Orders.Take(200)
                          select new { CustomerID = ord.CustomerID, ShipName = ord.ShipName, ShipAddress = ord.ShipAddress, ShipCity = ord.ShipCity, ShipCountry = ord.ShipCountry });

            return orders;
        }
    }
}