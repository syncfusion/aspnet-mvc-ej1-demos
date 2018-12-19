#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        // GET: DragAndDrop
        public ActionResult DragAndDrop()
        {
            IList<EditableOrder> orders = (IList<EditableOrder>)HttpContext.Session["Orders2"];
            if (orders == null)
                HttpContext.Session["Orders2"] =  orders =  new List<EditableOrder>();
            ViewBag.datasource2 = orders;
            ViewBag.datasource = OrderRepository.GetAllRecords();
            return View();
        }

        public ActionResult RowDropHandler(List<EditableOrder> added, List<EditableOrder> deleted)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            RowDropModel dropDetails = (RowDropModel)ser.Deserialize(Request.Headers["rowDropDetails"], typeof(RowDropModel));
            var count = 0;
            var srcData = OrderRepository.GetAllRecords();
            var destData = (List<EditableOrder>)HttpContext.Session["Orders2"];
            if (dropDetails.SourceID == "DestGrid")
            {
                srcData = destData;
                destData = (List<EditableOrder>)OrderRepository.GetAllRecords();
            }
            if (added != null)
            {
                foreach (var item in added)
                {
                    destData.Insert(dropDetails.DestinationRowIndex + count, item);
                    EditableOrder result = srcData.Where(o => o.OrderID == item.OrderID).FirstOrDefault();
                    srcData.Remove(result);
                    count++;
                }
            }
            return Json("success", JsonRequestBehavior.AllowGet);
        }
    }
}