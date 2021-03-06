// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The IP Addresses and Ports that require inbound network access to and
    /// within the subnet of the App Service Environment.
    /// </summary>
    public partial class InboundEnvironmentEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the InboundEnvironmentEndpoint class.
        /// </summary>
        public InboundEnvironmentEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InboundEnvironmentEndpoint class.
        /// </summary>
        /// <param name="description">Short text describing the purpose of the
        /// network traffic.</param>
        /// <param name="endpoints">The IP addresses that network traffic will
        /// originate from in cidr notation.</param>
        /// <param name="ports">The ports that network traffic will arrive to
        /// the App Service Environment at.</param>
        public InboundEnvironmentEndpoint(string description = default(string), IList<string> endpoints = default(IList<string>), IList<string> ports = default(IList<string>))
        {
            Description = description;
            Endpoints = endpoints;
            Ports = ports;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets short text describing the purpose of the network
        /// traffic.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the IP addresses that network traffic will originate
        /// from in cidr notation.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<string> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the ports that network traffic will arrive to the App
        /// Service Environment at.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<string> Ports { get; set; }

    }
}
