<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595840/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328206)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomNextPageCommand.cs](./CS/ViewerCustomCommand/CustomNextPageCommand.cs) (VB: [CustomNextPageCommand.vb](./VB/ViewerCustomCommand/CustomNextPageCommand.vb))
* [CustomPdfViewerCommandFactoryService.cs](./CS/ViewerCustomCommand/CustomPdfViewerCommandFactoryService.cs) (VB: [CustomPdfViewerCommandFactoryService.vb](./VB/ViewerCustomCommand/CustomPdfViewerCommandFactoryService.vb))
* [Form1.cs](./CS/ViewerCustomCommand/Form1.cs) (VB: [Form1.vb](./VB/ViewerCustomCommand/Form1.vb))
* [Program.cs](./CS/ViewerCustomCommand/Program.cs) (VB: [Program.vb](./VB/ViewerCustomCommand/Program.vb))
<!-- default file list end -->
# How to replace standard PDF Viewer control command with your own custom command


This example shows how to modify the functionality of an existing PDF Viewer command.<br><br>The [WinForms PDF Viewer](https://www.devexpress.com/products/net/controls/winforms/pdf-viewer/) exposes the <strong>IPdfViewerCommandFactoryService</strong> interface that enables you to substitute the default command with your own custom command.<br><br>


<h3>Description</h3>

To accomplish this task:<br><br>-&nbsp;Create a custom command class (e.g., a <strong>CustomNextPageCommand</strong> class), inherited from the command that you wish to replace (e.g., <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPdfViewerCommandsPdfNextPageCommandMembersTopicAll">PdfNextPageCommand</a>).&nbsp; <br>- Override the required method of the command.&nbsp; The main functionality and command specifics is located in the<strong> Execute</strong> method.<br>- Create a class (e.g., <strong>CustomPdfViewerCommandFactoryService</strong>) implementing the <strong>IPdfViewerCommandFactoryService</strong>. You should override the <strong>CreateCommand</strong> method to create an instance of a custom command class if an identifier of a certain command is passed as a parameter. So, instead of the default command, a custom command will be used by the PdfViewer.<br>- Use the created class to substitute the default PdfViewer&rsquo;s service.

<br/>


