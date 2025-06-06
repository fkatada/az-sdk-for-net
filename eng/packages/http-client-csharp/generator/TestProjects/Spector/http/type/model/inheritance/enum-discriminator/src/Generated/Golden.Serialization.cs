// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Model.Inheritance.EnumDiscriminator
{
    public partial class Golden : IJsonModel<Golden>
    {
        internal Golden() => throw null;

        void IJsonModel<Golden>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Golden IJsonModel<Golden>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected override Dog JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Golden>.Write(ModelReaderWriterOptions options) => throw null;

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Golden IPersistableModel<Golden>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected override Dog PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Golden>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;
    }
}
