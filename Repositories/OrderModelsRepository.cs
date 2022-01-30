using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public static class OrderModelsRepository
    {
        public static List<Order> GetALl(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DeletedDate == null).ToList();
                rows = 0;
                if (orders.Any())
                {
                    orders.ForEach(o => db.Entry(o).Reference(r => r.Customer).Load());
                    rows = orders.Count;
                }

                return orders;
            }
        }

        public static List<Order> GetALl(Order firstFilter, Order secondFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DeletedDate == null);

                if (firstFilter.Id != 0)
                    orders = orders.Where(o => o.Id == firstFilter.Id);
                else
                {
                    orders = firstFilter.DatePlaced != null && secondFilter.DatePlaced != null
                        ? orders.Where(o => firstFilter.DatePlaced <= o.DatePlaced && secondFilter.DatePlaced >= o.DatePlaced)
                        : orders;

                    orders = firstFilter.DatePlaced != null
                        ? orders.Where(o => firstFilter.DatePlaced <= o.DatePlaced)
                        : orders;

                    orders = secondFilter.DatePlaced != null
                        ? orders.Where(o => secondFilter.DatePlaced >= o.DatePlaced)
                        : orders;

                    orders = firstFilter.Total != null && secondFilter.Total != null
                        ? orders.Where(o => firstFilter.Total <= o.Total && o.Total <= secondFilter.Total)
                        : orders;

                    orders = firstFilter.Total != null
                        ? orders.Where(o => firstFilter.Total <= o.Total)
                        : orders;

                    orders = secondFilter.Total != null
                        ? orders.Where(o => o.Total <= secondFilter.Total)
                        : orders;

                    orders = firstFilter.Status != OrderStatus.Unknown
                        ? orders.Where(x => x.Status == firstFilter.Status)
                        : orders;

                    orders = firstFilter.PaidByCash != null
                        ? orders.Where(o => o.PaidByCash == firstFilter.PaidByCash)
                        : orders;
                }

                rows = 0;

                if (orders.Any())
                {
                    orders.ForEachAsync(o => db.Entry(o).Reference(r => r.Customer).Load());
                    rows = orders.Count();
                    return orders.ToList().Skip((page - 1) * count).Take(count).ToList();
                }

                return orders.ToList();
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
