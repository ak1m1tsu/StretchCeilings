using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Interfaces.Models;

namespace StretchCeilings.Models
{
    public class Log : ILog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("OrderId")]
        public int? OrderId { get; set; }
        [Column("OrderId")]
        public virtual Order Order { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Logs.Add(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(Id).CurrentValues.SetValues(DeletedDate = DateTime.Now);
                db.SaveChanges();
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