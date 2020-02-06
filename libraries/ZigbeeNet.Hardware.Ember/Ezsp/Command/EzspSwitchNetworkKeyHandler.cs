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
    /// Class to implement the Ember EZSP command " switchNetworkKeyHandler ".
    /// A callback to inform the application that the Network Key has been updated and the node has
    /// been switched over to use the new key. The actual key being used is not passed up, but the
    /// sequence number is.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspSwitchNetworkKeyHandler : EzspFrameResponse
    {
        
        public const int FRAME_ID = 110;
        
        /// <summary>
        ///  The sequence number of the new network key.
        /// </summary>
        private int _keySequenceNumber;
        
        public EzspSwitchNetworkKeyHandler(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _keySequenceNumber = deserializer.DeserializeUInt8();
        }
        
        /// <summary>
        /// The keySequenceNumber to set as <see cref="uint8_t"/> </summary>
        public void SetKeySequenceNumber(int keySequenceNumber)
        {
            _keySequenceNumber = keySequenceNumber;
        }
        
        /// <summary>
        ///  The sequence number of the new network key.
        /// Return the keySequenceNumber as <see cref="System.Int32"/>
        /// </summary>
        public int GetKeySequenceNumber()
        {
            return _keySequenceNumber;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspSwitchNetworkKeyHandler [keySequenceNumber=");
            builder.Append(_keySequenceNumber);
            builder.Append(']');
            return builder.ToString();
        }
    }
}