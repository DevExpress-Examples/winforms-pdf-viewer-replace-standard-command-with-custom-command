<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595840/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328206)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# PDF Viewer for WinForms - Replace Standard PDF Viewer Control Command with a Custom Command

This example shows how to modify the functionality of an existing PDF Viewer command.

## Implementation Details

The WinForms PDF Viewer exposes the [IPdfViewerCommandFactoryService](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.IPdfViewerCommandFactoryService) interface that enables you to substitute the default command with your own custom command.

Create a custom command class (e.g., a <strong>CustomNextPageCommand</strong> class), inherited from the command that you wish to replace (e.g., [PdfNextPageCommand](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.Commands.PdfNextPageCommand)). Override the required method of the command. The main functionality and command specifics is located in the<strong> Execute</strong> method.

Create a class (e.g., <strong>CustomPdfViewerCommandFactoryService</strong>) implementing the <strong>IPdfViewerCommandFactoryService</strong>. Override the <strong>CreateCommand</strong> method to create an instance of a custom command class if an identifier of a certain command is passed as a parameter. Use the created class to substitute the default PdfViewer's service.

## Files to Review

* [CustomNextPageCommand.cs](./CS/ViewerCustomCommand/CustomNextPageCommand.cs) (VB: [CustomNextPageCommand.vb](./VB/ViewerCustomCommand/CustomNextPageCommand.vb))
* [CustomPdfViewerCommandFactoryService.cs](./CS/ViewerCustomCommand/CustomPdfViewerCommandFactoryService.cs) (VB: [CustomPdfViewerCommandFactoryService.vb](./VB/ViewerCustomCommand/CustomPdfViewerCommandFactoryService.vb))
* [Form1.cs](./CS/ViewerCustomCommand/Form1.cs) (VB: [Form1.vb](./VB/ViewerCustomCommand/Form1.vb))

## Documentation

* [How to: Replace Standard PDF Viewer Control Command with your own Custom Command](https://docs.devexpress.com/WindowsForms/115299/controls-and-libraries/pdf-viewer/examples/customization/how-to-replace-standard-pdf-viewer-control-command-with-your-own-custom-command)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pdf-viewer-replace-standard-command-with-custom-command&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pdf-viewer-replace-standard-command-with-custom-command&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
