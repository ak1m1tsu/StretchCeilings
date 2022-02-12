using System.Collections.Generic;

namespace StretchCeilings.Models.Interfaces
{
    public interface IEmployee : IDbModel
    {
        List<TimeTable> GetSchedule();
    }
}
