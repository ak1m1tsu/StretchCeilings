using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Employee : IEmployee
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// full name
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// role identifier
        /// </summary>
        [Column("RoleId")]
        public int? RoleId { get; set; }
        /// <summary>
        /// role
        /// </summary>
        [Column("RoleId")]
        public virtual Role Role { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Employees.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Employees.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public IEnumerable<TimeTable> GetSchedule()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Schedule.Where(t => t.EmployeeId == Id && t.DeletedDate == null).ToList();
            }
        }
    }
}