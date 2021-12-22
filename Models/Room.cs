using stretch_ceilings_app.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Rooms")]
    public class Room : IRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Area { get; set; }
        [Column("Type")]
        public Type Type { get; set; }
        public int Corners { get; set; }
        [Column("EstateID")]
        public int EstateID { get; set; }
        [Column("EstateID")]
        public Estate Estate { get; set; }

        public string GetPlane()
        {
            return string.Empty;
        }
        public string AddPlane(string path)
        {
            return string.Empty;
        }
        public string ChangePlane(string path)
        {
            return string.Empty;
        }
    }

    public enum Type
    {
        WaterCloset,
        Nursery,
        Bathroom,
        Bedroom,
        Kitchen,
        LivingRoom,
        HallWay,
        Hall,
        Pool,
        Balcony
    }
}