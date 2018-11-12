using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class DropdownlistController : Controller
    {
        //
        // GET: /DropdownListMethods/
        List<Books> book = new List<Books>();
        public ActionResult Methods()
        {
            book.Add(new Books { category = "Art", text = "1 Item", id = 0 });
            book.Add(new Books { category = "Architecture", id = 1, text = "2 Item" });
            book.Add(new Books { category = "Biographies", id = 2, text = "3 Item" });
            book.Add(new Books { category = "Business", id = 3, text = "4 Item" });
            book.Add(new Books { category = "ComputerIT", id = 4, text = "5 Item" });
            book.Add(new Books { category = "Comics", id = 5, text = "6 Item" });
            book.Add(new Books { category = "Cookery", id = 6, text = "7 Item" });
            book.Add(new Books { category = "Environment", id = 7, text = "8 Item" });
            book.Add(new Books { category = "Fiction", id = 8, text = "9 Item" });
            book.Add(new Books { category = "Health", id = 9, text = "10 Item" });
            book.Add(new Books { category = "Humanities", id = 10, text = "11 Item" });
            book.Add(new Books { category = "Language", id = 11, text = "12 Item" });
            book.Add(new Books { category = "Literature", id = 12, text = "13 Item" });
            book.Add(new Books { category = "Memoirs", id = 13, text = "14 Item" });
            book.Add(new Books { category = "Management", id = 14, text = "15 Item" });
            book.Add(new Books { category = "Professional", id = 15, text = "16 Item" });
            book.Add(new Books { category = "Reference", id = 16, text = "17 Item" });
            book.Add(new Books { category = "Spirituality", id = 17, text = "18 Item" });
            book.Add(new Books { category = "Sports", id = 18, text = "19 Item" });
            book.Add(new Books { category = "Sciences", id = 19, text = "20 Item" });
            ViewBag.datasource = book;
            return View();
        }

    }
}
