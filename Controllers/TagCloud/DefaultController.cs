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
        // GET: /TagCloudDefault/
        List<WebsiteCollection> sites = new List<WebsiteCollection>(); 
        public ActionResult Default()
        {
            sites.Add(new WebsiteCollection { text = "Google", url = "http://www.google.com", frequency = 12 });
            sites.Add(new WebsiteCollection { text = "All Things Digital", url = "http://allthingsd.com/", frequency = 3 });
            sites.Add(new WebsiteCollection { text = "Arts Technica", url = "http://arstechnica.com/", frequency = 8 });
            sites.Add(new WebsiteCollection { text = "Business Week", url = "http://www.businessweek.com/", frequency = 2 });
            sites.Add(new WebsiteCollection { text = "Yahoo", url = "http://in.yahoo.com/", frequency = 12 });
            sites.Add(new WebsiteCollection { text = "Center Networks", url = "http://www.centernetworks.com/", frequency = 5 });
            sites.Add(new WebsiteCollection { text = "Crave", url = "http://news.cnet.com/crave/", frequency = 8 });
            sites.Add(new WebsiteCollection { text = "Crunch Gear", url = "http://techcrunch.com/gadgets/", frequency = 20 });
            sites.Add(new WebsiteCollection { text = "Daily Tech", url = "http://www.dailytech.com/", frequency = 1 });
            sites.Add(new WebsiteCollection { text = "Electronista", url = "http://www.electronista.com/", frequency = 3 });
            sites.Add(new WebsiteCollection { text = "Engadget", url = "http://www.engadget.com/", frequency = 5 });
            sites.Add(new WebsiteCollection { text = "Gearlog", url = "http://www.gearlog.com/", frequency = 9 });
            sites.Add(new WebsiteCollection { text = "Information Week", url = "http://www.informationweek.com/", frequency = 0 });
            sites.Add(new WebsiteCollection { text = "PCWorld", url = "http://www.pcworld.com/", frequency = 11 });
            sites.Add(new WebsiteCollection { text = "Tech Republic", url = "http://techrepublic.com/", frequency = 3 });
            sites.Add(new WebsiteCollection { text = "Valleywag", url = "http://valleywag.gawker.com/", frequency = 6 });
            sites.Add(new WebsiteCollection { text = "Rediff", url = "http://in.rediff.com/", frequency = 9 });
            sites.Add(new WebsiteCollection { text = "WebProNews", url = "http://www.webpronews.com/", frequency = 2 });
            ViewBag.datasource = sites;
            return View();
        }

    }
}
