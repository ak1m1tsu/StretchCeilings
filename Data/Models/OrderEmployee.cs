using System.ComponentModel.DataAnnotations.Schema;

namespace StretchCeilingsApp.Data.Models
{
    [Table("OrderEmployees")]
    public class OrderEmployee
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")]
        public virtual Order Order { get; set; }
        [Column("EmployeeId")] 
        public int? EmployeeId { get; set; }
        [Column("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
