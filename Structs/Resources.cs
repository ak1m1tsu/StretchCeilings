using System.Collections.Generic;

namespace StretchCeilings.Structs
{
    public struct Resources
    {
        public const string Number = "№";
        public const string Area = "Площадь";
        public const string Corners = "Углы";
        public const string Type = "Тип";
        public const string Name = "Название";
        public const string PersonName = "Имя";
        public const string Manufacturer = "Производитель";
        public const string Ceiling = "Потолок";
        public const string Price = "Цена";
        public const string Texture = "Текстура";
        public const string Color = "Цвет";
        public const string Date = "Дата";
        public const string DateCreated = "Дата создания";
        public const string Action = "Событие";
        public const string DayOfWeek = "День недели";
        public const string ShiftStart = "Начало смены";
        public const string ShiftEnd = "Конец смены";
        public const string FullName = "ФИО";
        public const string Role = "Должность";
        public const string PhoneNumber = "Номер телефона";
        public const string Selected = "Выбрано";
        public const string Space = " ";
        public const string DisplayMember = "Content";
        public const string ControlsEmpty = "Не все поля заполнены.";
        public const string InvalidPriceRange = "Неверно указан диапозон цен.";
        public const string EmptyPhoneNumber = "+7(   )   -  -  ";
        public const string RequiredToFill = "Это поле обязательно к заполнению.";
        public const string DefaultIconButtonText = "";
        public const string DefaultTextBoxText = "";
        public const string FilterDateTimePickerCustomFormat = @"dd.MM.yyyy HH:mm";
        public const string No = "Нет";
        public const string Yes = "Да";
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
