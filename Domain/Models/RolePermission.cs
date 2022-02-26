using System.ComponentModel.DataAnnotations.Schema;

namespace StretchCeilings.Domain.Models
{
    /// <summary>
    /// Presents database entity
    /// </summary>
    public class RolePermission
    {
        /// <summary>
        /// role identifier
        /// </summary>
        [Column("RoleId")] 
        public int? RoleId { get; set; }
        /// <summary>
        /// role
        /// </summary>
        [Column("RoleId")] 
        public virtual Role Role { get; set; }
        /// <summary>
        /// permission identifier
        /// </summary>
        [Column("PermissionId")] 
        public int? PermissionId { get; set; }
        /// <summary>
        /// permission
        /// </summary>
        [Column("PermissionId")] 
        public virtual Permission Permission { get; set; }
    }
}
