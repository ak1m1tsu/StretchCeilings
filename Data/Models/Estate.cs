using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Estates")]
    public class Estate : IEstate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Column("CustomerId")]
        public int? CustomerId { get; set; }
        [Column("CustomerId")]
        public virtual Customer Customer { get; set; }
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