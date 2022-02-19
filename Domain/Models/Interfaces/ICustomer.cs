using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface ICustomer : IDbModel
    {
        List<Estate> GetEstates();
    }
}
