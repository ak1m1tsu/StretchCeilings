using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IScheduleRepository
    {
        List<TimeTable> Get(TimeTable filter, int count, int page);
        string Add(TimeTable timeTable);
        string Delete(TimeTable timeTable);
        string Change(int oldTimeTable, TimeTable newTimeTable);
    }
}
