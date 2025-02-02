// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of IPConfigurationBgpPeeringAddress. </summary>
    public partial class IPConfigurationBgpPeeringAddress
    {
        /// <summary> Initializes a new instance of IPConfigurationBgpPeeringAddress. </summary>
        public IPConfigurationBgpPeeringAddress()
        {
            DefaultBgpIPAddresses = new ChangeTrackingList<string>();
            CustomBgpIPAddresses = new ChangeTrackingList<string>();
            TunnelIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IPConfigurationBgpPeeringAddress. </summary>
        /// <param name="ipConfigurationId"> The ID of IP configuration which belongs to gateway. </param>
        /// <param name="defaultBgpIPAddresses"> The list of default BGP peering addresses which belong to IP configuration. </param>
        /// <param name="customBgpIPAddresses"> The list of custom BGP peering addresses which belong to IP configuration. </param>
        /// <param name="tunnelIPAddresses"> The list of tunnel public IP addresses which belong to IP configuration. </param>
        internal IPConfigurationBgpPeeringAddress(string ipConfigurationId, IReadOnlyList<string> defaultBgpIPAddresses, IList<string> customBgpIPAddresses, IReadOnlyList<string> tunnelIPAddresses)
        {
            IPConfigurationId = ipConfigurationId;
            DefaultBgpIPAddresses = defaultBgpIPAddresses;
            CustomBgpIPAddresses = customBgpIPAddresses;
            TunnelIPAddresses = tunnelIPAddresses;
        }

        /// <summary> The ID of IP configuration which belongs to gateway. </summary>
        public string IPConfigurationId { get; set; }
        /// <summary> The list of default BGP peering addresses which belong to IP configuration. </summary>
        public IReadOnlyList<string> DefaultBgpIPAddresses { get; }
        /// <summary> The list of custom BGP peering addresses which belong to IP configuration. </summary>
        public IList<string> CustomBgpIPAddresses { get; }
        /// <summary> The list of tunnel public IP addresses which belong to IP configuration. </summary>
        public IReadOnlyList<string> TunnelIPAddresses { get; }
    }
}
