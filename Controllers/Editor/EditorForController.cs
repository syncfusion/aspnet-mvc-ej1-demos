#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Models;
using MVCSampleBrowser.Models;


namespace MVCSampleBrowser.Controllers
{  
    public partial class EditorController : Controller
    {        
        
        public ActionResult EditorFor()
        {
            //Editor For
            EditorProperties editor = new EditorProperties();
            editor.EnableStrictMode = true;
            ViewData["editmodel"] = editor;

            //Mask Edit
            MaskEditProperties maskmodel = new MaskEditProperties();
            maskmodel.WatermarkText = "Enter value";
            maskmodel.MaskFormat = "99-999-99999";
            ViewData["MaskModel"] = maskmodel;

            return View(new EditorValue());
        }
        [HttpPost]
        public ActionResult EditorFor(EditorValue model)
        {
            //Editor For
            EditorProperties editor = new EditorProperties();
            editor.EnableStrictMode = true;
            ViewData["editmodel"] = editor;

            //Mask Edit
            MaskEditProperties maskmodel = new MaskEditProperties();
            maskmodel.WatermarkText = "watermark";
            maskmodel.MaskFormat = "99-99-99999";
            ViewData["MaskModel"] = maskmodel;

            return View(model);
        }

    }
    
   
}
