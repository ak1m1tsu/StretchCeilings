using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface IManufacturer : IDbModel
    {
        /// <summary>
        /// Returns manufacturers ceilings
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Ceiling"/>
        /// </returns>
        IEnumerable<Ceiling> GetCeilings();
    }
}
