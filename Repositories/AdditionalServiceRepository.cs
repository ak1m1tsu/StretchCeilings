using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class AdditionalServiceRepository
    {
        public static List<AdditionalService> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.AdditionalServices.Where(o => o.DeletedDate == null)
                    .AsEnumerable();

                var additionalServices = enumerable.ToList();

                rows = additionalServices.Count();
                
                return additionalServices;
            }
        }

        public static List<AdditionalService> GetAll(AdditionalService firstFilter, AdditionalService secondsFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.AdditionalServices.Where(s => s.DeletedDate == null)
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
                    enumerable = enumerable.Where(s => s.Name == firstFilter.Name);

                var additionalServices = enumerable.ToList();

                rows = additionalServices.Count();

                return additionalServices.Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static AdditionalService GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.AdditionalServices.Find(id);
            }
        }
    }
}
