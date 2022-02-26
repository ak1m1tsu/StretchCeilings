using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Service : IService
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// manufacturer identifier
        /// </summary>
        [Column("ManufacturerId")] 
        public int? ManufacturerId { get; set; }
        /// <summary>
        /// manufacturer
        /// </summary>
        [Column("ManufacturerId")] 
        public virtual Manufacturer Manufacturer { get; set; }
        /// <summary>
        /// ceiling identifier
        /// </summary>
        [Column("CeilingId")] 
        public int? CeilingId { get; set; }
        /// <summary>
        /// ceiling
        /// </summary>
        [Column("CeilingId")] 
        public virtual Ceiling Ceiling { get; set; }
        /// <summary>
        /// room identifier
        /// </summary>
        [Column("RoomId")] 
        public int? RoomId { get; set; }
        /// <summary>
        /// room
        /// </summary>
        [Column("RoomId")] 
        public virtual Room Room { get; set; }
        /// <summary>
        /// price
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Services.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public void CalculatePrice()
        {
            using (var db = new StretchCeilingsContext())
            {
                var ceiling = db.Ceilings.FirstOrDefault(x => x.Id == CeilingId && DeletedDate == null);
                var room = db.CustomersRooms.FirstOrDefault(x => x.Id == RoomId && DeletedDate == null);
                var services = db.ServiceAdditionalServices
                    .Join(db.AdditionalServices, sas => sas.AdditionalServiceId, a => a.Id, (sas, a) => new { sas, a })
                    .Where(@t => @t.a.DeletedDate == null && @t.sas.ServiceId == Id)
                    .Select(@t => @t.sas);
                var s = services.ToList();
                Price = (ceiling?.Price * room?.Area) ?? 0;

                if (services.Any() == false)
                    return;

                foreach (var serviceAdditionalService in services)
                {
                    db.Entry(serviceAdditionalService).Reference(x => x.AdditionalService).Load();
                    Price += serviceAdditionalService.Count * serviceAdditionalService.AdditionalService.Price;
                }
            }
        }

        /// <inheritdoc />
        public IEnumerable<ServiceAdditionalService> GetAdditionalServices()
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

        /// <inheritdoc />
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