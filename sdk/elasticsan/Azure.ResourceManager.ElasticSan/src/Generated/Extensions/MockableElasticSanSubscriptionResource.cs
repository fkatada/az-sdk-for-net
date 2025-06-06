// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ElasticSan.Models;

namespace Azure.ResourceManager.ElasticSan.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableElasticSanSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _elasticSanClientDiagnostics;
        private ElasticSansRestOperations _elasticSanRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableElasticSanSubscriptionResource"/> class for mocking. </summary>
        protected MockableElasticSanSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableElasticSanSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableElasticSanSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ElasticSanClientDiagnostics => _elasticSanClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ElasticSanResource.ResourceType.Namespace, Diagnostics);
        private ElasticSansRestOperations ElasticSanRestClient => _elasticSanRestClient ??= new ElasticSansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ElasticSanResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the available Skus in the region and information related to them
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter='location eq &lt;location&gt;' to filter on location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanSkuInformation> GetSkusAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ElasticSanSkuInformation.DeserializeElasticSanSkuInformation(e), SkusClientDiagnostics, Pipeline, "MockableElasticSanSubscriptionResource.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the available Skus in the region and information related to them
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter='location eq &lt;location&gt;' to filter on location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanSkuInformation> GetSkus(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ElasticSanSkuInformation.DeserializeElasticSanSkuInformation(e), SkusClientDiagnostics, Pipeline, "MockableElasticSanSubscriptionResource.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of ElasticSans in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/elasticSans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanResource> GetElasticSansAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticSanRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticSanRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticSanResource(Client, ElasticSanData.DeserializeElasticSanData(e)), ElasticSanClientDiagnostics, Pipeline, "MockableElasticSanSubscriptionResource.GetElasticSans", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of ElasticSans in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/elasticSans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ElasticSans_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanResource> GetElasticSans(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticSanRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticSanRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticSanResource(Client, ElasticSanData.DeserializeElasticSanData(e)), ElasticSanClientDiagnostics, Pipeline, "MockableElasticSanSubscriptionResource.GetElasticSans", "value", "nextLink", cancellationToken);
        }
    }
}
