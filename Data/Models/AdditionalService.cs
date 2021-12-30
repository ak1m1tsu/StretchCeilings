using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("AdditionalServices")]
    public class AdditionalService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}