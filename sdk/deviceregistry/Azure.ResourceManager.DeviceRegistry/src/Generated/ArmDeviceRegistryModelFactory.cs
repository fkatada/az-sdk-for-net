// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDeviceRegistryModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="DeviceRegistry.DeviceRegistryAssetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <returns> A new <see cref="DeviceRegistry.DeviceRegistryAssetData"/> instance for mocking. </returns>
        public static DeviceRegistryAssetData DeviceRegistryAssetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, AssetProperties properties = null, DeviceRegistryExtendedLocation extendedLocation = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DeviceRegistryAssetData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                extendedLocation,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AssetProperties"/>. </summary>
        /// <param name="uuid"> Globally unique, immutable, non-reusable id. </param>
        /// <param name="isEnabled"> Enabled/Disabled status of the asset. </param>
        /// <param name="externalAssetId"> Asset id provided by the customer. </param>
        /// <param name="displayName"> Human-readable display name. </param>
        /// <param name="description"> Human-readable description of the asset. </param>
        /// <param name="assetEndpointProfileRef"> A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides data points for this asset. Must provide asset endpoint profile name. </param>
        /// <param name="version"> An integer that is incremented each time the resource is modified. </param>
        /// <param name="manufacturer"> Asset manufacturer name. </param>
        /// <param name="manufacturerUri"> Asset manufacturer URI. </param>
        /// <param name="model"> Asset model name. </param>
        /// <param name="productCode"> Asset product code. </param>
        /// <param name="hardwareRevision"> Revision number of the hardware. </param>
        /// <param name="softwareRevision"> Revision number of the software. </param>
        /// <param name="documentationUri"> Reference to the documentation. </param>
        /// <param name="serialNumber"> Asset serial number. </param>
        /// <param name="attributes"> A set of key-value pairs that contain custom attributes set by the customer. </param>
        /// <param name="discoveredAssetRefs"> Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered asset names must be provided. </param>
        /// <param name="defaultDatasetsConfiguration"> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultEventsConfiguration"> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultTopic"> Object that describes the default topic information for the asset. </param>
        /// <param name="datasets"> Array of datasets that are part of the asset. Each dataset describes the data points that make up the set. </param>
        /// <param name="events"> Array of events that are part of the asset. Each event can have per-event configuration. </param>
        /// <param name="status"> Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.AssetProperties"/> instance for mocking. </returns>
        public static AssetProperties AssetProperties(string uuid = null, bool? isEnabled = null, string externalAssetId = null, string displayName = null, string description = null, string assetEndpointProfileRef = null, long? version = null, string manufacturer = null, Uri manufacturerUri = null, string model = null, string productCode = null, string hardwareRevision = null, string softwareRevision = null, Uri documentationUri = null, string serialNumber = null, IDictionary<string, BinaryData> attributes = null, IEnumerable<string> discoveredAssetRefs = null, string defaultDatasetsConfiguration = null, string defaultEventsConfiguration = null, DeviceRegistryTopic defaultTopic = null, IEnumerable<DeviceRegistryDataset> datasets = null, IEnumerable<DeviceRegistryEvent> events = null, DeviceRegistryAssetStatus status = null, DeviceRegistryProvisioningState? provisioningState = null)
        {
            attributes ??= new Dictionary<string, BinaryData>();
            discoveredAssetRefs ??= new List<string>();
            datasets ??= new List<DeviceRegistryDataset>();
            events ??= new List<DeviceRegistryEvent>();

            return new AssetProperties(
                uuid,
                isEnabled,
                externalAssetId,
                displayName,
                description,
                assetEndpointProfileRef,
                version,
                manufacturer,
                manufacturerUri,
                model,
                productCode,
                hardwareRevision,
                softwareRevision,
                documentationUri,
                serialNumber,
                attributes,
                discoveredAssetRefs?.ToList(),
                defaultDatasetsConfiguration,
                defaultEventsConfiguration,
                defaultTopic,
                datasets?.ToList(),
                events?.ToList(),
                status,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeviceRegistryAssetStatus"/>. </summary>
        /// <param name="errors"> Array object to transfer and persist errors that originate from the Edge. </param>
        /// <param name="version"> A read only incremental counter indicating the number of times the configuration has been modified from the perspective of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to the cloud. In steady state, this should equal version. </param>
        /// <param name="datasets"> Array of dataset statuses that describe the status of each dataset. </param>
        /// <param name="events"> Array of event statuses that describe the status of each event. </param>
        /// <returns> A new <see cref="Models.DeviceRegistryAssetStatus"/> instance for mocking. </returns>
        public static DeviceRegistryAssetStatus DeviceRegistryAssetStatus(IEnumerable<DeviceRegistryAssetStatusError> errors = null, long? version = null, IEnumerable<DeviceRegistryAssetStatusDataset> datasets = null, IEnumerable<DeviceRegistryAssetStatusEvent> events = null)
        {
            errors ??= new List<DeviceRegistryAssetStatusError>();
            datasets ??= new List<DeviceRegistryAssetStatusDataset>();
            events ??= new List<DeviceRegistryAssetStatusEvent>();

            return new DeviceRegistryAssetStatus(errors?.ToList(), version, datasets?.ToList(), events?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeviceRegistryAssetStatusError"/>. </summary>
        /// <param name="code"> Error code for classification of errors (ex: 400, 404, 500, etc.). </param>
        /// <param name="message"> Human readable helpful error message to provide additional context for error (ex: “capability Id 'foo' does not exist”). </param>
        /// <returns> A new <see cref="Models.DeviceRegistryAssetStatusError"/> instance for mocking. </returns>
        public static DeviceRegistryAssetStatusError DeviceRegistryAssetStatusError(int? code = null, string message = null)
        {
            return new DeviceRegistryAssetStatusError(code, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeviceRegistryAssetStatusDataset"/>. </summary>
        /// <param name="name"> The name of the dataset. Must be unique within the status.datasets array. This name is used to correlate between the spec and status dataset information. </param>
        /// <param name="messageSchemaReference"> The message schema reference object. </param>
        /// <returns> A new <see cref="Models.DeviceRegistryAssetStatusDataset"/> instance for mocking. </returns>
        public static DeviceRegistryAssetStatusDataset DeviceRegistryAssetStatusDataset(string name = null, MessageSchemaReference messageSchemaReference = null)
        {
            return new DeviceRegistryAssetStatusDataset(name, messageSchemaReference, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MessageSchemaReference"/>. </summary>
        /// <param name="schemaRegistryNamespace"> The message schema registry namespace. </param>
        /// <param name="schemaName"> The message schema name. </param>
        /// <param name="schemaVersion"> The message schema version. </param>
        /// <returns> A new <see cref="Models.MessageSchemaReference"/> instance for mocking. </returns>
        public static MessageSchemaReference MessageSchemaReference(string schemaRegistryNamespace = null, string schemaName = null, string schemaVersion = null)
        {
            return new MessageSchemaReference(schemaRegistryNamespace, schemaName, schemaVersion, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeviceRegistryAssetStatusEvent"/>. </summary>
        /// <param name="name"> The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec and status event information. </param>
        /// <param name="messageSchemaReference"> The message schema reference object. </param>
        /// <returns> A new <see cref="Models.DeviceRegistryAssetStatusEvent"/> instance for mocking. </returns>
        public static DeviceRegistryAssetStatusEvent DeviceRegistryAssetStatusEvent(string name = null, MessageSchemaReference messageSchemaReference = null)
        {
            return new DeviceRegistryAssetStatusEvent(name, messageSchemaReference, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistry.DeviceRegistryAssetEndpointProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <returns> A new <see cref="DeviceRegistry.DeviceRegistryAssetEndpointProfileData"/> instance for mocking. </returns>
        public static DeviceRegistryAssetEndpointProfileData DeviceRegistryAssetEndpointProfileData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, DeviceRegistryAssetEndpointProfileProperties properties = null, DeviceRegistryExtendedLocation extendedLocation = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DeviceRegistryAssetEndpointProfileData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                extendedLocation,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DeviceRegistryAssetEndpointProfileProperties"/>. </summary>
        /// <param name="uuid"> Globally unique, immutable, non-reusable id. </param>
        /// <param name="targetAddress"> The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration. </param>
        /// <param name="endpointProfileType"> Defines the configuration for the connector type that is being used with the endpoint profile. </param>
        /// <param name="authentication"> Defines the client authentication mechanism to the server. </param>
        /// <param name="additionalConfiguration"> Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF). </param>
        /// <param name="discoveredAssetEndpointProfileRef"> Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery flow. Discovered asset endpoint profile name must be provided. </param>
        /// <param name="statusErrors"> Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.DeviceRegistryAssetEndpointProfileProperties"/> instance for mocking. </returns>
        public static DeviceRegistryAssetEndpointProfileProperties DeviceRegistryAssetEndpointProfileProperties(string uuid = null, Uri targetAddress = null, string endpointProfileType = null, DeviceRegistryAuthentication authentication = null, string additionalConfiguration = null, string discoveredAssetEndpointProfileRef = null, IEnumerable<AssetEndpointProfileStatusError> statusErrors = null, DeviceRegistryProvisioningState? provisioningState = null)
        {
            statusErrors ??= new List<AssetEndpointProfileStatusError>();

            return new DeviceRegistryAssetEndpointProfileProperties(
                uuid,
                targetAddress,
                endpointProfileType,
                authentication,
                additionalConfiguration,
                discoveredAssetEndpointProfileRef,
                statusErrors != null ? new AssetEndpointProfileStatus(statusErrors?.ToList(), serializedAdditionalRawData: null) : null,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AssetEndpointProfileStatusError"/>. </summary>
        /// <param name="code"> Error code for classification of errors (ex: 400, 404, 500, etc.). </param>
        /// <param name="message"> Human readable helpful error message to provide additional context for error (ex: “targetAddress 'foo' is not a valid url”). </param>
        /// <returns> A new <see cref="Models.AssetEndpointProfileStatusError"/> instance for mocking. </returns>
        public static AssetEndpointProfileStatusError AssetEndpointProfileStatusError(int? code = null, string message = null)
        {
            return new AssetEndpointProfileStatusError(code, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistry.DeviceRegistryBillingContainerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="billingContainerProvisioningState"> The resource-specific properties for this resource. </param>
        /// <param name="etag"> Resource ETag. </param>
        /// <returns> A new <see cref="DeviceRegistry.DeviceRegistryBillingContainerData"/> instance for mocking. </returns>
        public static DeviceRegistryBillingContainerData DeviceRegistryBillingContainerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DeviceRegistryProvisioningState? billingContainerProvisioningState = null, ETag? etag = null)
        {
            return new DeviceRegistryBillingContainerData(
                id,
                name,
                resourceType,
                systemData,
                billingContainerProvisioningState != null ? new BillingContainerProperties(billingContainerProvisioningState, serializedAdditionalRawData: null) : null,
                etag,
                serializedAdditionalRawData: null);
        }
    }
}
