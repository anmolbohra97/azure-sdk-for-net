// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Chaos.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing the Experiment data model.
    /// Model that represents a Experiment resource.
    /// </summary>
    public partial class ExperimentData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ExperimentData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="steps"> List of steps. </param>
        /// <param name="selectors"> List of selectors. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="steps"/> or <paramref name="selectors"/> is null. </exception>
        public ExperimentData(AzureLocation location, IEnumerable<Step> steps, IEnumerable<Selector> selectors) : base(location)
        {
            Argument.AssertNotNull(steps, nameof(steps));
            Argument.AssertNotNull(selectors, nameof(selectors));

            Steps = steps.ToList();
            Selectors = selectors.ToList();
        }

        /// <summary> Initializes a new instance of ExperimentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the experiment resource. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="steps"> List of steps. </param>
        /// <param name="selectors"> List of selectors. </param>
        /// <param name="startOnCreation"> A boolean value that indicates if experiment should be started on creation or not. </param>
        internal ExperimentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, IList<Step> steps, IList<Selector> selectors, bool? startOnCreation) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Steps = steps;
            Selectors = selectors;
            StartOnCreation = startOnCreation;
        }

        /// <summary> The identity of the experiment resource. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> List of steps. </summary>
        public IList<Step> Steps { get; }
        /// <summary> List of selectors. </summary>
        public IList<Selector> Selectors { get; }
        /// <summary> A boolean value that indicates if experiment should be started on creation or not. </summary>
        public bool? StartOnCreation { get; set; }
    }
}
