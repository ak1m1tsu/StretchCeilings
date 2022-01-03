using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class OrderRepository
    {
        public static List<Order> GetOrders()
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DateDeleted == null).ToList();

                if (orders.Any())
                {
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Customer).Load());
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
