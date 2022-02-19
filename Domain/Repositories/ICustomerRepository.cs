using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetAll(Customer filter, int count, int page, SortOption option = SortOption.Descending, CustomerProperty property = CustomerProperty.FullName);
    }
}