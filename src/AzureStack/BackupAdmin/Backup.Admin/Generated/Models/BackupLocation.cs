// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Backup.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about the backup location.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupLocation : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BackupLocation class.
        /// </summary>
        public BackupLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupLocation class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location of the resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="path">Path to the update location</param>
        /// <param name="userName">Username to access the location.</param>
        /// <param name="password">Password to access the location.</param>
        /// <param name="encryptionKeyBase64">Encryption key.</param>
        /// <param name="backupFrequencyInHours">The interval, in hours, for
        /// the frequency that the scheduler takes a backup.</param>
        /// <param name="availableCapacity">Free space at the backup
        /// location.</param>
        /// <param name="isBackupSchedulerEnabled">True if the backup scheduler
        /// is enabled.</param>
        /// <param name="nextBackupTime">The scheduled time of the next
        /// backup.</param>
        /// <param name="lastBackupTime">Time of backup.</param>
        /// <param name="backupRetentionPeriodInDays">The retention period, in
        /// days, for backs in the storage location.</param>
        public BackupLocation(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string path = default(string), string userName = default(string), string password = default(string), string encryptionKeyBase64 = default(string), int? backupFrequencyInHours = default(int?), string availableCapacity = default(string), bool? isBackupSchedulerEnabled = default(bool?), string nextBackupTime = default(string), string lastBackupTime = default(string), int? backupRetentionPeriodInDays = default(int?))
            : base(id, name, type, location, tags)
        {
            Path = path;
            UserName = userName;
            Password = password;
            EncryptionKeyBase64 = encryptionKeyBase64;
            BackupFrequencyInHours = backupFrequencyInHours;
            AvailableCapacity = availableCapacity;
            IsBackupSchedulerEnabled = isBackupSchedulerEnabled;
            NextBackupTime = nextBackupTime;
            LastBackupTime = lastBackupTime;
            BackupRetentionPeriodInDays = backupRetentionPeriodInDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path to the update location
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets username to access the location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets password to access the location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets encryption key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.encryptionKeyBase64")]
        public string EncryptionKeyBase64 { get; set; }

        /// <summary>
        /// Gets or sets the interval, in hours, for the frequency that the
        /// scheduler takes a backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.backupFrequencyInHours")]
        public int? BackupFrequencyInHours { get; set; }

        /// <summary>
        /// Gets or sets free space at the backup location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.availableCapacity")]
        public string AvailableCapacity { get; set; }

        /// <summary>
        /// Gets or sets true if the backup scheduler is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.isBackupSchedulerEnabled")]
        public bool? IsBackupSchedulerEnabled { get; set; }

        /// <summary>
        /// Gets or sets the scheduled time of the next backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.nextBackupTime")]
        public string NextBackupTime { get; set; }

        /// <summary>
        /// Gets or sets time of backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.lastBackupTime")]
        public string LastBackupTime { get; set; }

        /// <summary>
        /// Gets or sets the retention period, in days, for backs in the
        /// storage location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalStoreDefault.backupRetentionPeriodInDays")]
        public int? BackupRetentionPeriodInDays { get; set; }

    }
}
