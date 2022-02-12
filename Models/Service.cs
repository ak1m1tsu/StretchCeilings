using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models.Interfaces;

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
                var old = db.Services.FirstOrDefault(x => x.Id == Id);
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
                var services = db.ServiceAdditionalServices
                    .Join(db.AdditionalServices, sas => sas.AdditionalServiceId, a => a.Id, (sas, a) => new { sas, a })
                    .Where(@t => @t.a.DeletedDate == null && @t.sas.ServiceId == Id)
                    .Select(@t => @t.sas);
                
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
                var additionalServices = db.ServiceAdditionalServices
                    .Join(db.AdditionalServices, sas => sas.AdditionalServiceId, a => a.Id, (sas, a) => new { sas, a })
                    .Join(db.Services, @t => @t.sas.ServiceId, s => s.Id, (@t, s) => new { @t, s })
                    .Where(@t => @t.@t.sas.ServiceId == Id)
                    .Select(@t => @t.@t.sas);

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
                var old = db.Services.FirstOrDefault(x => x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }


}