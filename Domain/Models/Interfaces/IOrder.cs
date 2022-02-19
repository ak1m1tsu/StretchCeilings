using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IOrder : IDbModel
    {
        void CalculateTotal();
        List<Log> GetLogs();
        List<Service> GetServices();
        List<Employee> GetEmployees();
    }
}
