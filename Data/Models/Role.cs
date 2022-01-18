using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
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
                                                      $"VALUES ({Id}, {permission.Id})");
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletePermission(Permission permission)
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    db.Database.ExecuteSqlCommandAsync($"DELETE {Id}, {permission.Id} FROM RolePermissions");
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Permission> GetPermissions()
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    return db.Database.SqlQuery<Permission>("SELECT Permissions.* FROM Permissions " +
                                                            "INNER JOIN RolePermissions " +
                                                            "ON Permissions.Id = RolePermissions.PermissionId " +
                                                            $"WHERE RolePermissions.RoleId = {Id}").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}