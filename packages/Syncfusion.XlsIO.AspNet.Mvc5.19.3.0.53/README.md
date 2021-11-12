[Syncfusion Essential XlsIO](https://www.syncfusion.com/excel-framework/net?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) is a high-performance and feature-rich .NET Excel library to work with Microsoft Excel documents. This Excel library allows you to create, read, and edit Microsoft Excel files in ASP.NET MVC application. It offers APIs to support Microsoft Excel equivalent features along with conversion APIs to easily convert Excel files to PDF, images, and more.

## Key features
* Easily [import and export](https://help.syncfusion.com/file-formats/xlsio/working-with-data?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) data from/to common business objects.
* Performs quick [evaluation](https://help.syncfusion.com/file-formats/xlsio/working-with-formulas?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) with 400+ functions.
* Imports data into a customized format using [Template Markers](https://help.syncfusion.com/file-formats/xlsio/working-with-template-markers?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).
* Create and edit all [chart](https://help.syncfusion.com/file-formats/xlsio/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) types including Excel 2016 charts.
* Cell [data validations](https://help.syncfusion.com/file-formats/xlsio/working-with-data-validation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) can be applied with operators, alert messages, custom formulas, and drop-down lists.
* Highlights important cells by [conditional formats](https://help.syncfusion.com/file-formats/xlsio/working-with-conditional-formatting?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).
* Performs various [cell-level operations](https://help.syncfusion.com/file-formats/xlsio/worksheet-cells-manipulation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) like resizing, hide or unhide, insert or delete, group and ungroup, and so on.
* Supports various [formatting](https://help.syncfusion.com/file-formats/xlsio/working-with-cell-or-range-formatting?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) like number formats, text alignments, font settings, border settings, color settings, rich-text, and so on.
* Supports applying built-in styles and custom styles to cells.
* [Sorts](https://help.syncfusion.com/file-formats/xlsio/worksheet-cells-manipulation#data-sorting?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) data based on cell value, cell color, and font color.
* [Filters](https://help.syncfusion.com/file-formats/xlsio/worksheet-cells-manipulation#data-filtering?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) data based on cell value, cell color, icons, and so on.
* Create and edit the [auto shapes, comments, text boxes, combo boxes, check boxes, and option buttons](https://help.syncfusion.com/file-formats/xlsio/working-with-drawing-objects?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).
* Enables [page settings](https://help.syncfusion.com/file-formats/xlsio/working-with-excel-worksheet#page-setup-settings?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) like orientation, paper size, scaling, margins, print titles, header and footer, and so on.

## Getting Started

### Installation commands

* Simply run **Install-Package Syncfusion.XlsIO.AspNet.Mvc5** from the Package Manager Console in Visual Studio to fetch the NuGet package.
* If you already have **Syncfusion.XlsIO.AspNet.Mvc5** for .NET and want to upgrade the version, please run **Syncfusion.XlsIO.AspNet.Mvc5** to get the latest version.
* You can run the following snippets in your environment to see how **Syncfusion.XlsIO.AspNet.Mvc5** works.

### Create an Excel document using XlsIO

The following code snippet explains how to create an Excel document.

```csharp
//Initialize ExcelEngine.
using (ExcelEngine excelEngine = new ExcelEngine())
{
    //Initialize IApplication.
	IApplication application = excelEngine.Excel;
	//Set the default version as Xlsx.
	application.DefaultVersion = ExcelVersion.Xlsx;
    //Create a new workbook with one worksheet.
	IWorkbook workbook = application.Workbooks.Create(1);
	//Get the worksheet into IWorksheet.
	IWorksheet worksheet = workbook.Worksheets[0];
	//Set a value to Excel cell.
	worksheet.Range["A1"].Value = "Hello World";
    //Save the Excel document.
	workbook.SaveAs("Output.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.Open);
}
```

### Read an Excel document using XlsIO

The following code snippet explains how to read an Excel document.

```csharp
//Initialize ExcelEngine.
using (ExcelEngine excelEngine = new ExcelEngine())
{
    //Initialize IApplication.
    IApplication application = excelEngine.Excel;
	//Set the default version as Xlsx.
    application.DefaultVersion = ExcelVersion.Xlsx;
    //Load an existing workbook into IWorkbook.
    IWorkbook workbook = application.Workbooks.Open(Server.MapPath("App_Data/Sample.xlsx"));
    //Save the Excel document.
	workbook.SaveAs("Output.xlsx", HttpContext.ApplicationInstance.Response, ExcelDownloadType.Open);
}
```

## File Formats supported by XlsIO

Syncfusion Essential XlsIO supports .xls, .xlsx, .xlsm, .xltm, .xltx, .xml, .csv, .txt and .ods file formats.

## Compatible Microsoft Excel Versions
* Microsoft Excel 97-2003
* Microsoft Excel 2007
* Microsoft Excel 2010
* Microsoft Excel 2013
* Microsoft Excel 2016
* Microsoft Excel 2019

## Resources
* **Product page:** [Syncfusion Excel Framework](https://www.syncfusion.com/excel-framework/net?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)
* **Documentation:** [Syncfusion Excel library](https://help.syncfusion.com/file-formats/xlsio/overview?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)
* **Online demo:** [Syncfusion Excel library - Online demos](https://ej2.syncfusion.com/aspnetmvc/XlsIO/Default#/material?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)

* **Blog:** [Syncfusion Excel library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)
* **Knowledge Base:** [Syncfusion Excel library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)
* **Ebooks:** [Syncfusion Excel library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)
* **FAQ:** [Syncfusion Excel library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/excel?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

		
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget). To acquire a license, you can purchase one [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget).

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ASPNET%20MVC%20XlSIO%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-xlsio-nuget) | Toll Free: 1-888-9 DOTNET

