using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface IOrder : IDbModel
    {
        /// <summary>
        /// Calculate orders total price
        /// </summary>
        void CalculateTotal();
        /// <summary>
        /// Returns orders logs
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Log"/>
        /// </returns>
        IEnumerable<Log> GetLogs();
        /// <summary>
        /// Returns orders services
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Service"/>
        /// </returns>
        IEnumerable<Service> GetServices();
        /// <summary>
        /// Returns orders employees
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Employee"/>
        /// </returns>
        IEnumerable<Employee> GetEmployees();
        /// <summary>
        /// Returns orders work dates
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="OrderWorkDate"/>
        /// </returns>
        IEnumerable<OrderWorkDate> GetWorkDates();

        /// <summary>
        /// Remove service from order
        /// </summary>
        /// <param name="id">service identifier</param>
        void RemoveService(int id);
        /// <summary>
        /// Remove employee from order
        /// </summary>
        /// <param name="id">employee identifier</param>
        void RemoveEmployee(int id);
    }
}
