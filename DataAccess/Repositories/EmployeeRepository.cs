using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess.Repositories.Extensions;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class EmployeeRepository : Repository, IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return Context.Employees.Where(x => x.DeletedDate == null)
                .Include(x => x.Role)
                .OrderByDescending(x => x.FullName)
                .AsEnumerable();
        }

        public IEnumerable<Employee> GetAll(
            Employee filter,
            int count,
            int page,
            SortOption option = SortOption.Descending,
            EmployeeProperty property = EmployeeProperty.FullName)
        {
            var enumerable = Context.Employees.Where(x => x.DeletedDate == null)
                .Include(x => x.Role)
                .AsEnumerable();

            if (filter.Id != 0)
                enumerable = enumerable.Where(x => x.Id == filter.Id);

            if (filter.FullName != null)
                enumerable = enumerable.Where(x => x.FullName.IndexOf(filter.FullName, StringComparison.OrdinalIgnoreCase) > -1);

            if (filter.RoleId != null && filter.RoleId != 0)
                enumerable = enumerable.Where(x => x.RoleId == filter.RoleId);

            var employees = enumerable.SortBy(property.ToString(), option).ToList();

            return employees.Skip((page - 1) * count).Take(count);
        }

        public Employee FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee FindByLogin(string login)
        {
            return Context.Employees.Include(x => x.Role)
                .FirstOrDefault(x => x.Login == login && x.DeletedDate == null);
        }
    }
}
