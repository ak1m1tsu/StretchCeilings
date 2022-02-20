using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
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
                    var rolePermission = new RolePermission()
                    {
                        RoleId = Id, PermissionId = permission.Id
                    };
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
                    if (rolePermission != null)
                        db.RolePermissions.Remove(rolePermission);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Permission> GetPermissions()
        {
            using (var db = new StretchCeilingsContext())
            {
                var permissions = db.Roles
                    .Join(db.RolePermissions, r => r.Id, rp => rp.RoleId, (r, rp) => new { r, rp })
                    .Join(db.Permissions, @t => @t.rp.PermissionId, p => p.Id, (@t, p) => new { @t, p })
                    .Where(@t => @t.@t.rp.RoleId == Id)
                    .Select(@t => @t.p);

                return permissions.ToList();
            }
        }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Roles.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Roles.First(x => x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Roles.First(x => x.Id == Id);
                db.Roles.Remove(old);
                db.SaveChanges();
            }
        }
    }
}