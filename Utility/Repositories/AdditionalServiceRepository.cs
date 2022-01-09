using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class AdditionalServiceRepository
    {
        public static List<AdditionalService> GetAdditionalServices(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var additionalServices = db.AdditionalServices.Where(o => o.DateDeleted == null).ToList();
                rows = 0;

                if (additionalServices.Any())
                {
                    rows = additionalServices.Count;
                }

                return additionalServices;
            }
        }

        public static List<AdditionalService> GetAdditionalServices(AdditionalService filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var additionalServices = db.AdditionalServices.Where(o => o.Equals(filter)).ToList();
                rows = 0;

                if (additionalServices.Any())
                {
                    rows = additionalServices.Count;
                    additionalServices = additionalServices.Skip((page - 1) * count).Take(count).ToList();
                }

                return additionalServices;
            }
        }

        public static AdditionalService GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var additionalService = db.AdditionalServices.FirstOrDefault(o => o.Id == id);

                return additionalService;
            }
        }
    }
}
