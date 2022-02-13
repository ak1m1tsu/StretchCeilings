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
                var enumerable = db.CustomersRooms.Where(x => x.DeletedDate == null)
                    .Include(x => x.Estate)
                    .AsEnumerable();

                var rooms = enumerable.ToList();

                rows = rooms.Count();

                return rooms.ToList();
            }
        }

        public static List<Room> GetAll(Customer customer, Estate estate, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.CustomersRooms.Where(x => x.DeletedDate == null)
                    .Include(x => x.Estate)
                    .Include(x => x.Estate.Customer)
                    .AsEnumerable();
                
                if (estate != null)
                    enumerable = enumerable.Where(x => x.Estate.Id == estate.Id);

                if (customer != null)
                    enumerable = enumerable.Where(x => x.Estate.Customer.Id == customer.Id);

                var rooms = enumerable.ToList();

                rows = rooms.Count();

                return rooms.Skip((page - 1) * count).Take(count).ToList();
            }
        }
    }
}