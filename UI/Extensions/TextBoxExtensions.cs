﻿using System.Windows.Forms;

namespace StretchCeilings.UI.Extensions
{
    public static class TextBoxExtensions
    {
        public static void UpdatePagesValue(this TextBox textBox, int current, int max)
        {
            if (max < current)
                return;

            textBox.Text = $@"{current} из {max}";
        }
    }
}
