using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IOrder
    {
        decimal CalculateTotal();
        List<Log> GetLogs();
        string AddLog(Log log);
        string DeleteLog(Log log);
    }
}
