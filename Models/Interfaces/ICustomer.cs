using System.Collections.Generic;

namespace StretchCeilings.Models.Interfaces
{
    public interface ICustomer : IDbModel
    {
        List<Estate> GetEstates();
    }
}
