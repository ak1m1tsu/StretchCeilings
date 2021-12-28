using stretch_ceilings_app.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Roles")]
    public class Role : IRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateDeleted { get; set; }

        public string AddPermission(Permission permission)
        {
            throw new NotImplementedException();
        }

        public string DeletePermission(Permission permission)
        {
            throw new NotImplementedException();
        }

        public List<Permission> GetPermissions()
        {
            throw new NotImplementedException();
        }
    }
}