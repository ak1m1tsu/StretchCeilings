using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StretchCeilings.Models
{
    public class OrderWorkDate
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")] 
        public virtual Order Order { get; set; }
        public DateTime DateOfWork { get; set; }
    }
}
