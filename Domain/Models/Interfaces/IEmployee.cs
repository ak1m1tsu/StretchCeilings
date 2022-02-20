using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IEmployee : IDbModel
    {
        IEnumerable<TimeTable> GetSchedule();
    }
}
