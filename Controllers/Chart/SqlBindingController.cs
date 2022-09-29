#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ChartController : Controller
    {
        public ActionResult SqlBinding()
        {
            List<ChartSqlData> data = new List<ChartSqlData>();
            string connectionString = null;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NORTHWND.MDF;Integrated Security=True;User Instance=false;Connect Timeout=100;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string command2 = "SELECT * FROM [Products] WHERE UnitPrice < 10";
            SqlCommand cmd1 = new SqlCommand(command2, con);
            adapter.SelectCommand = cmd1;
            adapter.Fill(dataset);
            for (var i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                string x1 = Convert.ToString(dataset.Tables[0].Rows[i]["ProductName"]);
                double y1 = Convert.ToDouble(dataset.Tables[0].Rows[i]["UnitPrice"]);
                double y2 = Convert.ToDouble(dataset.Tables[0].Rows[i]["UnitsInStock"]);
                data.Add(new ChartSqlData(x1, y1, y2));
            }
            ViewBag.dataSource = data;
            return View();
        }

    }
    
    [Serializable]
    public class ChartSqlData
    {
        public ChartSqlData(string xvalue, double yvalue1, double yvalue2)
        {
            this.ProductName = xvalue;
            this.UnitPrice = yvalue1;
            this.UnitsInStock = yvalue2;
        }
        public string ProductName
        {
            get;
            set;
        }
        public double UnitPrice
        {
            get;
            set;
        }
        public double UnitsInStock
        {
            get;
            set;
        }
    }
}
