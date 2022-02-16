using System;
using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Repositories.Enums;

namespace StretchCeilings.Repositories
{
    public class CustomerRepository
    {
        public static List<Customer> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Customers.Where(x => x.DeletedDate == null)
                    .OrderByDescending(x => x.FullName)
                    .AsEnumerable();

                var customers = enumerable.ToList();

                return customers.ToList();
            }
        }

        public static List<Customer> GetAll(
            Customer filter, 
            int count, 
            int page,
            SortOption option = SortOption.Descending,
            CustomerProperty property = CustomerProperty.FullName)
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

                var customers = enumerable.SortBy(property.ToString(), option).ToList();

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
