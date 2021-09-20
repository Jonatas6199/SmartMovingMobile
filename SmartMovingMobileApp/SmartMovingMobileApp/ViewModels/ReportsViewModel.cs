using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

namespace SmartMovingMobileApp.ViewModels
{
    public class ReportsViewModel : BaseViewModel
    {
        HttpClient client;
        public ReportsViewModel()
        {
            Title = "Relatórios";
            client = new HttpClient();
        }
        
        public async Task<Stream> GetReport()
        {
            Stream report = await client.GetStreamAsync("https://gps-indoor.herokuapp.com/report");
            return report;
        }
    }
}
