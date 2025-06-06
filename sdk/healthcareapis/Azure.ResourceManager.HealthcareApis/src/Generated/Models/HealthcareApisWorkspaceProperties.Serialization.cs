// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisWorkspaceProperties : IUtf8JsonSerializable, IJsonModel<HealthcareApisWorkspaceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareApisWorkspaceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareApisWorkspaceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisWorkspaceProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        HealthcareApisWorkspaceProperties IJsonModel<HealthcareApisWorkspaceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisWorkspaceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisWorkspaceProperties(document.RootElement, options);
        }

        internal static HealthcareApisWorkspaceProperties DeserializeHealthcareApisWorkspaceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareApisProvisioningState? provisioningState = default;
            IReadOnlyList<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = default;
            HealthcareApisPublicNetworkAccess? publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HealthcareApisProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisPrivateEndpointConnectionData> array = new List<HealthcareApisPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HealthcareApisPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareApisWorkspaceProperties(provisioningState, privateEndpointConnections ?? new ChangeTrackingList<HealthcareApisPrivateEndpointConnectionData>(), publicNetworkAccess, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareApisWorkspaceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHealthcareApisContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisWorkspaceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareApisWorkspaceProperties IPersistableModel<HealthcareApisWorkspaceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHealthcareApisWorkspaceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisWorkspaceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareApisWorkspaceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
