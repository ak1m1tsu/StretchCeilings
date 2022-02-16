using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Repositories.Enums;

namespace StretchCeilings.Repositories
{
    public class OrderRepository
    {
        public static List<Order> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Orders.Where(o => o.DeletedDate == null)
                    .Include(x => x.Customer)
                    .OrderByDescending(x => x.Id)
                    .AsEnumerable();

                var orders = enumerable.ToList();
                
                return orders.ToList();
            }
        }
        
        public static List<Order> GetAll(Order firstFilter, 
            Order secondFilter, 
            Customer customer, 
            Employee employee,
            int count, 
            int page,
            SortOption option = SortOption.Descending,
            OrderProperty property = OrderProperty.Id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Orders.Where(o => o.DeletedDate == null)
                    .Include(x => x.Customer)
                    .AsEnumerable();

                if (firstFilter.Id != 0)
                    enumerable = enumerable.Where(o => o.Id == firstFilter.Id);

                if (firstFilter.DatePlaced != null && secondFilter.DatePlaced != null)
                    enumerable = enumerable.Where(o =>
                        firstFilter.DatePlaced <= o.DatePlaced && secondFilter.DatePlaced >= o.DatePlaced);

                if (firstFilter.DatePlaced != null)
                    enumerable = enumerable.Where(o => firstFilter.DatePlaced <= o.DatePlaced);

                if (secondFilter.DatePaid != null)
                    enumerable = enumerable.Where(o => secondFilter.DatePlaced >= o.DatePlaced);

                if (firstFilter.Total != null && secondFilter.Total != null)
                    enumerable = enumerable.Where(o => firstFilter.Total <= o.Total && o.Total <= secondFilter.Total);

                if (firstFilter.Total != null)
                    enumerable = enumerable.Where(o => firstFilter.Total <= o.Total);

                if (secondFilter.Total != null)
                    enumerable = enumerable.Where(o => o.Total <= secondFilter.Total);

                if (firstFilter.Status != OrderStatus.Unknown && firstFilter.Status != null)
                    enumerable = enumerable.Where(x => x.Status == firstFilter.Status);

                if (firstFilter.PaidByCash != null)
                    enumerable = enumerable.Where(o => o.PaidByCash == firstFilter.PaidByCash);

                if (customer != null && customer.Id != 0)
                    enumerable = enumerable.Where(x => x.Customer.Id == customer.Id);

                if (employee != null && employee.Id != 0)
                {
                    enumerable = enumerable.Join(db.OrderEmployees, o => o.Id, oe => oe.OrderId, (o, oe) => new { o, oe })
                        .Where(@t => @t.oe.Employee.Id == employee.Id)
                        .Select(@t => @t.o);
                }

                var orders = enumerable.SortBy(property.ToString(), option).ToList();

                return orders.Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static Order GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Orders.Include(x => x.Customer).First(x => x.Id == id);
            }
        }
    }
}
