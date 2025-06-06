// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// settings for compression.
    /// Serialized Name: CompressionSettings
    /// </summary>
    public partial class RouteCacheCompressionSettings
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

        /// <summary> Initializes a new instance of <see cref="RouteCacheCompressionSettings"/>. </summary>
        public RouteCacheCompressionSettings()
        {
            ContentTypesToCompress = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteCacheCompressionSettings"/>. </summary>
        /// <param name="contentTypesToCompress">
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// Serialized Name: CompressionSettings.contentTypesToCompress
        /// </param>
        /// <param name="isCompressionEnabled">
        /// Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.
        /// Serialized Name: CompressionSettings.isCompressionEnabled
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteCacheCompressionSettings(IList<string> contentTypesToCompress, bool? isCompressionEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// Serialized Name: CompressionSettings.contentTypesToCompress
        /// </summary>
        public IList<string> ContentTypesToCompress { get; }
        /// <summary>
        /// Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.
        /// Serialized Name: CompressionSettings.isCompressionEnabled
        /// </summary>
        public bool? IsCompressionEnabled { get; set; }
    }
}
