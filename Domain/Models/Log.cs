using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Log : IDbModel
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// order identifier
        /// </summary>
        [Column("OrderId")]
        public int? OrderId { get; set; }
        /// <summary>
        /// order
        /// </summary>
        [Column("OrderId")]
        public virtual Order Order { get; set; }
        /// <summary>
        /// comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// created date
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.Now;
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Logs.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Logs.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Logs.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}