using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> Get(Role filter, int count, int page);
        string Add(Role role);
        string Delete(Role role);
        string Change(int oldRole, Role newRole);
    }
}
