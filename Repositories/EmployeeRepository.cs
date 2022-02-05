using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public class EmployeeRepository : NotNull
    {
        public static List<Employee> GetAll(Employee filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Employees.Where(x => x.DeletedDate == null);
                rows = 0;

                if (filter.Id != 0)
                    queryable = queryable.Where(x => x.Id == filter.Id);

                if (IsNull(filter.FullName) == false)
                    queryable = queryable.Where(x => x.FullName == filter.FullName);

                if (IsNull(filter.RoleId) == false)
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

        public static List<Employee> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Employees.Where(x => x.DeletedDate == null);

                if (queryable.Any() == false)
                    return queryable.ToList();

                queryable.ForEachAsync(x => db.Entry(x).Reference(r => r.Role).Load());
                
                return queryable.ToList();
            }
        }

        public static Employee GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var employee = db.Employees.FirstOrDefault(e => e.Id == id);

                if (IsNull(employee) == false)
                    db.Entry(employee).Reference(e => e.Role).Load();
                
                return employee;
            }
        }

        public static Employee GetUser(string login, string password)
        {
            using (var db = new StretchCeilingsContext())
            {
                var user = db.Employees.FirstOrDefault(x => x.Login == login && x.Password == password);
                
                if (IsNull(user) == false)
                    db.Entry(user).Reference(x=>x.Role).Load();
                
                return user;
            }
        }
    }
}
