// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Effective network security rules.
    /// </summary>
    public partial class EffectiveNetworkSecurityRule
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityRule
        /// class.
        /// </summary>
        public EffectiveNetworkSecurityRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityRule
        /// class.
        /// </summary>
        /// <param name="name">The name of the security rule specified by the
        /// user (if created by the user).</param>
        /// <param name="protocol">The network protocol this rule applies to.
        /// Possible values are: 'Tcp', 'Udp', and 'All'. Possible values
        /// include: 'Tcp', 'Udp', 'All'</param>
        /// <param name="sourcePortRange">The source port or range.</param>
        /// <param name="destinationPortRange">The destination port or
        /// range.</param>
        /// <param name="sourcePortRanges">The source port ranges. Expected
        /// values include a single integer between 0 and 65535, a range using
        /// '-' as seperator (e.g. 100-400), or an asterix (*)</param>
        /// <param name="destinationPortRanges">The destination port ranges.
        /// Expected values include a single integer between 0 and 65535, a
        /// range using '-' as seperator (e.g. 100-400), or an asterix
        /// (*)</param>
        /// <param name="sourceAddressPrefix">The source address
        /// prefix.</param>
        /// <param name="destinationAddressPrefix">The destination address
        /// prefix.</param>
        /// <param name="sourceAddressPrefixes">The source address prefixes.
        /// Expected values include CIDR IP ranges, Default Tags
        /// (VirtualNetwork, AureLoadBalancer, Internet), System Tags, and the
        /// asterix (*).</param>
        /// <param name="destinationAddressPrefixes">The destination address
        /// prefixes. Expected values include CIDR IP ranges, Default Tags
        /// (VirtualNetwork, AureLoadBalancer, Internet), System Tags, and the
        /// asterix (*).</param>
        /// <param name="expandedSourceAddressPrefix">The expanded source
        /// address prefix.</param>
        /// <param name="expandedDestinationAddressPrefix">Expanded destination
        /// address prefix.</param>
        /// <param name="access">Whether network traffic is allowed or denied.
        /// Possible values are: 'Allow' and 'Deny'. Possible values include:
        /// 'Allow', 'Deny'</param>
        /// <param name="priority">The priority of the rule.</param>
        /// <param name="direction">The direction of the rule. Possible values
        /// are: 'Inbound and Outbound'. Possible values include: 'Inbound',
        /// 'Outbound'</param>
        public EffectiveNetworkSecurityRule(string name = default(string), EffectiveSecurityRuleProtocol protocol = default(EffectiveSecurityRuleProtocol), string sourcePortRange = default(string), string destinationPortRange = default(string), IList<string> sourcePortRanges = default(IList<string>), IList<string> destinationPortRanges = default(IList<string>), string sourceAddressPrefix = default(string), string destinationAddressPrefix = default(string), IList<string> sourceAddressPrefixes = default(IList<string>), IList<string> destinationAddressPrefixes = default(IList<string>), IList<string> expandedSourceAddressPrefix = default(IList<string>), IList<string> expandedDestinationAddressPrefix = default(IList<string>), SecurityRuleAccess access = default(SecurityRuleAccess), int? priority = default(int?), SecurityRuleDirection direction = default(SecurityRuleDirection))
        {
            Name = name;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            ExpandedSourceAddressPrefix = expandedSourceAddressPrefix;
            ExpandedDestinationAddressPrefix = expandedDestinationAddressPrefix;
            Access = access;
            Priority = priority;
            Direction = direction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the security rule specified by the user
        /// (if created by the user).
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the network protocol this rule applies to. Possible
        /// values are: 'Tcp', 'Udp', and 'All'. Possible values include:
        /// 'Tcp', 'Udp', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public EffectiveSecurityRuleProtocol Protocol { get; set; }

        /// <summary>
        /// Gets or sets the source port or range.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePortRange")]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// Gets or sets the destination port or range.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPortRange")]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Gets or sets the source port ranges. Expected values include a
        /// single integer between 0 and 65535, a range using '-' as seperator
        /// (e.g. 100-400), or an asterix (*)
        /// </summary>
        [JsonProperty(PropertyName = "sourcePortRanges")]
        public IList<string> SourcePortRanges { get; set; }

        /// <summary>
        /// Gets or sets the destination port ranges. Expected values include a
        /// single integer between 0 and 65535, a range using '-' as seperator
        /// (e.g. 100-400), or an asterix (*)
        /// </summary>
        [JsonProperty(PropertyName = "destinationPortRanges")]
        public IList<string> DestinationPortRanges { get; set; }

        /// <summary>
        /// Gets or sets the source address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the destination address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddressPrefix")]
        public string DestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the source address prefixes. Expected values include
        /// CIDR IP ranges, Default Tags (VirtualNetwork, AureLoadBalancer,
        /// Internet), System Tags, and the asterix (*).
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddressPrefixes")]
        public IList<string> SourceAddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets the destination address prefixes. Expected values
        /// include CIDR IP ranges, Default Tags (VirtualNetwork,
        /// AureLoadBalancer, Internet), System Tags, and the asterix (*).
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddressPrefixes")]
        public IList<string> DestinationAddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets the expanded source address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "expandedSourceAddressPrefix")]
        public IList<string> ExpandedSourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets expanded destination address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "expandedDestinationAddressPrefix")]
        public IList<string> ExpandedDestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets whether network traffic is allowed or denied. Possible
        /// values are: 'Allow' and 'Deny'. Possible values include: 'Allow',
        /// 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public SecurityRuleAccess Access { get; set; }

        /// <summary>
        /// Gets or sets the priority of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the direction of the rule. Possible values are:
        /// 'Inbound and Outbound'. Possible values include: 'Inbound',
        /// 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public SecurityRuleDirection Direction { get; set; }

    }
}
