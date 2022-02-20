using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IManufacturer : IDbModel
    {
        IEnumerable<Ceiling> GetCeilings();
    }
}
