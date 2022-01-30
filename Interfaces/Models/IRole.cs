using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
{
    public interface IRole
    {
        List<Permission> GetPermissions();
        void AddPermission(Permission permission);
        void DeletePermission(Permission permission);
    }
}
