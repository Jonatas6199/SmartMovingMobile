using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartMovingMobileApp.Services
{
    public interface IDataModel<T>
    {
        Task<T> GetDataAsync();
    }
}
