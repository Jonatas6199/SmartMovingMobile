using SmartMovingMobileApp.Models;
using SmartMovingMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartMovingMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportsPage : ContentPage
    {
        private ReportsViewModel ReportsViewModel { get; set; }

        public ReportsPage()
        {
            Title = "Relatórios";
            InitializeComponent();
            ReportsViewModel = BindingContext as ReportsViewModel;
        }

       
        private async void listViewReports_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Report selected = listViewReports.SelectedItem as Report;
            await Shell.Current.GoToAsync($"ReportsItemPage?ReportId={selected.Id}");
        }
       
    }
}