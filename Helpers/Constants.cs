using System.Collections.Generic;
using FontAwesome.Sharp;

namespace StretchCeilings.Helpers
{
    public static class Constants
    {
        #region Icons

        public static IconChar NoneIcon => IconChar.None;
        public static IconChar SearchIcon => IconChar.Search;
        public static IconChar WindowRestoreIcon => IconChar.WindowRestore;
        public static IconChar WindowMaximizeIcon => IconChar.WindowMaximize;
        public static IconChar UserIcon => IconChar.User;

        #endregion
        #region Strings

        public static string DefaultIconButtonText => "";
        public static string DefaultTextBoxText => null;
        public static string DefaultDateTimePickerCustomFormat => " ";

        public static string FilterDateTimePickerCustomFormat => @"dd.MM.yyyy HH:mm";

        public static string DefaultLinkLabelText => "Нет";

        public static  IDictionary<string, bool> PaidByCashItems => new Dictionary<string, bool>()
        {
            { "Нет" , false },
            { "Да", true }
        };

        #endregion
        #region Numerics

        public static decimal DefaultNumericUpDownValue => 0;

        public static int[] RowCountItems => new int[3] { 2, 5, 10 };

        #endregion
    }
}
