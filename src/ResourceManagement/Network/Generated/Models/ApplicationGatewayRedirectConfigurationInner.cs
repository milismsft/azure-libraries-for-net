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
    /// Redirect configuration of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayRedirectConfigurationInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRedirectConfigurationInner class.
        /// </summary>
        public ApplicationGatewayRedirectConfigurationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRedirectConfigurationInner class.
        /// </summary>
        /// <param name="redirectType">Supported http redirection types -
        /// Permanent, Temporary, Found, SeeOther. Possible values include:
        /// 'Permanent', 'Found', 'SeeOther', 'Temporary'</param>
        /// <param name="targetListener">Reference to a listener to redirect
        /// the request to.</param>
        /// <param name="targetUrl">Url to redirect the request to.</param>
        /// <param name="includePath">Include path in the redirected
        /// url.</param>
        /// <param name="includeQueryString">Include query string in the
        /// redirected url.</param>
        /// <param name="requestRoutingRules">Request routing specifying
        /// redirect configuration.</param>
        /// <param name="urlPathMaps">Url path maps specifying default redirect
        /// configuration.</param>
        /// <param name="pathRules">Path rules specifying redirect
        /// configuration.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayRedirectConfigurationInner(string id = default(string), ApplicationGatewayRedirectType redirectType = default(ApplicationGatewayRedirectType), Management.ResourceManager.Fluent.SubResource targetListener = default(Management.ResourceManager.Fluent.SubResource), string targetUrl = default(string), bool? includePath = default(bool?), bool? includeQueryString = default(bool?), IList<Management.ResourceManager.Fluent.SubResource> requestRoutingRules = default(IList<Management.ResourceManager.Fluent.SubResource>), IList<Management.ResourceManager.Fluent.SubResource> urlPathMaps = default(IList<Management.ResourceManager.Fluent.SubResource>), IList<Management.ResourceManager.Fluent.SubResource> pathRules = default(IList<Management.ResourceManager.Fluent.SubResource>), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            RedirectType = redirectType;
            TargetListener = targetListener;
            TargetUrl = targetUrl;
            IncludePath = includePath;
            IncludeQueryString = includeQueryString;
            RequestRoutingRules = requestRoutingRules;
            UrlPathMaps = urlPathMaps;
            PathRules = pathRules;
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
        /// Gets or sets supported http redirection types - Permanent,
        /// Temporary, Found, SeeOther. Possible values include: 'Permanent',
        /// 'Found', 'SeeOther', 'Temporary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectType")]
        public ApplicationGatewayRedirectType RedirectType { get; set; }

        /// <summary>
        /// Gets or sets reference to a listener to redirect the request to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetListener")]
        public Management.ResourceManager.Fluent.SubResource TargetListener { get; set; }

        /// <summary>
        /// Gets or sets url to redirect the request to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetUrl")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Gets or sets include path in the redirected url.
        /// </summary>
        [JsonProperty(PropertyName = "properties.includePath")]
        public bool? IncludePath { get; set; }

        /// <summary>
        /// Gets or sets include query string in the redirected url.
        /// </summary>
        [JsonProperty(PropertyName = "properties.includeQueryString")]
        public bool? IncludeQueryString { get; set; }

        /// <summary>
        /// Gets or sets request routing specifying redirect configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestRoutingRules")]
        public IList<Management.ResourceManager.Fluent.SubResource> RequestRoutingRules { get; set; }

        /// <summary>
        /// Gets or sets url path maps specifying default redirect
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMaps")]
        public IList<Management.ResourceManager.Fluent.SubResource> UrlPathMaps { get; set; }

        /// <summary>
        /// Gets or sets path rules specifying redirect configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pathRules")]
        public IList<Management.ResourceManager.Fluent.SubResource> PathRules { get; set; }

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
