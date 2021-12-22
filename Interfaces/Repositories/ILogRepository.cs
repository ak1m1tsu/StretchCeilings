using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface ILogRepository
    {
        List<Log> Get(Log filter, int count, int page);
        string Add(Log log);
        string Delete(Log log);
        string Change(int oldLog, Log newLog);
    }
}
