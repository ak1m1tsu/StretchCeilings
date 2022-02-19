using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface IRoomRepository : IRepository<Room>
    {
        IEnumerable<Room> GetAll(Customer customer, Estate estate, int count, int page,
            SortOption option = SortOption.Descending, RoomProperty property = RoomProperty.CustomerId);
    }
}