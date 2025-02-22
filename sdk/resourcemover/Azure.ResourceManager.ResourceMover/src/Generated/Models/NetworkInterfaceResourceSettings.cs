// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the network interface resource settings. </summary>
    public partial class NetworkInterfaceResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of NetworkInterfaceResourceSettings. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public NetworkInterfaceResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            Argument.AssertNotNull(targetResourceName, nameof(targetResourceName));

            Tags = new ChangeTrackingDictionary<string, string>();
            IPConfigurations = new ChangeTrackingList<NicIPConfigurationResourceSettings>();
            ResourceType = "Microsoft.Network/networkInterfaces";
        }

        /// <summary> Initializes a new instance of NetworkInterfaceResourceSettings. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="ipConfigurations"> Gets or sets the IP configurations of the NIC. </param>
        /// <param name="enableAcceleratedNetworking"> Gets or sets a value indicating whether accelerated networking is enabled. </param>
        internal NetworkInterfaceResourceSettings(string resourceType, string targetResourceName, IDictionary<string, string> tags, IList<NicIPConfigurationResourceSettings> ipConfigurations, bool? enableAcceleratedNetworking) : base(resourceType, targetResourceName)
        {
            Tags = tags;
            IPConfigurations = ipConfigurations;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            ResourceType = resourceType ?? "Microsoft.Network/networkInterfaces";
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the IP configurations of the NIC. </summary>
        public IList<NicIPConfigurationResourceSettings> IPConfigurations { get; }
        /// <summary> Gets or sets a value indicating whether accelerated networking is enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
    }
}
