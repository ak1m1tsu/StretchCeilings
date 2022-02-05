using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class RoomRepository : NotNull
    {
        public static Room GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var room = db.CustomersRooms.FirstOrDefault(x => x.Id == id);

                if (IsNull(room))
                    db.Entry(room).Reference(r => r.Estate).Load();

                return room;
            }
        }

        public static List<Room> GetByEstateId(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var rooms = db.CustomersRooms.Where(x => x.EstateId == id);

                if (rooms.Any())
                    rooms.ForEachAsync(room => db.Entry(room).Reference(r => r.Estate).Load());

                return rooms.ToList();
            }
        }
    }
}