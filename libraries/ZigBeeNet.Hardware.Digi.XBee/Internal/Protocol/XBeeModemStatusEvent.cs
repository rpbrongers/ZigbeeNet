//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Modem Status ".
    /// Devices send the status messages in this frame in response to specific conditions. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeModemStatusEvent : XBeeFrame, IXBeeEvent
    {
        
        /// <summary>
        /// Response field
        /// </summary>
        private ModemStatus _status;
        
        /// <summary>
        ///  Return the status as <see cref="ModemStatus"/>
        /// </summary>
        public ModemStatus GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            InitializeDeserializer(incomingData);
            _status = DeserializeModemStatus();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(200);
            builder.Append("XBeeModemStatusEvent [status=");
            builder.Append(_status);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
