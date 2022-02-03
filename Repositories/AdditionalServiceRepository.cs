using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public static class AdditionalServiceRepository
    {
        public static List<AdditionalService> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var additionalServices = db.AdditionalServices.Where(o => o.DeletedDate == null).ToList();
                rows = 0;

                if (additionalServices.Any())
                {
                    rows = additionalServices.Count;
                }

                return additionalServices;
            }
        }

        public static List<AdditionalService> GetAll(AdditionalService firstFilter, AdditionalService secondsFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var additionalServices = db.AdditionalServices.Where(s => s.DeletedDate == null).ToList();
                rows = 0;

                if (firstFilter.Id != 0)
                    additionalServices = additionalServices.Where(s => s.Id == firstFilter.Id).ToList();
                else
                {
                    if (firstFilter.Price != null && secondsFilter.Price != null)
                    {
                        additionalServices = additionalServices.Where(s =>
                            firstFilter.Price <= s.Price && s.Price <= secondsFilter.Price).ToList();
                    }
                    else if(firstFilter.Price != null)
                    {
                        additionalServices = additionalServices.Where(s => firstFilter.Price <= s.Price).ToList();
                    }
                    else if(secondsFilter.Price != null)
                    {
                        additionalServices = additionalServices.Where(s => s.Price <= secondsFilter.Price).ToList();
                    }

                    if (firstFilter.Name != null)
                    {
                        additionalServices = additionalServices.Where(s => s.Name == firstFilter.Name).ToList();
                    }
                }

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
