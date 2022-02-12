using System.Collections.Generic;

namespace StretchCeilings.Models.Interfaces
{
    public interface IEstate : IDbModel
    {
        List<Room> GetRooms();
    }
}
