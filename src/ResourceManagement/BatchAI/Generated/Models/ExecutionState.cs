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
    /// Defines values for ExecutionState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ExecutionState>))]
    public class ExecutionState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ExecutionState>
    {
        public static readonly ExecutionState Queued = Parse("queued");
        public static readonly ExecutionState Running = Parse("running");
        public static readonly ExecutionState Terminating = Parse("terminating");
        public static readonly ExecutionState Succeeded = Parse("succeeded");
        public static readonly ExecutionState Failed = Parse("failed");
    }
}
