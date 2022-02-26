using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of manufacturers
    /// </summary>
    public interface IManufacturerRepository : IRepository<Manufacturer>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of manufacturers
        /// </summary>
        /// <param name="filter">filter</param>
        /// <param name="count">manufacturers count</param>
        /// <param name="page">page number in the manufacturers table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of <see cref="Manufacturer"/></param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="Manufacturer">T</see> is a <see cref="Manufacturer"/>
        /// </returns>
        IEnumerable<Manufacturer> GetAll(Manufacturer filter, int count, int page,
            SortOption option = SortOption.Descending, ManufacturerProperty property = ManufacturerProperty.Address);
    }
}