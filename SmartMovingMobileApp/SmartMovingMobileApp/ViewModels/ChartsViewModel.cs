using SmartMovingMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMovingMobileApp.ViewModels
{
    public class ChartsViewModel : BaseViewModel
    {
        public List<ChartDataModel> SectorsVisitsChartData { get; }
        public List<SectorChartDataModel> Sector1Data { get; }
        public List<SectorChartDataModel> Sector2Data { get; }
        public List<SectorChartDataModel> Sector3Data { get; }
        public ChartsViewModel()
        {
            Title = "Gráficos";
            SectorsVisitsChartData = FillChartData();
            Sector1Data = sector1Data();
            Sector2Data = sector2Data();
            Sector3Data = sector3Data();
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
        private List<SectorChartDataModel> sector1Data()
        {
            DateTime today = DateTime.Today;
            DateTime yesterday = today.AddDays(-1);
            DateTime beforeYesterday = today.AddDays(-2);
            return new List<SectorChartDataModel>
            {
                new SectorChartDataModel
                {
                    Name = "Vegetais",
                    DateOfVisit = today,
                    VisitsAmount = 80
                },
                new SectorChartDataModel
                {
                    Name = "Vegetais",
                    DateOfVisit = yesterday,
                    VisitsAmount = 110
                },
                new SectorChartDataModel
                {
                    Name = "Vegetais",
                    DateOfVisit = beforeYesterday,
                    VisitsAmount = 40
                }
            };
        }
        private List<SectorChartDataModel> sector2Data()
        {
            DateTime today = DateTime.Today;
            DateTime yesterday = today.AddDays(-1);
            DateTime beforeYesterday = today.AddDays(-2);
            return new List<SectorChartDataModel>
            {
                new SectorChartDataModel
                {
                    Name = "Bolachas",
                    DateOfVisit = today,
                    VisitsAmount = 20
                },
                new SectorChartDataModel
                {
                    Name = "Bolachas",
                    DateOfVisit = yesterday,
                    VisitsAmount = 40
                },
                new SectorChartDataModel
                {
                    Name = "Bolachas",
                    DateOfVisit = beforeYesterday,
                    VisitsAmount = 65
                }
            };
        }
        private List<SectorChartDataModel> sector3Data()
        {
            DateTime today = DateTime.Today;
            DateTime yesterday = today.AddDays(-1);
            DateTime beforeYesterday = today.AddDays(-2);
            return new List<SectorChartDataModel>
            {
                new SectorChartDataModel
                {
                    Name = "Higiene",
                    DateOfVisit = today,
                    VisitsAmount = 2
                },
                new SectorChartDataModel
                {
                    Name = "Higiene",
                    DateOfVisit = yesterday,
                    VisitsAmount = 7
                },
                new SectorChartDataModel
                {
                    Name = "Higiene",
                    DateOfVisit = beforeYesterday,
                    VisitsAmount = 13
                }
            };
        }
        /*
         var today = DateTime.Today;
         var tomorrow = today.AddDays(1);
         var yesterday = today.AddDays(-1);
         */
    }
    public class ChartDataModel
    {
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}
