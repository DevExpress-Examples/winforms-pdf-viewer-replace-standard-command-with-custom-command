Imports DevExpress.XtraPdfViewer
Imports System.Windows.Forms

Namespace ViewerCustomCommand

    Public Partial Class Form1
        Inherits Form

        Private Sub ReplacePdfViewerCommandFactoryService(ByVal control As PdfViewer)
            Dim service As IPdfViewerCommandFactoryService = control.GetService(Of IPdfViewerCommandFactoryService)()
            If service Is Nothing Then Return
            control.RemoveService(GetType(IPdfViewerCommandFactoryService))
            control.AddService(GetType(IPdfViewerCommandFactoryService), New CustomPdfViewerCommandFactoryService(control, service))
        End Sub

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument("..\..\Demo.pdf")
            ReplacePdfViewerCommandFactoryService(pdfViewer1)
        End Sub
    End Class
End Namespace
