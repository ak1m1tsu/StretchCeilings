using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Room : IDbModel
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// area
        /// </summary>
        public int? Area { get; set; }
        /// <summary>
        /// type
        /// </summary>
        public RoomType? Type { get; set; }
        /// <summary>
        /// corners
        /// </summary>
        public int? Corners { get; set; }
        /// <summary>
        /// estate identifier
        /// </summary>
        [Column("EstateId")]
        public int? EstateId { get; set; }
        /// <summary>
        /// estate
        /// </summary>
        [Column("EstateId")]
        public virtual Estate Estate { get; set; }
        /// <summary>
        /// plane path
        /// </summary>
        public string Plane { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.CustomersRooms.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(Id).CurrentValues.SetValues(DeletedDate = DateTime.Now);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.CustomersRooms.FirstOrDefault(x => x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}