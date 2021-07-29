using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.AppCode.Extensions
{
    public static partial class Extension
    {
        public static string ToHash(this string value)
        {
            value = $"77932313sahib.az.specials.{value}.sahib.az.specials.13239377";

            using (var provider = SHA512.Create())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(value);

                buffer = provider.ComputeHash(buffer);

                StringBuilder sb = new StringBuilder();

                foreach (var item in buffer)
                {
                    sb.Append(item.ToString("x2"));
                }

                return sb.ToString();

                //return string.Join("", buffer.Select(b=>b.ToString("x2")));
            }
        }
    }
}