// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Microsoft.Azure.Management.EventHub.Fluent.Models
{

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    public class SkuName : ExpandableStringEnum<SkuName>
    {
        public static readonly SkuName Basic = Parse("Basic");
        public static readonly SkuName Standard = Parse("Standard");
    }
}
