using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class ManufacturerOrderRepository
    {
        public static List<ManufacturerOrder> GetManufacturerOrders(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.ManufacturerOrders.Where(o => o.DateDeleted == null).ToList();
                rows = 0;
                if (orders.Any())
                {
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Ceiling).Load());
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Manufacturer).Load());
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Room).Load());
                    rows = orders.Count;
                }

                return orders;
            }
        }

        public static List<ManufacturerOrder> GetManufacturerOrders(ManufacturerOrder filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.ManufacturerOrders.Where(o => o.Equals(filter)).ToList();
                rows = 0;

                if (orders.Any())
                {
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Ceiling).Load());
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Manufacturer).Load());
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Room).Load());
                    rows = orders.Count;
                    orders = orders.Skip((page - 1) * count).Take(count).ToList();
                }

                return orders;
            }
        }

        public static ManufacturerOrder GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var order = db.ManufacturerOrders.FirstOrDefault(o => o.Id == id);

                if (order != null)
                {
                    db.Entry(order).Reference(o => o.Ceiling).Load();
                    db.Entry(order).Reference(o => o.Manufacturer).Load();
                    db.Entry(order).Reference(o => o.Room).Load();
                }

                return order;
            }
        }
    }
}
