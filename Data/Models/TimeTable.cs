using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Schedule")]
    public class TimeTable : ITimeTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("EmployeeId")]
        public int? EmployeeId { get; set; }
        [Column("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Schedules.Add(this);
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