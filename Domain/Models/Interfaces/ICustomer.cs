using System;
using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface ICustomer : IDbModel
    {
        /// <summary>
        /// Returns customers estates
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Estate"/>
        /// </returns>
        IList<Estate> GetEstates();

        /// <summary>
        /// Returns customer orders
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Order"/>
        /// </returns>
        IList<Order> GetOrders();

        IList<Service> GetServices();

        /// <summary>
        /// Returns customer orders count for same period
        /// </summary>
        /// <param name="dateFrom">date from</param>
        /// <param name="dateUntil">date until</param>
        /// <returns>
        /// customer orders count
        /// </returns>
        int GetOrdersCount(DateTime dateFrom, DateTime dateUntil);
    }
}
