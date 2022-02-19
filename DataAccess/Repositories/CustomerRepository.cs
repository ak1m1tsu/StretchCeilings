using System;
using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public IEnumerable<Customer> GetAll(
            Customer filter,
            int count,
            int page,
            SortOption option = SortOption.Descending,
            CustomerProperty property = CustomerProperty.FullName)
        {
            var enumerable = Context.Customers.Where(x => x.DeletedDate == null)
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

        public IEnumerable<Customer> GetAll()
        {
            return Context.Customers.AsEnumerable();
        }

        public Customer FindById(int id)
        {
            return Context.Customers.Find(id);
        }
    }
}
