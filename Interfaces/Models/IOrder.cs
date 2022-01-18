using System.Collections.Generic;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Interfaces.Models
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
