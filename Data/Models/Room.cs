using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Rooms")]
    public class Room : IRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Area { get; set; }
        public RoomType Type { get; set; }
        public int Corners { get; set; }
        [Column("EstateId")]
        public int? EstateId { get; set; }
        [Column("EstateId")]
        public virtual Estate Estate { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Rooms.Add(this);
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
                db.Entry(this.Id).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}