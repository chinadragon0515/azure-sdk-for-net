// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The VnetGateway contract. This is used to give the vnet gateway access
    /// to the VPN package.
    /// </summary>
    public partial class VnetGateway : Resource
    {
        /// <summary>
        /// The VNET name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The URI where the Vpn package can be downloaded
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnPackageUri")]
        public string VpnPackageUri { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}