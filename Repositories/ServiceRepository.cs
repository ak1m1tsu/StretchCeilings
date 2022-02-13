using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class ServiceRepository
    {
        public static List<Service> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Services.Where(o => o.DeletedDate == null)
                    .Include(x => x.Ceiling)
                    .Include(x => x.Manufacturer)
                    .Include(x => x.Room)
                    .AsEnumerable();

                var services = enumerable.ToList();

                rows = services.Count();

                return services;
            }
        }

        public static List<Service> GetAll(Service firstFilter, Service secondFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Services.Where(o => o.DeletedDate == null)
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

                var services = enumerable.ToList();

                rows = services.Count;

                return services.Skip((page - 1) * count).Take(count).ToList();
            }
        }
    }
}
