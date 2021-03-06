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
    using ZigBeeNet.Hardware.Ember.Ezsp.Structure;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " setConcentrator ".
    /// Enable/disable concentrator support.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspSetConcentratorRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 16;
        
        /// <summary>
        ///  If this bool is true the concentrator support is enabled. Otherwise is disabled. If this bool
        /// is false all the other arguments are ignored.
        /// </summary>
        private bool _enable;
        
        /// <summary>
        ///  Must be either EMBER_HIGH_RAM_CONCENTRATOR or EMBER_LOW_RAM_CONCENTRATOR. The former
        /// is used when the caller has enough memory to store source routes for the whole network. In that
        /// case, remote nodes stop sending route records once the concentrator has successfully
        /// received one. The latter is used when the concentrator has insufficient RAM to store all
        /// outbound source routes. In that case, route records are sent to the concentrator prior to
        /// every inbound APS unicast.
        /// </summary>
        private EmberConcentratorType _concentratorType;
        
        /// <summary>
        ///  The minimum amount of time that must pass between MTORR broadcasts.
        /// </summary>
        private int _minTime;
        
        /// <summary>
        ///  The maximum amount of time that can pass between MTORR broadcasts.
        /// </summary>
        private int _maxTime;
        
        /// <summary>
        ///  The number of route errors that will trigger a re-broadcast of the MTORR.
        /// </summary>
        private int _routeErrorThreshold;
        
        /// <summary>
        ///  The number of APS delivery failures that will trigger a re-broadcast of the MTORR.
        /// </summary>
        private int _deliveryFailureThreshold;
        
        /// <summary>
        ///  The maximum number of hops that the MTORR broadcast will be allowed to have. A value of 0 will be
        /// converted to the EMBER_MAX_HOPS value set by the stack.
        /// </summary>
        private int _maxHops;
        
        private EzspSerializer _serializer;
        
        public EzspSetConcentratorRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The enable to set as <see cref="bool"/> </summary>
        public void SetEnable(bool enable)
        {
            _enable = enable;
        }
        
        /// <summary>
        /// The concentratorType to set as <see cref="EmberConcentratorType"/> </summary>
        public void SetConcentratorType(EmberConcentratorType concentratorType)
        {
            _concentratorType = concentratorType;
        }
        
        /// <summary>
        /// The minTime to set as <see cref="uint16_t"/> </summary>
        public void SetMinTime(int minTime)
        {
            _minTime = minTime;
        }
        
        /// <summary>
        /// The maxTime to set as <see cref="uint16_t"/> </summary>
        public void SetMaxTime(int maxTime)
        {
            _maxTime = maxTime;
        }
        
        /// <summary>
        /// The routeErrorThreshold to set as <see cref="uint8_t"/> </summary>
        public void SetRouteErrorThreshold(int routeErrorThreshold)
        {
            _routeErrorThreshold = routeErrorThreshold;
        }
        
        /// <summary>
        /// The deliveryFailureThreshold to set as <see cref="uint8_t"/> </summary>
        public void SetDeliveryFailureThreshold(int deliveryFailureThreshold)
        {
            _deliveryFailureThreshold = deliveryFailureThreshold;
        }
        
        /// <summary>
        /// The maxHops to set as <see cref="uint8_t"/> </summary>
        public void SetMaxHops(int maxHops)
        {
            _maxHops = maxHops;
        }
        
        /// <summary>
        ///  If this bool is true the concentrator support is enabled. Otherwise is disabled. If this bool
        /// is false all the other arguments are ignored.
        /// Return the enable as <see cref="System.Boolean"/>
        /// </summary>
        public bool GetEnable()
        {
            return _enable;
        }
        
        /// <summary>
        ///  Must be either EMBER_HIGH_RAM_CONCENTRATOR or EMBER_LOW_RAM_CONCENTRATOR. The former
        /// is used when the caller has enough memory to store source routes for the whole network. In that
        /// case, remote nodes stop sending route records once the concentrator has successfully
        /// received one. The latter is used when the concentrator has insufficient RAM to store all
        /// outbound source routes. In that case, route records are sent to the concentrator prior to
        /// every inbound APS unicast.
        /// Return the concentratorType as <see cref="EmberConcentratorType"/>
        /// </summary>
        public EmberConcentratorType GetConcentratorType()
        {
            return _concentratorType;
        }
        
        /// <summary>
        ///  The minimum amount of time that must pass between MTORR broadcasts.
        /// Return the minTime as <see cref="System.Int32"/>
        /// </summary>
        public int GetMinTime()
        {
            return _minTime;
        }
        
        /// <summary>
        ///  The maximum amount of time that can pass between MTORR broadcasts.
        /// Return the maxTime as <see cref="System.Int32"/>
        /// </summary>
        public int GetMaxTime()
        {
            return _maxTime;
        }
        
        /// <summary>
        ///  The number of route errors that will trigger a re-broadcast of the MTORR.
        /// Return the routeErrorThreshold as <see cref="System.Int32"/>
        /// </summary>
        public int GetRouteErrorThreshold()
        {
            return _routeErrorThreshold;
        }
        
        /// <summary>
        ///  The number of APS delivery failures that will trigger a re-broadcast of the MTORR.
        /// Return the deliveryFailureThreshold as <see cref="System.Int32"/>
        /// </summary>
        public int GetDeliveryFailureThreshold()
        {
            return _deliveryFailureThreshold;
        }
        
        /// <summary>
        ///  The maximum number of hops that the MTORR broadcast will be allowed to have. A value of 0 will be
        /// converted to the EMBER_MAX_HOPS value set by the stack.
        /// Return the maxHops as <see cref="System.Int32"/>
        /// </summary>
        public int GetMaxHops()
        {
            return _maxHops;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeBool(_enable);
            _serializer.SerializeEmberConcentratorType(_concentratorType);
            _serializer.SerializeUInt16(_minTime);
            _serializer.SerializeUInt16(_maxTime);
            _serializer.SerializeUInt8(_routeErrorThreshold);
            _serializer.SerializeUInt8(_deliveryFailureThreshold);
            _serializer.SerializeUInt8(_maxHops);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspSetConcentratorRequest [enable=");
            builder.Append(_enable);
            builder.Append(", concentratorType=");
            builder.Append(_concentratorType);
            builder.Append(", minTime=");
            builder.Append(_minTime);
            builder.Append(", maxTime=");
            builder.Append(_maxTime);
            builder.Append(", routeErrorThreshold=");
            builder.Append(_routeErrorThreshold);
            builder.Append(", deliveryFailureThreshold=");
            builder.Append(_deliveryFailureThreshold);
            builder.Append(", maxHops=");
            builder.Append(_maxHops);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
