using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class ServiceRepository
    {
        public static List<Service> GetServices(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var services = db.Services.Where(o => o.DateDeleted == null).ToList();
                rows = 0;
                if (services.Any())
                {
                    services.ForEach(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                    services.ForEach(s => db.Entry(s).Reference(r => r.Manufacturer).Load());
                    rows = services.Count;
                }

                return services;
            }
        }

        public static List<Service> GetServices(Service filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var services = db.Services.Where(o => o.Equals(filter)).ToList();
                rows = 0;

                if (services.Any())
                {
                    services.ForEach(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                    services.ForEach(s => db.Entry(s).Reference(r => r.Manufacturer).Load());
                    rows = services.Count;
                    services = services.Skip((page - 1) * count).Take(count).ToList();
                }

                return services;
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
