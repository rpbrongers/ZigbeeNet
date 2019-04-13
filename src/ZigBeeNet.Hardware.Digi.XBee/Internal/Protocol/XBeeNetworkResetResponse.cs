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
    /// Class to implement the XBee command " Network Reset ".
    /// AT Command <b>NR</b></p>Resets network layer parameters on one or more modules within a
    /// PAN. Responds immediately with an OK then causes a network restart. The device loses all
    /// network configuration and routing information. If NR = 0: Resets network layer parameters
    /// on the node issuing the command. If NR = 1: Sends broadcast transmission to reset network
    /// layer parameters on all nodes in the PAN. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeNetworkResetResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        /// Sends broadcast transmission to reset network layer parameters on all nodes in the PAN. 
        /// </summary>
        private bool _resetRemoteDevices;
        
        /// <summary>
        ///  Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        ///  Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        ///  Sends broadcast transmission to reset network layer parameters on all nodes in the PAN. 
        /// Return the resetRemoteDevices as <see cref="System.Boolean"/>
        /// </summary>
        public bool GetResetRemoteDevices()
        {
            return _resetRemoteDevices;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            this.InitializeDeserializer(incomingData);
            this._frameId = this.DeserializeInt8();
            DeserializeAtCommand();
            this._commandStatus = this.DeserializeCommandStatus();
            if (_commandStatus != CommandStatus.OK || IsComplete())
            {
                    return;
            }
            this._resetRemoteDevices = this.DeserializeBoolean();
        }
    }
}
