using SmartMovingMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartMovingMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportsPage : ContentPage
    {
        private CancellationTokenSource cancellationTokenSource;
        private ReportsViewModel ReportsViewModel { get; set; }
        public ReportsPage()
        {
            Title = "Relatórios";
            InitializeComponent();
            BindingContext = ReportsViewModel = new ReportsViewModel();
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GetReport();
        }
        public async void GetReport()
        {
            //TODO: não tem como manter uma stream aberta, tem que salvar esse arquivo aí em algum lugar
            Stream stream = await ReportsViewModel.GetReport();
            await Task.Delay(200);
            pdfViewerControl.Unload();
            await Task.Delay(200);
            await pdfViewerControl.LoadDocumentAsync(stream, cancellationTokenSource);
            await Task.Delay(200);
            stream.Dispose();
        }
    }
}