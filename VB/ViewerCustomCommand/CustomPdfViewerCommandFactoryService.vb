Imports DevExpress.Utils
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraPdfViewer.Commands

Namespace ViewerCustomCommand

    Public Class CustomPdfViewerCommandFactoryService
        Implements IPdfViewerCommandFactoryService

        Private ReadOnly service As IPdfViewerCommandFactoryService

        Private ReadOnly control As PdfViewer

        Public Sub New(ByVal control As PdfViewer, ByVal service As IPdfViewerCommandFactoryService)
            Guard.ArgumentNotNull(control, "control")
            Guard.ArgumentNotNull(service, "service")
            Me.control = control
            Me.service = service
        End Sub

        Public Function CreateCommand(ByVal id As PdfViewerCommandId) As PdfViewerCommand Implements IPdfViewerCommandFactoryService.CreateCommand
            If id = PdfViewerCommandId.NextPage Then Return New CustomNextPageCommand(control)
            Return service.CreateCommand(id)
        End Function
    End Class
End Namespace
