using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Utility.Extensions
{
    public static class StringExtensions
    {
        private static readonly Dictionary<string, OrderStatus> CachedStatuses;
        private static readonly Dictionary<string, CeilingTexture> CachedTextures;
        private static readonly Dictionary<string, CeilingColor> CachedColors;

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

            CachedTextures = new Dictionary<string, CeilingTexture>
            {
                { "Тканевый", CeilingTexture.Fabric },
                { "Матовый", CeilingTexture.Matte },
                { "Глянцевый", CeilingTexture.Glossy },
                { "Сатиновый", CeilingTexture.Satin }
            };

            CachedColors = new Dictionary<string, CeilingColor>
            {
                { "Белый", CeilingColor.White},
                { "Цветной", CeilingColor.Colored },
            };
        }

        public static OrderStatus ParseStatusEnum(this string value)
        {
            return CachedStatuses.FirstOrDefault(k => k.Key == value).Value;
        }

        public static CeilingTexture ParseCeilingTextureEnum(this string value)
        {
            return CachedTextures.FirstOrDefault(k => k.Key == value).Value;
        }

        public static CeilingColor ParseCeilingColorEnum(this string value)
        {
            return CachedColors.FirstOrDefault(k => k.Key == value).Value;
        }
    }
}
