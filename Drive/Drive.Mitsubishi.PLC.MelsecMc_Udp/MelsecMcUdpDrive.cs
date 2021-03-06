﻿using BetterIOT.Common.DriveConfig;
using BetterIOT.Hsl.Template;
using HslCommunication.Profinet.Melsec;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drive.Mitsubishi.PLC.MelsecMc_Udp
{
    public class MelsecMcUdpDrive : NetworkDeviceBaseTemplate<MelsecMcUdpConfig>
    {
        public override void DeviceConn(MelsecMcUdpConfig config)
        {
            MelsecMcUdp mcUdp = new MelsecMcUdp();
            mcUdp.IpAddress = config.IP;
            mcUdp.Port = config.Port;
            NetworkDevice = mcUdp;
        }

        public override void DeviceDiscnn()
        {
            
        }
    }
}
