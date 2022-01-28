using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StretchCeilingsApp.Data.Models
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
