// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The deleted certificate item containing metadata about the deleted
    /// certificate.
    /// </summary>
    public partial class DeletedCertificateItem : CertificateItem
    {
        /// <summary>
        /// Initializes a new instance of the DeletedCertificateItem class.
        /// </summary>
        public DeletedCertificateItem() { }

        /// <summary>
        /// Initializes a new instance of the DeletedCertificateItem class.
        /// </summary>
        /// <param name="id">Certificate identifier.</param>
        /// <param name="attributes">The certificate management
        /// attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        /// <param name="x509Thumbprint">Thumbprint of the certificate.</param>
        /// <param name="recoveryId">The url of the recovery object, used to
        /// identify and recover the deleted certificate.</param>
        /// <param name="scheduledPurgeDate">The time when the certificate is
        /// scheduled to be purged, in UTC</param>
        /// <param name="deletedDate">The time when the certificate was
        /// deleted, in UTC</param>
        public DeletedCertificateItem(string id = default(string), CertificateAttributes attributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), byte[] x509Thumbprint = default(byte[]), string recoveryId = default(string), System.DateTime? scheduledPurgeDate = default(System.DateTime?), System.DateTime? deletedDate = default(System.DateTime?))
            : base(id, attributes, tags, x509Thumbprint)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
        }

        /// <summary>
        /// Gets or sets the url of the recovery object, used to identify and
        /// recover the deleted certificate.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryId")]
        public string RecoveryId { get; set; }

        /// <summary>
        /// Gets the time when the certificate is scheduled to be purged, in
        /// UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "scheduledPurgeDate")]
        public System.DateTime? ScheduledPurgeDate { get; protected set; }

        /// <summary>
        /// Gets the time when the certificate was deleted, in UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "deletedDate")]
        public System.DateTime? DeletedDate { get; protected set; }

    }
}

