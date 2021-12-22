using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IRoomRepository
    {
        List<Room> Get(Room filter, int count, int page);
        string Add(Room room);
        string Delete(Room room);
        string Change(int oldRoom, Room newRoom);
    }
}
