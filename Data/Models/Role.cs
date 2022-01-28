using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilingsApp.Interfaces.Models;

namespace StretchCeilingsApp.Data.Models
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
                    var rolePermission = new RolePermission() {RoleId = Id, PermissionId = permission.Id};
                    db.RolePermissions.Add(rolePermission);
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
                    var rolePermission = db.RolePermissions.FirstOrDefault(x => x.PermissionId == permission.Id);
                    if (rolePermission != null) db.RolePermissions.Remove(rolePermission);
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
            using (var db = new StretchCeilingsContext())
            {
                var list = new List<Permission>();
                var rolePermissions = db.RolePermissions.Where(x => x.RoleId == Id);
                foreach (var rolePermission in rolePermissions)
                {
                    db.Entry(rolePermission).Reference(r => r.Permission).Load();
                    list.Add(rolePermission.Permission);
                }

                return list;
            }
        }
    }
}