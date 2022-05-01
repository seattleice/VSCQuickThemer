using System.Collections.Generic;
using Colourful;
using System.Drawing;


namespace ThemeFunctions.Colors
{
    public class ColorDifferenceComparer : IComparer<Color>
    {

        private readonly bool _descending;

        public ColorDifferenceComparer(bool descending = false)
        {
            _descending = descending;
        }

        public int Compare(Color x, Color y)
        {
            var cv = new ConverterBuilder().FromRGB().ToLab().Build();

            double baseNum = 255;

            var black = cv.Convert(new RGBColor(Color.Black.R / baseNum, Color.Black.G / baseNum, Color.Black.B / baseNum));
            var lA = cv.Convert(new RGBColor(x.R / baseNum, x.G / baseNum, x.B / baseNum));
            var lB = cv.Convert(new RGBColor(y.R / baseNum, y.G / baseNum, y.B / baseNum));

            //' Get the distance from black for the two colors
            var distA = new Colourful.CIE94ColorDifference().ComputeDifference(lA, black);
            var distB = new Colourful.CIE94ColorDifference().ComputeDifference(lB, black);

            if (_descending)
            {
                return (int)(distB - distA);
            }
            else
            {
                return (int)(distA - distB);
            }

        }
    }


    public class HexColorDifferenceComparer : IComparer<string>
    {

        private readonly bool _descending;

        public HexColorDifferenceComparer(bool descending = false)
        {
            _descending = descending;
        }

        public int Compare(string a, string b)
        {

            var x = a.ToArgbColor(true);
            var y = b.ToArgbColor(true);

            var cv = new ConverterBuilder().FromRGB().ToLab().Build();

            double baseNum = 255;

            var black = cv.Convert(new RGBColor(Color.Black.R / baseNum, Color.Black.G / baseNum, Color.Black.B / baseNum));
            var lA = cv.Convert(new RGBColor(x.R / baseNum, x.G / baseNum, x.B / baseNum));
            var lB = cv.Convert(new RGBColor(y.R / baseNum, y.G / baseNum, y.B / baseNum));

            //' Get the distance from black for the two colors
            var distA = new Colourful.CIE94ColorDifference().ComputeDifference(lA, black);
            var distB = new Colourful.CIE94ColorDifference().ComputeDifference(lB, black);

            if (_descending)
            {
                return (int)(distB - distA);
            }
            else
            {
                return (int)(distA - distB);
            }

        }
    }

   


}
