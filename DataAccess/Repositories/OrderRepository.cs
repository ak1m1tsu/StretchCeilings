using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public override IEnumerable<Order> GetAll()
        {
            return Context.Orders.Where(o => o.DeletedDate == null)
                .Include(x => x.Customer)
                .OrderByDescending(x => x.Id)
                .AsEnumerable();
        }

        public IEnumerable<Order> GetAll(Order firstFilter,
            Order secondFilter,
            Customer customer,
            Employee employee,
            int count,
            int page,
            SortOption option = SortOption.Descending,
            OrderProperty property = OrderProperty.Id)
        {
            var enumerable = Context.Orders.Where(o => o.DeletedDate == null)
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
                enumerable = enumerable.Join(Context.OrderEmployees, o => o.Id, oe => oe.OrderId, (o, oe) => new { o, oe })
                    .Where(@t => @t.oe.Employee.Id == employee.Id)
                    .Select(@t => @t.o);
            }

            var orders = enumerable.SortBy(property.ToString(), option).ToList();

            return orders.Skip((page - 1) * count).Take(count);
        }

        public override Order FindById(int id)
        {
            return Context.Orders.Include(x => x.Customer).First(x => x.Id == id);
        }
    }
}
