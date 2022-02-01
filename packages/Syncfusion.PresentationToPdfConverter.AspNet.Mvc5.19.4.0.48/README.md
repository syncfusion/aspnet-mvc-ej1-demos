The [Syncfusion Essential Presentation](https://www.syncfusion.com/powerpoint-framework/net?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget) library converts a [PowerPoint presentation to PDF](https://www.syncfusion.com/powerpoint-framework/net/powerpoint-to-pdf-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget) with just five lines of code and also it does not require Adobe and Microsoft PowerPoint application to be installed in the machine. It preserves the original appearance of the PowerPoint presentation in the converted PDF document.

## Key Features
* Convert entire [PowerPoint presentation to PDF](https://help.syncfusion.com/file-formats/presentation/presentation-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget).
* Convert specific [PowerPoint slide to PDF](https://help.syncfusion.com/file-formats/presentation/presentation-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget).
* Convert PowerPoint presentation to PDF with,
  * [Auto shapes](https://help.syncfusion.com/file-formats/presentation/working-with-shapes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Images](https://help.syncfusion.com/file-formats/presentation/working-with-images?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Tables](https://help.syncfusion.com/file-formats/presentation/working-with-tables?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Charts](https://help.syncfusion.com/file-formats/presentation/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget#chart-to-image-conversion)
  * [Connectors](https://help.syncfusion.com/file-formats/presentation/create-edit-connectors-in-powerpoint-slides-cs-vb-net?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Header and Footer](https://help.syncfusion.com/file-formats/presentation/working-with-headers-and-footers?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [SmartArts](https://help.syncfusion.com/file-formats/presentation/smartart?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [OLE Objects](https://help.syncfusion.com/file-formats/presentation/working-with-ole-objects?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Group shapes](https://help.syncfusion.com/file-formats/presentation/working-with-shapes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Rich-text formatting](https://help.syncfusion.com/file-formats/presentation/working-with-paragraphs?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Paragraph alignments](https://help.syncfusion.com/file-formats/presentation/working-with-paragraphs?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Hyperlinks](https://help.syncfusion.com/file-formats/presentation/working-with-hyperlinks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Handouts](https://help.syncfusion.com/file-formats/presentation/presentation-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [Notes Pages](https://help.syncfusion.com/file-formats/presentation/presentation-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
  * [PDF Conformance](https://help.syncfusion.com/file-formats/presentation/presentation-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
* Support to run the Presentation applications in multi-thread and its thread safe.

## Getting Started
You can fetch the Syncfusion .NET MVC PowerPoint library NuGet by simply running `Install-Package Syncfusion.PresentationToPdfConverter.AspNet.Mvc5` from the Package Manager Console in Visual Studio.

You can also try some code examples of common use cases from our [GitHub Repository](https://github.com/syncfusion/ej2-aspnetmvc-samples/tree/master/Controllers/Presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget).

## Convert PPTX to PDF programmatically using C# 

The following code example illustrates how to convert the PowerPoint Presentation to PDF.

```csharp
//Open the existing PowerPoint presentation.
IPresentation pptxDoc = Presentation.Open("Template.pptx");
//Convert the PowerPoint document to PDF document.
PdfDocument pdfDocument = PresentationToPdfConverter.Convert(pptxDoc);
//Save the converted PDF document.
pdfDocument.Save("Sample.pdf");
//Close the PDF document.
pdfDocument.Close(true);
//Close the PowerPoint Presentation.
pptxDoc.Close();
```
## Supported File Formats
* Creates, reads, and edits popular text file formats like PPTX, PPTM, POTX and POTM.
* Converts PowerPoint Presentation to PDF.

## Compatible Microsoft PowerPoint Versions
* Microsoft PowerPoint 2007
* Microsoft PowerPoint 2010
* Microsoft PowerPoint 2013
* Microsoft PowerPoint 2016
* Microsoft PowerPoint 2019

## Resources
* **Product page:** [Syncfusion PowerPoint Framework](https://www.syncfusion.com/powerpoint-framework/net/powerpoint-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
* **Documentation:** [Syncfusion PowerPoint library](https://help.syncfusion.com/file-formats/presentation/overview?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
* **Online demo:** [Syncfusion PowerPoint library - Online demos](https://ej2.syncfusion.com/aspnetmvc/Presentation/Default?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget#/material)

* **Blog:** [Syncfusion PowerPoint library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
* **Knowledge Base:** [Syncfusion PowerPoint library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
* **Ebooks:** [Syncfusion PowerPoint library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)
* **FAQ:** [Syncfusion PowerPoint library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/powerpoint?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ASPNET%20MVC%20PresentationToPdfConverter%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentationtopdfconverter-nuget) | Toll Free: 1-888-9 DOTNET