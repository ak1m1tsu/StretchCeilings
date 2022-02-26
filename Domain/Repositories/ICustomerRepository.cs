using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of customers
    /// </summary>
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of customers
        /// </summary>
        /// <param name="filter">filter</param>
        /// <param name="count">customers count</param>
        /// <param name="page">page number in the customers table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of <see cref="Customer"/></param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="Customer">T</see> is a <see cref="Customer"/>
        /// </returns>
        IEnumerable<Customer> GetAll(Customer filter, int count, int page, SortOption option = SortOption.Descending, CustomerProperty property = CustomerProperty.FullName);
    }
}