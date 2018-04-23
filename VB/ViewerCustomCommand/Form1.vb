Imports DevExpress.XtraPdfViewer
Imports System
Imports System.Windows.Forms

Namespace ViewerCustomCommand
    Partial Public Class Form1
        Inherits Form

        Private Sub ReplacePdfViewerCommandFactoryService(ByVal control As PdfViewer)
            Dim service As IPdfViewerCommandFactoryService = control.GetService(Of IPdfViewerCommandFactoryService)()
            If service Is Nothing Then
                Return
            End If
            control.RemoveService(GetType(IPdfViewerCommandFactoryService))
            control.AddService(GetType(IPdfViewerCommandFactoryService), New CustomPdfViewerCommandFactoryService(control,service))
        End Sub

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument("..\..\Demo.pdf")
            ReplacePdfViewerCommandFactoryService(pdfViewer1)
        End Sub
    End Class
End Namespace
