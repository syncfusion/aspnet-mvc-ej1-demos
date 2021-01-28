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
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class TagCloudController : Controller
    {
        //
        // GET: /TagCloudEvents/
        List<WebsiteCollection> cars = new List<WebsiteCollection>(); 
        public ActionResult Events()
        {
            cars.Add(new WebsiteCollection { text = "Hindustan Motors", url = "http://www.zigwheels.com/newcars/Hindustan-Motors", frequency = 10 });
            cars.Add(new WebsiteCollection { text = "Bentley Continental ", url = "http://www.zigwheels.com/newcars/Bentley/Continental", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "BMW 7", url = "http://www.zigwheels.com/newcars/BMW/7-Series", frequency = 8 });
            cars.Add(new WebsiteCollection { text = "Bugatti Veyron", url = "http://www.zigwheels.com/newcars/Bugatti/Veyron", frequency = 2 });
            cars.Add(new WebsiteCollection { text = "Honda", url = "http://www.zigwheels.com/newcars/Honda", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "Chevrolet Beat", url = "http://www.zigwheels.com/newcars/Chevrolet/Beat", frequency = 7 });
            cars.Add(new WebsiteCollection { text = "Force Motors", url = "http://www.zigwheels.com/newcars/Force-Motors/Gurkha", frequency = 5 });
            cars.Add(new WebsiteCollection { text = "Ford", url = "http://www.zigwheels.com/newcars/Ford", frequency = 8 });
            cars.Add(new WebsiteCollection { text = "Ferrari FF", url = "http://www.zigwheels.com/newcars/Ferrari/FF", frequency = 5 });
            cars.Add(new WebsiteCollection { text = "Audi A7", url = "http://www.zigwheels.com/newcars/Audi/A7", frequency = 20 });
            cars.Add(new WebsiteCollection { text = "HM Mitsubishi", url = "http://www.zigwheels.com/newcars/HM-Mitsubishi", frequency = 1 });
            cars.Add(new WebsiteCollection { text = "Hyundai Santro", url = "http://www.zigwheels.com/newcars/Hyundai/Santro-Xing", frequency = 9 });
            cars.Add(new WebsiteCollection { text = "Jaguar XKR", url = "http://www.zigwheels.com/newcars/Jaguar/XKR", frequency = 0 });
            cars.Add(new WebsiteCollection { text = "Rolls Royce", url = "http://www.zigwheels.com/newcars/Rolls-Royce", frequency = 6 });
            cars.Add(new WebsiteCollection { text = "Land Rover Range", url = "http://www.zigwheels.com/newcars/Land-Rover/Range-Rover", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "Mercedes Benz", url = "http://www.zigwheels.com/newcars/Mercedes-Benz/A-Class", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "Lamborghini", url = "http://www.zigwheels.com/newcars/Lamborghini/Gallardo", frequency = 14 });
            cars.Add(new WebsiteCollection { text = "Volvo S60", url = "http://www.zigwheels.com/newcars/Volvo/S60", frequency = 1 });
            ViewBag.datasource = cars;
            return View();
        }

    }
}
