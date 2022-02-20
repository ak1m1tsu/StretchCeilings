using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IEstate : IDbModel
    {
        IEnumerable<Room> GetRooms();
    }
}
