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
using SmartMovingMobileApp.Models;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Essentials;
using Newtonsoft.Json;

namespace SmartMovingMobileApp.ViewModels
{
    public class ReportAPI
    {
        public string message { get; set; }
    }
    public class ReportsViewModel : BaseViewModel
    {
        // Lista dos relatórios para o Front
        public ObservableCollection<Report> ReportsCollection { get; }
        HttpClient client;
        public Command RefreshListComand { get; }
        public Command DonwloadReports { get; }

        public ReportsViewModel()
        {
            Title = "Relatórios";
            client = new HttpClient();
            ReportsCollection = new ObservableCollection<Report>();
            RefreshListComand = new Command(async () => await FetchReportsList());
            DonwloadReports = new Command(async () => await SaveFile(1));
        }
        // Buscar lista de relatórios
        public async Task FetchReportsList()
        {
            List<Report> retorno = await DataModelBase.FetchReportsList();
            ReportsCollection.Clear();
            retorno.ForEach(r => ReportsCollection.Add(r));
        }
        // Buscar relatórios por Id na API
        public async Task<byte[]> GetReport(int reportId)
        {
            string report = await client.GetStringAsync("https://gps-indoor.herokuapp.com/report");
            ReportAPI result = JsonConvert.DeserializeObject<ReportAPI>(report);
            var bytes = Convert.FromBase64String(result.message);
            return bytes;
        }
        // Salva o relatório no diretório
        private async Task SaveFile(int id)
        {
            byte[] bytes = await GetReport(id);
            await WriteFile(bytes);
        }
        public static Task<byte[]> ConvertStreamToByteArray(Stream stream)
        {
            return Task.Run(() =>
            {
                byte[] byteArray = new byte[16 * 1024];
                using (MemoryStream mStream = new MemoryStream())
                {
                    int bit;
                    while ((bit = stream.Read(byteArray, 0, byteArray.Length)) > 0)
                    {
                        mStream.Write(byteArray, 0, bit);
                    }
                    return mStream.ToArray();
                }
            });
        }
        // Salva o relatório no caminho especificado
        private async Task WriteFile(byte[] bytes)
        {
            await Task.Run(() =>
            {
                string documentsPath = FileSystem.AppDataDirectory + "//Reports//";
                if (!Directory.Exists(documentsPath))
                    Directory.CreateDirectory(documentsPath);
                string localFilename = "report.pdf";
                string localPath = Path.Combine(documentsPath, localFilename);
                if (File.Exists(localPath))
                {
                    File.Delete(localPath);
                }
                File.WriteAllBytes(localPath, bytes);
            });

        }

    }
}