// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary>
    /// A class representing the WebPubSub data model.
    /// A class represent a resource.
    /// </summary>
    public partial class WebPubSubData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of WebPubSubData. </summary>
        /// <param name="location"> The location. </param>
        public WebPubSubData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<WebPubSubPrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<WebPubSubSharedPrivateLinkData>();
        }

        /// <summary> Initializes a new instance of WebPubSubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="identity"> A class represent managed identities used for request and response. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="externalIP"> The publicly accessible IP of the resource. </param>
        /// <param name="hostName"> FQDN of the service instance. </param>
        /// <param name="publicPort"> The publicly accessible port of the resource which is designed for browser/client side usage. </param>
        /// <param name="serverPort"> The publicly accessible port of the resource which is designed for customer server side usage. </param>
        /// <param name="version"> Version of the resource. Probably you need the same or higher version of client SDKs. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the resource. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources. </param>
        /// <param name="tls"> TLS settings for the resource. </param>
        /// <param name="hostNamePrefix"> Deprecated. </param>
        /// <param name="liveTraceConfiguration"> Live trace configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="resourceLogConfiguration"> Resource log configuration of a Microsoft.SignalRService resource. </param>
        /// <param name="networkAcls"> Network ACLs for the resource. </param>
        /// <param name="publicNetworkAccess">
        /// Enable or disable public network access. Default to "Enabled".
        /// When it's Enabled, network ACLs still apply.
        /// When it's Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </param>
        /// <param name="isLocalAuthDisabled">
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won't work.
        /// </param>
        /// <param name="isAadAuthDisabled">
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won't work.
        /// </param>
        internal WebPubSubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BillingInfoSku sku, ManagedServiceIdentity identity, WebPubSubProvisioningState? provisioningState, string externalIP, string hostName, int? publicPort, int? serverPort, string version, IReadOnlyList<WebPubSubPrivateEndpointConnectionData> privateEndpointConnections, IReadOnlyList<WebPubSubSharedPrivateLinkData> sharedPrivateLinkResources, WebPubSubTlsSettings tls, string hostNamePrefix, LiveTraceConfiguration liveTraceConfiguration, ResourceLogConfiguration resourceLogConfiguration, WebPubSubNetworkAcls networkAcls, string publicNetworkAccess, bool? isLocalAuthDisabled, bool? isAadAuthDisabled) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ProvisioningState = provisioningState;
            ExternalIP = externalIP;
            HostName = hostName;
            PublicPort = publicPort;
            ServerPort = serverPort;
            Version = version;
            PrivateEndpointConnections = privateEndpointConnections;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            Tls = tls;
            HostNamePrefix = hostNamePrefix;
            LiveTraceConfiguration = liveTraceConfiguration;
            ResourceLogConfiguration = resourceLogConfiguration;
            NetworkAcls = networkAcls;
            PublicNetworkAccess = publicNetworkAccess;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            IsAadAuthDisabled = isAadAuthDisabled;
        }

        /// <summary> The billing information of the resource. </summary>
        public BillingInfoSku Sku { get; set; }
        /// <summary> A class represent managed identities used for request and response. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public WebPubSubProvisioningState? ProvisioningState { get; }
        /// <summary> The publicly accessible IP of the resource. </summary>
        public string ExternalIP { get; }
        /// <summary> FQDN of the service instance. </summary>
        public string HostName { get; }
        /// <summary> The publicly accessible port of the resource which is designed for browser/client side usage. </summary>
        public int? PublicPort { get; }
        /// <summary> The publicly accessible port of the resource which is designed for customer server side usage. </summary>
        public int? ServerPort { get; }
        /// <summary> Version of the resource. Probably you need the same or higher version of client SDKs. </summary>
        public string Version { get; }
        /// <summary> Private endpoint connections to the resource. </summary>
        public IReadOnlyList<WebPubSubPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The list of shared private link resources. </summary>
        public IReadOnlyList<WebPubSubSharedPrivateLinkData> SharedPrivateLinkResources { get; }
        /// <summary> TLS settings for the resource. </summary>
        internal WebPubSubTlsSettings Tls { get; set; }
        /// <summary> Request client certificate during TLS handshake if enabled. </summary>
        public bool? IsClientCertEnabled
        {
            get => Tls is null ? default : Tls.IsClientCertEnabled;
            set
            {
                if (Tls is null)
                    Tls = new WebPubSubTlsSettings();
                Tls.IsClientCertEnabled = value;
            }
        }

        /// <summary> Deprecated. </summary>
        public string HostNamePrefix { get; }
        /// <summary> Live trace configuration of a Microsoft.SignalRService resource. </summary>
        public LiveTraceConfiguration LiveTraceConfiguration { get; set; }
        /// <summary> Resource log configuration of a Microsoft.SignalRService resource. </summary>
        internal ResourceLogConfiguration ResourceLogConfiguration { get; set; }
        /// <summary> Gets or sets the list of category configurations. </summary>
        public IList<ResourceLogCategory> ResourceLogCategories
        {
            get
            {
                if (ResourceLogConfiguration is null)
                    ResourceLogConfiguration = new ResourceLogConfiguration();
                return ResourceLogConfiguration.Categories;
            }
        }

        /// <summary> Network ACLs for the resource. </summary>
        public WebPubSubNetworkAcls NetworkAcls { get; set; }
        /// <summary>
        /// Enable or disable public network access. Default to "Enabled".
        /// When it's Enabled, network ACLs still apply.
        /// When it's Disabled, public network access is always disabled no matter what you set in network ACLs.
        /// </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary>
        /// DisableLocalAuth
        /// Enable or disable local auth with AccessKey
        /// When set as true, connection with AccessKey=xxx won't work.
        /// </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary>
        /// DisableLocalAuth
        /// Enable or disable aad auth
        /// When set as true, connection with AuthType=aad won't work.
        /// </summary>
        public bool? IsAadAuthDisabled { get; set; }
    }
}
