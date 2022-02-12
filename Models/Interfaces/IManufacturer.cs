using System.Collections.Generic;

namespace StretchCeilings.Models.Interfaces
{
    public interface IManufacturer : IDbModel
    {
        List<Ceiling> GetCeilings();
    }
}
