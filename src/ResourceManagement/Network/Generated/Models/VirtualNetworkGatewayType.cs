// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// Defines values for VirtualNetworkGatewayType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    public class VirtualNetworkGatewayType : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<VirtualNetworkGatewayType>
    {
        public static readonly VirtualNetworkGatewayType Vpn = Parse("Vpn");
        public static readonly VirtualNetworkGatewayType ExpressRoute = Parse("ExpressRoute");
    }
}
