using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
{
    [Table("ManufacturerOrders")]
    public class ManufacturerOrder : IManufacturerOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ManufacturerId")]
        public int? ManufacturerId { get; set; }
        [Column("ManufacturerId")]
        public virtual Manufacturer Manufacturer { get; set; }
        [Column("CeilingId")]
        public int? CeilingId { get; set; }
        [Column("CeilingId")]
        public virtual Ceiling Ceiling { get; set; }
        public DateTime? DateFilled { get; set; }
        public DateTime? DateComming { get; set; }
        public decimal? Total { get; set; }

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