using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.Commissioning;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.Commissioning
{
    /// <summary>
    /// Restart Device Command value object class.
    ///
    /// Cluster: Commissioning. Command ID 0x00 is sent TO the server.
    /// This command is a specific command used for the Commissioning cluster.
    ///
    ///     ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class RestartDeviceCommand : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0015;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x00;

        /// <summary>
        /// Option command message field.
        /// </summary>
        public byte Option { get; set; }

        /// <summary>
        /// Delay command message field.
        /// </summary>
        public byte Delay { get; set; }

        /// <summary>
        /// Jitter command message field.
        /// </summary>
        public byte Jitter { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public RestartDeviceCommand()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Option, ZclDataType.Get(DataType.BITMAP_8_BIT));
            serializer.Serialize(Delay, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(Jitter, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Option = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.BITMAP_8_BIT));
            Delay = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            Jitter = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("RestartDeviceCommand [");
            builder.Append(base.ToString());
            builder.Append(", Option=");
            builder.Append(Option);
            builder.Append(", Delay=");
            builder.Append(Delay);
            builder.Append(", Jitter=");
            builder.Append(Jitter);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
