using System;
using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class ManufacturerRepository : Repository, IManufacturerRepository
    {
        public IEnumerable<Manufacturer> GetAll()
        {
            return Context.Manufacturers.Where(x => x.DeletedDate == null)
                .AsEnumerable();
        }

        public IEnumerable<Manufacturer> GetAll(
            Manufacturer filter,
            int count,
            int page,
            SortOption option = SortOption.Descending,
            ManufacturerProperty property = ManufacturerProperty.Address)
        {
            var enumerable = Context.Manufacturers.Where(x => x.DeletedDate == null)
                .AsEnumerable();

            if (filter.Id != 0)
                enumerable = enumerable.Where(x => x.Id == filter.Id);

            if (filter.Address != null)
                enumerable = enumerable.Where(x => x.Address.IndexOf(filter.Address, StringComparison.OrdinalIgnoreCase) > -1);

            if (filter.Country != Country.Unknown)
                enumerable = enumerable.Where(x => x.Country == filter.Country);

            if (filter.Name != null)
                enumerable = enumerable.Where(x => x.Name.IndexOf(filter.Name, StringComparison.OrdinalIgnoreCase) > -1);

            var manufacturers = enumerable.SortBy(property.ToString(), option).ToList();

            return manufacturers.Skip((page - 1) * count).Take(count);
        }

        public Manufacturer FindById(int id)
        {
            return Context.Manufacturers.First(o => o.Id == id);
        }
    }
}
