// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _keyVaultVaultsClientDiagnostics;
        private VaultsRestOperations _keyVaultVaultsRestClient;
        private ClientDiagnostics _vaultsClientDiagnostics;
        private VaultsRestOperations _vaultsRestClient;
        private ClientDiagnostics _managedHsmClientDiagnostics;
        private ManagedHsmsRestOperations _managedHsmRestClient;
        private ClientDiagnostics _managedHsmsClientDiagnostics;
        private ManagedHsmsRestOperations _managedHsmsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics KeyVaultVaultsClientDiagnostics => _keyVaultVaultsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", KeyVaultResource.ResourceType.Namespace, Diagnostics);
        private VaultsRestOperations KeyVaultVaultsRestClient => _keyVaultVaultsRestClient ??= new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(KeyVaultResource.ResourceType));
        private ClientDiagnostics VaultsClientDiagnostics => _vaultsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private VaultsRestOperations VaultsRestClient => _vaultsRestClient ??= new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ManagedHsmClientDiagnostics => _managedHsmClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ManagedHsmResource.ResourceType.Namespace, Diagnostics);
        private ManagedHsmsRestOperations ManagedHsmRestClient => _managedHsmRestClient ??= new ManagedHsmsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedHsmResource.ResourceType));
        private ClientDiagnostics ManagedHsmsClientDiagnostics => _managedHsmsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedHsmsRestOperations ManagedHsmsRestClient => _managedHsmsRestClient ??= new ManagedHsmsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeletedKeyVaultResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedKeyVaultResources and their operations over a DeletedKeyVaultResource. </returns>
        public virtual DeletedKeyVaultCollection GetDeletedKeyVaults()
        {
            return GetCachedClient(Client => new DeletedKeyVaultCollection(Client, Id));
        }

        /// <summary> Gets a collection of DeletedManagedHsmResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of DeletedManagedHsmResources and their operations over a DeletedManagedHsmResource. </returns>
        public virtual DeletedManagedHsmCollection GetDeletedManagedHsms()
        {
            return GetCachedClient(Client => new DeletedManagedHsmCollection(Client, Id));
        }

        /// <summary>
        /// The List operation gets information about the vaults associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KeyVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KeyVaultResource> GetKeyVaultsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => KeyVaultVaultsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => KeyVaultVaultsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new KeyVaultResource(Client, KeyVaultData.DeserializeKeyVaultData(e)), KeyVaultVaultsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetKeyVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the vaults associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KeyVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KeyVaultResource> GetKeyVaults(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => KeyVaultVaultsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => KeyVaultVaultsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new KeyVaultResource(Client, KeyVaultData.DeserializeKeyVaultData(e)), KeyVaultVaultsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetKeyVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted vaults in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedKeyVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedKeyVaultResource> GetDeletedKeyVaultsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VaultsRestClient.CreateListDeletedRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VaultsRestClient.CreateListDeletedNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeletedKeyVaultResource(Client, DeletedKeyVaultData.DeserializeDeletedKeyVaultData(e)), VaultsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedKeyVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted vaults in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedKeyVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedKeyVaultResource> GetDeletedKeyVaults(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VaultsRestClient.CreateListDeletedRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VaultsRestClient.CreateListDeletedNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeletedKeyVaultResource(Client, DeletedKeyVaultData.DeserializeDeletedKeyVaultData(e)), VaultsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedKeyVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks that the vault name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KeyVaultNameAvailabilityResult>> CheckKeyVaultNameAvailabilityAsync(KeyVaultNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = KeyVaultVaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckKeyVaultNameAvailability");
            scope.Start();
            try
            {
                var response = await KeyVaultVaultsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the vault name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KeyVaultNameAvailabilityResult> CheckKeyVaultNameAvailability(KeyVaultNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = KeyVaultVaultsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckKeyVaultNameAvailability");
            scope.Start();
            try
            {
                var response = KeyVaultVaultsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the managed HSM Pools associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedHsmResource> GetManagedHsmsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedHsmRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedHsmRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedHsmResource(Client, ManagedHsmData.DeserializeManagedHsmData(e)), ManagedHsmClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetManagedHsms", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the managed HSM Pools associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/managedHSMs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedHsmResource> GetManagedHsms(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedHsmRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedHsmRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedHsmResource(Client, ManagedHsmData.DeserializeManagedHsmData(e)), ManagedHsmClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetManagedHsms", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the deleted managed HSMs associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_ListDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedManagedHsmResource> GetDeletedManagedHsmsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedHsmsRestClient.CreateListDeletedRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedHsmsRestClient.CreateListDeletedNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeletedManagedHsmResource(Client, DeletedManagedHsmData.DeserializeDeletedManagedHsmData(e)), ManagedHsmsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedManagedHsms", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the deleted managed HSMs associated with the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/deletedManagedHSMs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_ListDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedManagedHsmResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedManagedHsmResource> GetDeletedManagedHsms(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedHsmsRestClient.CreateListDeletedRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedHsmsRestClient.CreateListDeletedNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeletedManagedHsmResource(Client, DeletedManagedHsmData.DeserializeDeletedManagedHsmData(e)), ManagedHsmsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedManagedHsms", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks that the managed hsm name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkMhsmNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_CheckMhsmNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The name of the managed hsm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedHsmNameAvailabilityResult>> CheckManagedHsmNameAvailabilityAsync(ManagedHsmNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckManagedHsmNameAvailability");
            scope.Start();
            try
            {
                var response = await ManagedHsmRestClient.CheckManagedHsmNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the managed hsm name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.KeyVault/checkMhsmNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedHsms_CheckMhsmNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The name of the managed hsm. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedHsmNameAvailabilityResult> CheckManagedHsmNameAvailability(ManagedHsmNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ManagedHsmClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckManagedHsmNameAvailability");
            scope.Start();
            try
            {
                var response = ManagedHsmRestClient.CheckManagedHsmNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
