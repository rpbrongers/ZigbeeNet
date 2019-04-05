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
    /// Class to implement the XBee command " Ieee Address Low ".
    /// AT Command <b>SL</b></p>DisplaLs the lower 32 bits of the unique IEEE 64-bit extended
    /// address assigned to the XBee in the factory. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeIeeeAddressLowResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int[] _ieeeAddress;
        
        /// <summary>
        /// Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        /// Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        /// Return the ieeeAddress as <see cref="System.Int32"/>
        /// </summary>
        public int GetIeeeAddress()
        {
            return _ieeeAddress;
        }
    }
}
