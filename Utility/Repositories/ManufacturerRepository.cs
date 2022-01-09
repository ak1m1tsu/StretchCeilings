using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class ManufacturerRepository
    {
        public static List<Order> GetOrders(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DateDeleted == null).ToList();
                rows = 0;
                if (orders.Any())
                {
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Customer).Load());
                    rows = orders.Count;
                }

                return orders;
            }
        }

        public static List<Order> GetOrders(Order filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.Equals(filter)).ToList();
                rows = 0;

                if (orders.Any())
                {
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Customer).Load());
                    rows = orders.Count;
                    orders = orders.Skip((page - 1) * count).Take(count).ToList();
                }

                return orders;
            }
        }

        public static Order GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.Id == id);

                if (order != null)
                {
                    db.Entry(order).Reference(o => o.Customer).Load();
                }

                return order;
            }
        }
    }
}
