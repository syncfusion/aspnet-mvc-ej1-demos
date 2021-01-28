#region Copyright Syncfusion Inc. 2001 - 2021
// Copyright Syncfusion Inc. 2001 - 2021. All rights reserved.
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
using System.IO;
using System.Drawing;
using Syncfusion.PresentationToPdfConverter;
using Syncfusion.Presentation;
using Syncfusion.Pdf;
using Syncfusion.Mvc.Pdf;

namespace MVCSampleBrowser.Controllers
{
    
    public partial class PresentationController : Controller
    {
        public static List<string> imageList = new List<string>();
        //
        // GET: /PresentationViewer/
        List<string> pptxFiles = new List<string>(4) { "CreatePresentation.pptx", "Reporting.pptx", "NewCharts.pptx", "Overview.pptx" };
        string path = null;
        public string PathName
        {
            get
            {
                return path;
            }
            set{ path = value; }
        }

        public ActionResult PresentationViewer()
        {
            //foreach(string file in pptxFiles)
            //{
                IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(pptxFiles[0]));
                ConvertToImages(presentation, pptxFiles[0]);
                
           // }
           // imageList.Clear();
            return View();
        }

        //[AcceptVerbs(HttpVerbs.Post)]

        ////public ActionResult PresentationViewer(FormCollection name)
        ////{
        //    string filename = pptxFiles[0];

        //    IPresentation presentation = Presentation.Open(ResolveApplicationDataPath(filename));

        //    //To set each slide in a pdf page.
        //    PresentationToPdfConverterSettings settings = new PresentationToPdfConverterSettings();

        //    settings.ShowHiddenSlides = true;

        //    PdfDocument doc = new PdfDocument();
        //    //Instance to create pdf document from presentation
        // //   PdfDocument doc = PresentationToPdfConverter.Convert(presentation, settings);
           
        //    string path = Path.GetFileNameWithoutExtension(filename);

        //    //Saves the pdf document
        //    doc.ExportAsActionResult("PptToPdfSample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);

        //    return View();
           
        //}

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PresentationViewer(FormCollection collection)
        {
            string variable = collection.AllKeys[0].Substring(0,6);
            String filename = null;
            switch(variable)
            {
                case "Slide1":
                    filename = ResolveApplicationDataPath(pptxFiles[0]);
                    break;
                case "Slide2":
                    filename = ResolveApplicationDataPath(pptxFiles[1]);
                    break;
                case "Slide3":
                    filename = ResolveApplicationDataPath(pptxFiles[2]);
                    break;
                case "Slide4":
                    filename = ResolveApplicationDataPath(pptxFiles[3]);
                    break;
            }
            IPresentation presentation = Presentation.Open(filename);
            ConvertToImages(presentation, filename);
            this.PathName = filename;
            return View();
        }
       

        private void ConvertToImages(IPresentation presentation, string filename)
        {
            int i = 1;
            imageList.Clear();
            List<Image> Values = new List<Image>(4);
            string name = null;
            string itemPath = "../images/presentation/";
            foreach (ISlide slide in presentation.Slides)
            {
                //Converts slide to image
                System.Drawing.Image image = System.Drawing.Image.FromStream(slide.ConvertToImage(Syncfusion.Drawing.ImageFormat.Emf));
                System.Drawing.Image.GetThumbnailImageAbort myCallback =
                                    new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
                System.Drawing.Image newImage = image.GetThumbnailImage(690, 400, myCallback, System.IntPtr.Zero);
                name = Path.GetFileNameWithoutExtension(filename);
                string dataPath = string.Format("{0}\\Images\\presentation\\", Request.PhysicalPath.ToLower().Split(new string[] { "\\web" }, StringSplitOptions.None));
                string fileName = Path.GetFullPath(dataPath) + name;
                Directory.CreateDirectory(fileName);
                fileName = fileName + "\\" + name + i + ".jpg";
                newImage.Save(fileName);
              
                imageList.Add(itemPath + name + "/"+ name+ i + ".jpg");
                //Saves the image
                i += 1;

            }
          
            
        }

        public bool ThumbnailCallback()
        {
            return false;
        }
    }
}


     
  
   