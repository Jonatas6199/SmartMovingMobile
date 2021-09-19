using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMovingMobileApp.Models
{
    public class DataModel
    {
        public PeopleAverage PeopleAverage { get; set; }
        public TimeAverage TimeAverage { get; set; }//Média de tempo de permanência no mercado
        public Section MostVisitedSection { get; set; }//Setor mais visitado
        public Section LessVisitedSection { get; set; }//Setor menos visitado
    }
    public class PeopleAverage
    {
        public double PeopleAverageAmount { get; set; } //https://cdn3.iconfinder.com/data/icons/digital-marketing-27/64/Human-people-teamwork-graph-analysis-man-256.png
        public string PeopleAverageIconPath { get; set; }
    }
    public class TimeAverage
    {
        public double TimeAverageAmount { get; set; }
        public string TimeAverageIconPath { get; set; }
    }
}
