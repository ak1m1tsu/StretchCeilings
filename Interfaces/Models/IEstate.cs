using System.Collections.Generic;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Interfaces.Models
{
    public interface IEstate
    {
        void Add();
        void Update();
        void Delete();
        List<Room> GetRooms();
    }
}
