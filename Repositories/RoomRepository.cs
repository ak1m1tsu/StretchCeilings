using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Repositories.Enums;

namespace StretchCeilings.Repositories
{
    public class RoomRepository
    {
        public static List<Room> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.CustomersRooms.Where(x => x.DeletedDate == null)
                    .Include(x => x.Estate)
                    .Include(x => x.Estate.Customer)
                    .AsEnumerable();

                var rooms = enumerable.ToList();

                return rooms.ToList();
            }
        }

        public static List<Room> GetAll(
            Customer customer, 
            Estate estate, 
            int count, 
            int page, 
            SortOption option = SortOption.Descending,
            RoomProperty property = RoomProperty.CustomerId)
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

                var rooms = enumerable.SortBy(property.ToString(), option).ToList();

                return rooms.Skip((page - 1) * count).Take(count).ToList();
            }
        }
    }
}