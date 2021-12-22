using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("RolePermissions")]
    public class RolePermission
    {
        [Column("RoleID")]
        public int RoleID { get; set; }
        [Column("RoleID")]
        public Role Role { get; set; }
        [Column("PermissionID")]
        public int PermissionID { get; set; }
        [Column("PermissionID")]
        public Permission Permission { get; set; }
    }
}