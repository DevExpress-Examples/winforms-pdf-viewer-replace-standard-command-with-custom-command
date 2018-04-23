using DevExpress.XtraPdfViewer;
using System;
using System.Windows.Forms;

namespace ViewerCustomCommand {
    public partial class Form1 : Form {

        void ReplacePdfViewerCommandFactoryService(PdfViewer control) {
            IPdfViewerCommandFactoryService service = control.GetService<IPdfViewerCommandFactoryService>();
            if (service == null)
                return;
            control.RemoveService(typeof(IPdfViewerCommandFactoryService));
            control.AddService(typeof(IPdfViewerCommandFactoryService), new CustomPdfViewerCommandFactoryService(control,service));
        }

        public Form1() {
            InitializeComponent();
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");
            ReplacePdfViewerCommandFactoryService(pdfViewer1);
        }     
    }
}
