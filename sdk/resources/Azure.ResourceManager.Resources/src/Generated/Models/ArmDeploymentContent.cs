// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment operation parameters. </summary>
    public partial class ArmDeploymentContent
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

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentContent"/>. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ArmDeploymentContent(ArmDeploymentProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentContent"/>. </summary>
        /// <param name="location"> The location to store the deployment data. </param>
        /// <param name="properties"> The deployment properties. </param>
        /// <param name="tags"> Deployment tags. </param>
        /// <param name="identity"> The Managed Identity configuration for a deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDeploymentContent(AzureLocation? location, ArmDeploymentProperties properties, IDictionary<string, string> tags, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Properties = properties;
            Tags = tags;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentContent"/> for deserialization. </summary>
        internal ArmDeploymentContent()
        {
        }

        /// <summary> The location to store the deployment data. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> The deployment properties. </summary>
        [WirePath("properties")]
        public ArmDeploymentProperties Properties { get; }
        /// <summary> Deployment tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
    }
}
