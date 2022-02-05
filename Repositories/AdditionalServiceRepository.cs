using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class AdditionalServiceRepository : NotNull
    {
        public static List<AdditionalService> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.AdditionalServices.Where(o => o.DeletedDate == null);
                rows = 0;
                
                if (queryable.Any())
                    rows = queryable.Count();
                
                return queryable.ToList();
            }
        }

        public static List<AdditionalService> GetAll(AdditionalService firstFilter, AdditionalService secondsFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.AdditionalServices.Where(s => s.DeletedDate == null);
                rows = 0;

                if (firstFilter.Id != 0)
                    queryable = queryable.Where(s => s.Id == firstFilter.Id);

                if ((IsNull(firstFilter.Price) && IsNull(secondsFilter.Price)) == false)
                    queryable = queryable.Where(s => firstFilter.Price <= s.Price && s.Price <= secondsFilter.Price);
                
                if (IsNull(firstFilter.Price) == false)
                    queryable = queryable.Where(s => firstFilter.Price <= s.Price);
                
                if (IsNull(secondsFilter.Price) == false)
                    queryable = queryable.Where(s => s.Price <= secondsFilter.Price);

                if (IsNull(firstFilter.Name) == false)
                    queryable = queryable.Where(s => s.Name == firstFilter.Name);
                
                
                if (queryable.Any() == false)
                    return queryable.ToList();
                
                rows = queryable.Count();

                return queryable.ToList().Skip((page - 1) * count).Take(count).ToList();
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
