using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface ICustomer : IDbModel
    {
        IEnumerable<Estate> GetEstates();
    }
}
