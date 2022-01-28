﻿using System.Windows.Forms;

namespace StretchCeilingsApp.Utility.Extensions.Controls
{
    public static class TextBoxExtensions
    {
        public static void UpdatePagesValue(this TextBox textBox, int current, int max)
        {
            if (max < current) return;

            textBox.Text = $@"{current} | {max}";
        }
    }
}
