using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Manufacturers")]
    public class Manufacturer : IManufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Manufacturers.Add(this);
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

        public List<ManufacturerOrder> GetOrders()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.ManufacturerOrders.Where(order => order.ManufacturerId == Id).ToList();
            }
        }

        public List<Ceiling> GetCeilings()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Ceilings.Where(ceiling => ceiling.ManufacturerId == Id).ToList();
            }
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