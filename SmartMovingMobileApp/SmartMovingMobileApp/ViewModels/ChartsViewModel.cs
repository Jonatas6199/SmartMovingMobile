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
                    Name = "Hortifruti",
                    Amount = 219
                },
                new ChartDataModel
                {
                    Name = "Frios",
                    Amount = 185
                },
                new ChartDataModel
                {
                    Name = "Bebidas",
                    Amount = 168
                }
            };
        }
        private List<SectorChartDataModel> sector1Data()
        {
            DateTime today = DateTime.Today;
            return new List<SectorChartDataModel>
            {
                new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today.AddDays(-6),
                    VisitsAmount = 28
                },
                new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today.AddDays(-5),
                    VisitsAmount = 29
                }
                ,
                new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today.AddDays(-4),
                    VisitsAmount = 12
                }
                ,
                new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today.AddDays(-3),
                    VisitsAmount = 40
                }
                ,
                new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today.AddDays(-2),
                    VisitsAmount = 33
                }
                ,
                new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today.AddDays(-1),
                    VisitsAmount = 45
                },
                  new SectorChartDataModel
                {
                    Name = "Hortifruti",
                    DateOfVisit = today,
                    VisitsAmount = 32
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
