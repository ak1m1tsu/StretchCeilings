using System.Collections.Generic;
using System.Linq;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Models.Enums;

namespace StretchCeilings.Domain.Extensions
{

    /// <summary>
    /// Presents extension for converting enums to string
    /// </summary>
    public static class EnumExtensions
    {
        private static readonly Dictionary<OrderStatus, string> OrderStatuses = new Dictionary<OrderStatus, string>
        {
            { OrderStatus.Canceled, "Отменен" },
            { OrderStatus.Finished, "Выполнен" },
            { OrderStatus.WaitingForCustomerAnswer, "Ожидает ответа заказчика" },
            { OrderStatus.WaitingForExecution, "Ожидает выполения" },
            { OrderStatus.WaitingForMeasurements, "Ожидает результатов замеров" },
            { OrderStatus.WaitingForPaid, "Ожидает оплаты" },
            { OrderStatus.WaitingForCeilings, "Ожидает пирбытия потолков" },
        };
        private static readonly Dictionary<PermissionCode, string> PermissionCodes = new Dictionary<PermissionCode, string>
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
        private static readonly Dictionary<ColorType, string> ColorTypes = new Dictionary<ColorType, string>
        {
            { ColorType.White, "Белый" },
            { ColorType.Colored, "Цветной" },
        };
        private static readonly Dictionary<TextureType, string> TextureTypes = new Dictionary<TextureType, string>
        {
            { TextureType.Fabric, "Тканевый" },
            { TextureType.Matte, "Матовый" },
            { TextureType.Glossy, "Глянцевый" },
            { TextureType.Satin, "Сатиновый" }
        };
        private static readonly Dictionary<RoomType, string> RoomTypes = new Dictionary<RoomType, string>
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
        private static readonly Dictionary<Country, string> Countries = new Dictionary<Country, string>()
        {
            { Country.Russia, "Россия" },
            { Country.USA, "США" },
            { Country.UK, "Англия" },
            { Country.Germany, "Германия" },
            { Country.China, "Китай" },
        };
        private static readonly Dictionary<OrderProperty, string> OrderProperties = new Dictionary<OrderProperty, string>()
        {
            { OrderProperty.Id, "Номер" },
            { OrderProperty.CustomerId, "Клиент" },
            { OrderProperty.DatePlaced, "Дата размещения" },
            { OrderProperty.Total, "Стоимость" },
            { OrderProperty.PaidByCash, "Оплачен наличными" },
            { OrderProperty.Status, "Статус" }
        };
        private static readonly Dictionary<ServiceProperty, string> ServiceProperties = new Dictionary<ServiceProperty, string>()
        {
            { ServiceProperty.CeilingId, "Потолок" },
            { ServiceProperty.ManufacturerId, "Производитель" },
            { ServiceProperty.Price, "Цена" },

        };
        private static readonly Dictionary<EmployeeProperty, string> EmployeeProperties = new Dictionary<EmployeeProperty, string>()
        {
            { EmployeeProperty.FullName, "ФИО" },
            { EmployeeProperty.RoleId, "Должность" }
        };
        private static readonly Dictionary<CustomerProperty, string> CustomerProperties = new Dictionary<CustomerProperty, string>()
        {
            { CustomerProperty.FullName, "ФИО" },
            { CustomerProperty.PhoneNumber, "Номер телефона" }
        };
        private static readonly Dictionary<AdditionalServiceProperty, string> AdditionalServiceProperties = new Dictionary<AdditionalServiceProperty, string>()
        {
            { AdditionalServiceProperty.Name, "Название" },
            { AdditionalServiceProperty.Price, "Цена" }
    };
        private static readonly Dictionary<ManufacturerProperty, string> ManufacturerProperties = new Dictionary<ManufacturerProperty, string>()
        {
            { ManufacturerProperty.Address, "Адрес" },
            { ManufacturerProperty.Country, "Страна" }
        };

        /// <summary>
        /// Convert <see cref="ColorType"/> to <see cref="string"/>
        /// </summary>
        /// <param name="colorType">source</param>
        /// <returns>
        /// Converted <see cref="ColorType"/>
        /// </returns>
        public static string ParseString(this ColorType colorType)
        {
            return ColorTypes.FirstOrDefault(c => c.Key == colorType).Value;
        }

