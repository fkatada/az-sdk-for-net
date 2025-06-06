// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmNicDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmNicDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmNicDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InMageRcmNicDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
            }
            if (Optional.IsDefined(IsPrimaryNic))
            {
                writer.WritePropertyName("isPrimaryNic"u8);
                writer.WriteStringValue(IsPrimaryNic);
            }
            if (Optional.IsDefined(IsSelectedForFailover))
            {
                writer.WritePropertyName("isSelectedForFailover"u8);
                writer.WriteStringValue(IsSelectedForFailover);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceIPAddress))
            {
                writer.WritePropertyName("sourceIPAddress"u8);
                writer.WriteStringValue(SourceIPAddress.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SourceIPAddressType))
            {
                writer.WritePropertyName("sourceIPAddressType"u8);
                writer.WriteStringValue(SourceIPAddressType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SourceNetworkId))
            {
                writer.WritePropertyName("sourceNetworkId"u8);
                writer.WriteStringValue(SourceNetworkId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceSubnetName))
            {
                writer.WritePropertyName("sourceSubnetName"u8);
                writer.WriteStringValue(SourceSubnetName);
            }
            if (Optional.IsDefined(TargetIPAddress))
            {
                writer.WritePropertyName("targetIPAddress"u8);
                writer.WriteStringValue(TargetIPAddress.ToString());
            }
            if (Optional.IsDefined(TargetIPAddressType))
            {
                writer.WritePropertyName("targetIPAddressType"u8);
                writer.WriteStringValue(TargetIPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(TargetSubnetName))
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (Optional.IsDefined(TestSubnetName))
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (Optional.IsDefined(TestIPAddress))
            {
                writer.WritePropertyName("testIPAddress"u8);
                writer.WriteStringValue(TestIPAddress.ToString());
            }
            if (Optional.IsDefined(TestIPAddressType))
            {
                writer.WritePropertyName("testIPAddressType"u8);
                writer.WriteStringValue(TestIPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(TargetNicName))
            {
                writer.WritePropertyName("targetNicName"u8);
                writer.WriteStringValue(TargetNicName);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InMageRcmNicDetails IJsonModel<InMageRcmNicDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmNicDetails(document.RootElement, options);
        }

        internal static InMageRcmNicDetails DeserializeInMageRcmNicDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string isPrimaryNic = default;
            string isSelectedForFailover = default;
            IPAddress sourceIPAddress = default;
            SiteRecoveryEthernetAddressType? sourceIPAddressType = default;
            ResourceIdentifier sourceNetworkId = default;
            string sourceSubnetName = default;
            IPAddress targetIPAddress = default;
            SiteRecoveryEthernetAddressType? targetIPAddressType = default;
            string targetSubnetName = default;
            string testSubnetName = default;
            IPAddress testIPAddress = default;
            SiteRecoveryEthernetAddressType? testIPAddressType = default;
            string targetNicName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimaryNic"u8))
                {
                    isPrimaryNic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSelectedForFailover"u8))
                {
                    isSelectedForFailover = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceSubnetName"u8))
                {
                    sourceSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testIPAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testIPAddressType = new SiteRecoveryEthernetAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetNicName"u8))
                {
                    targetNicName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InMageRcmNicDetails(
                nicId,
                isPrimaryNic,
                isSelectedForFailover,
                sourceIPAddress,
                sourceIPAddressType,
                sourceNetworkId,
                sourceSubnetName,
                targetIPAddress,
                targetIPAddressType,
                targetSubnetName,
                testSubnetName,
                testIPAddress,
                testIPAddressType,
                targetNicName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmNicDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InMageRcmNicDetails IPersistableModel<InMageRcmNicDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInMageRcmNicDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmNicDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmNicDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
