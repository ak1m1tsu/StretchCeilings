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
                var services = db.Services.Where(o => o.DeletedDate == null);
                rows = 0;

                if (!services.Any()) 
                    return services.ToList();

                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Manufacturer).Load());
                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Room).Load());

                rows = services.Count();

                return services.ToList();
            }
        }

        public static List<Service> GetAll(Service firstFilter, Service secondFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var services = db.Services.Where(o => o.DeletedDate == null);
                rows = 0;

                if (firstFilter.Id != 0)
                    services = services.Where(x => x.Id == firstFilter.Id);

                if (firstFilter.Price != null && secondFilter.Price != null)
                    services = services.Where(x => firstFilter.Price <= x.Price && x.Price <= secondFilter.Price);

                if (firstFilter.Price != null)
                    services = services.Where(x => firstFilter.Price <= x.Price);

                if (secondFilter.Price != null)
                    services = services.Where(x => x.Price <= secondFilter.Price);

                if (firstFilter.ManufacturerId != null)
                    services = services.Where(x => x.ManufacturerId == firstFilter.ManufacturerId);

                if (firstFilter.CeilingId != null)
                    services = services.Where(x => x.CeilingId == firstFilter.CeilingId);
                
                if (!services.Any())
                    return services.ToList();

                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Manufacturer).Load());
                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Room).Load());


                rows = services.Count();

                return services.ToList().Skip((page - 1) * count).Take(count).ToList();

            }
        }
    }
}
