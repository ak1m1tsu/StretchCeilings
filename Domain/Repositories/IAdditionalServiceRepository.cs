using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface IAdditionalServiceRepository : IRepository<AdditionalService>
    {
        IEnumerable<AdditionalService> GetAll(AdditionalService firstFilter, AdditionalService secondsFilter, int count,
            int page, SortOption option = SortOption.Descending,
            AdditionalServiceProperty property = AdditionalServiceProperty.Name);
    }
}