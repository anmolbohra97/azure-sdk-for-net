// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Properties pertaining to the UnknownTarget. </summary>
    internal partial class UnknownTarget
    {
        /// <summary> Initializes a new instance of UnknownTarget. </summary>
        public UnknownTarget()
        {
            Attributes = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of UnknownTarget. </summary>
        /// <param name="attributes"> Dictionary of string-&gt;string pairs containing information about the Storage Target. </param>
        internal UnknownTarget(IDictionary<string, string> attributes)
        {
            Attributes = attributes;
        }

        /// <summary> Dictionary of string-&gt;string pairs containing information about the Storage Target. </summary>
        public IDictionary<string, string> Attributes { get; }
    }
}
