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
        [Column("RoomId")]
        public int? RoomId { get; set; }
        [Column("RoomId")]
        public virtual Room Room { get; set; }
        public DateTime? DateFilled { get; set; }
        public DateTime? DateComing { get; set; }
        public DateTime? DateDeleted { get; set; }
        public decimal? Total { get; private set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.ManufacturerOrders.Add(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(this.Id).CurrentValues.SetValues(DateDeleted = DateTime.Now);
                db.SaveChanges();
            }
        }

        public void CalculateTotal()
        {
            Total = Room.Area * Ceiling.Price;
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(this.Id).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}