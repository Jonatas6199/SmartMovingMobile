using SmartMovingMobileApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SmartMovingMobileApp.Services
{
    public class MockDataModel : IDataModel<DataModel>
    {
        public DataModel dataModel;
        public List<Report> reports;
        private int CurrentReportId { get; set; }
        private Stream CurrentReportStream { get; set; }
        public MockDataModel()
        {
            CreateMockData();
        }
        //cria dados "mockados" (falsos para testes)
        private void CreateMockData()
        {
            dataModel = new DataModel
            {
                MostVisitedSection = new Section
                {
                    AmountOfVisits = 219,
                    Name = "Hortifruti",
                    SectionIconPath = "https://cdn2.iconfinder.com/data/icons/fruits-and-vegetables-silhouette/100/_1____-40-256.png"
                },
                LessVisitedSection = new Section
                {
                    AmountOfVisits = 168,
                    Name = "Bebidas",
                    SectionIconPath = "https://cdn4.iconfinder.com/data/icons/essential-app-1/16/wine-drink-alcohol-celebrate-256.png"
                },
                PeopleAverage = new PeopleAverage
                {
                    PeopleAverageAmount = 74,
                    PeopleAverageIconPath = "https://cdn3.iconfinder.com/data/icons/digital-marketing-27/64/Human-people-teamwork-graph-analysis-man-256.png"
                },
                TimeAverage = new TimeAverage
                {
                    TimeAverageAmount = 50,
                    TimeAverageIconPath = "https://cdn4.iconfinder.com/data/icons/essential-app-2/16/stop-watch-time-count-256.png"
                }
            };


            reports = new List<Report>
            {
                new Report
                {
                    Id = 0,
                    Name = "Relatório"
                },
                new Report
                {
                    Id = 1,
                    Name = "Relatório01"
                },
                new Report
                {
                    Id = 2,
                    Name = "Relatório02"
                },
                new Report
                {
                    Id = 3,
                    Name = "Relatório03"
                }
            };
        }

        // Retorna uma tarefa que retorna todos os dados
        public async Task<DataModel> GetDataAsync()
        {
            return await Task.FromResult(dataModel);
        }

        //Retorna uma tarefa que retorna uma lista de relatórios
        public async Task<List<Report>> FetchReportsList()
        {
            return await Task.FromResult(reports);
        }


        
    }
}
