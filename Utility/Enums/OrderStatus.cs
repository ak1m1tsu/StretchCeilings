namespace StretchCeilingsApp.Utility.Enums
{
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
