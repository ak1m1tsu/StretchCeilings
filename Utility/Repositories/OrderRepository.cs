using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class OrderRepository
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

        public static List<Order> GetOrders(Order firstFilter, Order secondFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DateDeleted == null).ToList();

                if (firstFilter.Id != 0)
                    orders = orders.Where(o => o.Id == firstFilter.Id).ToList();
                else
                {
                    if (firstFilter.DatePlaced != null && secondFilter.DatePlaced != null)
                    {
                        orders = orders.Where(o => firstFilter.DatePlaced <= o.DatePlaced && secondFilter.DatePlaced >= o.DatePlaced).ToList();
                    }
                    else if (firstFilter.DatePlaced != null)
                    {
                        orders = orders.Where(o => firstFilter.DatePlaced <= o.DatePlaced).ToList();
                    }
                    else if (secondFilter.DatePlaced != null)
                    {
                        orders = orders.Where(o => secondFilter.DatePlaced >= o.DatePlaced).ToList();
                    }

                    if (firstFilter.Total != null && secondFilter.Total != null)
                    {
                        orders = orders.Where(o => firstFilter.Total <= o.Total && o.Total <= secondFilter.Total).ToList();
                    }
                    else if (firstFilter.Total != null)
                    {
                        orders = orders.Where(o => firstFilter.Total <= o.Total).ToList();
                    }
                    else if (secondFilter.Total != null)
                    {
                        orders = orders.Where(o => o.Total <= secondFilter.Total).ToList();
                    }

                    if (firstFilter.Status != OrderStatus.Unknown)
                    {
                        orders = orders.Where(o => o.Status == firstFilter.Status).ToList();
                    }

                    if (firstFilter.PaidByCash != null)
                    {
                        orders = orders.Where(o => o.PaidByCash == firstFilter.PaidByCash).ToList();
                    }
                }

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
