using stretch_ceilings_app.Models;
using stretch_ceilings_app.Utility.Enums;
using System;

namespace stretch_ceilings_app.Utility
{
    public static class EnumExtantion
    {
        public static string PermissionCodeToString(this PermissionCode code)
        {
            switch (code)
            {
                case PermissionCode.AddOrder:
                    return "Добавить заказ";
                case PermissionCode.EditOrder:
                    return "Изменить заказ";
                case PermissionCode.DelOrder:
                    return "Удалить заказ";
                case PermissionCode.AddCustomer:
                    return "Добавить клиента";
                case PermissionCode.EditCustomer:
                    return "Изменить клиента";
                case PermissionCode.DelCustomer:
                    return "Удалить клиента";
                case PermissionCode.AddEmployee:
                    return "Добавить сотрудника";
                case PermissionCode.EditEmployee:
                    return "Изменить сотрудника";
                case PermissionCode.DelEmployee:
                    return "Удалить сотрудника";
                case PermissionCode.AddService:
                    return "Добавить услугу";
                case PermissionCode.EditService:
                    return "Изменить услугу";
                case PermissionCode.DelService:
                    return "Удалить услугу";
                case PermissionCode.AddManufacturer:
                    return "Добавить производителя";
                case PermissionCode.EditManufacturer:
                    return "Изменить производителя";
                case PermissionCode.DelManucaturer:
                    return "Удалить производителя";
                case PermissionCode.AddManufacturerOrder:
                    return "Добавить заказ производителя";
                case PermissionCode.EditManufacturerOrder:
                    return "Изменить заказ производителя";
                case PermissionCode.DelManufacturerOrder:
                    return "Удалить заказ производителя";
                default:
                    return "Неизвестный код";
            }
        }

        public static string OrderStatusToString(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.WaitingForMeasurements:
                    return "Ожидает результатов замеров";
                case OrderStatus.WaitingForCustomerAnswer:
                    return "Ожидает ответа заказчика";
                case OrderStatus.WaitingForPaid:
                    return "Ожидает оплаты";
                case OrderStatus.WaitingForServices:
                    return "Ожидает пирбытия потолков";
                case OrderStatus.WaitiongForExecution:
                    return "Ожидает выполения";
                case OrderStatus.Canceled:
                    return "Отменен";
                case OrderStatus.Finished:
                    return "Выполнен";
                default:
                    return "Неизвестный статус";
            }
        }

        public static string CeilingTextureToString(this CeilingTexture texture)
        {
            switch (texture)
            {
                case CeilingTexture.Matte:
                    return "Матовый";
                case CeilingTexture.Glossy:
                    return "Глянцевый";
                case CeilingTexture.Satin:
                    return "Сатиновый";
                case CeilingTexture.Tissular:
                    return "Тканевый";
                default:
                    return "Неизвестная фактура";
            }
        }

        public static string RoomTypeToString(this RoomType type)
        {
            switch (type)
            {
                case RoomType.WaterCloset:
                    return "Туалет";
                case RoomType.Nursery:
                    return "Детская";
                case RoomType.Bathroom:
                    return "Ванная";
                case RoomType.Bedroom:
                    return "Спальня";
                case RoomType.Kitchen:
                    return "Кухня";
                case RoomType.LivingRoom:
                    return "Гостинная";
                case RoomType.HallWay:
                    return "Прихожая";
                case RoomType.Hall:
                    return "Зал";
                case RoomType.Pool:
                    return "Бассейн";
                case RoomType.Balcony:
                    return "Балкон";
                default:
                    return "Неизсвестный тип";
            }
        }
    }
}
