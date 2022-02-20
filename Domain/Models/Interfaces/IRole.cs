using System.Collections.Generic;

namespace StretchCeilings.Domain.Models.Interfaces
{
    public interface IRole : IDbModel
    {
        IEnumerable<Permission> GetPermissions();
        void AddPermission(Permission permission);
        void DeletePermission(Permission permission);
    }
}
