The Syncfusion Essential [HTML-to-PDF converter](https://www.syncfusion.com/pdf-framework/net/html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) is a .NET library that converts URLs, HTML string to PDF in any ASP.NET MVC application. This converter uses IE rendering engine.


## Key features:
* Converts any [webpage to PDF.](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#url-to-pdf)
* Converts any raw [HTML string to PDF.] (https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#html-string-to-pdf)
* Support to create [table of contents] (https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#table-of-contents) automatically.
* Support to [form](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#form-authentication), [windows](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#windows-authentication) and [token](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#token-based-authentication) based authentications.
* Support to [system](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#token-based-authentication) and [manual](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#manual-proxy) proxy.
* Works both in 32-bit and 64-bit environments.
* Supports header and footer.
* Repeats HTML table header and footer in PDF.
* Supports HTML5, CSS3, SVG, and Web fonts.
* Support to run the applications in multi-thread and its thread safe. 
* Supports internal and external hyperlinks.
* Sets document properties, page settings, security, viewer preferences, etc.
* Protects PDF document with password and permission.

## Getting Started
You can fetch the Syncfusion .NET MVC HTML to PDF NuGet by simply running `Install-Package Syncfusion.HtmlToPdfConverter.IE.AspNet.Mvc5` from the Package Manager Console in Visual Studio.

## Convert HTML to PDF document programmatically using C#

```csharp
//Initialize HTML to PDF converter 
HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(); 

//Convert HTML to PDF document 
PdfDocument document = htmlConverter.Convert("https://www.syncfusion.com");
 
//Save and close the PDF document 
document.Save("Output.pdf");
document.Close(true);
```

## Resources

* **Product page:** [Syncfusion HTML to PDF]( https://www.syncfusion.com/pdf-framework/net/html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* **Documentation:** [Syncfusion HTML to PDF library](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/ie?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* **Blog:** [Syncfusion Excel library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* **Knowledge Base:** [Syncfusion Excel library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* **Ebooks:** [Syncfusion Excel library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* **FAQ:** [Syncfusion Excel library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://support.syncfusion.com/create?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ASPNET%20MVC%20HTMLtoPDF%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | Toll Free: 1-888-9 DOTNET