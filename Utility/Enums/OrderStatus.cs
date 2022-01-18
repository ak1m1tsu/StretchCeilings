namespace stretch_ceilings_app.Utility.Enums
{
    public enum OrderStatus
    {
        WaitingForMeasurements = 0,
        WaitingForCustomerAnswer,
        WaitingForPaid,
        WaitingForCeilings,
        WaitingForExecution,
        Canceled,
        Finished,
        Unknown
    }
}
