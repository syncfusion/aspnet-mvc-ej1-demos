The [Syncfusion Essential DocIO](https://www.syncfusion.com/word-framework/net/word-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget) library converts a [Word document to PDF](https://www.syncfusion.com/word-framework/net/word-to-pdf-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget) with just five lines of code and also it does not require Adobe and Microsoft Word application to be installed in the machine. It preserves the original appearance of the Word document in the converted PDF document.

## Key Features
* Convert [Word document into PDF](https://help.syncfusion.com/file-formats/docio/word-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget).
* Convert Word document to PDF with,
  * [Tables](https://help.syncfusion.com/file-formats/docio/working-with-tables?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Charts](https://help.syncfusion.com/file-formats/docio/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Shapes](https://help.syncfusion.com/file-formats/docio/working-with-shapes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Group shape](https://help.syncfusion.com/file-formats/docio/working-with-shapes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget#grouping-shapes) in DOCX and WordML format documents
  * [Bookmarks](https://help.syncfusion.com/file-formats/docio/working-with-bookmarks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Fields](https://help.syncfusion.com/file-formats/docio/working-with-fields?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Form fields](https://help.syncfusion.com/file-formats/docio/working-with-form-fields?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [OLE objects](https://help.syncfusion.com/file-formats/docio/working-with-paragraph#appending-ole-objects?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Watermark](https://help.syncfusion.com/file-formats/docio/applying-watermark?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Comments](https://help.syncfusion.com/file-formats/docio/working-with-comments?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Footnotes and endnotes](https://help.syncfusion.com/file-formats/docio/working-with-footnotes-and-endnotes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Content controls](https://help.syncfusion.com/file-formats/docio/working-with-content-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Mathematical equation](https://help.syncfusion.com/file-formats/docio/working-with-mathematical-equation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [Track changes](https://help.syncfusion.com/file-formats/docio/accepting-or-rejecting-track-changes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* Convert commonly used file formats into PDF such as,
  * [DOC](https://help.syncfusion.com/file-formats/docio/word-file-formats#word-binary-97-2003-format?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [DOCX](https://help.syncfusion.com/file-formats/docio/word-file-formats?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [RTF](https://help.syncfusion.com/file-formats/docio/rtf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [WordML](https://help.syncfusion.com/file-formats/docio/word-file-formats?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget#word-processing-xml-xml)
  * [TXT](https://help.syncfusion.com/file-formats/docio/text?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
  * [HTML](https://help.syncfusion.com/file-formats/docio/html?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* Support to run the DocIO applications in multi-thread and its thread safe.

## Getting Started
You can fetch the Syncfusion .NET MVC Word library NuGet by simply running `Install-Package Syncfusion.DocToPDFConverter.AspNet.Mvc5` from the Package Manager Console in Visual Studio.

You can also try some code examples of common use cases from our [GitHub Repository](https://github.com/syncfusion/ej2-aspnetmvc-samples/tree/master/Controllers/DocIO?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget).

## Convert Word document to PDF programmatically using C# 

The following code example illustrates how to convert a Word document into PDF document.

```csharp
//Loads an existing Word document.
WordDocument wordDocument = new WordDocument("Template.docx", Syncfusion.DocIO.FormatType.Automatic);
//Creates an instance of the DocToPDFConverter.
DocToPDFConverter converter = new DocToPDFConverter();
//Converts Word document into PDF document.
PdfDocument pdfDocument = render.ConvertToPDF(wordDocument);
//Saves the PDF file.
pdfDocument.Save("Sample.pdf");
//Closes the instance of document objects.
pdfDocument.Close(true);
wordDocument.Close();
```

## Supported File Formats
* Creates, reads, and edits popular text file formats like DOC, DOT, DOCM, DOTM, DOCX, DOTX, HTML, RTF, TXT, and XML (WordML). 
* Converts Word documents also to PDF, and ODT files.

## Compatible Microsoft Word Versions
* Microsoft Word 97-2003
* Microsoft Word 2007
* Microsoft Word 2010
* Microsoft Word 2013
* Microsoft Word 2016
* Microsoft Word 2019

## Resources
* **Product page:** [Syncfusion Word Framework](https://www.syncfusion.com/word-framework/net/word-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* **Documentation:** [Syncfusion Word library](https://help.syncfusion.com/file-formats/docio/overview?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* **Online demo:** [Syncfusion Word library - Online demos](https://ej2.syncfusion.com/aspnetmvc/DocIO/UpdateFields?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget#/material)
* **Blog:** [Syncfusion Word library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* **Knowledge Base:** [Syncfusion Word library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* **Ebooks:** [Syncfusion Word library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)
* **FAQ:** [Syncfusion Word library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/word?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ASPNET%20MVC%20DocToPdfConverter%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-doctopdfconverter-nuget) | Toll Free: 1-888-9 DOTNET