using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilingsApp.Data;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Utility.Repositories
{
    public static class ServiceModelsRepository
    {
        public static List<Service> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var services = db.Services.Where(o => o.DeletedDate == null);
                rows = 0;
                if (!services.Any()) return services.ToList();
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
                {
                    services = services.Where(x => x.Id == firstFilter.Id);
                }
                else
                {
                    services = firstFilter.Price != null && secondFilter.Price != null
                        ? services.Where(x => firstFilter.Price <= x.Price && x.Price <= secondFilter.Price)
                        : services;

                    services = firstFilter.Price != null
                        ? services.Where(x => firstFilter.Price <= x.Price)
                        : services;

                    services = secondFilter.Price != null
                        ? services.Where(x => x.Price <= secondFilter.Price)
                        : services;

                    services = firstFilter.ManufacturerId != null
                        ? services.Where(x => x.ManufacturerId == firstFilter.ManufacturerId)
                        : services;

                    services = firstFilter.CeilingId != null
                        ? services.Where(x => x.CeilingId == firstFilter.CeilingId)
                        : services;
                }

                if (services.Any())
                {
                    services.ToList().ForEach(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                    services.ToList().ForEach(s => db.Entry(s).Reference(r => r.Manufacturer).Load());
                    rows = services.Count();
                    return services.ToList().Skip((page - 1) * count).Take(count).ToList();
                }

                return services.ToList();
            }
        }

        public static Service GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var service = db.Services.FirstOrDefault(o => o.Id == id);

                if (service != null)
                {
                    db.Entry(service).Reference(r => r.Ceiling).Load();
                    db.Entry(service).Reference(r => r.Manufacturer).Load();
                }

                return service;
            }
        }
    }
}
