﻿using System;
using System.Collections.Generic;
using System.Text;
using ZigBeeNet.Hardware.TI.CC2531.Packet;
using ZigBeeNet.Logging;

namespace ZigBeeNet.Hardware.TI.CC2531.Network
{
    public class SynchronousCommandListener : ISynchronousCommandListener
    {
        private readonly ILog _logger = LogProvider.For<SynchronousCommandListener>();

        public event EventHandler<ZToolPacket> OnResponseReceived;

        public void ReceivedCommandResponse(ZToolPacket packet)
        {
            _logger.Trace(" {Packet} received as synchronous command.", packet.GetType().Name);
            OnResponseReceived?.Invoke(this, packet);
        }
    }
}
