// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Fluent.Models
{
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Defines values for StoragePermissions.
    /// </summary>
    public class StoragePermissions : ExpandableStringEnum<StoragePermissions>
    {
        public static readonly StoragePermissions All = Parse("all");
        public static readonly StoragePermissions Get = Parse("get");
        public static readonly StoragePermissions List = Parse("list");
        public static readonly StoragePermissions Delete = Parse("delete");
        public static readonly StoragePermissions Set = Parse("set");
        public static readonly StoragePermissions Update = Parse("update");
        public static readonly StoragePermissions Regeneratekey = Parse("regeneratekey");
        public static readonly StoragePermissions Setsas = Parse("setsas");
        public static readonly StoragePermissions Listsas = Parse("listsas");
        public static readonly StoragePermissions Getsas = Parse("getsas");
        public static readonly StoragePermissions Deletesas = Parse("deletesas");
    }
}
