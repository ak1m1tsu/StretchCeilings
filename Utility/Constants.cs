using System.Drawing;
using FontAwesome.Sharp;

namespace stretch_ceilings_app.Utility
{
    public static class Constants
    {
        #region Colors
        
        public static readonly Color FlatRed = Color.FromArgb( 231, 76, 60);
        public static readonly Color FlatAlphaRed = Color.FromArgb( 0, 231, 76, 60);
        public static readonly Color FlatGreen = Color.FromArgb( 46, 204, 113);
        public static readonly Color FlatAlphaGreen = Color.FromArgb( 0, 46, 204, 113);
        public static readonly Color FlatYellow = Color.FromArgb( 241, 196, 15);
        public static readonly Color FlatAlphaYellow = Color.FromArgb( 0, 241, 196, 15);

        #endregion
        #region Enum fields

        public static readonly IconChar DefaultIconButtonIconChar = IconChar.Search;

        #endregion
        #region String fields

        public static readonly string DefaultIconButtonText = "";
        public static readonly string DefaultTextBoxText = "";
        public static readonly string DefaultDateTimePickerCustomFormat = " ";
        public static readonly string DefaultDataGridViewButtonCellText = "❌";

        public static readonly string FilterDateTimePickerCustomFormat = @"dd.MM.yyyy HH:mm";

        #endregion
        #region Interger fields

        public static readonly int DefaultNumericUpDownValue = 0;

        public static readonly int[] RowCountItems = new int[4] { 5, 10, 15, 20 };

        #endregion
    }
}
