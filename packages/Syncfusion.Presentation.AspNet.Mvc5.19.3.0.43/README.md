The Syncfusion [.NET PowerPoint library](https://www.syncfusion.com/powerpoint-framework/net/powerpoint-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) (Essential Presentation) allows you to add advanced PowerPoint Presentations processing functionalities to any .NET Core application and does not require Microsoft PowerPoint application to be installed in the machine. It is a non-UI component that provides a full-fledged document instance model similar to the Microsoft Office COM libraries to iterate with the PowerPoint presentation elements explicitly and perform necessary manipulation. Using this library, you can create, read, edit and convert PowerPoint presentation programmatically. 

## Key Features
* Support to [create](https://help.syncfusion.com/file-formats/presentation/getting-started?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#creating-a-simple-powerpoint-presentation-with-basic-elements-from-scratch) PowerPoint presentation from scratch.
* [Open](https://help.syncfusion.com/file-formats/presentation/loading-and-saving-the-presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#opening-an-existing-presentation-from-file-system), [modify](https://help.syncfusion.com/file-formats/presentation/working-with-powerpoint-presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), and [save](https://help.syncfusion.com/file-formats/presentation/loading-and-saving-the-presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#saving-a-powerpoint-presentation-to-file-system) existing presentations.
* Ability to [convert PowerPoint presentation to PDF](https://help.syncfusion.com/file-formats/presentation/presentation-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget).
* Ability to [convert PowerPoint slides to images](https://help.syncfusion.com/file-formats/presentation/presentation-to-image?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget).
* Ability to [create](https://help.syncfusion.com/file-formats/presentation/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#creating-a-chartfrom-scratch) and [edit](https://help.syncfusion.com/file-formats/presentation/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#editing-the-chart-data) charts.
* Ability to [convert chart in a slide to image](https://help.syncfusion.com/file-formats/presentation/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#chart-to-image-conversion).
* Ability to [clone](https://help.syncfusion.com/file-formats/presentation/working-with-slide?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#cloning-slide) and [merge](https://help.syncfusion.com/file-formats/presentation/working-with-slide?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#merging-slide) slides in presentation
* Ability to [create](https://help.syncfusion.com/file-formats/presentation/working-with-animation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) and [edit](https://help.syncfusion.com/file-formats/presentation/working-with-animation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#edit-existing-animation-effect) animations.
* Ability to [create](https://help.syncfusion.com/file-formats/presentation/create-edit-slide-transitions-in-powerpoint-presentation-slides-cs-vb-net?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#set-a-transition-effect-to-a-powerpoint-slide) and [edit](https://help.syncfusion.com/file-formats/presentation/create-edit-slide-transitions-in-powerpoint-presentation-slides-cs-vb-net?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#modify-a-transition-effect-applied-to-a-powerpoint-slide) transition effects.
* Ability to [create](https://help.syncfusion.com/file-formats/presentation/comments?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#adding-a-comment) and [edit](https://help.syncfusion.com/file-formats/presentation/comments?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#modifying-the-comment) comments.
* Ability to [encrypt](https://help.syncfusion.com/file-formats/presentation/security?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#encrypting-with-password) and [decrypt](https://help.syncfusion.com/file-formats/presentation/security?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#decrypting-the-powerpoint-presentation) PowerPoint presentation.
* Ability to [set and remove write protection](https://help.syncfusion.com/file-formats/presentation/security?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#write-protection) of PowerPoint presentation.
* Ability to access the [Built-in](https://help.syncfusion.com/file-formats/presentation/working-with-powerpoint-presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#working-with-powerpoint-presentation-properties) and [Custom](https://help.syncfusion.com/file-formats/presentation/working-with-powerpoint-presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#custom-document-properties) document properties.
* Ability to [create](https://help.syncfusion.com/file-formats/presentation/working-with-sections?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#creating-a-section) and [modify](https://help.syncfusion.com/file-formats/presentation/working-with-sections?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) sections in PowerPoint presentation.

## Getting Started
You can fetch the Syncfusion .NET MVC PowerPoint library NuGet by simply running `Install-Package Syncfusion.Presentation.AspNet.Mvc5` from the Package Manager Console in Visual Studio.

You can also try some code examples of common use cases from our [GitHub Repository](https://github.com/syncfusion/ej2-aspnetmvc-samples/tree/master/Controllers/Presentation?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget).

## Create a PowerPoint Presentation programmatically using C# 

The following code example illustrates how to create a PowerPoint Presentation.

```csharp
//Creates a new instance of PowerPoint presentation.
IPresentation pptxDoc = Presentation.Create();
//Adds a slide to the PowerPoint Presentation.
ISlide firstSlide = pptxDoc.Slides.Add(SlideLayoutType.Blank);
//Adds a textbox in a slide by specifying its position and size.
IShape textShape = firstSlide.AddTextBox(100, 75, 756, 200);
//Adds a new paragraph with text.
textShape.TextBody.AddParagraph("Hello World");
//Saves the Presentation.
pptxDoc.Save("Sample.pptx");
//Closes the Presentation instance and free the memory consumed.
pptxDoc.Close();
```

## Manipulate the PowerPoint Presentation programmatically using C# 

The following code example illustrates how to manipulate the PowerPoint Presentation.

```csharp
//Opens an existing Presentation.
IPresentation pptxDoc = Presentation.Open("Template.pptx");
//To-Do some manipulation.
//To-Do some manipulation.
//Saves the Presentation.
pptxDoc.Save("Sample.pptx");
//Closes the Presentation instance and free the memory consumed.
pptxDoc.Close();
```

## Supported File Formats
* Creates, reads, and edits popular text file formats like PPTX, PPTM, POTX and POTM.
* Converts PowerPoint Presentation also to PDF, and Image.

## Compatible Microsoft PowerPoint Versions
* Microsoft PowerPoint 2007
* Microsoft PowerPoint 2010
* Microsoft PowerPoint 2013
* Microsoft PowerPoint 2016
* Microsoft PowerPoint 2019

## Resources
* **Product page:** [Syncfusion PowerPoint Framework](https://www.syncfusion.com/powerpoint-framework/net/powerpoint-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)
* **Documentation:** [Syncfusion PowerPoint library](https://help.syncfusion.com/file-formats/presentation/overview?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)
* **Online demo:** [Syncfusion PowerPoint library - Online demos](https://ej2.syncfusion.com/aspnetmvc/Presentation/Default?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget#/material)

* **Blog:** [Syncfusion PowerPoint library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)
* **Knowledge Base:** [Syncfusion PowerPoint library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)
* **Ebooks:** [Syncfusion PowerPoint library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)
* **FAQ:** [Syncfusion PowerPoint library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/powerpoint?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ASPNET%20MVC%20Presentation%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-presentation-nuget) | Toll Free: 1-888-9 DOTNET