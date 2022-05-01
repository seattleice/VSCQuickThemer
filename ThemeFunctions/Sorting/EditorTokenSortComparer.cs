using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeFunctions.Json;
using Colourful;
using System.Drawing;
using ThemeFunctions.Colors;

namespace ThemeFunctions.Sorting
{
    public enum EditorTokenSortTypeEnum
    {
        byName = 0,
        byforegroundHexColorString = 1,
        byforegroundHexColorRGB = 2,
        bybackgroundHexColorString = 3,
        bybackgroundHexColorRGB = 4
    }

    public class EditorTokenSortComparer : IComparer<EditorToken>
    {
        
        private bool _ascending = true;
        private EditorTokenSortTypeEnum _sortType;

        public EditorTokenSortComparer(bool sortAscending, EditorTokenSortTypeEnum sortType)
        {
            _ascending = sortAscending;
            _sortType = sortType;
        }

        public int Compare(EditorToken x, EditorToken y)
        {

            switch (_sortType)
            {
                case EditorTokenSortTypeEnum.byName:
                    {
                        return CompareNames(x, y);
                    }
                case EditorTokenSortTypeEnum.byforegroundHexColorString:
                case EditorTokenSortTypeEnum.bybackgroundHexColorString:
                    {
                        return CompareHexColorStrings(x, y, _sortType == EditorTokenSortTypeEnum.byforegroundHexColorString);
                    }
                case EditorTokenSortTypeEnum.byforegroundHexColorRGB:
                case EditorTokenSortTypeEnum.bybackgroundHexColorRGB:
                    {
                        return CompareHexRGBDifference(x, y, _sortType == EditorTokenSortTypeEnum.byforegroundHexColorRGB);
                    }
            }

            return 0;
        }
            
        private int CompareNames(EditorToken x, EditorToken y)
        {
            StringComparer invCmp = StringComparer.InvariantCulture;

            if (_ascending)
            {
                return invCmp.Compare(x.name, y.name);
            }
            else
            {
                return invCmp.Compare(y.name, x.name);
            }
        
        }
            
        private int CompareHexColorStrings(EditorToken x, EditorToken y, bool IsForeground)
        {
            StringComparer invCmp = StringComparer.InvariantCulture;

            if (_ascending)
            {
                return IsForeground ? invCmp.Compare(x.foreground, y.foreground) : invCmp.Compare(x.background, y.background);
            }
            else
            {
                return IsForeground ? invCmp.Compare(y.foreground, x.foreground) : invCmp.Compare(y.background, x.background);
            }
        }

        public int CompareHexRGBDifference(EditorToken a, EditorToken b, bool IsForeground)
        {

            var x = IsForeground ? a.foreground.ToArgbColor(true) : a.background.ToArgbColor(true);
            var y = IsForeground ? b.foreground.ToArgbColor(true) : b.background.ToArgbColor(true);

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
