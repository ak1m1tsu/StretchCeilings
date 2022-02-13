using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;

namespace StretchCeilings.Repositories
{
    public class OrderRepository
    {
        public static List<Order> GetAll(out int rows)
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

        public static List<Order> GetAll(Order firstFilter, Order secondFilter, Customer customer, Employee employee, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var orders = db.Orders.Where(o => o.DeletedDate == null);
                rows = 0;

                if (firstFilter.Id != 0)
                    orders = orders.Where(o => o.Id == firstFilter.Id);

                if (firstFilter.DatePlaced != null && secondFilter.DatePlaced != null)
                    orders = orders.Where(o =>
                        firstFilter.DatePlaced <= o.DatePlaced && secondFilter.DatePlaced >= o.DatePlaced);

                if (firstFilter.DatePlaced != null)
                        orders = orders.Where(o => firstFilter.DatePlaced <= o.DatePlaced);

                if (secondFilter.DatePaid != null)
                        orders = orders.Where(o => secondFilter.DatePlaced >= o.DatePlaced);

                if (firstFilter.Total != null && secondFilter.Total != null)
                    orders = orders.Where(o => firstFilter.Total <= o.Total && o.Total <= secondFilter.Total);

                if (firstFilter.Total != null)
                    orders = orders.Where(o => firstFilter.Total <= o.Total);

                if (secondFilter.Total != null)
                    orders = orders.Where(o => o.Total <= secondFilter.Total);
                
                if (firstFilter.Status != OrderStatus.Unknown && firstFilter.Status != null)
                    orders = orders.Where(x => x.Status == firstFilter.Status);

                if (firstFilter.PaidByCash != null)
                    orders = orders.Where(o => o.PaidByCash == firstFilter.PaidByCash);

                if (customer != null && customer.Id != 0)
                    orders = orders.Where(x => x.CustomerId == customer.Id);

                if (employee != null && employee.Id != 0)
                {
                    orders = orders.Join(db.OrderEmployees, o => o.Id, oe => oe.OrderId, (o, oe) => new { o, oe })
                        .Where(@t => @t.oe.EmployeeId == employee.Id)
                        .Select(@t => @t.o);
                }

                if (orders.Any() == false) 
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
                var order = db.Orders.Find(id);

                if (order != null)
                    db.Entry(order).Reference(x => x.Customer).Load();

                return order;
            }
        }
    }
}
