using SmartMovingMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartMovingMobileApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public DataModel DataModel { get; set; }
        public string MostVisitedSection { get; }
        public string LessVisitedSection { get; }
        public string PeopleAverage { get; }
        public string TimeAverage { get; }
        public Uri MostVisitedSectionIcon { get; }
        public Uri LessVisitedSectionIcon { get; }
        public Uri PeopleAverageIcon { get; }
        public Uri TimeAverageIcon { get; }
        public HomeViewModel()
        {
            Title = "Home";
            GetData();
            MostVisitedSection = "Setor Mais Visitado: " + DataModel.MostVisitedSection.Name;
            LessVisitedSection = "Setor Menos Visitado: " + DataModel.LessVisitedSection.Name;
            PeopleAverage = "Média de Visitas: " + DataModel.PeopleAverage.PeopleAverageAmount;
            TimeAverage = "Tempo de Permanência Médio: " + DataModel.TimeAverage.TimeAverageAmount + " minutos";

            MostVisitedSectionIcon = new Uri(DataModel.MostVisitedSection.SectionIconPath);
            LessVisitedSectionIcon = new Uri(DataModel.LessVisitedSection.SectionIconPath);
            PeopleAverageIcon = new Uri(DataModel.PeopleAverage.PeopleAverageIconPath);
            TimeAverageIcon = new Uri(DataModel.TimeAverage.TimeAverageIconPath);
        }
        public async void GetData()
        {
            DataModel = await DataModelBase.GetDataAsync();
        }
    }
}
