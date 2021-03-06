//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " mfglibSendPacket ".
    /// Sends a single packet consisting of the following bytes: packetLength,
    /// packetContents[0], ... , packetContents[pack-etLength - 3], CRC[0], CRC[1]. The total
    /// number of bytes sent is packetLength + 1. The radio replaces the last two bytes of
    /// packetContents[]with the 16-bit CRC for the packet.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspMfglibSendPacketRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 137;
        
        /// <summary>
        ///  The packet to send. The last two bytes will be replacedwith the 16-bit CRC.
        /// </summary>
        private int[] _packetContents;
        
        private EzspSerializer _serializer;
        
        public EzspMfglibSendPacketRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The packetContents to set as <see cref="uint8_t[]"/> </summary>
        public void SetPacketContents(int[] packetContents)
        {
            _packetContents = packetContents;
        }
        
        /// <summary>
        ///  The packet to send. The last two bytes will be replacedwith the 16-bit CRC.
        /// Return the packetContents as <see cref="System.Int32"/>
        /// </summary>
        public int[] GetPacketContents()
        {
            return _packetContents;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeUInt8(_packetContents.Length);
            _serializer.SerializeUInt8Array(_packetContents);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspMfglibSendPacketRequest [packetContents=");
            if (_packetContents == null)
            {
                builder.Append("null");
            }
            else
            {
                for (int cnt = 0
                ; cnt < _packetContents.Length; cnt++
                )
                {
                    if (cnt > 0)
                    {
                        builder.Append(' ');
                    }
                    builder.Append(string.Format("0x{0:X02}", _packetContents[cnt]));
                }
            }
            builder.Append(']');
            return builder.ToString();
        }
    }
}
