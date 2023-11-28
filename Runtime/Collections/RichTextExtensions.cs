using UnityEngine;

namespace Quirks.Collections
{
    public static class RichTextExtensions
    {
        public static string Bold(this string s) => string.Format("<b>{0}</b>", s);

        public static string Italic(this string s) => string.Format("<i>{0}</i>", s);

        public static string Size(this string s, int size) => string.Format("<size={1}>{0}</size>", s, size);

        #region Quick Colors

        public static string ColorWhite(this string s) => SetColor(s, "white");

        public static string ColorBlack(this string s) => SetColor(s, "black");

        public static string ColorRed(this string s) => SetColor(s, "red");

        public static string ColorGreen(this string s) => SetColor(s, "green");

        public static string ColorBlue(this string s) => SetColor(s, "blue");

        #endregion

        public static string SetColor(this string s, string color) => string.Format("<color={1}>{0}</color>", s, color);

        public static string SetColor(this string s, Color color) => string.Format("<color=#{1}>{0}</color>", s, ColorUtility.ToHtmlStringRGB(color));
    }
}
