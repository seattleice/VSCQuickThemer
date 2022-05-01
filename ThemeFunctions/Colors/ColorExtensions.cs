using System;
using System.Drawing;
using System.Globalization;

// Extension functions for formatting and converting hex color string and ARGB colors
namespace ThemeFunctions.Colors
{
    //public class HexColor
    //{
    //    private readonly string _value;
        
    //    public HexColor(string value)
    //    {
    //        if (!value.StartsWith("#"))
    //        {
    //            throw new InvalidOperationException("Not a valid hex color string");
    //        }

    //        _value = value;
    //    }

    //    public static implicit operator HexColor(string value)
    //    {
    //        return new HexColor(value);
    //    }

    //    public static implicit operator string(HexColor value)
    //    {
    //        return value._value;
    //    }
    //}


    public static class ColorExtensions
    {

        // Compares colors without using Alpha
        public static bool IsRgbEqual(this Color value, Color compareColor)
        {
               return (value.R == compareColor.R && value.G == compareColor.G && value.B == compareColor.B);
        }

        // Compares colors without using Alpha
        public static bool IsRgbEqual(this string hexColorString, string hexCompareColorString)
        {
            if(string.IsNullOrEmpty(hexColorString) || string.IsNullOrEmpty(hexCompareColorString)) { return false; }

            var x = hexColorString.ToArgbColor();
            var y = hexCompareColorString.ToArgbColor();

            return (x.R == y.R && x.G == y.G && x.B == y.B);
        }

        // Returns a color with no Alpha
        public static Color ToRgb(this Color value)
        {
            return Color.FromArgb(255, value.R, value.G, value.B);
        }
        
        public static string ToHexColorString(this Color value)
        {
            return ToHexColorString(value, false).ToLower();
        }

        public static string ToHexColorString(this Color value, bool removeAlpha)
        {
            if ((value.A == 255) || removeAlpha)
            {
                return ($"#{value.R:X2}{value.G:X2}{value.B:X2}").ToLower();
            }
            else
            {
                return ($"#{value.R:X2}{value.G:X2}{value.B:X2}{value.A:X2}").ToLower();
            }

        }

        public static Color ToArgbColor(this string value)
        {
            return  ToArgbColor(value, false);
        } 


        public static Color ToArgbColor(this string value, bool ignoreAlpha)
        {

            if (String.IsNullOrEmpty(value)) { return Color.White; }

            if (!value.StartsWith("#")) { throw new InvalidCastException("String was not a hex color string"); }

            var newhexString = value.Replace("#", "");

            if ((newhexString.Length == 3) || (newhexString.Length == 6))
            {
                return System.Drawing.ColorTranslator.FromHtml(value);
            }
            else if (newhexString.Length == 4)
            {
                var alpha = ignoreAlpha ? 255 : int.Parse(newhexString.Substring(3, 1) + newhexString.Substring(3, 1), NumberStyles.HexNumber);

                return Color.FromArgb(
                    alpha,
                    int.Parse(newhexString.Substring(0, 1) + newhexString.Substring(0, 1), NumberStyles.HexNumber),
                    int.Parse(newhexString.Substring(1, 1) + newhexString.Substring(1, 1), NumberStyles.HexNumber),
                    int.Parse(newhexString.Substring(2, 1) + newhexString.Substring(2, 1), NumberStyles.HexNumber)
                );
            }
            else if (newhexString.Length == 8)
            {
                var alpha = ignoreAlpha ? 255 : int.Parse(newhexString.Substring(6, 2), NumberStyles.HexNumber);

                return Color.FromArgb(
                    alpha,
                    int.Parse(newhexString.Substring(0, 2), NumberStyles.HexNumber),
                    int.Parse(newhexString.Substring(2, 2), NumberStyles.HexNumber),
                    int.Parse(newhexString.Substring(4, 2), NumberStyles.HexNumber)
                );
            }

            return Color.White;

        }

        public static string FormatHexColor(this string hexString)
        {
            return FormatHexColor(hexString, false);
        }

        public static string FormatHexColor(this string hexString, bool removeAlpha)
        {
            if (String.IsNullOrEmpty(hexString)) return hexString;

            if (!hexString.StartsWith("#")) { throw new InvalidCastException("String was not a hex color string"); }

            hexString = hexString.Replace("#", "");

            if (hexString.Length == 8)
            {
                if (removeAlpha)
                {
                    return ($"#{hexString.Substring(0, 6)}").ToLower();
                }
                else
                {
                    return ($"#{hexString}").ToLower();
                }
            }
            else if (hexString.Length == 3)
            {
                var r = hexString.Substring(0, 1);
                var g = hexString.Substring(1, 1);
                var b = hexString.Substring(2, 1);

                return ($"#{r + r + g + g + b + b}").ToLower();

            }
            else if (hexString.Length == 4)
            {
                var r = hexString.Substring(0, 1);
                var g = hexString.Substring(1, 1);
                var b = hexString.Substring(2, 1);
                var a = hexString.Substring(3, 1);

                if (removeAlpha)
                {
                    return ($"#{r + r + g + g + b + b}").ToLower();
                }
                else
                {
                    return ($"#{r + r + g + g + b + b + a + a}").ToLower();
                }
            }
            else
            {
                return ($"#{hexString}").ToLower();
            }
        }



    }

}
