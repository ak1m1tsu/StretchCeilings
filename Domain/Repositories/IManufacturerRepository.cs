using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface IManufacturerRepository : IRepository<Manufacturer>
    {
        IEnumerable<Manufacturer> GetAll(Manufacturer filter, int count, int page,
            SortOption option = SortOption.Descending, ManufacturerProperty property = ManufacturerProperty.Address);
    }
}