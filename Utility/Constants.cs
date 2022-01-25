using System.Drawing;
using FontAwesome.Sharp;

namespace stretch_ceilings_app.Utility
{
    public static class Constants
    {
        #region Fonts

        public static readonly Font DataGridViewFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

        #endregion
        #region Colors

        public static readonly Color DraculaBackground = Color.FromArgb(40, 42, 54);
        public static readonly Color DraculaSelection = Color.FromArgb(68, 71, 90);
        public static readonly Color DraculaForeground = Color.FromArgb(248, 248, 242);
        public static readonly Color DraculaComment = Color.FromArgb(40, 42, 54);
        public static readonly Color DraculaCyan = Color.FromArgb(139, 233, 253);
        public static readonly Color DraculaGreen = Color.FromArgb(80, 250, 123);
        public static readonly Color DraculaOrange = Color.FromArgb(255, 184, 108);
        public static readonly Color DraculaPink = Color.FromArgb(255 ,121 ,198);
        public static readonly Color DraculaPurple = Color.FromArgb(189 ,147 ,249);
        public static readonly Color DraculaRed = Color.FromArgb(255, 85, 85);
        public static readonly Color DraculaYellow = Color.FromArgb(241, 250, 140);

        public static readonly Color DraculaAlphaRed = Color.FromArgb( 0, 255, 85, 85);
        public static readonly Color DraculaAlphaGreen = Color.FromArgb( 0, 80, 250, 123);
        public static readonly Color DraculaAlphaYellow = Color.FromArgb( 0, 241, 250, 140);

        #endregion
        #region Icons

        public static readonly IconChar NoneIcon = IconChar.None;
        public static readonly IconChar SearchIcon = IconChar.Search;
        public static readonly IconChar UserIcon = IconChar.User;

        #endregion
        #region Strings

        public static readonly string DefaultIconButtonText = "";
        public static readonly string DefaultTextBoxText = "";
        public static readonly string DefaultDateTimePickerCustomFormat = " ";
        public static readonly string DefaultDataGridViewButtonCellText = "❌";

        public static readonly string FilterDateTimePickerCustomFormat = @"dd.MM.yyyy HH:mm";

        public static readonly string ErrorCaption = "Ошибка.";
        public static readonly string WarningCaption = "Предупреждение.";
        public static readonly string InfoCaption = "Информация.";

        #endregion
        #region Numerics

        public static readonly decimal DefaultNumericUpDownValue = 0;

        public static readonly int[] RowCountItems = new int[3] { 25, 50, 100 };

        #endregion
    }
}
