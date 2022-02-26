using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of additional services
    /// </summary>
    public interface IAdditionalServiceRepository : IRepository<AdditionalService>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of additional services
        /// </summary>
        /// <param name="firstFilter">first filter</param>
        /// <param name="secondsFilter">second filter</param>
        /// <param name="count">additional services count</param>
        /// <param name="page">page number in the additional services table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of <see cref="AdditionalService"/></param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="AdditionalService">T</see> is a <see cref="AdditionalService"/>
        /// </returns>
        IEnumerable<AdditionalService> GetAll(AdditionalService firstFilter, AdditionalService secondsFilter, int count,
            int page, SortOption option = SortOption.Descending,
            AdditionalServiceProperty property = AdditionalServiceProperty.Name);
    }
}