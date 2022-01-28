using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilingsApp.Interfaces.Models;

namespace StretchCeilingsApp.Data.Models
{
    [Table("Logs")]
    public class Log : ILog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("OrderId")]
        public int? OrderId { get; set; }
        [Column("OrderId")]
        public virtual Order Order { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
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
                db.Entry(this.Id).CurrentValues.SetValues(DeletedDate = DateTime.Now);
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