#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class TagCloudController : Controller
    {
        //
        // GET: /TagCloudRtl/
        List<WebsiteCollection> links = new List<WebsiteCollection>(); 
        public ActionResult Rtl()
        {
            links.Add(new WebsiteCollection { text = "جوجل", url = "http://www.google.com", frequency = 12 });
            links.Add(new WebsiteCollection { text = "كل الأشياء الرقمية", url = "http://allthingsd.com/", frequency = 3 });
            links.Add(new WebsiteCollection { text = "الفنون تكنيكا", url = "http://arstechnica.com/", frequency = 8 });
            links.Add(new WebsiteCollection { text = "بيزنس ويك", url = "http://www.businessweek.com/", frequency = 2 });
            links.Add(new WebsiteCollection { text = "ياهو", url = "http://in.yahoo.com/", frequency = 12 });
            links.Add(new WebsiteCollection { text = "مركز الشبكات", url = "http://www.centernetworks.com/", frequency = 5 });
            links.Add(new WebsiteCollection { text = "حن", url = "http://news.cnet.com/crave/", frequency = 8 });
            links.Add(new WebsiteCollection { text = "جير أزمة", url = "http://techcrunch.com/gadgets/", frequency = 20 });
            links.Add(new WebsiteCollection { text = "يوميا تك", url = "http://www.dailytech.com/", frequency = 1 });
            links.Add(new WebsiteCollection { text = "التقنية بلا حدود", url = "http://www.engadget.com/", frequency = 5 });
            links.Add(new WebsiteCollection { text = "الأسبوع المعلومات", url = "http://www.informationweek.com/", frequency = 0 });
            links.Add(new WebsiteCollection { text = "إستخدام آمن", url = "http://www.pcworld.com/", frequency = 11 });
            links.Add(new WebsiteCollection { text = "جمهورية التكنولوجيا", url = "http://techrepublic.com/", frequency = 3 });
            links.Add(new WebsiteCollection { text = "الثعبان", url = "http://valleywag.gawker.com/", frequency = 6 });
            links.Add(new WebsiteCollection { text = "ريديف", url = "http://in.rediff.com/", frequency = 9 });
            ViewBag.datasource = links;
            return View();
        }

    }
}
