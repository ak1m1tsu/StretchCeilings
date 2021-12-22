using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("OrderServices")]
    public class OrderService
    {
        [Column("OrderID")]
        public int OrderID { get; set; }
        [Column("OrderID")]
        public Order Order { get; set; }
        [Column("ServiceID")]
        public int ServiceID { get; set; }
        [Column("ServiceID")]
        public Service Service { get; set; }
    }
}