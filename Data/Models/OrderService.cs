using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Data.Models
{
    [Table("OrderServices")]
    public class OrderService
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")] 
        public virtual Order Order { get; set; }
        [Column("ServiceId")] 
        public int? ServiceId { get; set; }
        [Column("ServiceId")] 
        public virtual Service Service { get; set; }
    }
}