        /// <summary>
        /// Convert <see cref="PermissionCode"/> to <see cref="string"/>
        /// </summary>
        /// <param name="code">source</param>
        /// <returns>
        /// Converted <see cref="PermissionCode"/>
        /// </returns>
        public static string ParseString(this PermissionCode code)
        {
            return PermissionCodes.FirstOrDefault(c => c.Key == code).Value;
        }

        /// <summary>
        /// Convert <see cref="OrderStatus"/> to <see cref="string"/>
        /// </summary>
        /// <param name="status">source</param>
        /// <returns>
        /// Converted <see cref="OrderStatus"/>
        /// </returns>
        public static string ParseString(this OrderStatus status)
        {
            return OrderStatuses.FirstOrDefault(c => c.Key == status).Value;
        }

        /// <summary>
        /// Convert <see cref="TextureType"/> to <see cref="string"/>
        /// </summary>
        /// <param name="textureType">source</param>
        /// <returns>
        /// Converted <see cref="TextureType"/>
        /// </returns>
        public static string ParseString(this TextureType textureType)
        {
            return TextureTypes.FirstOrDefault(t => t.Key == textureType).Value;
        }

        /// <summary>
        /// Convert <see cref="RoomType"/> to <see cref="string"/>
        /// 
        /// </summary>
        /// <param name="type">source</param>
        /// <returns>
        /// Converted <see cref="RoomType"/>
        /// </returns>
        public static string ParseString(this RoomType type)
        {
            return RoomTypes.FirstOrDefault(t => t.Key == type).Value;
        }

        /// <summary>
        /// Convert <see cref="Country"/> to <see cref="string"/>
        /// 
        /// </summary>
        /// <param name="type">source</param>
        /// <returns>
        /// Converted <see cref="Country"/>
        /// </returns>
        public static string ParseString(this Country type)
        {
            return Countries.FirstOrDefault(t => t.Key == type).Value;
        }

        /// <summary>
        /// Convert <see cref="ServiceProperty"/> to <see cref="string"/>
        /// 
        /// </summary>
        /// <param name="property">source</param>
        /// <returns>
        /// Converted <see cref="ServiceProperty"/>
        /// </returns>
        public static string ParseString(this OrderProperty property)
        {
            return OrderProperties.FirstOrDefault(x => x.Key == property).Value;
        }
        /// <summary>
        /// Convert <see cref="AdditionalServiceProperty"/> to <see cref="string"/>
        /// 
        /// </summary>
        /// <param name="property">source</param>
        /// <returns>
        /// Converted <see cref="AdditionalServiceProperty"/>
        /// </returns>
        public static string ParseString(this AdditionalServiceProperty property)
        {
            return AdditionalServiceProperties.FirstOrDefault(x => x.Key == property).Value;
        }
        /// <summary>
        /// Convert <see cref="CustomerProperty"/> to <see cref="string"/>
        /// 
        /// </summary>
        /// <param name="property">source</param>
        /// <returns>
        /// Converted <see cref="CustomerProperty"/>
        /// </returns>
        public static string ParseString(this CustomerProperty property)
        {
            return CustomerProperties.FirstOrDefault(x => x.Key == property).Value;
        }
        /// <summary>
        /// Convert <see cref="EmployeeProperty"/> to <see cref="string"/>
        /// </summary>
        /// <param name="property">source</param>
        /// <returns>
        /// Converted <see cref="EmployeeProperty"/>
        /// </returns>
        public static string ParseString(this EmployeeProperty property)
        {
            return EmployeeProperties.FirstOrDefault(x => x.Key == property).Value;
        }
        /// <summary>
        /// Convert <see cref="ManufacturerProperty"/> to <see cref="string"/>
        /// </summary>
        /// <param name="property">source</param>
        /// <returns>
        /// Converted <see cref="ManufacturerProperty"/>
        /// </returns>
        public static string ParseString(this ManufacturerProperty property)
        {
            return ManufacturerProperties.FirstOrDefault(x => x.Key == property).Value;
        }
        /// <summary>
        /// Convert <see cref="ServiceProperty"/> to <see cref="string"/>
        /// </summary>
        /// <param name="property">source</param>
        /// <returns>
        /// Converted <see cref="ServiceProperty"/>
        /// </returns>
        public static string ParseString(this ServiceProperty property)
        {
            return ServiceProperties.FirstOrDefault(x => x.Key == property).Value;
        }
    }
}
