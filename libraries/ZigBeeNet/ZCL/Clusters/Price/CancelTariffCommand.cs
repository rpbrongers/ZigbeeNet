using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.Price;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.Price
{
    /// <summary>
    /// Cancel Tariff Command value object class.
    ///
    /// Cluster: Price. Command ID 0x0E is sent FROM the server.
    /// This command is a specific command used for the Price cluster.
    ///
    /// The CancelTariff command indicates that all data associated with a particular tariff
    /// instance should be discarded. <br> In markets where permanently active price
    /// information is required for billing purposes, it is recommended that
    /// replacement/superseding PublishTariffInformation, PublishPriceMatrix,
    /// PublishBlockThresholds and PublishTierLabels commands are used in place of a
    /// CancelTariff command.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class CancelTariffCommand : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0700;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x0E;

        /// <summary>
        /// Provider ID command message field.
        /// 
        /// An unsigned 32-bit field containing a unique identifier for the commodity
        /// provider. This field allows differentiation in deregulated markets where
        /// multiple commodity providers may be available.
        /// </summary>
        public uint ProviderId { get; set; }

        /// <summary>
        /// Issuer Tariff ID command message field.
        /// 
        /// Unique identifier generated by the commodity Supplier. All parts of a tariff
        /// instance shall have the same Issuer Tariff ID.
        /// </summary>
        public uint IssuerTariffId { get; set; }

        /// <summary>
        /// Tariff Type command message field.
        /// 
        /// An 8-bit bitmap identifying the type of tariff to be cancelled by this command. The
        /// least significant nibble represents an enumeration of the tariff type
        /// (Generation Meters shall use the ‘Received’ Tariff). The most significant nibble
        /// is reserved.
        /// </summary>
        public byte TariffType { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public CancelTariffCommand()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(ProviderId, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(IssuerTariffId, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(TariffType, ZclDataType.Get(DataType.BITMAP_8_BIT));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            ProviderId = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            IssuerTariffId = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            TariffType = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.BITMAP_8_BIT));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("CancelTariffCommand [");
            builder.Append(base.ToString());
            builder.Append(", ProviderId=");
            builder.Append(ProviderId);
            builder.Append(", IssuerTariffId=");
            builder.Append(IssuerTariffId);
            builder.Append(", TariffType=");
            builder.Append(TariffType);
            builder.Append(']');

            return builder.ToString();
        }
    }
}