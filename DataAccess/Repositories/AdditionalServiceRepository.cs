using System;
using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class AdditionalServiceRepository : Repository<AdditionalService>, IAdditionalServiceRepository
    {
        public override IEnumerable<AdditionalService> GetAll()
        {
            return Context.AdditionalServices.Where(o => o.DeletedDate == null)
                .OrderByDescending(x => x.Id)
                .AsEnumerable();
        }

        public IEnumerable<AdditionalService> GetAll(
            AdditionalService firstFilter, 
            AdditionalService secondsFilter, 
            int count, 
            int page,
            SortOption option = SortOption.Descending,
            AdditionalServiceProperty property = AdditionalServiceProperty.Name)
        {
            var enumerable = Context.AdditionalServices.Where(s => s.DeletedDate == null)
                .AsEnumerable();

            if (firstFilter.Id != 0)
                enumerable = enumerable.Where(s => s.Id == firstFilter.Id);

            if (firstFilter.Price != null && secondsFilter.Price != null)
                enumerable = enumerable.Where(s => firstFilter.Price <= s.Price && s.Price <= secondsFilter.Price);

            if (firstFilter.Price != null)
                enumerable = enumerable.Where(s => firstFilter.Price <= s.Price);

            if (secondsFilter.Price != null)
                enumerable = enumerable.Where(s => s.Price <= secondsFilter.Price);

            if (firstFilter.Name != null)
                enumerable = enumerable.Where(s => s.Name.IndexOf(firstFilter.Name, StringComparison.OrdinalIgnoreCase) > -1);

            var additionalServices = enumerable.SortBy(property.ToString(), option).ToList();

            return additionalServices.Skip((page - 1) * count).Take(count);
        }

        public override AdditionalService FindById(int id)
        {
            return Context.AdditionalServices.Find(id);
        }
    }
}
