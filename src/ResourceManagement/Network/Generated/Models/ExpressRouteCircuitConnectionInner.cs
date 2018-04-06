// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Express Route Circuit Connection in an ExpressRouteCircuitPeering
    /// resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuitConnectionInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCircuitConnectionInner class.
        /// </summary>
        public ExpressRouteCircuitConnectionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCircuitConnectionInner class.
        /// </summary>
        /// <param name="expressRouteCircuitPeering">Reference to Express Route
        /// Circuit Private Peering Resource of the circuit initiating
        /// connection.</param>
        /// <param name="peerExpressRouteCircuitPeering">Reference to Express
        /// Route Circuit Private Peering Resource of the peered
        /// circuit.</param>
        /// <param name="addressPrefix">/29 IP address space to carve out
        /// Customer addresses for tunnels.</param>
        /// <param name="authorizationKey">The authorization key.</param>
        /// <param name="circuitConnectionStatus">Express Route Circuit
        /// Connection State. Possible values are: 'Connected' and
        /// 'Disconnected'. Possible values include: 'Connected', 'Connecting',
        /// 'Disconnected'</param>
        /// <param name="provisioningState">Provisioning state of the circuit
        /// connection resource. Possible values are: 'Succeded', 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteCircuitConnectionInner(string id = default(string), Management.ResourceManager.Fluent.SubResource expressRouteCircuitPeering = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource peerExpressRouteCircuitPeering = default(Management.ResourceManager.Fluent.SubResource), string addressPrefix = default(string), string authorizationKey = default(string), CircuitConnectionStatus circuitConnectionStatus = default(CircuitConnectionStatus), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            CircuitConnectionStatus = circuitConnectionStatus;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference to Express Route Circuit Private Peering
        /// Resource of the circuit initiating connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteCircuitPeering")]
        public Management.ResourceManager.Fluent.SubResource ExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// Gets or sets reference to Express Route Circuit Private Peering
        /// Resource of the peered circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerExpressRouteCircuitPeering")]
        public Management.ResourceManager.Fluent.SubResource PeerExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// Gets or sets /29 IP address space to carve out Customer addresses
        /// for tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the authorization key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// Gets express Route Circuit Connection State. Possible values are:
        /// 'Connected' and 'Disconnected'. Possible values include:
        /// 'Connected', 'Connecting', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.circuitConnectionStatus")]
        public CircuitConnectionStatus CircuitConnectionStatus { get; private set; }

        /// <summary>
        /// Gets provisioning state of the circuit connection resource.
        /// Possible values are: 'Succeded', 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
