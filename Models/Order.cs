using stretch_ceilings_app.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Orders")]
    public class Order : IOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("CustomerID")]
        public int CustomerID { get; set; }
        [Column("CustomerID")]
        public Customer Customer { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime DateOfMeasurements { get; set; }
        public DateTime[] DateOfWork { get; set; }
        public DateTime DatePaid { get; set; }
        public DateTime DateCanceled { get; set; }
        public bool PaidByCash { get; set; }
        [Column("Status")]
        public Status Status { get; set; }
        public decimal Total { get; set; }

        public decimal CalculateTotal()
        {
            return new decimal();
        }

        public List<Log> GetLogs()
        {
            return new List<Log>();
        }
        
        public string AddLog(Log log)
        {
            return string.Empty;
        }

        public string DeleteLog(Log log)
        {
            return string.Empty;
        }

    }

    public enum Status
    {
        WaitingForMeasurements,
        WaitingForClientAnswer,
        WaitingForPaid,
        WaitingForServices,
        WaitiongForExecution,
        Canceled,
        Done
    }
}