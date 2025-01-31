﻿using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace resolution.iconmanager
{
    class SystemFile
    {
        //h = 27;
        //w = 22;
        public static byte[] systemfile = new byte[]
        {
                0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
                0,0,0,0,0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,0,0,0,0,1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,0,0,0,1,2,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,0,0,1,2,2,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,0,1,2,2,2,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,1,1,1,2,2,2,2,2,2,1,1,1,2,2,1,
                0,1,2,2,2,2,1,2,2,2,2,2,2,2,2,1,2,2,2,2,2,1,
                0,1,2,2,2,2,1,2,2,2,2,2,2,2,2,1,2,2,2,2,2,1,
                0,1,2,2,2,2,2,1,1,1,2,2,2,2,2,2,1,1,1,2,2,1,
                0,1,2,2,2,2,2,2,2,2,1,1,2,2,1,2,2,2,2,1,2,1,
                0,1,2,1,1,2,2,2,2,2,1,1,2,2,1,2,2,2,2,1,2,1,
                0,1,2,1,1,2,1,1,1,1,2,1,1,1,1,1,1,1,1,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,1,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,1,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,1,2,2,1,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,1,1,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,
                0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
        };
        public static void drawsysicon(VBECanvas vbe, uint x, uint y)
        {
            for (uint h = 0; h < 27; h++)
            {
                for (uint w = 0; w < 22; w++)
                {
                    if (systemfile[h * 22 + w] == 1)
                    {
                        vbe.DrawFilledRectangle(new Pen(Color.Black), (int)(w + x), (int)(h + y), 1, 1);
                    }
                    if (systemfile[h * 22 + w] == 2)
                    {
                        vbe.DrawFilledRectangle(new Pen(Color.White), (int)(w + x), (int)(h + y), 1, 1);
                    }
                }
            }
        }
    }
}
