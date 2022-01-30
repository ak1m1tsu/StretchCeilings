using System.ComponentModel.DataAnnotations.Schema;

namespace StretchCeilings.Models
{
    public class RolePermission
    {
        [Column("RoleId")] 
        public int? RoleId { get; set; }
        [Column("RoleId")] 
        public virtual Role Role { get; set; }
        [Column("PermissionId")] 
        public int? PermissionId { get; set; }
        [Column("PermissionId")] 
        public virtual Permission Permission { get; set; }
    }
}
