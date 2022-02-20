using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IOrder : IDbModel
    {
        void CalculateTotal();
        IEnumerable<Log> GetLogs();
        IEnumerable<Service> GetServices();
        IEnumerable<Employee> GetEmployees();
    }
}
