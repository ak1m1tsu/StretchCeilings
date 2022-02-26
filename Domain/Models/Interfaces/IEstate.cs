using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface IEstate : IDbModel
    {
        /// <summary>
        /// Returns estate rooms
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Room"/>
        /// </returns>
        IEnumerable<Room> GetRooms();
    }
}
