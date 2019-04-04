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
    /// Class to implement the XBee command " Get Detailed Version ".
    /// AT Command <b>VL</b></p>Shows detailed version information, device type, time stamp for
    /// the build, Ember stack version, and bootloader version. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeGetDetailedVersionCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        /// 
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// The frameId to set as <see cref="uint8"/>
        /// </summary>
        public void SetFrameId(int frameId)
        {
            this._frameId = frameId;
        }
        
        /// <summary>
        /// Method for serializing the command fields
        ///
        /// </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeATCOMMAND("\"VL\"");
            return this.GetPayload();
        }
    }
}
