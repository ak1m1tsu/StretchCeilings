using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetAll(Order firstFilter, Order secondFilter, Customer customer, Employee employee,
            int count, int page, SortOption option = SortOption.Descending, OrderProperty property = OrderProperty.Id);
    }
}