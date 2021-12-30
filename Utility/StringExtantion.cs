using System;

namespace stretch_ceilings_app.Utility
{
    public static class StringExtantion
    {
        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
