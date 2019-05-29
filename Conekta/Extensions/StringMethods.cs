using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conekta.Extensions
{
    public static class StringMethods
    {
        public static string ToSnakeCase(this string str)
        {
            var values = str.Select((x, i) => i > 0 && char.IsUpper(x) ? $"_{x}" : $"{x}");
            return string.Concat(values).ToLower();
        }
    }
}