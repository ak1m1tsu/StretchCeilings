using System.Collections.Generic;
using System.Linq;
using StretchCeilingsApp.Utility.Enums;

namespace StretchCeilingsApp.Utility.Extensions
{

    public static class EnumExtensions
    {
        private static readonly Dictionary<OrderStatus, string> _orderStatuses;
        private static readonly Dictionary<PermissionCode, string> _permissionCodes;
        private static readonly Dictionary<ColorType, string> _colorTypes;
        private static readonly Dictionary<TextureType, string> _textureTypes;
        private static readonly Dictionary<RoomType, string> _roomTypes;
        private static readonly Dictionary<Country, string> _countries;

        static EnumExtensions()
        {
            _orderStatuses = new Dictionary<OrderStatus, string>
            {
                { OrderStatus.Canceled, "Отменен" },
                { OrderStatus.Finished, "Выполнен" },
                { OrderStatus.WaitingForCustomerAnswer, "Ожидает ответа заказчика" },
                { OrderStatus.WaitingForExecution, "Ожидает выполения" },
                { OrderStatus.WaitingForMeasurements, "Ожидает результатов замеров" },
                { OrderStatus.WaitingForPaid, "Ожидает оплаты" },
                { OrderStatus.WaitingForCeilings, "Ожидает пирбытия потолков" },
            };
            _colorTypes = new Dictionary<ColorType, string>
            {
                { ColorType.White, "Белый" },
                { ColorType.Colored, "Цветной" },
            };
            _permissionCodes = new Dictionary<PermissionCode, string>
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
                { PermissionCode.AddAdditionalService, "Добавить доп. услугу" },
                { PermissionCode.EditAdditionalService, "Изменить доп. услугу" },
                { PermissionCode.DelAdditionalService, "Удалить доп. услугу" },
            };
            _textureTypes = new Dictionary<TextureType, string>
            {
                { TextureType.Fabric, "Тканевый" },
                { TextureType.Matte, "Матовый" },
                { TextureType.Glossy, "Глянцевый" },
                { TextureType.Satin, "Сатиновый" }
            };
            _roomTypes = new Dictionary<RoomType, string>
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
            _countries = new Dictionary<Country, string>()
            {
                { Country.Russia, "Россия" },
                { Country.USA, "США" },
                { Country.UK, "Англия" },
                { Country.Germany, "Германия" },
                { Country.China, "Китай" },
            };
        }

        public static string ParseString(this ColorType colorType)
        {
            return _colorTypes.FirstOrDefault(c => c.Key == colorType).Value;
        }
        public static string ParseString(this PermissionCode code)
        {
            return _permissionCodes.FirstOrDefault(c => c.Key == code).Value;
        }

        public static string ParseString(this OrderStatus status)
        {
            return _orderStatuses.FirstOrDefault(c => c.Key == status).Value;
        }

        public static string ParseString(this TextureType textureType)
        {
            return _textureTypes.FirstOrDefault(t => t.Key == textureType).Value;
        }

        public static string ParseString(this RoomType type)
        {
            return _roomTypes.FirstOrDefault(t => t.Key == type).Value;
        }

        public static string ParseString(this Country type)
        {
            return _countries.FirstOrDefault(t => t.Key == type).Value;
        }
    }
}
