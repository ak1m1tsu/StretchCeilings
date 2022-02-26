using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of services
    /// </summary>
    public interface IServiceRepository : IRepository<Service>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of services
        /// </summary>
        /// <param name="firstFilter">first filter</param>
        /// <param name="secondFilter">second filter</param>
        /// <param name="count">count of services</param>
        /// <param name="page">page number in the services table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of service</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="Service">T</see> is a <see cref="Service"/>
        /// </returns>
        IEnumerable<Service> GetAll(Service firstFilter, Service secondFilter, int count, int page,
            SortOption option = SortOption.Descending, ServiceProperty property = ServiceProperty.Price);
    }
}