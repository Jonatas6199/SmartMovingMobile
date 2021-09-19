using SmartMovingMobileApp.ViewModels;
using SmartMovingMobileApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmartMovingMobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ChartsPage), typeof(ChartsPage));
            Routing.RegisterRoute(nameof(ReportsPage), typeof(ReportsPage));

        }

    }
}
