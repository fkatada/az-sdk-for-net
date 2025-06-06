// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Union
{
    public partial class StringAndArrayCases : IJsonModel<StringAndArrayCases>
    {
        internal StringAndArrayCases() => throw null;

        void IJsonModel<StringAndArrayCases>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        StringAndArrayCases IJsonModel<StringAndArrayCases>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual StringAndArrayCases JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<StringAndArrayCases>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        StringAndArrayCases IPersistableModel<StringAndArrayCases>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual StringAndArrayCases PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<StringAndArrayCases>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;
    }
}
