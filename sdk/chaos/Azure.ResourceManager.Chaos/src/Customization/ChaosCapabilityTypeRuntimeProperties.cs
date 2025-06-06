﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Runtime properties of this Capability Type. </summary>
    [Obsolete("This class is now deprecated. Please use the new class `ChaosCapabilityMetadataRuntimeProperties` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal partial class ChaosCapabilityTypeRuntimeProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChaosCapabilityTypeRuntimeProperties"/>. </summary>
        public ChaosCapabilityTypeRuntimeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChaosCapabilityTypeRuntimeProperties"/>. </summary>
        /// <param name="kind"> String of the kind of the resource's action type (continuous or discrete). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChaosCapabilityTypeRuntimeProperties(string kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> String of the kind of the resource's action type (continuous or discrete). </summary>
        public string Kind { get; }
    }
}
