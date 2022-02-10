using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Interfaces.Models;

namespace StretchCeilings.Models
{
    public class Service : IService
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
        public decimal? Price { get; set; }
        public DateTime? DeletedDate { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Services.Add(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Services.FirstOrDefault(x => x.Id == this.Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void CalculatePrice()
        {
            using (var db = new StretchCeilingsContext())
            {
                var ceiling = db.Ceilings.FirstOrDefault(x => x.ManufacturerId == ManufacturerId && DeletedDate == null);
                var room = db.CustomersRooms.FirstOrDefault(x => x.Id == RoomId && DeletedDate == null);
                var services = from sas in db.ServiceAdditionalServices
                    join a in db.AdditionalServices on sas.AdditionalServiceId equals a.Id
                    where a.DeletedDate == null && sas.ServiceId == Id
                    select sas;
                
                Price = (ceiling?.Price * room?.Area) ?? 0;

                if (!services.Any())
                    return;

                services.ForEachAsync(x => db.Entry(x).Reference(r => r.AdditionalService).Load());
                services.ForEachAsync(x => Price += x.Count * x.AdditionalService.Price);
            }
        }

        public List<ServiceAdditionalService> GetAdditionalServices()
        {
            using (var db = new StretchCeilingsContext())
            {
                var additionalServices = from sas in db.ServiceAdditionalServices
                    join a in db.AdditionalServices on sas.AdditionalServiceId equals a.Id
                    join s in db.Services on sas.ServiceId equals s.Id
                    where sas.ServiceId == Id
                    select sas;

                if (additionalServices.Any())
                    additionalServices.ForEachAsync(
                        sas => db.Entry(sas).Reference(r => r.AdditionalService).Load());

                return additionalServices.ToList();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Services.FirstOrDefault(x => x.Id == this.Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }


}