using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class OrderRepository : NotNull
    {
        public static List<Order> GetALl(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DeletedDate == null);
                rows = 0;

                if (orders.Any() == false) 
                    return orders.ToList();
                
                rows = orders.Count();
                orders.ForEachAsync(o => db.Entry(o).Reference(r => r.Customer).Load());
                
                return orders.ToList();
            }
        }

        public static List<Order> GetALl(Order firstFilter, Order secondFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DeletedDate == null);
                rows = 0;

                if (firstFilter.Id != 0)
                    orders = orders.Where(o => o.Id == firstFilter.Id);

                if ((IsNull(firstFilter.DatePlaced) && IsNull(secondFilter.DatePlaced)) == false)
                    orders = orders.Where(o =>
                        firstFilter.DatePlaced <= o.DatePlaced && secondFilter.DatePlaced >= o.DatePlaced);

                if (IsNull(firstFilter.DatePlaced) == false)
                        orders = orders.Where(o => firstFilter.DatePlaced <= o.DatePlaced);

                if (IsNull(secondFilter.DatePaid) == false)
                        orders = orders.Where(o => secondFilter.DatePlaced >= o.DatePlaced);

                if ((IsNull(firstFilter.Total) && IsNull(secondFilter.Total)) == false)
                    orders = orders.Where(o => firstFilter.Total <= o.Total && o.Total <= secondFilter.Total);

                if (IsNull(firstFilter.Total) == false)
                    orders = orders.Where(o => firstFilter.Total <= o.Total);

                if (IsNull(secondFilter.Total) == false)
                    orders = orders.Where(o => o.Total <= secondFilter.Total);
                
                if (firstFilter.Status != OrderStatus.Unknown)
                    orders = orders.Where(x => x.Status == firstFilter.Status);

                if (IsNull(firstFilter.PaidByCash) == false)
                    orders = orders.Where(o => o.PaidByCash == firstFilter.PaidByCash);

                if (!orders.Any()) 
                    return orders.ToList();
                
                orders.ForEachAsync(o => db.Entry(o).Reference(r => r.Customer).Load());
                rows = orders.Count();

                return orders.ToList().Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static Order GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.Id == id);

                if (IsNull(order) == false)
                    db.Entry(order).Reference(o => o.Customer).Load();

                return order;
            }
        }
    }
}
