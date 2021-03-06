// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Part of MultiTenantDiagnosticSettings. Specifies the settings for a
    /// particular log.
    /// </summary>
    public partial class LogSettings
    {
        /// <summary>
        /// Initializes a new instance of the LogSettings class.
        /// </summary>
        public LogSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogSettings class.
        /// </summary>
        /// <param name="enabled">a value indicating whether this log is
        /// enabled.</param>
        /// <param name="category">Name of a Diagnostic Log category for a
        /// resource type this setting is applied to. To obtain the list of
        /// Diagnostic Log categories for a resource, first perform a GET
        /// diagnostic settings operation.</param>
        /// <param name="retentionPolicy">the retention policy for this
        /// log.</param>
        public LogSettings(bool enabled, string category = default(string), RetentionPolicy retentionPolicy = default(RetentionPolicy))
        {
            Category = category;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a Diagnostic Log category for a resource type
        /// this setting is applied to. To obtain the list of Diagnostic Log
        /// categories for a resource, first perform a GET diagnostic settings
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this log is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for this log.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
    }
}
