using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public override IEnumerable<Service> GetAll()
        {
            return Context.Services.Where(o => o.DeletedDate == null)
                .Include(x => x.Ceiling)
                .Include(x => x.Manufacturer)
                .Include(x => x.Room)
                .AsEnumerable();
        }

        public override Service FindById(int id)
        {
            return Context.Services.Find(id);
        }

        public IEnumerable<Service> GetAll(Service firstFilter, Service secondFilter, int count, int page, 
            SortOption option = SortOption.Descending, 
            ServiceProperty property = ServiceProperty.Price)
        {
            var enumerable = Context.Services.Where(o => o.DeletedDate == null)
                .Include(x => x.Ceiling)
                .Include(x => x.Manufacturer)
                .Include(x => x.Room)
                .AsEnumerable();

            if (firstFilter.Id != 0)
                enumerable = enumerable.Where(x => x.Id == firstFilter.Id);

            if (firstFilter.Price != null && secondFilter.Price != null)
                enumerable = enumerable.Where(x => firstFilter.Price <= x.Price && x.Price <= secondFilter.Price);

            if (firstFilter.Price != null)
                enumerable = enumerable.Where(x => firstFilter.Price <= x.Price);

            if (secondFilter.Price != null)
                enumerable = enumerable.Where(x => x.Price <= secondFilter.Price);

            if (firstFilter.ManufacturerId != null)
                enumerable = enumerable.Where(x => x.Manufacturer.Id == firstFilter.ManufacturerId);

            if (firstFilter.CeilingId != null)
                enumerable = enumerable.Where(x => x.Ceiling.Id == firstFilter.CeilingId);

            var services = enumerable.SortBy(property.ToString(), option).ToList();

            return services.Skip((page - 1) * count).Take(count);
        }
    }
}
