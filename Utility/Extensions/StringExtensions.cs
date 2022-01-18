using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Utility.Extensions
{
    public static class StringExtensions
    {
        private static readonly Dictionary<string, OrderStatus> CachedStatuses;

        static StringExtensions()
        {
            CachedStatuses = new Dictionary<string, OrderStatus>()
            {
                { "Отменен", OrderStatus.Canceled },
                { "Выполнен", OrderStatus.Finished },
                { "Ожидает ответа заказчика", OrderStatus.WaitingForCustomerAnswer },
                { "Ожидает выполения", OrderStatus.WaitingForExecution },
                { "Ожидает результатов замеров", OrderStatus.WaitingForMeasurements },
                { "Ожидает оплаты", OrderStatus.WaitingForPaid },
                { "Ожидает пирбытия потолков", OrderStatus.WaitingForCeilings },
            };
        }

        public static OrderStatus ParseStatusEnum(this string value)
        {
            return CachedStatuses.FirstOrDefault(k => k.Key == value).Value;
        }
    }
}
