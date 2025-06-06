// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataFactory
{
    public partial class DataFactoryTriggerResource : IJsonModel<DataFactoryTriggerData>
    {
        private static DataFactoryTriggerData s_dataDeserializationInstance;
        private static DataFactoryTriggerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DataFactoryTriggerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataFactoryTriggerData>)Data).Write(writer, options);

        DataFactoryTriggerData IJsonModel<DataFactoryTriggerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataFactoryTriggerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DataFactoryTriggerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataFactoryTriggerData>(Data, options, AzureResourceManagerDataFactoryContext.Default);

        DataFactoryTriggerData IPersistableModel<DataFactoryTriggerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataFactoryTriggerData>(data, options, AzureResourceManagerDataFactoryContext.Default);

        string IPersistableModel<DataFactoryTriggerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataFactoryTriggerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
