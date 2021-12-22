using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> Get(Employee filter, int count, int page);
        string Add(Employee employee);
        string Delete(Employee employee);
        string Change(int oldEmployee, Employee newEmployee);
    }
}
