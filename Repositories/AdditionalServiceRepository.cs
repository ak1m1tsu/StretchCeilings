using System;
using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Repositories.Enums;

namespace StretchCeilings.Repositories
{
    public class AdditionalServiceRepository
    {
        public static List<AdditionalService> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.AdditionalServices.Where(o => o.DeletedDate == null)
                    .OrderByDescending(x => x.Id)
                    .AsEnumerable();

                var additionalServices = enumerable.ToList();
                
                return additionalServices;
            }
        }

        public static List<AdditionalService> GetAll(
            AdditionalService firstFilter, 
            AdditionalService secondsFilter, 
            int count, 
            int page,
            SortOption option = SortOption.Descending,
            AdditionalServiceProperty property = AdditionalServiceProperty.Name)
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
                    enumerable = enumerable.Where(s => s.Name.IndexOf(firstFilter.Name, StringComparison.OrdinalIgnoreCase) > -1);

                var additionalServices = enumerable.SortBy(property.ToString(), option).ToList();

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
