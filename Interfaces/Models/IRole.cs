using System.Collections.Generic;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IRole
    {
        List<Permission> GetPermissions();
        void AddPermission(Permission permission);
        void DeletePermission(Permission permission);
    }
}
