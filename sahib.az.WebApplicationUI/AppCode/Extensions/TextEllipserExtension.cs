using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.AppCode.Extensions
{
    public static partial class Extension
    {
        public static string EllipseText(this string value, int maxLength = 17)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            if (value.Length <= maxLength)
            {
                return value;
            }

            return $"{value.Substring(0, maxLength)}...";
        }
    }
}
