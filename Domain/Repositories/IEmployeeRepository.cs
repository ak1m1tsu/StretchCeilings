using System.Collections.Generic;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Repositories
{
    /// <summary>
    /// Represents a repository of employees
    /// </summary>
    public interface IEmployeeRepository : IRepository<Employee>
    {
        /// <summary>
        /// Returns a filtered and ordered enumeration of employees
        /// </summary>
        /// <param name="filter">filter</param>
        /// <param name="count">employees count</param>
        /// <param name="page">page number in the employees table</param>
        /// <param name="option">order option</param>
        /// <param name="property">property of <see cref="Employee"/></param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where <see cref="Employee">T</see> is a <see cref="Employee"/>
        /// </returns>
        IEnumerable<Employee> GetAll(Employee filter, int count, int page, SortOption option = SortOption.Descending, EmployeeProperty property = EmployeeProperty.FullName);
        /// <summary>
        /// Returns a employee with a specific login
        /// </summary>
        /// <param name="login"></param>
        /// <returns>
        /// <see cref="Employee"/>
        /// </returns>
        Employee FindByLogin(string login);
    }
}