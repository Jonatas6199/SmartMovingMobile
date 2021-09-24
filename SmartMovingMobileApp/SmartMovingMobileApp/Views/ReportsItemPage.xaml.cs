using SmartMovingMobileApp.Models;
using SmartMovingMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartMovingMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ReportId), "ReportId")]

    public partial class ReportsItemPage : ContentPage
    {
        private ReportsItemViewModel ReportsItemViewModel;
        private CancellationTokenSource cancellationTokenSource;
        public int ReportId
        {
            set
            {
                LoadDocument();
            }
        }

        public ReportsItemPage()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            ReportsItemViewModel = BindingContext as ReportsItemViewModel;
        }

        // Volta para a página anterior
        private async void Button_Clicked(object sender, EventArgs e)
        {
            pdfViewerControl.Unload();
            await Shell.Current.GoToAsync("..");
        }
        // Carrega o relatório no viewer
        private void LoadDocument()
        {
            LoadDocumentAsync();
        }
        private async void LoadDocumentAsync()
        {
            try
            {

                string documentsPath = FileSystem.AppDataDirectory + "//Reports//";
                string localFilename = "report.pdf";
                string localPath = Path.Combine(documentsPath, localFilename);
                FileStream stream1 = File.Open(localPath, FileMode.Open);
                await pdfViewerControl.LoadDocumentAsync(stream1, cancellationTokenSource);

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);

            }
        }

        // Compartilhar relatório (TO DO)
        private async void btnShare_Clicked(object sender, EventArgs e)
        {
            await ShareFile("text");
        }
        public async Task ShareFile(string text)
        {
            ShareFile shareFile = new ShareFile(text);
            await Share.RequestAsync(new ShareFileRequest
            {
                File = shareFile,
                Title = $"Compartilhar {shareFile.FileName}"
            });
        }
        //Gráfico de barras horizontal ou de pizza (TO DO)
        //Total de visitas no período selecionado  (TO DO)
        //Gráfico de linha do setor (TO DO)
        //Filtro de data da home no topo (TO DO)
    }
}