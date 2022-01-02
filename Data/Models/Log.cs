using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
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
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}