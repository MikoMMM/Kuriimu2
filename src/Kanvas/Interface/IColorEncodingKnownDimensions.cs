﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanvas.Interface
{
    /// <summary>
    /// An interface for additionally defining a Width and a Height to use in the encoding.
    /// </summary>
    public interface IColorEncodingKnownDimensions : IColorEncoding
    {
        /// <summary>
        /// The Width of the image to convert.
        /// </summary>
        int Width { set; }

        /// <summary>
        /// The Height of the image to convert.
        /// </summary>
        int Height { set; }
    }
}
