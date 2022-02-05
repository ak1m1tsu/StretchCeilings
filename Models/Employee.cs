﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Interfaces.Models;

namespace StretchCeilings.Models
{
    public class Employee : IEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [Column("RoleId")]
        public int? RoleId { get; set; }
        [Column("RoleId")]
        public virtual Role Role { get; set; }
        public DateTime? DeletedDate { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Employees.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Employees.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Employees.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public List<TimeTable> GetSchedule()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Schedule.Where(t => t.EmployeeId == Id && t.DeletedDate == null).ToList();
            }
        }
    }
}