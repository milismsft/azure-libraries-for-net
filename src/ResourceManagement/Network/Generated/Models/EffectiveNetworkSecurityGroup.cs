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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Effective network security group.
    /// </summary>
    public partial class EffectiveNetworkSecurityGroup
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroup
        /// class.
        /// </summary>
        public EffectiveNetworkSecurityGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityGroup
        /// class.
        /// </summary>
        /// <param name="networkSecurityGroup">The ID of network security group
        /// that is applied.</param>
        /// <param name="association">Associated resources.</param>
        /// <param name="effectiveSecurityRules">A collection of effective
        /// security rules.</param>
        /// <param name="tagMap">Mapping of tags to list of IP Addresses
        /// included within the tag.</param>
        public EffectiveNetworkSecurityGroup(Management.ResourceManager.Fluent.SubResource networkSecurityGroup = default(Management.ResourceManager.Fluent.SubResource), EffectiveNetworkSecurityGroupAssociation association = default(EffectiveNetworkSecurityGroupAssociation), IList<EffectiveNetworkSecurityRule> effectiveSecurityRules = default(IList<EffectiveNetworkSecurityRule>), IDictionary<string, IList<string>> tagMap = default(IDictionary<string, IList<string>>))
        {
            NetworkSecurityGroup = networkSecurityGroup;
            Association = association;
            EffectiveSecurityRules = effectiveSecurityRules;
            TagMap = tagMap;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of network security group that is applied.
        /// </summary>
        [JsonProperty(PropertyName = "networkSecurityGroup")]
        public Management.ResourceManager.Fluent.SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets associated resources.
        /// </summary>
        [JsonProperty(PropertyName = "association")]
        public EffectiveNetworkSecurityGroupAssociation Association { get; set; }

        /// <summary>
        /// Gets or sets a collection of effective security rules.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveSecurityRules")]
        public IList<EffectiveNetworkSecurityRule> EffectiveSecurityRules { get; set; }

        /// <summary>
        /// Gets or sets mapping of tags to list of IP Addresses included
        /// within the tag.
        /// </summary>
        [JsonProperty(PropertyName = "tagMap")]
        public IDictionary<string, IList<string>> TagMap { get; set; }

    }
}
