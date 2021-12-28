using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("OrderLogs")]
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime? DateCanceled { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}