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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// UrlPathMaps give a url path to the backend mapping information for
    /// PathBasedRouting.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayUrlPathMapInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayUrlPathMapInner
        /// class.
        /// </summary>
        public ApplicationGatewayUrlPathMapInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayUrlPathMapInner
        /// class.
        /// </summary>
        /// <param name="defaultBackendAddressPool">Default backend address
        /// pool resource of URL path map.</param>
        /// <param name="defaultBackendHttpSettings">Default backend http
        /// settings resource of URL path map.</param>
        /// <param name="defaultRedirectConfiguration">Default redirect
        /// configuration resource of URL path map.</param>
        /// <param name="pathRules">Path rule of URL path map resource.</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayUrlPathMapInner(string id = default(string), Management.ResourceManager.Fluent.SubResource defaultBackendAddressPool = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource defaultBackendHttpSettings = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource defaultRedirectConfiguration = default(Management.ResourceManager.Fluent.SubResource), IList<ApplicationGatewayPathRuleInner> pathRules = default(IList<ApplicationGatewayPathRuleInner>), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            DefaultBackendAddressPool = defaultBackendAddressPool;
            DefaultBackendHttpSettings = defaultBackendHttpSettings;
            DefaultRedirectConfiguration = defaultRedirectConfiguration;
            PathRules = pathRules;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets default backend address pool resource of URL path map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultBackendAddressPool")]
        public Management.ResourceManager.Fluent.SubResource DefaultBackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets default backend http settings resource of URL path
        /// map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultBackendHttpSettings")]
        public Management.ResourceManager.Fluent.SubResource DefaultBackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets default redirect configuration resource of URL path
        /// map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultRedirectConfiguration")]
        public Management.ResourceManager.Fluent.SubResource DefaultRedirectConfiguration { get; set; }

        /// <summary>
        /// Gets or sets path rule of URL path map resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pathRules")]
        public IList<ApplicationGatewayPathRuleInner> PathRules { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
