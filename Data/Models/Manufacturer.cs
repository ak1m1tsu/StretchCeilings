using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using stretch_ceilings_app.Interfaces.Models;
using stretch_ceilings_app.Utility.Enums;

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
        public Country Country { get; set; }
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
                DateDeleted = DateTime.Now;
                var old = db.Manufacturers.FirstOrDefault(x => x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
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
                var old = db.Manufacturers.FirstOrDefault(x=>x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}