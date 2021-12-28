using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("FactoryOrders")]
    public class FactoryOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Factory")]
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
        public DateTime? DateFilled { get; set; }
        public DateTime? DateComming { get; set; }
        public decimal Total { get; set; }
    }
}