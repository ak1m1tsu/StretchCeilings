using System.Collections.Generic;
using System.Linq;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    public class RoleRepository : Repository, IRoleRepository
    {
        public  IEnumerable<Role> GetAll()
        {
            return Context.Roles.AsEnumerable();
        }

        public Role FindById(int id)
        {
            return Context.Roles.Find(id);
        }
    }
}
