using System.Collections.Generic;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Interfaces.Models
{
    public interface IRole
    {
        List<Permission> GetPermissions();
        void AddPermission(Permission permission);
        void DeletePermission(Permission permission);
    }
}
