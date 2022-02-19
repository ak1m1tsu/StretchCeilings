using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class RoomRepository : Repository, IRoomRepository
    {
        public IEnumerable<Room> GetAll()
        {
            return Context.CustomersRooms.Where(x => x.DeletedDate == null)
                .Include(x => x.Estate)
                .Include(x => x.Estate.Customer);
        }

        public Room FindById(int id)
        {
            return Context.CustomersRooms.Find(id);
        }

        public IEnumerable<Room> GetAll(Customer customer, Estate estate, int count, int page,
            SortOption option = SortOption.Descending,
            RoomProperty property = RoomProperty.CustomerId)
        {
            var enumerable = Context.CustomersRooms.Where(x => x.DeletedDate == null)
                .Include(x => x.Estate)
                .Include(x => x.Estate.Customer)
                .AsEnumerable();

            if (estate != null)
                enumerable = enumerable.Where(x => x.Estate.Id == estate.Id);

            if (customer != null)
                enumerable = enumerable.Where(x => x.Estate.Customer.Id == customer.Id);

            var rooms = enumerable.SortBy(property.ToString(), option).ToList();

            return rooms.Skip((page - 1) * count).Take(count);
        }
    }
}