using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Estates")]
    public class Estate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime? DateDeleted { get; set; }

        public List<Room> GetRooms()
        {
            return new List<Room>();
        }
        public string AddRoom(Room room)
        {
            return string.Empty;
        }
        public string DeleteRoom(Room room)
        {
            return string.Empty;
        }
    }
}