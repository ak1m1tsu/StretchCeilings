using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IRole
    {
        List<Permission> GetPermissions();
        string AddPermission(Permission permission);
        string DeletePermission(Permission permission);
    }
}
