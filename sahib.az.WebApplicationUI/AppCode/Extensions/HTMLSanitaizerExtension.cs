using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.AppCode.Extensions
{
    public static partial class Extension
    {
        public static string RemoveHTMLTags(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            Regex tagPattern = new Regex("<[^>]*>");

            return tagPattern.Replace(value, "");
        }
    }
}
