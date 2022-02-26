using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of orders
    /// </summary>
    public interface IOrderRepository : IRepository<Order>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of orders
        /// </summary>
        /// <param name="firstFilter">first filter</param>
        /// <param name="secondFilter">second filter</param>
        /// <param name="customer">third filter</param>
        /// <param name="employee">fourth filter</param>
        /// <param name="count">orders count</param>
        /// <param name="page">page number in the orders table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of <see cref="Order"/></param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="Order">T</see> is a <see cref="Order"/>
        /// </returns>
        IEnumerable<Order> GetAll(Order firstFilter, Order secondFilter, Customer customer, Employee employee,
            int count, int page, SortOption option = SortOption.Descending, OrderProperty property = OrderProperty.Id);
    }
}