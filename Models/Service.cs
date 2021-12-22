using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FacotoryID { get; set; }
        public Factory Factory { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Pipes { get; set; }
        public int Lamps { get; set; }
        public bool Backlight { get; set; }
        public decimal Price { get; set; }
        public DateTime DeteDeleted { get; set; }
    }
}