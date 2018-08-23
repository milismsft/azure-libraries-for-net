// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Search;
    using Microsoft.Azure.Management.Search.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an Azure Search service and its current state.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SearchServiceInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SearchServiceInner class.
        /// </summary>
        public SearchServiceInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchServiceInner class.
        /// </summary>
        /// <param name="sku">The SKU of the Search Service, which determines
        /// price tier and capacity limits.</param>
        /// <param name="replicaCount">The number of replicas in the Search
        /// service. If specified, it must be a value between 1 and 12
        /// inclusive for standard SKUs or between 1 and 3 inclusive for basic
        /// SKU.</param>
        /// <param name="partitionCount">The number of partitions in the Search
        /// service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values
        /// greater than 1 are only valid for standard SKUs. For 'standard3'
        /// services with hostingMode set to 'highDensity', the allowed values
        /// are between 1 and 3.</param>
        /// <param name="hostingMode">Applicable only for the standard3 SKU.
        /// You can set this property to enable up to 3 high density partitions
        /// that allow up to 1000 indexes, which is much higher than the
        /// maximum indexes allowed for any other SKU. For the standard3 SKU,
        /// the value is either 'default' or 'highDensity'. For all other SKUs,
        /// this value must be 'default'. Possible values include: 'default',
        /// 'highDensity'</param>
        /// <param name="status">The status of the Search service. Possible
        /// values include: 'running': The Search service is running and no
        /// provisioning operations are underway. 'provisioning': The Search
        /// service is being provisioned or scaled up or down. 'deleting': The
        /// Search service is being deleted. 'degraded': The Search service is
        /// degraded. This can occur when the underlying search units are not
        /// healthy. The Search service is most likely operational, but
        /// performance might be slow and some requests might be dropped.
        /// 'disabled': The Search service is disabled. In this state, the
        /// service will reject all API requests. 'error': The Search service
        /// is in an error state. If your service is in the degraded, disabled,
        /// or error states, it means the Azure Search team is actively
        /// investigating the underlying issue. Dedicated services in these
        /// states are still chargeable based on the number of search units
        /// provisioned. Possible values include: 'running', 'provisioning',
        /// 'deleting', 'degraded', 'disabled', 'error'</param>
        /// <param name="statusDetails">The details of the Search service
        /// status.</param>
        /// <param name="provisioningState">The state of the last provisioning
        /// operation performed on the Search service. Provisioning is an
        /// intermediate state that occurs while service capacity is being
        /// established. After capacity is set up, provisioningState changes to
        /// either 'succeeded' or 'failed'. Client applications can poll
        /// provisioning status (the recommended polling interval is from 30
        /// seconds to one minute) by using the Get Search Service operation to
        /// see when an operation is completed. If you are using the free
        /// service, this value tends to come back as 'succeeded' directly in
        /// the call to Create Search service. This is because the free service
        /// uses capacity that is already set up. Possible values include:
        /// 'succeeded', 'provisioning', 'failed'</param>
        public SearchServiceInner(Sku sku, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), int? replicaCount = default(int?), int? partitionCount = default(int?), HostingMode? hostingMode = default(HostingMode?), SearchServiceStatus? status = default(SearchServiceStatus?), string statusDetails = default(string), ProvisioningState? provisioningState = default(ProvisioningState?))
            : base(location, id, name, type, tags)
        {
            ReplicaCount = replicaCount;
            PartitionCount = partitionCount;
            HostingMode = hostingMode;
            Status = status;
            StatusDetails = statusDetails;
            ProvisioningState = provisioningState;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of replicas in the Search service. If
        /// specified, it must be a value between 1 and 12 inclusive for
        /// standard SKUs or between 1 and 3 inclusive for basic SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicaCount")]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Gets or sets the number of partitions in the Search service; if
        /// specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1
        /// are only valid for standard SKUs. For 'standard3' services with
        /// hostingMode set to 'highDensity', the allowed values are between 1
        /// and 3.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionCount")]
        public int? PartitionCount { get; set; }

        /// <summary>
        /// Gets or sets applicable only for the standard3 SKU. You can set
        /// this property to enable up to 3 high density partitions that allow
        /// up to 1000 indexes, which is much higher than the maximum indexes
        /// allowed for any other SKU. For the standard3 SKU, the value is
        /// either 'default' or 'highDensity'. For all other SKUs, this value
        /// must be 'default'. Possible values include: 'default',
        /// 'highDensity'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingMode")]
        public HostingMode? HostingMode { get; set; }

        /// <summary>
        /// Gets the status of the Search service. Possible values include:
        /// 'running': The Search service is running and no provisioning
        /// operations are underway. 'provisioning': The Search service is
        /// being provisioned or scaled up or down. 'deleting': The Search
        /// service is being deleted. 'degraded': The Search service is
        /// degraded. This can occur when the underlying search units are not
        /// healthy. The Search service is most likely operational, but
        /// performance might be slow and some requests might be dropped.
        /// 'disabled': The Search service is disabled. In this state, the
        /// service will reject all API requests. 'error': The Search service
        /// is in an error state. If your service is in the degraded, disabled,
        /// or error states, it means the Azure Search team is actively
        /// investigating the underlying issue. Dedicated services in these
        /// states are still chargeable based on the number of search units
        /// provisioned. Possible values include: 'running', 'provisioning',
        /// 'deleting', 'degraded', 'disabled', 'error'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public SearchServiceStatus? Status { get; private set; }

        /// <summary>
        /// Gets the details of the Search service status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusDetails")]
        public string StatusDetails { get; private set; }

        /// <summary>
        /// Gets the state of the last provisioning operation performed on the
        /// Search service. Provisioning is an intermediate state that occurs
        /// while service capacity is being established. After capacity is set
        /// up, provisioningState changes to either 'succeeded' or 'failed'.
        /// Client applications can poll provisioning status (the recommended
        /// polling interval is from 30 seconds to one minute) by using the Get
        /// Search Service operation to see when an operation is completed. If
        /// you are using the free service, this value tends to come back as
        /// 'succeeded' directly in the call to Create Search service. This is
        /// because the free service uses capacity that is already set up.
        /// Possible values include: 'succeeded', 'provisioning', 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the SKU of the Search Service, which determines price
        /// tier and capacity limits.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (ReplicaCount > 12)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ReplicaCount", 12);
            }
            if (ReplicaCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ReplicaCount", 1);
            }
            if (PartitionCount > 12)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PartitionCount", 12);
            }
            if (PartitionCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PartitionCount", 1);
            }
        }
    }
}
