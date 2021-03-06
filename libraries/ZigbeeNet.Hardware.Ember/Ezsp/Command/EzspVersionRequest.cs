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
    /// Class to implement the Ember EZSP command " version ".
    /// The command allows the Host to specify the desired EZSP version and must be sent before any
    /// other command. This document describes EZSP version 4 and stack type 2 (mesh). The response
    /// provides information about the firmware running on the NCP.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspVersionRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 0;
        
        /// <summary>
        ///  The EZSP version the Host wishes to use. To successfully set the version and allow other
        /// commands.
        /// </summary>
        private int _desiredProtocolVersion;
        
        private EzspSerializer _serializer;
        
        public EzspVersionRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The desiredProtocolVersion to set as <see cref="uint8_t"/> </summary>
        public void SetDesiredProtocolVersion(int desiredProtocolVersion)
        {
            _desiredProtocolVersion = desiredProtocolVersion;
        }
        
        /// <summary>
        ///  The EZSP version the Host wishes to use. To successfully set the version and allow other
        /// commands.
        /// Return the desiredProtocolVersion as <see cref="System.Int32"/>
        /// </summary>
        public int GetDesiredProtocolVersion()
        {
            return _desiredProtocolVersion;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeUInt8(_desiredProtocolVersion);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspVersionRequest [desiredProtocolVersion=");
            builder.Append(_desiredProtocolVersion);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
