using System.Collections.Generic;

namespace StretchCeilings.Helpers.Structs
{
    public struct Resources
    {
        public const string ControlsEmpty = "Не все поля заполнены.";
        public const string EmptyPhoneNumber = "+7(   )   -  -";
        public const string RequiredToFillOut = "Это поле обязательно к заполнению.";
        public const string DefaultIconButtonText = "";
        public const string DefaultTextBoxText = "";
        public const string DefaultDateTimePickerCustomFormat = " ";
        public const string FilterDateTimePickerCustomFormat = @"dd.MM.yyyy HH:mm";
        public const string DefaultLinkLabelText = "Нет";
        public const string Rubles = "руб.";
        public const decimal DefaultNumericUpDownValue = 0;

        public static  IDictionary<string, bool> PaidByCashItems => new Dictionary<string, bool>()
        {
            { "Нет" , false },
            { "Да", true }
        };
        public static int[] RowCountItems => new int[3] { 2, 5, 10 };
    }
}
