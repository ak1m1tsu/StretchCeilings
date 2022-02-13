using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> GetAll(Employee filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Employees.Where(x => x.DeletedDate == null);
                rows = 0;

                if (filter.Id != 0)
                    queryable = queryable.Where(x => x.Id == filter.Id);

                if (filter.FullName != null)
                    queryable = queryable.Where(x => x.FullName == filter.FullName);

                if (filter.RoleId != null && filter.RoleId != 0)
                    queryable = queryable.Where(x => x.RoleId == filter.RoleId);

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
                var queryable = db.Employees.Where(x => x.DeletedDate == null);
                rows = 0;

                if (queryable.Any() == false)
                    return queryable.ToList();
                
                queryable.ForEachAsync(x => db.Entry(x).Reference(r => r.Role).Load());
                rows = queryable.Count();
                
                return queryable.ToList();
            }
        }

        public static Employee GetUser(string login, string password)
        {
            using (var db = new StretchCeilingsContext())
            {
                var user = db.Employees.FirstOrDefault(x => x.Login == login && x.Password == password && x.DeletedDate == null);
                
                if (user != null)
                    db.Entry(user).Reference(x=>x.Role).Load();
                
                return user;
            }
        }
    }
}
