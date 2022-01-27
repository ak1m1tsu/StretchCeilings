using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Ceilings")]
    public class Ceiling : ICeiling
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("ManufacturerId")]
        public int? ManufacturerId { get; set; }
        [Column("ManufacturerId")]
        public virtual Manufacturer Manufacturer { get; set; }
        public TextureType TextureType { get; set; }
        public ColorType ColorType { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Ceilings.Add(this);
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