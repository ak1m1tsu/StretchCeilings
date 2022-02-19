using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface IServiceRepository : IRepository<Service>
    {
        IEnumerable<Service> GetAll(Service firstFilter, Service secondFilter, int count, int page,
            SortOption option = SortOption.Descending, ServiceProperty property = ServiceProperty.Price);
    }
}