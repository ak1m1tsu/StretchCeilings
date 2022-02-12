using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class CustomerRepository
    {
        public static List<Customer> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Customers.Where(x => x.DeletedDate == null);
                rows = 0;

                if (queryable.Any())
                    rows = queryable.Count();

                return queryable.ToList();
            }
        }

        public static List<Customer> GetAll(Customer filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Customers.Where(x => x.DeletedDate == null);
                rows = 0;

                if (filter.Id != 0)
                    queryable = queryable.Where(x => x.Id == filter.Id);

                if (filter.FullName != null)
                    queryable = queryable.Where(x => x.FullName == filter.FullName);

                if (filter.PhoneNumber != null)
                    queryable = queryable.Where(x => x.PhoneNumber == filter.PhoneNumber);
                
                if (!queryable.Any())
                    return queryable.ToList();

                rows = queryable.Count();
                return queryable.ToList().Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static Customer GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Customers.FirstOrDefault(o => o.Id == id);
            }
        }
    }
}
