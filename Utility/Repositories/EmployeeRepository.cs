using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class EmployeeRepository
    {
        public static List<Employee> GetAll(Employee filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Employees.Where(x => x.DateDeleted == null);
                rows = 0;

                if (filter.Id != 0)
                {
                    queryable = queryable.Where(x => x.Id == filter.Id);
                }
                else
                {
                    queryable = filter.FullName != null
                        ? queryable.Where(x => x.FullName == filter.FullName)
                        : queryable;

                    queryable = filter.Role != null
                        ? queryable.Where(x => x.Role.Name == filter.Role.Name)
                        : queryable;
                }

                if (queryable.Any() == false)
                    return queryable.ToList();

                queryable.ForEachAsync(x => db.Entry(x).Reference(r => r.Role).Load());
                rows = queryable.Count();
                return queryable.ToList().Skip((page - 1) * count).Take(count).ToList();
            }
        }

        public static List<Employee> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Employees.Where(x => x.DateDeleted == null);
                rows = 0;

                if (queryable.Any())
                {
                    queryable.ForEachAsync(x => db.Entry(x).Reference(r => r.Role).Load());
                    rows = queryable.Count();
                }

                return queryable.ToList();
            }
        }

        public static List<Employee> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Employees.Where(x => x.DateDeleted == null).ToList();

                if (queryable.Any())
                {
                    queryable.ForEach(x => db.Entry(x).Reference(r => r.Role).Load());
                }

                return queryable;
            }
        }

        public static Employee GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var employee = db.Employees.FirstOrDefault(e => e.Id == id);

                if (employee != null)
                {
                    db.Entry(employee).Reference(e => e.Role).Load();
                }

                return employee;
            }
        }
    }
}
