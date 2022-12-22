#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
using Syncfusion.Presentation;
using System.Drawing;
using System.IO;

namespace MVCSampleBrowser.Controllers
{
    public partial class PresentationController : Controller
    {
        public ActionResult EncryptAndDecrypt(string Group1, string Group2)
        {
            string file = ResolveApplicationDataPath("Syncfusion Presentation.pptx");
            if (Group1 == null)
                return View();
            IPresentation presentation;
            if (Group1 == "CreateEncryptDoc")
            {
                presentation = Presentation.Open(file, "syncfusion");
                presentation.Encrypt("syncfusion");
                return new PresentationResult(presentation, "Encryption.pptx", HttpContext.ApplicationInstance.Response);
            }
            else
            {
                presentation = Presentation.Open(file, "syncfusion");
                presentation.RemoveEncryption();
                return new PresentationResult(presentation, "Decryption.pptx", HttpContext.ApplicationInstance.Response);
            }           
        }
    }
}