﻿using System;

namespace Drive.Panasonic.PLC.MC_3E__Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            PanasonicMcNetDrive panasonic = new PanasonicMcNetDrive();
            panasonic.Start(args[0]);
        }
    }
}
