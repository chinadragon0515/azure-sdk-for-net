// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties related to an event hub endpoint.
    /// </summary>
    public partial class RoutingEventHubProperties
    {
        /// <summary>
        /// Initializes a new instance of the RoutingEventHubProperties class.
        /// </summary>
        public RoutingEventHubProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoutingEventHubProperties class.
        /// </summary>
        /// <param name="connectionString">The connection string of the event
        /// hub endpoint. </param>
        /// <param name="name">The name that identifies this endpoint. The name
        /// can only include alphanumeric characters, periods, underscores,
        /// hyphens and has a maximum length of 64 characters. The following
        /// names are reserved:  events, operationsMonitoringEvents,
        /// fileNotifications, $default. Endpoint names must be unique across
        /// endpoint types.</param>
        /// <param name="subscriptionId">The subscription identifier of the
        /// event hub endpoint.</param>
        /// <param name="resourceGroup">The name of the resource group of the
        /// event hub endpoint.</param>
        public RoutingEventHubProperties(string connectionString, string name, string subscriptionId = default(string), string resourceGroup = default(string))
        {
            ConnectionString = connectionString;
            Name = name;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string of the event hub endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the name that identifies this endpoint. The name can
        /// only include alphanumeric characters, periods, underscores, hyphens
        /// and has a maximum length of 64 characters. The following names are
        /// reserved:  events, operationsMonitoringEvents, fileNotifications,
        /// $default. Endpoint names must be unique across endpoint types.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subscription identifier of the event hub endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group of the event hub
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[A-Za-z0-9-._]{1,64}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[A-Za-z0-9-._]{1,64}$");
                }
            }
        }
    }
}
