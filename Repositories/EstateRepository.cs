using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class EstateRepository
    {
        public static List<Estate> GetByCustomerId(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var estates = db.Estates.Where(x => x.CustomerId == id);

                if (estates.Any() == false)
                    return estates.ToList();

                estates.ForEachAsync(x => db.Entry(x).Reference(r => r.Customer).Load());

                return estates.ToList();
            }
        }

        public static Estate GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var estate = db.Estates.FirstOrDefault(x => x.Id == id);

                if (estate == null)
                    return new Estate();

                db.Entry(estate).Reference(r => r.Customer).Load();

                return estate;
            }
        }
    }
}
