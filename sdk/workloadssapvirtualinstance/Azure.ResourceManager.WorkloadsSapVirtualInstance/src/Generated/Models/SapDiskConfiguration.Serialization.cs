// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    public partial class SapDiskConfiguration : IUtf8JsonSerializable, IJsonModel<SapDiskConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapDiskConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SapDiskConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapDiskConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RecommendedConfiguration))
            {
                writer.WritePropertyName("recommendedConfiguration"u8);
                writer.WriteObjectValue(RecommendedConfiguration, options);
            }
            if (Optional.IsCollectionDefined(SupportedConfigurations))
            {
                writer.WritePropertyName("supportedConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        SapDiskConfiguration IJsonModel<SapDiskConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapDiskConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapDiskConfiguration(document.RootElement, options);
        }

        internal static SapDiskConfiguration DeserializeSapDiskConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DiskVolumeConfiguration recommendedConfiguration = default;
            IReadOnlyList<SupportedConfigurationsDiskDetails> supportedConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recommendedConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedConfiguration = DiskVolumeConfiguration.DeserializeDiskVolumeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SupportedConfigurationsDiskDetails> array = new List<SupportedConfigurationsDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedConfigurationsDiskDetails.DeserializeSupportedConfigurationsDiskDetails(item, options));
                    }
                    supportedConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SapDiskConfiguration(recommendedConfiguration, supportedConfigurations ?? new ChangeTrackingList<SupportedConfigurationsDiskDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapDiskConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerWorkloadsSapVirtualInstanceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SapDiskConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        SapDiskConfiguration IPersistableModel<SapDiskConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapDiskConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSapDiskConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapDiskConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapDiskConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
