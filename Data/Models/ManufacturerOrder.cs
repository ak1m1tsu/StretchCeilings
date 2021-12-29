using stretch_ceilings_app.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("ManufacturerOrder")]
    public class ManufacturerOrder : IManufacturerOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("FactoryId")]
        public int FactoryId { get; set; }
        [Column("FactoryId")]
        public Manufacturer Factory { get; set; }
        public DateTime? DateFilled { get; set; }
        public DateTime? DateComming { get; set; }
        public decimal Total { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}