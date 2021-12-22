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
        public int ID { get; set; }
        [Column("OrderID")]
        public int OrderID { get; set; }
        [Column("OrderID")]
        public Order Order { get; set; }
        public string Comment { get; set; }
        public DateTime DateCanceled { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}