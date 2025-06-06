// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteSlotExtensionResource"/> and their operations.
    /// Each <see cref="WebSiteSlotExtensionResource"/> in the collection will belong to the same instance of <see cref="WebSiteSlotResource"/>.
    /// To get a <see cref="WebSiteSlotExtensionCollection"/> instance call the GetWebSiteSlotExtensions method from an instance of <see cref="WebSiteSlotResource"/>.
    /// </summary>
    public partial class WebSiteSlotExtensionCollection : ArmCollection, IEnumerable<WebSiteSlotExtensionResource>, IAsyncEnumerable<WebSiteSlotExtensionResource>
    {
        private readonly ClientDiagnostics _webSiteSlotExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotExtensionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotExtensionCollection"/> class for mocking. </summary>
        protected WebSiteSlotExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotExtensionResource.ResourceType, out string webSiteSlotExtensionWebAppsApiVersion);
            _webSiteSlotExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Install site extension on a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_InstallSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteSlotExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteSlotExtensionWebAppsRestClient.InstallSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSiteSlotExtensionResource>(new WebSiteSlotExtensionOperationSource(Client), _webSiteSlotExtensionWebAppsClientDiagnostics, Pipeline, _webSiteSlotExtensionWebAppsRestClient.CreateInstallSiteExtensionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Install site extension on a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_InstallSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual ArmOperation<WebSiteSlotExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteSlotExtensionWebAppsRestClient.InstallSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken);
                var operation = new AppServiceArmOperation<WebSiteSlotExtensionResource>(new WebSiteSlotExtensionOperationSource(Client), _webSiteSlotExtensionWebAppsClientDiagnostics, Pipeline, _webSiteSlotExtensionWebAppsRestClient.CreateInstallSiteExtensionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotExtensionResource>> GetAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotExtensionWebAppsRestClient.GetSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get site extension information by its ID for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<WebSiteSlotExtensionResource> Get(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotExtensionWebAppsRestClient.GetSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get list of siteextensions for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListSiteExtensionsSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotExtensionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotExtensionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotExtensionWebAppsRestClient.CreateListSiteExtensionsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotExtensionWebAppsRestClient.CreateListSiteExtensionsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotExtensionResource(Client, SiteExtensionInfoData.DeserializeSiteExtensionInfoData(e)), _webSiteSlotExtensionWebAppsClientDiagnostics, Pipeline, "WebSiteSlotExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get list of siteextensions for a web site, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListSiteExtensionsSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotExtensionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotExtensionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotExtensionWebAppsRestClient.CreateListSiteExtensionsSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotExtensionWebAppsRestClient.CreateListSiteExtensionsSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotExtensionResource(Client, SiteExtensionInfoData.DeserializeSiteExtensionInfoData(e)), _webSiteSlotExtensionWebAppsClientDiagnostics, Pipeline, "WebSiteSlotExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotExtensionWebAppsRestClient.GetSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<bool> Exists(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotExtensionWebAppsRestClient.GetSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSiteSlotExtensionResource>> GetIfExistsAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotExtensionWebAppsRestClient.GetSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetSiteExtensionSlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual NullableResponse<WebSiteSlotExtensionResource> GetIfExists(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _webSiteSlotExtensionWebAppsClientDiagnostics.CreateScope("WebSiteSlotExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteSlotExtensionWebAppsRestClient.GetSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotExtensionResource> IEnumerable<WebSiteSlotExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotExtensionResource> IAsyncEnumerable<WebSiteSlotExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
