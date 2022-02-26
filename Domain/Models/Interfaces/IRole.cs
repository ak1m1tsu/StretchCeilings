using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    /// <inheritdoc />
    public interface IRole : IDbModel
    {
        /// <summary>
        /// Returns roles permissions
        /// </summary>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> where T is <see cref="Permission"/>
        /// </returns>
        IEnumerable<Permission> GetPermissions();
        /// <summary>
        /// Add permission
        /// </summary>
        /// <param name="permission">entity of <see cref="Permission"/></param>
        void AddPermission(Permission permission);
        /// <summary>
        /// Delete permission
        /// </summary>
        /// <param name="permission">entity of <see cref="Permission"/></param>
        void DeletePermission(Permission permission);
    }
}
