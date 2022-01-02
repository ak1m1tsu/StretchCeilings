using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace stretch_ceilings_app.Data.Models
{
    [Table("AdditionalServices")]
    public class AdditionalService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.AdditionalServices.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var oldAdditionalService = db.AdditionalServices.FirstOrDefault(s => s.Id == this.Id);
                if (oldAdditionalService != null)
                {
                    db.Entry(oldAdditionalService).CurrentValues.SetValues(this);
                    db.SaveChanges();
                }
            }
        }

        public void Delete()
        {
            DateDeleted = DateTime.Now;

            using (var db = new StretchCeilingsContext())
            {
                var oldAdditionalService = db.AdditionalServices.FirstOrDefault(s => s.Id == this.Id);
                if (oldAdditionalService != null)
                {
                    db.Entry(oldAdditionalService).CurrentValues.SetValues(this);
                    db.SaveChanges();
                }
            }
        }
    }
}