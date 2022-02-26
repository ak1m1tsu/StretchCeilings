using System.Collections.Generic;

namespace StretchCeilings.Domain
{
    /// <summary>
    /// Represents a repository of database entities
    /// </summary>
    /// <typeparam name="T">Database entity</typeparam>
    public interface IRepository<out T> where T : class
    {
        /// <summary>
        /// Returns database entities
        /// </summary>
        /// <returns>Enumerable of database entities</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Returns a database entity with a specific identifier
        /// </summary>
        /// <param name="id">entity identifier</param>
        /// <returns>Database entity</returns>
        T FindById(int id);
    }
}