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
            Stream stream = await ReportsViewModel.GetReport();
            pdfViewerControl.Unload();
            await pdfViewerControl.LoadDocumentAsync(stream, cancellationTokenSource);
        }
    }
}