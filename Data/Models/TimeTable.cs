using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Schedule")]
    public class TimeTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("EmployeeId")]
        public int EmployeeId { get; set; }
        [Column("EmployeeId")]
        public Employee Employee { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}