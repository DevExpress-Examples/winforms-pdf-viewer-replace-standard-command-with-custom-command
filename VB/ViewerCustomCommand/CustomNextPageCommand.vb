Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraPdfViewer.Commands
Imports System.Windows.Forms

Namespace ViewerCustomCommand

    Public Class CustomNextPageCommand
        Inherits PdfNextPageCommand

        Public Sub New(ByVal control As PdfViewer)
            MyBase.New(control)
        End Sub

        Public Overrides Sub Execute()
            MessageBox.Show("Custom command executed")
            MyBase.Execute()
        End Sub
    End Class
End Namespace
