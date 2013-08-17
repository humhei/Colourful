﻿using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using Colourful.Colors;

namespace Colourful.RGBWorkingSpaces
{
    /// <summary>
    /// ProPhoto RGB
    /// </summary>
    /// <remarks>
    /// Chromaticity coordinates taken from:
    /// http://www.brucelindbloom.com/index.html?WorkingSpaceInfo.html
    /// </remarks>
    public class ProPhotoRGB : IRGBWorkingSpace
    {
        public IInverseCompanding InverseCompanding
        {
            get { return new InverseGammaCompanding(1.8); }
        }

        public virtual XYZColorBase ReferenceWhite
        {
            get { return Illuminants.D50; }
        }

        public virtual RGBPrimariesChromaticityCoordinates ChromaticityCoordinates
        {
            get { return new RGBPrimariesChromaticityCoordinates { R = new ChromaticityCoordinates(0.7347, 0.2653), G = new ChromaticityCoordinates(0.1596, 0.8404), B = new ChromaticityCoordinates(0.0366, 0.0001) }; }
        }
    }
}