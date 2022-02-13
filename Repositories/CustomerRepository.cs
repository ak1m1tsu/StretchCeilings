using System;
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
                var enumerable = db.Customers.Where(x => x.DeletedDate == null)
                    .AsEnumerable();

                var customers = enumerable.ToList();

                rows = customers.Count();

                return customers.ToList();
            }
        }

        public static List<Customer> GetAll(Customer filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Customers.Where(x => x.DeletedDate == null)
                    .AsEnumerable();

                if (filter.Id != 0)
                    enumerable = enumerable.Where(x => x.Id == filter.Id);

                if (string.IsNullOrEmpty(filter.FullName) == false)
                    enumerable = enumerable.Where(x => x.FullName.IndexOf(filter.FullName, StringComparison.OrdinalIgnoreCase) > -1);
                
                if (string.IsNullOrEmpty(filter.PhoneNumber) == false)
                    enumerable = enumerable.Where(x => x.PhoneNumber == filter.PhoneNumber);

                var customers = enumerable.ToList();
                
                rows = customers.Count();

                return customers.Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static Customer GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Customers.Find(id);
            }
        }
    }
}
