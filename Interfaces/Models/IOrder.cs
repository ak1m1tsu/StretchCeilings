using System.Collections.Generic;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IOrder
    {
        void Add();
        void Update();
        void Delete();
        void CalculateTotal();
        List<Log> GetLogs();
        List<Service> GetServices();
        List<Employee> GetEmployees();
    }
}
