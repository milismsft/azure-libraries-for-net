// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB database account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseAccountInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseAccountInner class.
        /// </summary>
        public DatabaseAccountInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseAccountInner class.
        /// </summary>
        /// <param name="kind">Indicates the type of database account. This can
        /// only be set at database account creation. Possible values include:
        /// 'GlobalDocumentDB', 'MongoDB', 'Parse'</param>
        /// <param name="documentEndpoint">The connection endpoint for the
        /// Cosmos DB database account.</param>
        /// <param name="databaseAccountOfferType">The offer type for the
        /// Cosmos DB database account. Default value: Standard. Possible
        /// values include: 'Standard'</param>
        /// <param name="ipRangeFilter">Cosmos DB Firewall Support: This value
        /// specifies the set of IP addresses or IP address ranges in CIDR form
        /// to be included as the allowed list of client IPs for a given
        /// database account. IP addresses/ranges must be comma separated and
        /// must not contain any spaces.</param>
        /// <param name="enableAutomaticFailover">Enables automatic failover of
        /// the write region in the rare event that the region is unavailable
        /// due to an outage. Automatic failover will result in a new write
        /// region for the account and is chosen based on the failover
        /// priorities configured for the account.</param>
        /// <param name="consistencyPolicy">The consistency policy for the
        /// Cosmos DB database account.</param>
        /// <param name="capabilities">List of Cosmos DB capabilities for the
        /// account</param>
        /// <param name="writeLocations">An array that contains the write
        /// location for the Cosmos DB account.</param>
        /// <param name="readLocations">An array that contains of the read
        /// locations enabled for the Cosmos DB account.</param>
        /// <param name="failoverPolicies">An array that contains the regions
        /// ordered by their failover priorities.</param>
        public DatabaseAccountInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string provisioningState = default(string), string documentEndpoint = default(string), DatabaseAccountOfferType? databaseAccountOfferType = default(DatabaseAccountOfferType?), string ipRangeFilter = default(string), bool? enableAutomaticFailover = default(bool?), ConsistencyPolicy consistencyPolicy = default(ConsistencyPolicy), IList<Capability> capabilities = default(IList<Capability>), IList<Location> writeLocations = default(IList<Location>), IList<Location> readLocations = default(IList<Location>), IList<FailoverPolicyInner> failoverPolicies = default(IList<FailoverPolicyInner>))
            : base(location, id, name, type, tags)
        {
            Kind = kind;
            ProvisioningState = provisioningState;
            DocumentEndpoint = documentEndpoint;
            DatabaseAccountOfferType = databaseAccountOfferType;
            IpRangeFilter = ipRangeFilter;
            EnableAutomaticFailover = enableAutomaticFailover;
            ConsistencyPolicy = consistencyPolicy;
            Capabilities = capabilities;
            WriteLocations = writeLocations;
            ReadLocations = readLocations;
            FailoverPolicies = failoverPolicies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the type of database account. This can only
        /// be set at database account creation. Possible values include:
        /// 'GlobalDocumentDB', 'MongoDB', 'Parse'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the connection endpoint for the Cosmos DB database account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.documentEndpoint")]
        public string DocumentEndpoint { get; private set; }

        /// <summary>
        /// Gets the offer type for the Cosmos DB database account. Default
        /// value: Standard. Possible values include: 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseAccountOfferType")]
        public DatabaseAccountOfferType? DatabaseAccountOfferType { get; private set; }

        /// <summary>
        /// Gets or sets cosmos DB Firewall Support: This value specifies the
        /// set of IP addresses or IP address ranges in CIDR form to be
        /// included as the allowed list of client IPs for a given database
        /// account. IP addresses/ranges must be comma separated and must not
        /// contain any spaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipRangeFilter")]
        public string IpRangeFilter { get; set; }

        /// <summary>
        /// Gets or sets enables automatic failover of the write region in the
        /// rare event that the region is unavailable due to an outage.
        /// Automatic failover will result in a new write region for the
        /// account and is chosen based on the failover priorities configured
        /// for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAutomaticFailover")]
        public bool? EnableAutomaticFailover { get; set; }

        /// <summary>
        /// Gets or sets the consistency policy for the Cosmos DB database
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consistencyPolicy")]
        public ConsistencyPolicy ConsistencyPolicy { get; set; }

        /// <summary>
        /// Gets or sets list of Cosmos DB capabilities for the account
        /// </summary>
        [JsonProperty(PropertyName = "properties.capabilities")]
        public IList<Capability> Capabilities { get; set; }

        /// <summary>
        /// Gets an array that contains the write location for the Cosmos DB
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.writeLocations")]
        public IList<Location> WriteLocations { get; private set; }

        /// <summary>
        /// Gets an array that contains of the read locations enabled for the
        /// Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readLocations")]
        public IList<Location> ReadLocations { get; private set; }

        /// <summary>
        /// Gets an array that contains the regions ordered by their failover
        /// priorities.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverPolicies")]
        public IList<FailoverPolicyInner> FailoverPolicies { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConsistencyPolicy != null)
            {
                ConsistencyPolicy.Validate();
            }
            if (WriteLocations != null)
            {
                foreach (var element in WriteLocations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ReadLocations != null)
            {
                foreach (var element1 in ReadLocations)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (FailoverPolicies != null)
            {
                foreach (var element2 in FailoverPolicies)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
