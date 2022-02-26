using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface IEmployee : IDbModel
    {
        /// <summary>
        /// Returns employee schedule
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="TimeTable"/>
        /// </returns>
        IEnumerable<TimeTable> GetSchedule();
    }
}
