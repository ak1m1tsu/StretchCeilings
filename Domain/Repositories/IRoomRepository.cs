using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{

    /// <summary>
    /// Represents a repository of customer rooms
    /// </summary>
    public interface IRoomRepository : IRepository<Room>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of customer rooms
        /// </summary>
        /// <param name="customer">first filter</param>
        /// <param name="estate">second filter</param>
        /// <param name="count">rooms count</param>
        /// <param name="page">page number in the rooms table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of <see cref="Room"/></param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="Room">T</see> is a <see cref="Room"/>
        /// </returns>
        IEnumerable<Room> GetAll(Customer customer, Estate estate, int count, int page,
            SortOption option = SortOption.Descending, RoomProperty property = RoomProperty.CustomerId);
    }
}