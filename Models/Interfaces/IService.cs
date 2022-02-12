using System.Collections.Generic;

namespace StretchCeilings.Models.Interfaces
{
    public interface IService : IDbModel
    {
        List<ServiceAdditionalService> GetAdditionalServices();
    }
}
