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
        public int ID { get; set; }
        public DateTime Date { get; set; }
        [Column("ShiftEnd")]
        private double TimeStartTicks { get; set; }
        [Column("ShiftEnd")]
        private double TimeEndTicks { get; set; }
        [NotMapped]
        public TimeSpan TimeStart 
        { 
            get { return TimeSpan.FromMinutes(TimeStartTicks);  } 
            set { TimeStartTicks = value.TotalMinutes; } 
        }
        [NotMapped]
        public TimeSpan TimeEnd
        {
            get { return TimeSpan.FromMinutes(TimeEndTicks); }
            set { TimeEndTicks = value.TotalMinutes; }
        }
        public DateTime DateDeleted { get; set; }
    }
}