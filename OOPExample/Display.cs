﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Display
    {
        public int width { get; private set; }
        public int height { get; private set; }

        public Display(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
