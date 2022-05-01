using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeFunctions
{
    public delegate void TrackBarChangedEventHandler(int Alpha, int Red, int Green, int Blue);

    /// <summary>
    /// Describes various sort orders, suitable for sorting colors.
    /// </summary>
    public enum ColorsSortOrder
    {
        /// <summary>
        /// Sort colors by their Hue, Saturation and Brightness values.
        /// </summary>
        HSB,
        /// <summary>
        /// Sort colors by their names.
        /// </summary>
        Alphabetical,
        /// <summary>
        /// Sort colors by their Alpha, Red, Green and Blue values.
        /// </summary>
        Argb,
        /// <summary>
        /// Do not sort the colors.
        /// </summary>
        None
    }


    /// <summary>
    /// Determines the look of the custom colors sample box.
    /// </summary>
    public enum SampleBackground
    {
        /// <summary>
        /// One even color.
        /// </summary>
        Uniform,
        /// <summary>
        /// Different shades, spread across the control.
        /// </summary>
        ShadesOfControl,
        /// <summary>
        /// A Gray gradient.
        /// </summary>
        GradientGray,
        /// <summary>
        /// A color gradient.
        /// </summary>
        GradientColor
    }

    /// <summary>
    /// Location of the color in the sample box.
    /// </summary>
    public enum ColorSamplePosition
    {
        Top,
        Middle,
        Bottom,
        Entire
    }


}
