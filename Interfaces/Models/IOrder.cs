using System.Collections.Generic;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Interfaces.Models
{
    public interface IOrder
    {
        void Add();
        void Update();
        void Delete();
        decimal CalculateTotal();
        List<Log> GetLogs();
        void AddLog(Log log);
        void DeleteLog(Log log);
    }
}
