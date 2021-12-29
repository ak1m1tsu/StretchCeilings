using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
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
