using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class ServiceRepository : NotNull
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

                if ((IsNull(firstFilter.Price) && IsNull(secondFilter.Price)) == false)
                    services = services.Where(x => firstFilter.Price <= x.Price && x.Price <= secondFilter.Price);

                if (IsNull(firstFilter.Price) == false)
                    services = services.Where(x => firstFilter.Price <= x.Price);

                if (IsNull(secondFilter.Price) == false)
                    services = services.Where(x => x.Price <= secondFilter.Price);

                if (IsNull(firstFilter.ManufacturerId) == false)
                    services = services.Where(x => x.ManufacturerId == firstFilter.ManufacturerId);

                if(IsNull(firstFilter.CeilingId) == false)
                    services = services.Where(x => x.CeilingId == firstFilter.CeilingId);
                
                if (!services.Any())
                    return services.ToList();

                services.ToList().ForEach(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                services.ToList().ForEach(s => db.Entry(s).Reference(r => r.Manufacturer).Load());

                rows = services.Count();

                return services.ToList().Skip((page - 1) * count).Take(count).ToList();

            }
        }

        public static Service GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var service = db.Services.FirstOrDefault(o => o.Id == id);

                if (IsNull(service))
                    return service;

                db.Entry(service).Reference(r => r.Ceiling).Load();
                db.Entry(service).Reference(r => r.Manufacturer).Load();

                return service;
            }
        }
    }
}
