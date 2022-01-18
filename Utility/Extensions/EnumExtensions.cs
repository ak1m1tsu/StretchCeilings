using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Utility.Extensions
{

    public static class EnumExtensions
    {
        private static readonly Dictionary<OrderStatus, string> CachedStatuses;
        private static readonly Dictionary<PermissionCode, string> CachedCodes;
        private static readonly Dictionary<CeilingColor, string> CachedColors;
        private static readonly Dictionary<CeilingTexture, string> CachedTextures;
        private static readonly Dictionary<RoomType, string> CachedTypes;

        static EnumExtensions()
        {
            CachedStatuses = new Dictionary<OrderStatus, string>
            {
                { OrderStatus.Canceled, "Отменен" },
                { OrderStatus.Finished, "Выполнен" },
                { OrderStatus.WaitingForCustomerAnswer, "Ожидает ответа заказчика" },
                { OrderStatus.WaitingForExecution, "Ожидает выполения" },
                { OrderStatus.WaitingForMeasurements, "Ожидает результатов замеров" },
                { OrderStatus.WaitingForPaid, "Ожидает оплаты" },
                { OrderStatus.WaitingForCeilings, "Ожидает пирбытия потолков" },
            };
            CachedColors = new Dictionary<CeilingColor, string>
            {
                { CeilingColor.White, "Белый" },
                { CeilingColor.Colored, "Цветной" },
            };
            CachedCodes = new Dictionary<PermissionCode, string>
            {
                { PermissionCode.All , "Полный доступ" },
                { PermissionCode.AddOrder, "Добавить заказ" },
                { PermissionCode.EditOrder, "Изменить заказ" },
                { PermissionCode.DelOrder, "Удалить заказ" },
                { PermissionCode.AddCustomer, "Добавить клиента" },
                { PermissionCode.EditCustomer, "Изменить клиента" },
                { PermissionCode.DelCustomer, "Удалить клиента" },
                { PermissionCode.AddEmployee, "Добавить сотрудника" },
                { PermissionCode.EditEmployee, "Изменить сотрудника" },
                { PermissionCode.DelEmployee, "Удалить сотрудника" },
                { PermissionCode.AddService, "Добавить услугу" },
                { PermissionCode.EditService, "Изменить услугу" },
                { PermissionCode.DelService, "Удалить услугу" },
                { PermissionCode.AddManufacturer, "Добавить производителя" },
                { PermissionCode.EditManufacturer, "Изменить производителя" },
                { PermissionCode.DelManufacturer, "Удалить производителя" },
                { PermissionCode.AddManufacturerOrder, "Добавить заказ производителя" },
                { PermissionCode.EditManufacturerOrder, "Изменить заказ производителя" },
                { PermissionCode.DelManufacturerOrder, "Удалить заказ производителя" },
                { PermissionCode.AddAdditionalService, "Добавить доп. услугу" },
                { PermissionCode.EditAdditionalService, "Изменить доп. услугу" },
                { PermissionCode.DelAdditionalService, "Удалить доп. услугу" },
            };
            CachedTextures = new Dictionary<CeilingTexture, string>
            {
                { CeilingTexture.Fabric, "Тканевый" },
                { CeilingTexture.Matte, "Матовый" },
                { CeilingTexture.Glossy, "Глянцевый" },
                { CeilingTexture.Satin, "Сатиновый" }
            };
            CachedTypes = new Dictionary<RoomType, string>
            {
                { RoomType.Balcony, "Балкон" },
                { RoomType.Bathroom, "Ванна" },
                { RoomType.Bedroom, "Спальня" },
                { RoomType.Hall, "Зал" },
                { RoomType.HallWay, "Прихожая" },
                { RoomType.Kitchen, "Кухня" },
                { RoomType.LivingRoom, "Гостинная" },
                { RoomType.Nursery, "Детская" },
                { RoomType.Pool, "Бассейн" },
                { RoomType.WaterCloset, "Туалет" }
            };
        }

        public static string ParseString(this CeilingColor color)
        {
            return CachedColors.FirstOrDefault(c => c.Key == color).Value;
        }
        public static string ParseString(this PermissionCode code)
        {
            return CachedCodes.FirstOrDefault(c => c.Key == code).Value;
        }

        public static string ParseString(this OrderStatus status)
        {
            return CachedStatuses.FirstOrDefault(c => c.Key == status).Value;
        }

        public static string ParseString(this CeilingTexture texture)
        {
            return CachedTextures.FirstOrDefault(t => t.Key == texture).Value;
        }

        public static string ParseString(this RoomType type)
        {
            return CachedTypes.FirstOrDefault(t => t.Key == type).Value;
        }
    }
}
