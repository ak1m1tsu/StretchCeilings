using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
{
    public interface IEstate
    {
        void Add();
        void Update();
        void Delete();
        List<Room> GetRooms();
    }
}
