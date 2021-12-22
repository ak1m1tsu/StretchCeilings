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
        public int ID { get; set; }
        [Column("FactoryID")]
        public int FactoryID { get; set; }
        [Column("FactoryID")]
        public Factory Factory { get; set; }
        public DateTime DateFilled { get; set; }
        public DateTime DateComming { get; set; }
        public decimal Total { get; set; }
    }
}