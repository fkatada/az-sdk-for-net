// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork
{
    internal class MobileNetworkOperationSource : IOperationSource<MobileNetworkResource>
    {
        private readonly ArmClient _client;

        internal MobileNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        MobileNetworkResource IOperationSource<MobileNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MobileNetworkData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMobileNetworkContext.Default);
            return new MobileNetworkResource(_client, data);
        }

        async ValueTask<MobileNetworkResource> IOperationSource<MobileNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MobileNetworkData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMobileNetworkContext.Default);
            return await Task.FromResult(new MobileNetworkResource(_client, data)).ConfigureAwait(false);
        }
    }
}
