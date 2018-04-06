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
    /// Defines values for ServiceProviderProvisioningState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    public class ServiceProviderProvisioningState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ServiceProviderProvisioningState>
    {
        public static readonly ServiceProviderProvisioningState NotProvisioned = Parse("NotProvisioned");
        public static readonly ServiceProviderProvisioningState Provisioning = Parse("Provisioning");
        public static readonly ServiceProviderProvisioningState Provisioned = Parse("Provisioned");
        public static readonly ServiceProviderProvisioningState Deprovisioning = Parse("Deprovisioning");
    }
}
