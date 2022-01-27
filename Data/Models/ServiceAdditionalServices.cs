using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace stretch_ceilings_app.Data.Models
{
    [Table("ServiceAdditionalServices")]
    public class ServiceAdditionalService
    {
        [Column("ServiceId")] 
        public int? ServiceId { get; set; }
        [Column("ServiceId")] 
        public virtual Service Service { get; set; }
        [Column("AdditionalServiceId")] 
        public int? AdditionalServiceId { get; set; }
        [Column("AdditionalServiceId")] 
        public virtual AdditionalService AdditionalService { get; set; }
        public int Count { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {

                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {

                db.SaveChanges();
            }
        }

        public List<AdditionalService> GetAdditionalServices()
        {
            using (var db = new StretchCeilingsContext())
            {
                List<AdditionalService> services = new List<AdditionalService>();
                for (int i = 0; i < Count; i++)
                {
                    services.Add(db.AdditionalServices.FirstOrDefault(x=>x.Id == AdditionalServiceId));
                }

                return services;
            }
        }
    }
}
