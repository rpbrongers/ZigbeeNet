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
    using System.Collections.Generic;
    
    
    /// <summary>
    /// Class to implement the XBee command " Set Encryption Options ".
    /// AT Command <b>EO</b></p>Set or read the encryption enable setting.
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeSetEncryptionOptionsCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        /// 
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// 
        /// </summary>
        private List<EncryptionOptions> _encryptionOptions = new List<EncryptionOptions>();
        
        /// <summary>
        /// The frameId to set as <see cref="uint8"/>
        /// </summary>
        public void SetFrameId(int frameId)
        {
            this._frameId = frameId;
        }
        
        /// <summary>
        /// The encryptionOptions to add to the set as <see cref="EncryptionOptions"/>
        /// </summary>
        public void AddEncryptionOptions(EncryptionOptions encryptionOptions)
        {
            this._encryptionOptions.Add(encryptionOptions);
        }
        
        /// <summary>
        /// The encryptionOptions to remove to the set as <see cref="EncryptionOptions"/>
        /// </summary>
        public void RemoveEncryptionOptions(EncryptionOptions encryptionOptions)
        {
            this._encryptionOptions.Remove(encryptionOptions);
        }
        
        /// <summary>
        /// The encryptionOptions to set to the set as <see cref="EncryptionOptions"/>
        /// </summary>
        public void SetEncryptionOptions(IEnumerable<EncryptionOptions> encryptionOptions)
        {
            this._encryptionOptions.AddRange(encryptionOptions);
        }
        
        /// <summary>
        /// Method for serializing the command fields
        ///
        /// </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeATCOMMAND("\"EO\"");
            return this.GetPayload();
        }
    }
}
