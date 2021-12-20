Syncfusion [ExcelChart-to-Image converter](https://www.syncfusion.com/word-framework/net/word-to-pdf-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget) is a .NET class library for converting Excel chart to image in any ASP.NET MVC application without using Microsoft Office dependencies.

## Key features

* Following chart types are supported in Excel Chart To Image Conversion.
  * Area
  * Area_Stacked
  * Area_Stacked_100
  * Area_3D
  * Bar_Clustered
  * Bar_Stacked
  * Bar_Stacked_100
  * Bar_Clustered_3D
  * Bar_Stacked_3D
  * Bar_Stacked_100_3D
  * Bubble
  * Column_Clustered
  * Column_Stacked
  * Column_Stacked_100
  * Column_3D
  * Column_Clustered_3D
  * Column_Stacked_3D
  * Column_Stacked_100_3D
  * Doughnut
  * Doughnut_Exploded
  * Line
  * Line_Markers
  * Line_3D
  * Pie
  * Pie_Exploded
  * Pie_3D
  * Pie_Exploded_3D
  * Radar
  * Radar_Filled
  * Radar_Markers
  * Scatter_Line
  * Scatter_Line_Markers
  * Scatter_Markers
  * Scatter_SmoothedLine
  * Scatter_SmoothedLine_Markers
  * Stock_HighLowClose
  * Stock_OpenHighLowClose
  * Funnel
  * Waterfall
  * Histogram
  * Pareto

* Following chart elements are supported in Excel Chart to Image Conversion.
  * Axis
  * Axis titles
  * Chart title
  * Data labels
  * Grid lines
  * Legend
  * Trend line

## Getting Started

### Installation commands

* Simply run **Install-Package Syncfusion.ExcelChartToImageConverter.AspNet.Mvc5** from the Package Manager Console in Visual Studio to fetch the NuGet package.
* If you already have **Syncfusion.ExcelChartToImageConverter.AspNet.Mvc5** for .NET and want to upgrade the version, please run **Update-Package Syncfusion.ExcelChartToImageConverter.AspNet.Mvc5** to get the latest version.
* You can run the following snippets in your environment to see how **Syncfusion.ExcelChartToImageConverter.AspNet.Mvc5** works.

### Convert the chart in Excel workbook to Image

The following code snippet explains how to convert an Excel chart to Image.

```csharp
//Initialize ExcelEngine.
using (ExcelEngine excelEngine = new ExcelEngine())
{
    //Initialize IApplication.
    IApplication application = excelEngine.Excel;
	//Set the default version as Xlsx.
    application.DefaultVersion = ExcelVersion.Xlsx;
	//Initialize ChartToImageConverter.
    application.ChartToImageConverter = new ChartToImageConverter();
	//Set the Best scaling mode to ChartToImageConverter.
    application.ChartToImageConverter.ScalingMode = ScalingMode.Best;
	//Load an existing workbook into IWorkbook.
    IWorkbook workbook = application.Workbooks.Open(Server.MapPath("App_Data/Sample.xlsx"));
    //Get the worksheet into IWorksheet.
    IWorksheet worksheet = workbook.Worksheets[0];
	//Get the chart into IChart.
    IChart chart = worksheet.Charts[0];
    //Convert the Chart to Image
    MemoryStream stream = new MemoryStream();
    chart.SaveAsImage(stream);
    //Save the Image.
    Image image = Image.FromStream(stream);
    image.Save("Output.png");
}
```

## Resources
* **Product page:** [Syncfusion Excel Framework](https://www.syncfusion.com/excel-framework/net-core?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)
* **Documentation:** [Syncfusion Excel library](https://help.syncfusion.com/file-formats/xlsio/chart-to-image-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)
* **Blog:** [Syncfusion Excel library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)
* **Knowledge Base:** [Syncfusion Excel library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)
* **Ebooks:** [Syncfusion Excel library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)
* **FAQ:** [Syncfusion Excel library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/excel?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

		
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget). To acquire a license, you can purchase one [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget).

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ExcelChartToImage%20ASP.NET%20MVC-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-excelcharttoimageconverter-nuget) | Toll Free: 1-888-9 DOTNET