using stretch_ceilings_app.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Rooms")]
    public class Room : IRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Area { get; set; }
        [Required]
        public RoomType Type { get; set; }
        public int Corners { get; set; }
        [ForeignKey("Estate")]
        public int EstateId { get; set; }
        public Estate Estate { get; set; }
        public DateTime? DateDeleted { get; set; }

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

    public enum RoomType
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