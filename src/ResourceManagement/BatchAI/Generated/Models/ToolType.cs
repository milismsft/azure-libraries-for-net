// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ToolType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ToolType>))]
    public class ToolType : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ToolType>
    {
        public static readonly ToolType Cntk = Parse("cntk");
        public static readonly ToolType Tensorflow = Parse("tensorflow");
        public static readonly ToolType Caffe = Parse("caffe");
        public static readonly ToolType Caffe2 = Parse("caffe2");
        public static readonly ToolType Chainer = Parse("chainer");
        public static readonly ToolType Horovod = Parse("horovod");
        public static readonly ToolType Mpi = Parse("mpi");
        public static readonly ToolType Custom = Parse("custom");
    }
}
