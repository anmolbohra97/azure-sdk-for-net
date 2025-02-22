// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the OS and SAP Configurations for Deployment. </summary>
    public partial class OSSapConfiguration
    {
        /// <summary> Initializes a new instance of OSSapConfiguration. </summary>
        public OSSapConfiguration()
        {
        }

        /// <summary> Initializes a new instance of OSSapConfiguration. </summary>
        /// <param name="deployerVmPackages"> The url and storage account ID where deployer VM packages are uploaded. </param>
        /// <param name="sapFqdn"> The FQDN to set for the SAP system. </param>
        internal OSSapConfiguration(DeployerVmPackages deployerVmPackages, string sapFqdn)
        {
            DeployerVmPackages = deployerVmPackages;
            SapFqdn = sapFqdn;
        }

        /// <summary> The url and storage account ID where deployer VM packages are uploaded. </summary>
        public DeployerVmPackages DeployerVmPackages { get; set; }
        /// <summary> The FQDN to set for the SAP system. </summary>
        public string SapFqdn { get; set; }
    }
}
