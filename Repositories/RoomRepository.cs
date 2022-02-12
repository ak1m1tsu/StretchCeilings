using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class RoomRepository
    {
        public static List<Room> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var rooms = db.CustomersRooms.Where(x => x.DeletedDate == null);
                rows = 0;

                if (rooms.Any() == false)
                    return rooms.ToList();

                rooms.ForEachAsync(r => db.Entry(r).Reference(re => re.Estate).Load());
                rooms.ForEachAsync(r => db.Entry(r?.Estate).Reference(re => re.Customer).Load());
                rows = rooms.Count();

                return rooms.ToList();
            }
        }

        public static List<Room> GetAll(Customer customer, Estate estate, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var rooms = db.CustomersRooms.Where(x => x.DeletedDate == null);
                rows = 0;

                if (estate != null)
                    rooms = rooms.Where(x => x.EstateId == estate.Id);

                if (customer != null)
                    rooms = rooms.Where(x => x.Estate.CustomerId == customer.Id);

                if (rooms.Any() == false)
                    return rooms.ToList();

                rows = rooms.Count();
                rooms.ForEachAsync(r => db.Entry(r).Reference(re => re.Estate).Load());
                rooms.ForEachAsync(r => db.Entry(r.Estate).Reference(re => re.Customer).Load());

                return rooms.ToList().Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static Room GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var room = db.CustomersRooms.FirstOrDefault(x => x.Id == id);

                if (room != null)
                    db.Entry(room).Reference(r => r.Estate).Load();

                return room;
            }
        }

        public static List<Room> GetByEstateId(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var rooms = db.CustomersRooms.Where(x => x.EstateId == id && x.DeletedDate == null);

                if (rooms.Any())
                    rooms.ForEachAsync(room => db.Entry(room).Reference(r => r.Estate).Load());

                return rooms.ToList();
            }
        }
    }
}