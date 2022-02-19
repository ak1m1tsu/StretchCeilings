using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IService : IDbModel
    {
        List<ServiceAdditionalService> GetAdditionalServices();
    }
}
