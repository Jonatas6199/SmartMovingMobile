using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMovingMobileApp.ViewModels
{
    public class ChartsViewModel : BaseViewModel
    {
        public List<ChartDataModel> ChartData { get; }
        public ChartsViewModel()
        {
            Title = "Gráficos";
            ChartData = FillChartData();
        }
        private List<ChartDataModel> FillChartData()
        {
            return new List<ChartDataModel>
            {
                new ChartDataModel
                {
                    Name = "Vegetais",
                    Amount = 230
                },
                new ChartDataModel
                {
                    Name = "Bolachas",
                    Amount = 125
                },
                new ChartDataModel
                {
                    Name = "Higiene",
                    Amount = 22
                }
            };
        }
    }
    public class ChartDataModel
    {
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}
