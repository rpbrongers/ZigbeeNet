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
    using ZigBeeNet.Security;
    
    
    /// <summary>
    /// Class to implement the XBee command " Set Link Key ".
    /// AT Command <b>KY</b></p>Sets the 128-bit AES link key value that the device uses for
    /// encryption and decryption. This command is write-only and cannot be read. If you set KY to 0
    /// the coordinator transmits the network key in the clear to joining devices, and joining
    /// devices acquire the network key in the clear when joining. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeSetLinkKeyCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        ///  </summary>
        private int _frameId;
        
        /// <summary>
        ///  </summary>
        private ZigBeeKey _linkKey;
        
        /// <summary>
        /// The frameId to set as </summary>
        /// <seecref="uint8"
        ///>
        ///  </see>
        public void SetFrameId(int frameId)
        {
            this._frameId = frameId;
        }
        
        /// <summary>
        /// The linkKey to set as </summary>
        /// <seecref="ZigBeeKey"
        ///>
        ///  </see>
        public void SetLinkKey(ZigBeeKey linkKey)
        {
            this._linkKey = linkKey;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeInt8(_frameId);
            this.SerializeAtCommand("KY");
            this.SerializeZigBeeKey(_linkKey);
            return this.GetPayload();
        }
    }
}
