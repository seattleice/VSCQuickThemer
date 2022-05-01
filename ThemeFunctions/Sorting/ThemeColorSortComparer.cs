using System;
using System.Collections.Generic;
using ThemeFunctions.Json;
using Colourful;
using System.Drawing;
using ThemeFunctions.Colors;

namespace ThemeFunctions.Sorting
{
    public enum ThemeColorSortTypeEnum
    {
        byName = 0,
        byHexColorString = 1,
        byHexColorRGB = 2
    }

    public class ThemeColorSortComparer : IComparer<ThemeColor>
    {
        
        private bool _ascending = true;
        private ThemeColorSortTypeEnum _sortType;

        public ThemeColorSortComparer(bool sortAscending, ThemeColorSortTypeEnum sortType)
        {
            _ascending = sortAscending;
            _sortType = sortType;
        }

        public int Compare(ThemeColor x, ThemeColor y)
        {

            switch (_sortType)
            {
                case ThemeColorSortTypeEnum.byName:
                    {
                        return CompareNames(x, y);
                    }
                case ThemeColorSortTypeEnum.byHexColorString:
                    {
                        return CompareHexColorStrings(x, y);
                    }
                case ThemeColorSortTypeEnum.byHexColorRGB:
                    {
                        return CompareHexRGBDifference(x, y);
                    }
            }

            return 0;
        }
            
        private int CompareNames(ThemeColor x, ThemeColor y)
        {
            StringComparer invCmp = StringComparer.InvariantCulture;

            if (_ascending)
            {
                return invCmp.Compare(x.Name, y.Name);
            }
            else
            {
                return invCmp.Compare(y.Name, x.Name);
            }
        
        }
            
        private int CompareHexColorStrings(ThemeColor x, ThemeColor y)
        {
            StringComparer invCmp = StringComparer.InvariantCulture;

            if (_ascending)
            {
                return invCmp.Compare(x.HexColor, y.HexColor);
            }
            else
            {
                return invCmp.Compare(y.HexColor, x.HexColor);
            }
        }

        public int CompareHexRGBDifference(ThemeColor a, ThemeColor b)
        {

            var x = a.HexColor.ToArgbColor(true);
            var y = b.HexColor.ToArgbColor(true);

            var cv = new ConverterBuilder().FromRGB().ToLab().Build();

            double baseNum = 255;

            var black = cv.Convert(new RGBColor(Color.Black.R / baseNum, Color.Black.G / baseNum, Color.Black.B / baseNum));
            var lA = cv.Convert(new RGBColor(x.R / baseNum, x.G / baseNum, x.B / baseNum));
            var lB = cv.Convert(new RGBColor(y.R / baseNum, y.G / baseNum, y.B / baseNum));

            //' Get the distance from black for the two colors
            var distA = new Colourful.CIE94ColorDifference().ComputeDifference(lA, black);
            var distB = new Colourful.CIE94ColorDifference().ComputeDifference(lB, black);

            if (_ascending)
            {
                return (int)(distA - distB);
            }
            else
            {
                return (int)(distB - distA);
            }

        }

    }

}
