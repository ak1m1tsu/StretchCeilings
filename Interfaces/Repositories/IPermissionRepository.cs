using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IPermissionRepository
    {
        List<Permission> Get(Permission filter, int count, int page);
        string Add(Permission permission);
        string Delete(Permission permission);
        string Change(int oldPermission, Permission newPermission);
    }
}
