using System.Collections.Generic;
using System.Linq;
using StretchCeilings.Helpers.Enums;

namespace StretchCeilings.Helpers.Extensions
{
    public static class StringExtensions
    {
        private static readonly Dictionary<string, OrderStatus> _orderStatus;
        private static readonly Dictionary<string, TextureType> _textureTypes;
        private static readonly Dictionary<string, ColorType> _colorTypes;
        private static readonly Dictionary<string, Country> _countries;

        static StringExtensions()
        {
            _orderStatus = new Dictionary<string, OrderStatus>()
            {
                { "Отменен", OrderStatus.Canceled },
                { "Выполнен", OrderStatus.Finished },
                { "Ожидает ответа заказчика", OrderStatus.WaitingForCustomerAnswer },
                { "Ожидает выполения", OrderStatus.WaitingForExecution },
                { "Ожидает результатов замеров", OrderStatus.WaitingForMeasurements },
                { "Ожидает оплаты", OrderStatus.WaitingForPaid },
                { "Ожидает пирбытия потолков", OrderStatus.WaitingForCeilings },
            };

            _textureTypes = new Dictionary<string, TextureType>
            {
                { "Тканевый", TextureType.Fabric },
                { "Матовый", TextureType.Matte },
                { "Глянцевый", TextureType.Glossy },
                { "Сатиновый", TextureType.Satin }
            };

            _colorTypes = new Dictionary<string, ColorType>
            {
                { "Белый", ColorType.White},
                { "Цветной", ColorType.Colored },
            };
            _countries = new Dictionary<string, Country>()
            {
                { "Россия", Country.Russia },
                { "США", Country.USA },
                { "Англия", Country.UK },
                { "Германия", Country.Germany },
                { "Китай", Country.China },
            };
        }

        public static Country ToCountry(this string value)
        {
            return _countries.FirstOrDefault(k => k.Key == value).Value;
        }

        public static OrderStatus ToOrderStatus(this string value)
        {
            return _orderStatus.FirstOrDefault(k => k.Key == value).Value;
        }

        public static TextureType ToTextureType(this string value)
        {
            return _textureTypes.FirstOrDefault(k => k.Key == value).Value;
        }

        public static ColorType ToColorType(this string value)
        {
            return _colorTypes.FirstOrDefault(k => k.Key == value).Value;
        }
    }
}
