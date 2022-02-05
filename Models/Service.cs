﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
                db.Entry(Id).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void CalculatePrice()
        {
            using (var db = new StretchCeilingsContext())
            {
                Price = Ceiling?.Price * Room?.Area;
                var services = db.ServiceAdditionalServices.Where(x => x.ServiceId == Id);
                foreach (var serviceAdditionalService in services)
                {
                    Price += serviceAdditionalService.AdditionalService?.Price * serviceAdditionalService.Count;
                }
            }

        }

        public List<AdditionalService> GetAdditionalServices()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.AdditionalServices.SqlQuery("SELECT AdditionalServices.* FROM AdditionalServices " +
                                                      "INNER JOIN ServiceAdditServices ON ServiceAdditServices.AdditServiceId = AdditionalServices.Id " +
                                                      $"WHERE ServiceAdditServices.ServiceId = {Id} AND AdditionalServices.DeletedDate IS NULL").ToList();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(Id).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }


}