using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class EmployeeRepository
    {
        public static List<Employee> GetEmployees(Employee filter, int count, int pages, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var employees = db.Employees.Where(e => e.Equals(filter)).ToList();
                rows = 0;

                if (employees.Any())
                {
                    employees.ForEach(o => db.Entry(o).Reference(r => r.Role).Load());
                    rows = employees.Count();
                    employees = employees.Skip((pages - 1) * count).Take(count).ToList();
                }

                return employees.ToList();
            }
        }

        public static List<Employee> GetEmployees()
        {
            using (var db = new StretchCeilingsContext())
            {
                var employees = db.Employees.Where(e => e.DateDeleted == null).ToList();
                
                if (employees.Any())
                {
                    employees.ForEach(o => db.Entry(o).Reference(r => r.Role).Load());
                }

                return employees;
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
