using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("OrderEmployees")]
    public class OrderEmployee
    {
        [Column("OrderID")]
        public int OrderID { get; set; }
        [Column("OrderID")]
        public Order Order { get; set; }
        [Column("EmployeeID")]
        public int EmployeeID { get; set; }
        [Column("EmployeeID")]
        public Employee Employee { get; set; }
    }
}