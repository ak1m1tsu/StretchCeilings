using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetAll(Employee filter, int count, int page, SortOption option = SortOption.Descending, EmployeeProperty property = EmployeeProperty.FullName);
        Employee FindByLogin(string login);
    }
}