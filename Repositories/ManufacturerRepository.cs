using System;
using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;

namespace StretchCeilings.Repositories
{
    public class ManufacturerRepository
    {
        public static List<Manufacturer> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Manufacturers.Where(x => x.DeletedDate == null)
                    .AsEnumerable();

                var manufacturers = queryable.ToList();

                rows = manufacturers.Count();

                return manufacturers;
            }
        }

        public static List<Manufacturer> GetAll(Manufacturer filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Manufacturers.Where(x => x.DeletedDate == null)
                    .AsEnumerable();

                if (filter.Id != 0)
                    enumerable = enumerable.Where(x => x.Id == filter.Id);
                
                if (filter.Address != null)
                    enumerable =  enumerable.Where(x => x.Address.IndexOf(filter.Address, StringComparison.OrdinalIgnoreCase) > -1);

                if (filter.Country != Country.Unknown)
                    enumerable = enumerable.Where(x => x.Country == filter.Country);

                if (filter.Name != null)
                    enumerable = enumerable.Where(x => x.Name.IndexOf(filter.Name, StringComparison.OrdinalIgnoreCase) > -1);

                var manufacturers = enumerable.ToList();

                rows = manufacturers.Count();

                return manufacturers.Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static Manufacturer GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Manufacturers.First(o => o.Id == id);
            }
        }
    }
}
