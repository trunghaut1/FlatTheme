using System;
using System.Globalization;
using System.Linq;

namespace FlatTheme.Code
{
    internal static class StringExtensions
    {
        public static string ToTitleCase(this string text, string separator = " ")
        {
            TextInfo textInfo = CultureInfo.CurrentUICulture.TextInfo;

            string lowerText = textInfo.ToLower(text);
            string[] words = lowerText.Split(new[] { separator }, StringSplitOptions.None);

            return String.Join(separator, words.Select(v => textInfo.ToTitleCase(v)));
        }
    }
}
