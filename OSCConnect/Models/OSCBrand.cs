﻿using System.Drawing;

namespace OSCConnect.Models
{
    class OSCBrand : Brand
    {
        public string name()
        {
            return "OSC";
        }

        public string brandString()
        {
            return "osc";
        }

        public string dashboardURI()
        {
            return "http://ondemand.osc.edu/";
        }

        public Icon icon()
        {
            return Properties.Resources.oscicontransparent;
        }

        public Bitmap dashboardButtonBackground()
        {
            return Properties.Resources.osclogo2;
        }

        public Bitmap logoImage()
        {
            return Properties.Resources.osclogotext;
        }
    }
}
