#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
    using MVCSampleBrowser.Models;


    public static class OrderRepository
    {
        public static IList<EditableOrder> GetAllRecords()
        {
            IList<EditableOrder> orders = (IList<EditableOrder>)HttpContext.Current.Session["Orders"];

            if (orders == null)
            {
                HttpContext.Current.Session["Orders"] = orders = (from ord in new NorthwindDataContext().Orders.Take(200)
                                                                  select new EditableOrder
                                                                  {
                                                                      OrderID = ord.OrderID,
                                                                      OrderDate = ord.OrderDate,
                                                                      CustomerID = ord.CustomerID,
                                                                      EmployeeID = ord.EmployeeID,
                                                                      Freight = ord.Freight,
                                                                      ShipAddress = ord.ShipAddress,
                                                                      ShipCity = ord.ShipCity,
                                                                      ShipName = ord.ShipName,
                                                                      ShipPostalCode = ord.ShipPostalCode,
                                                                      ShipRegion = ord.ShipRegion,
                                                                      ShipCountry = ord.ShipCountry
                                                                  }).ToList();
                foreach (var order in orders)
                {
                    if (order.Freight > 30)
                        order.Verified = true;
                    else
                        order.Verified = false;
                }
            }
            return orders;
        }

        public static void Add(EditableOrder order)
        {
            GetAllRecords().Insert(0, order);
        }

        public static void Add(List<EditableOrder> order)
        {
            foreach (var temp in order)
                GetAllRecords().Insert(0, temp);
        }

        public static void Delete(int? OrderID)
        {
            EditableOrder result = GetAllRecords().Where(o => o.OrderID == OrderID).FirstOrDefault();
            GetAllRecords().Remove(result);
        }

        public static void Delete(List<EditableOrder> order)
        {
            foreach (var temp in order)
            {
                EditableOrder result = GetAllRecords().Where(o => o.OrderID == temp.OrderID).FirstOrDefault();
                GetAllRecords().Remove(result);
            }
        }

        public static void Update(EditableOrder order)
        {
            EditableOrder result = GetAllRecords().Where(o => o.OrderID == order.OrderID).FirstOrDefault();
            if (result != null)
            {
                result.OrderID = order.OrderID;
                result.OrderDate = order.OrderDate;
                result.CustomerID = order.CustomerID;
                result.EmployeeID = order.EmployeeID;
                result.Freight = order.Freight;
                result.ShipAddress = order.ShipAddress;
                result.ShipCity = order.ShipCity;               
                result.ShipName = order.ShipName;                
                result.ShipPostalCode = order.ShipPostalCode;
                result.ShipRegion = order.ShipRegion;
                result.ShipCountry = order.ShipCountry;
                result.Verified = order.Verified;
            }
        }              

        public static void Update(List<EditableOrder> order)
        {
            foreach (var temp in order)
            {
                EditableOrder result = GetAllRecords().Where(o => o.OrderID == temp.OrderID).FirstOrDefault();
                if (result != null)
                {
                    result.OrderID = temp.OrderID;
                    result.OrderDate = temp.OrderDate;
                    result.CustomerID = temp.CustomerID;
                    result.EmployeeID = temp.EmployeeID;
                    result.Freight = temp.Freight;
                    result.ShipAddress = temp.ShipAddress;
                    result.ShipCity = temp.ShipCity;
                    result.ShipName = temp.ShipName;
                    result.ShipPostalCode = temp.ShipPostalCode;
                    result.ShipRegion = temp.ShipRegion;
                    result.ShipCountry = temp.ShipCountry;
                    result.Verified = temp.Verified;
                }
            }
        }
        public static IList<EditableOrder> GetComplexRecords()
        {
            IList<EditableOrder> records = (IList<EditableOrder>)HttpContext.Current.Session["Records"];

            if (records == null)
            {
                HttpContext.Current.Session["Records"] = records = (from rec in new NorthwindDataContext().Orders.Take(200) select new EditableOrder
                                                                  {
                                                                      OrderID = rec.OrderID,
                                                                      OrderDate = rec.OrderDate,
                                                                      CustomerID = rec.CustomerID,
                                                                      EmployeeID = rec.EmployeeID,
                                                                      Freight = rec.Freight,
                                                                      ShipAddress = rec.ShipAddress,
                                                                      ShipCity = rec.ShipCity,
                                                                      ShipName = rec.ShipName,
                                                                      ShipPostalCode = rec.ShipPostalCode,
                                                                      ShipRegion = rec.ShipRegion,
                                                                      ShipCountry = rec.ShipCountry,
                                                                      Employee = new EditableEmployee
                                                                      {
                                                                          Address = rec.Employee.Address,
                                                                          FirstName = rec.Employee.FirstName,
                                                                          LastName = rec.Employee.LastName,
                                                                          EmployeeID = rec.Employee.EmployeeID
                                                                      }
                                                                      
                                                                  }).ToList();
                foreach (var record in records)
                {
                    if (record.Freight > 30)
                        record.Verified = true;
                    else
                        record.Verified = false;
                }
                foreach (var rec in records)
                {
                    var address = rec.Employee.Address;
                    rec.Employee.Address = address.Replace("\r\n", "");
                }
            }
            return records;
        }

        public static void ComplexAdd(EditableOrder record)
        {
            GetComplexRecords().Insert(0, record);
        }

        public static void ComplexAdd(List<EditableOrder> record)
        {
            foreach (var temp in record)
                GetComplexRecords().Insert(0, temp);
        }

        public static void ComplexDelete(int OrderID)
        {
            EditableOrder result = GetComplexRecords().Where(o => o.OrderID == OrderID).FirstOrDefault();
            GetComplexRecords().Remove(result);
        }

        public static void ComplexDelete(List<EditableOrder> record)
        {
            foreach (var temp in record)
            {
                EditableOrder result = GetComplexRecords().Where(o => o.OrderID == temp.OrderID).FirstOrDefault();
                GetComplexRecords().Remove(result);
            }
        }

        public static void ComplexUpdate(EditableOrder record)
        {
            EditableOrder result = GetComplexRecords().Where(o => o.OrderID == record.OrderID).FirstOrDefault();
            if (result != null)
            {
                result.OrderID = record.OrderID;
                result.OrderDate = record.OrderDate;
                result.CustomerID = record.CustomerID;
                result.EmployeeID = record.EmployeeID;
                result.Freight = record.Freight;
                result.ShipAddress = record.ShipAddress;
                result.ShipCity = record.ShipCity;
                result.ShipName = record.ShipName;
                result.ShipPostalCode = record.ShipPostalCode;
                result.ShipRegion = record.ShipRegion;
                result.ShipCountry = record.ShipCountry;
                result.Verified = record.Verified;
                result.Employee.Address = record.Employee.Address;
                result.Employee.FirstName = record.Employee.FirstName;
                result.Employee.LastName = record.Employee.LastName;
                result.Employee.EmployeeID = record.Employee.EmployeeID;


            }
        }

        public static void ComplexUpdate(List<EditableOrder> record)
        {
            foreach (var temp in record)
            {
                EditableOrder result = GetComplexRecords().Where(o => o.OrderID == temp.OrderID).FirstOrDefault();
                if (result != null)
                {
                    result.OrderID = temp.OrderID;
                    result.OrderDate = temp.OrderDate;
                    result.CustomerID = temp.CustomerID;
                    result.EmployeeID = temp.EmployeeID;
                    result.Freight = temp.Freight;
                    result.ShipAddress = temp.ShipAddress;
                    result.ShipCity = temp.ShipCity;
                    result.ShipName = temp.ShipName;
                    result.ShipPostalCode = temp.ShipPostalCode;
                    result.ShipRegion = temp.ShipRegion;
                    result.ShipCountry = temp.ShipCountry;
                    result.Verified = temp.Verified;
                    result.Employee.Address = temp.Employee.Address;
                    result.Employee.FirstName = temp.Employee.FirstName;
                    result.Employee.LastName = temp.Employee.LastName;
                    result.Employee.EmployeeID = temp.Employee.EmployeeID;

                }
            }
        }
    }
}
