using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Interfaces.Models;

namespace StretchCeilings.Models
{
    public class Room : IRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Area { get; set; }
        public RoomType? Type { get; set; }
        public int? Corners { get; set; }
        [Column("EstateId")]
        public int? EstateId { get; set; }
        [Column("EstateId")]
        public virtual Estate Estate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.CustomersRooms.Add(this);
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

        public string GetPlane()
        {
            throw new NotImplementedException();
        }

        public void SetPlane(string path)
        {
            throw new NotImplementedException();
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