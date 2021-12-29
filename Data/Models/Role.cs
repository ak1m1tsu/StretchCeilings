using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Interfaces;

namespace stretch_ceilings_app.Models
{
    [Table("Roles")]
    public class Role : IRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddPermission(Permission permission)
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    db.Database.ExecuteSqlCommandAsync("INSERT INTO RolePermissions (RoleId, PermissionId) " +
                                                       "VALUES (@id, @permissionId)", Id, permission.Id);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletePermission(Permission permission)
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    db.Database.ExecuteSqlCommandAsync($"DELETE @roleId, @permissionId FROM RolePermissions", Id, permission.Id);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Permission> GetPermissions()
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    return db.Permissions.SqlQuery($"SELECT Permissions.* FROM Permissions " +
                                                   $"INNER JOIN RolePermissions ON RolePermissions.PermissionId == Permissions.Id " +
                                                   $"WHERE RolePermissions.RoleId == @id " +
                                                   $"GROUP BY Permissions.Id", Id).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}