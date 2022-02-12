using System.Collections.Generic;

namespace StretchCeilings.Models.Interfaces
{
    public interface IRole : IDbModel
    {
        List<Permission> GetPermissions();
        void AddPermission(Permission permission);
        void DeletePermission(Permission permission);
    }
}
