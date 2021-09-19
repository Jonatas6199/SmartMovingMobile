using SmartMovingMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartMovingMobileApp.Services
{
    public class MockDataModel : IDataModel<DataModel>
    {
        public DataModel dataModel;
        public MockDataModel()
        {
            CreateMockDataModels();
        }
        private void CreateMockDataModels()
        {
            dataModel = new DataModel
            {
                MostVisitedSection = new Section
                {
                    AmountOfVisits = 230,
                    Name = "Vegetais",
                    SectionIconPath = "https://down.imgspng.com/download/0720/broccoli_PNG72974.png"
                },
                LessVisitedSection = new Section
                {
                    AmountOfVisits = 22,
                    Name = "Higiene",
                    SectionIconPath = "https://images.vexels.com/media/users/3/207151/isolated/lists/39f024691f9389afc9f45cde9756bfd2-icone-de-sabonete-liquido-de-mao.png"
                },
                PeopleAverage = new PeopleAverage
                {
                    PeopleAverageAmount = 290,
                    PeopleAverageIconPath = "https://cdn3.iconfinder.com/data/icons/digital-marketing-27/64/Human-people-teamwork-graph-analysis-man-256.png"
                },
                TimeAverage = new TimeAverage
                {
                    TimeAverageAmount = 67,
                    TimeAverageIconPath = "https://cdn4.iconfinder.com/data/icons/essential-app-2/16/stop-watch-time-count-256.png"
                }
            };
        }

        public async Task<DataModel> GetDataAsync()
        {
            return await Task.FromResult(dataModel);
        }
    }
}
