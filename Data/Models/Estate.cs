﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilingsApp.Interfaces.Models;

namespace StretchCeilingsApp.Data.Models
{
    [Table("Estates")]
    public class Estate : IEstate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Column("CustomerId")]
        public int? CustomerId { get; set; }
        [Column("CustomerId")]
        public virtual Customer Customer { get; set; }
        public DateTime? DeletedDate { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Estates.Add(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(this.Id).CurrentValues.SetValues(DeletedDate = DateTime.Now);
                db.SaveChanges();
            }
        }

        public List<Room> GetRooms()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Rooms.Where(r => r.EstateId == this.Id).ToList();
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