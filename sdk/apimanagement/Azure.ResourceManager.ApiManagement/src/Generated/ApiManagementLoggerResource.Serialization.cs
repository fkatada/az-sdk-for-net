// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementLoggerResource : IJsonModel<ApiManagementLoggerData>
    {
        private static ApiManagementLoggerData s_dataDeserializationInstance;
        private static ApiManagementLoggerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ApiManagementLoggerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementLoggerData>)Data).Write(writer, options);

        ApiManagementLoggerData IJsonModel<ApiManagementLoggerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementLoggerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementLoggerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ApiManagementLoggerData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ApiManagementLoggerData IPersistableModel<ApiManagementLoggerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementLoggerData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ApiManagementLoggerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementLoggerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
