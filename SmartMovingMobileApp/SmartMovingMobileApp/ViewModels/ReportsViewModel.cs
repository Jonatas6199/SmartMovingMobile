using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace SmartMovingMobileApp.ViewModels
{
    public class ReportsViewModel : BaseViewModel
    {
        public ReportsViewModel()
        {
            Title = "Relatórios";
        }
        public void CreatePdfFromData()
        {
            PdfDocument pdfDocument = new PdfDocument();

            PdfPage pdfPage = pdfDocument.Pages.Add();//Cria uma nova página e adiciona no doc pdf
        }
    }
}
