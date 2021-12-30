using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stretch_ceilings_app.Utility.Enums
{
    public enum OrderStatus
    {
        WaitingForMeasurements = 0,
        WaitingForCustomerAnswer,
        WaitingForPaid,
        WaitingForServices,
        WaitiongForExecution,
        Canceled,
        Finished
    }
}
