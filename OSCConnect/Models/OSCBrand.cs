﻿using System;
using System.Drawing;

namespace OSCConnect.Models
{
    class OSCBrand : Brand
    {
        public string name()
        {
            return "OSC";
        }

        public string dashboardURI()
        {
            return "http://www.osc.edu/";
        }

        public Icon icon()
        {
            return Properties.Resources.oscicontransparent;
        }

        public Bitmap dashboardButtonBackground()
        {
            return Properties.Resources.osclogo2;
        }
    }
}
