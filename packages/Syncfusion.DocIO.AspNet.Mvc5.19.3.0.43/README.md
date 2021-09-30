The Syncfusion [.NET Word library](https://www.syncfusion.com/word-framework/net/word-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) (Essential DocIO) allows you to add advanced Word document processing functionalities to any ASP.NET MVC application and does not require Microsoft Word application to be installed in the machine. It is a non-UI component that provides a full-fledged document instance model similar to the Microsoft Office COM libraries to iterate with the document elements explicitly and perform necessary manipulation. Using this library, you can [create](https://www.syncfusion.com/word-framework/net/word-library/create-word-documents?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), read, edit and convert Word documents programmatically. 

## Key Features
* Support to [create Word document](https://help.syncfusion.com/file-formats/docio/getting-started?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) from scratch.
* Support to open (read), modify and save existing Word documents.
* Advanced [Mail merge](https://help.syncfusion.com/file-formats/docio/working-with-mailmerge?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) support with different data sources.
* Ability to create or edit Word 97-2003 and later version documents (DOCX), and convert them to commonly used file formats such as [RTF](https://help.syncfusion.com/file-formats/docio/rtf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [WordML](https://help.syncfusion.com/file-formats/docio/word-file-formats?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget#word-processing-xml-xml), [TXT](https://help.syncfusion.com/file-formats/docio/text?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [HTML](https://help.syncfusion.com/file-formats/docio/html?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) and vice versa.
* Ability to export a Word document as an [Image](https://help.syncfusion.com/file-formats/docio/word-to-image?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) and [PDF](https://help.syncfusion.com/file-formats/docio/word-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) file.
* Ability to create and manipulate [charts](https://help.syncfusion.com/file-formats/docio/working-with-charts?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [Shapes](https://help.syncfusion.com/file-formats/docio/working-with-shapes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), and [Group shape](https://help.syncfusion.com/file-formats/docio/working-with-shapes?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget#grouping-shapes) in DOCX and WordML format documents.
* Ability to read and write [Built-In and Custom Document Properties](https://help.syncfusion.com/file-formats/docio/working-with-word-document?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget#working-with-word-document-properties).
* Ability to [find and replace](https://help.syncfusion.com/file-formats/docio/working-with-find-and-replace?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) text with its original formatting.
* Ability to insert [Bookmarks](https://help.syncfusion.com/file-formats/docio/working-with-bookmarks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) and navigate corresponding bookmarks to insert, replace, and delete content.
* Support to insert and edit the [form fields](https://help.syncfusion.com/file-formats/docio/working-with-form-fields?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget).
* Support to protect the document to [restrict access](https://help.syncfusion.com/file-formats/docio/working-with-security?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget#protecting-word-document-from-editing) to the elements present within the document.
* Ability to [encrypt and decrypt](https://help.syncfusion.com/file-formats/docio/working-with-security?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) Word documents.
* Support to insert and extract OLE objects.
* Support to run the DocIO applications in multi-thread and its thread safe.

## Getting Started
You can fetch the Syncfusion ASP.NET MVC Word library NuGet by simply running `Install-Package Syncfusion.DocIO.AspNet.Mvc5` from the Package Manager Console in Visual Studio.

You can also try some code examples of common use cases from our [GitHub Repository](https://github.com/syncfusion/ej2-aspnetmvc-samples/tree/master/Controllers/DocIO?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget).

## Create a Word Document programmatically using C# 

The following code example illustrates how to create a Word document.

```csharp
//Creates a new instance of WordDocument (Empty Word Document).
WordDocument document = new WordDocument();
//Adds a section and a paragraph to the document.
document.EnsureMinimal();
//Appends text to the last paragraph of the document.
document.LastParagraph.AppendText("Hello World");
//Saves the Word document.
document.Save("Sample.docx", FormatType.Docx);
//Closes the document.
document.Close();
```

## Manipulate the Word document programmatically using C# 

The following code example illustrates how to manipulate the Word document.

```csharp
//Opens an existing Word document.
WordDocument document = new WordDocument("Template.docx", FormatType.Automatic);
//To-Do some manipulation.
//To-Do some manipulation.
//Saves the Word document.
document.Save("Sample.docx", FormatType.Docx);
//Closes the document.
document.Close();
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
* **Product page:** [Syncfusion Word Framework](https://www.syncfusion.com/word-framework/net/word-library?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)
* **Documentation:** [Syncfusion Word library](https://help.syncfusion.com/file-formats/docio/overview?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)
* **Online demo:** [Syncfusion Word library - Online demos](https://ej2.syncfusion.com/aspnetmvc/DocIO/UpdateFields?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget#/material)
* **Blog:** [Syncfusion Word library - Blog](https://www.syncfusion.com/blogs/category/asp-net-mvc?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)
* **Knowledge Base:** [Syncfusion Word library - Knowledge Base](https://www.syncfusion.com/kb/aspnetmvc-js2?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)
* **Ebooks:** [Syncfusion Word library - Ebooks](https://www.syncfusion.com/succinctly-free-ebooks?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)
* **FAQ:** [Syncfusion Word library - FAQ](https://www.syncfusion.com/faq/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)

## Support and feedback
* For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget).
* Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback/word?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget).

## License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget). You can purchase a licnense [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

___

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20ASPNET%20MVC%20DocIO%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-docio-nuget) | Toll Free: 1-888-9 DOTNET