// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class GlobalRulestackResource : IJsonModel<GlobalRulestackData>
    {
        private static GlobalRulestackData s_dataDeserializationInstance;
        private static GlobalRulestackData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<GlobalRulestackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GlobalRulestackData>)Data).Write(writer, options);

        GlobalRulestackData IJsonModel<GlobalRulestackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GlobalRulestackData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<GlobalRulestackData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<GlobalRulestackData>(Data, options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);

        GlobalRulestackData IPersistableModel<GlobalRulestackData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GlobalRulestackData>(data, options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);

        string IPersistableModel<GlobalRulestackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GlobalRulestackData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
