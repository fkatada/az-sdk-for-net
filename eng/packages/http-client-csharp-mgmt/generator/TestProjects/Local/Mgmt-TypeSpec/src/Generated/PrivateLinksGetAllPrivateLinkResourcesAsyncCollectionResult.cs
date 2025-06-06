// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtTypeSpec.Models;

namespace MgmtTypeSpec
{
    internal partial class PrivateLinksGetAllPrivateLinkResourcesAsyncCollectionResult : AsyncPageable<BinaryData>
    {
        private readonly PrivateLinks _client;
        private readonly Uri _nextPage;
        private readonly Guid _subscriptionId;
        private readonly string _resourceGroupName;
        private readonly RequestContext _context;

        /// <summary> Initializes a new instance of PrivateLinksGetAllPrivateLinkResourcesAsyncCollectionResult, which is used to iterate over the pages of a collection. </summary>
        /// <param name="client"> The PrivateLinks client used to send requests. </param>
        /// <param name="nextPage"> The url of the next page of responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public PrivateLinksGetAllPrivateLinkResourcesAsyncCollectionResult(PrivateLinks client, Uri nextPage, Guid subscriptionId, string resourceGroupName, RequestContext context) : base(context?.CancellationToken ?? default)
        {
            Argument.AssertNotNull(resourceGroupName, nameof(resourceGroupName));

            _client = client;
            _nextPage = nextPage;
            _subscriptionId = subscriptionId;
            _resourceGroupName = resourceGroupName;
            _context = context;
        }

        /// <summary> Gets the pages of PrivateLinksGetAllPrivateLinkResourcesAsyncCollectionResult as an enumerable collection. </summary>
        /// <param name="continuationToken"> A continuation token indicating where to resume paging. </param>
        /// <param name="pageSizeHint"> The number of items per page. </param>
        /// <returns> The pages of PrivateLinksGetAllPrivateLinkResourcesAsyncCollectionResult as an enumerable collection. </returns>
        public override async IAsyncEnumerable<Page<BinaryData>> AsPages(string continuationToken, int? pageSizeHint)
        {
            Uri nextPage = continuationToken != null ? new Uri(continuationToken) : _nextPage;
            do
            {
                Response response = await GetNextResponse(pageSizeHint, nextPage).ConfigureAwait(false);
                if (response is null)
                {
                    yield break;
                }
                PrivateLinkResourceListResult responseWithType = (PrivateLinkResourceListResult)response;
                List<BinaryData> items = new List<BinaryData>();
                foreach (var item in responseWithType.Value)
                {
                    items.Add(BinaryData.FromObjectAsJson(item));
                }
                nextPage = responseWithType.NextLink;
                yield return Page<BinaryData>.FromValues(items, nextPage?.AbsoluteUri, response);
            }
            while (nextPage != null);
        }

        /// <summary> Get next page. </summary>
        /// <param name="pageSizeHint"> The number of items per page. </param>
        /// <param name="nextLink"> The next link to use for the next page of results. </param>
        private async ValueTask<Response> GetNextResponse(int? pageSizeHint, Uri nextLink)
        {
            HttpMessage message = _client.CreateGetAllPrivateLinkResourcesRequest(nextLink, _subscriptionId, _resourceGroupName, _context);
            using DiagnosticScope scope = _client.ClientDiagnostics.CreateScope("PrivateLinks.GetAllPrivateLinkResources");
            scope.Start();
            try
            {
                await _client.Pipeline.SendAsync(message, CancellationToken).ConfigureAwait(false);
                if (message.Response.IsError && _context.ErrorOptions != ErrorOptions.NoThrow)
                {
                    throw new RequestFailedException(message.Response);
                }
                return message.Response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
