//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Structure
{
    
    
    /// <summary>
    /// Class to implement the Ember Enumeration <b>EmberOutgoingMessageType</b>
    /// </summary>
    public enum EmberOutgoingMessageType
    {
        
        /// <summary>
        /// Default unknown value
        /// </summary>
        UNKNOWN = -1,
        
        /// <summary>
        ///  [0] Unicast sent directly to an EmberNodeId.
        /// </summary>
        EMBER_OUTGOING_DIRECT = 0x0000,
        
        /// <summary>
        ///  [1] Unicast sent using an entry in the address table.
        /// </summary>
        EMBER_OUTGOING_VIA_ADDRESS_TABLE = 0x0001,
        
        /// <summary>
        ///  [2] Unicast sent using an entry in the binding table.
        /// </summary>
        EMBER_OUTGOING_VIA_BINDING = 0x0002,
        
        /// <summary>
        ///  [3] Multicast message. This value is passed to emberMessageSentHandler() only. It may not
        /// be passed to emberSendUnicast().
        /// </summary>
        EMBER_OUTGOING_MULTICAST = 0x0003,
        
        /// <summary>
        ///  [4] Aliased multicast message. This value is passed to emberMessageSentHandler() only. It
        /// may not be passed to emberSendUnicast().
        /// </summary>
        EMBER_OUTGOING_MULTICAST_WITH_ALIAS = 0x0004,
        
        /// <summary>
        ///  [5] Aliased broadcast message. This value is passed to emberMessageSentHandler() only. It
        /// may not be passed to emberSendUnicast().
        /// </summary>
        EMBER_OUTGOING_BROADCAST_WITH_ALIAS = 0x0005,
        
        /// <summary>
        ///  [6] Broadcast message. This value is passed to emberMessageSentHandler() only. It may not
        /// be passed to emberSendUnicast().
        /// </summary>
        EMBER_OUTGOING_BROADCAST = 0x0006,
    }
}
