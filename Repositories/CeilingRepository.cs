using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public static class CeilingRepository
    {
        public static IEnumerable<Ceiling> GetByManufacturerId(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Ceilings.Where(x => x.ManufacturerId == id);
            }
        }

        public static Ceiling GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Ceilings.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
