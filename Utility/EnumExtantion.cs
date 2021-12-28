using stretch_ceilings_app.Models;
using System;

namespace stretch_ceilings_app.Utility
{
    public static class EnumExtantion
    {        
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
                case OrderStatus.Done:
                    return "Выполнен";
                default:
                    return "Неизвестный статус";
            }
        }
        public static string RoomTypeToString(this RoomType type)
        {
            switch (type)
            {
                case RoomType.WaterCloset:
                    return "";
                case RoomType.Nursery:
                    return "";
                case RoomType.Bathroom:
                    return "";
                case RoomType.Bedroom:
                    return "";
                case RoomType.Kitchen:
                    return "";
                case RoomType.LivingRoom:
                    return "";
                case RoomType.HallWay:
                    return "";
                case RoomType.Hall:
                    return "";
                case RoomType.Pool:
                    return "";
                case RoomType.Balcony:
                    return "";
                default:
                    return "";
            }
        }
    }
}
