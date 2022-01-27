using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Data.Models
{
    [Table("OrderWorkDays")]
    public class OrderWorkDay
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")] 
        public virtual Order Order { get; set; }
        public DateTime DateOfWork { get; set; }
    }
}
