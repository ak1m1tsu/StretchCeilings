using System.Collections.Generic;
using System.Linq;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;

namespace StretchCeilings.DataAccess.Repositories
{
    /// <inheritdoc cref="IRoleRepository" />
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Role> GetAll()
        {
            return Context.Roles.AsEnumerable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Role FindById(int id)
        {
            return Context.Roles.Find(id);
        }
    }
}
