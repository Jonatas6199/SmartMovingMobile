using SmartMovingMobileApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SmartMovingMobileApp.Services
{
    public interface IDataModel<T>
    {
        // Interface Datamodel - para tratar sobre os dados
        Task<T> GetDataAsync();
        Task<List<Report>> FetchReportsList();
     
    }
}
