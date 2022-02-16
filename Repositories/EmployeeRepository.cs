using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Repositories.Enums;

namespace StretchCeilings.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> GetAll(
            Employee filter, 
            int count, 
            int page,
            SortOption option = SortOption.Descending,
            EmployeeProperty property = EmployeeProperty.FullName)
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Employees.Where(x => x.DeletedDate == null)
                    .Include(x => x.Role)
                    .AsEnumerable();

                if (filter.Id != 0)
                    enumerable = enumerable.Where(x => x.Id == filter.Id);

                if (filter.FullName != null)
                    enumerable = enumerable.Where(x => x.FullName.IndexOf(filter.FullName, StringComparison.OrdinalIgnoreCase) > -1);

                if (filter.RoleId != null && filter.RoleId != 0)
                    enumerable = enumerable.Where(x => x.RoleId == filter.RoleId);

                var employees = enumerable.SortBy(property.ToString(), option).ToList();

                return employees.Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static List<Employee> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var enumerable = db.Employees.Where(x => x.DeletedDate == null)
                    .Include(x => x.Role)
                    .OrderByDescending(x => x.FullName)
                    .AsEnumerable();

                var employees = enumerable.ToList();
                
                return employees;
            }
        }

        public static Employee GetUser(string login, string password)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Employees.Include(x => x.Role)
                    .First(x => x.Login == login && x.Password == password && x.DeletedDate == null);
            }
        }
    }
}
