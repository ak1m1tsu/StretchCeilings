using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface IService : IDbModel
    {
        /// <summary>
        /// Returns service additional services
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="ServiceAdditionalService"/>
        /// </returns>
        IEnumerable<ServiceAdditionalService> GetAdditionalServices();

        /// <summary>
        /// Calculate service price
        /// </summary>
        void CalculatePrice();
    }
}
