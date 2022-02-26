namespace StretchCeilings.Domain.Models.Enums
{
    /// <summary>
    /// Statuses of order
    /// </summary>
    public enum OrderStatus
    {
        Unknown = 0,
        WaitingForMeasurements,
        WaitingForCustomerAnswer,
        WaitingForPaid,
        WaitingForCeilings,
        WaitingForExecution,
        Canceled,
        Finished,
    }
}
