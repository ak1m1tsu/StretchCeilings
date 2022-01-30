using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
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
