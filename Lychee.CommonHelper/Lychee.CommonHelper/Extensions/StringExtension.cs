using System;

namespace Lychee.CommonHelper.Extensions
{
    public static class StringExtension
    {
        public static bool EqualsTo(this string str1, string str2, StringComparison comparison = StringComparison.InvariantCultureIgnoreCase)
        {
            return string.Equals(str1, str2, comparison);
        }

        public static bool NotEqualsTo(this string str1, string str2, StringComparison comparison = StringComparison.InvariantCultureIgnoreCase)
        {
            return !string.Equals(str1, str2, comparison);
        }

        public static int ToInt(this object number)
        {
            try
            {
                return Convert.ToInt32(number);
            }
            catch
            {
                // ignored
            }

            return 0;
        }

        public static DateTime ToDateTime(this object date)
        {
            try
            {
                return Convert.ToDateTime(date);
            }
            catch
            {
                // ignored
            }

            return DateTime.MinValue;
        }

        public static bool ToBool(this object boolean)
        {
            try
            {
                return Convert.ToBoolean(boolean);
            }
            catch
            {
                // ignored
            }

            return false;
        }

        public static decimal ToDecimal(this object dec)
        {
            try
            {
                return Convert.ToDecimal(dec);
            }
            catch
            {
                // ignored
            }

            return 0;
        }

    }
}
