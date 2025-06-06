// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Databricks linked service. </summary>
    public partial class AzureDatabricksLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureDatabricksLinkedService"/>. </summary>
        /// <param name="domain"> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/> is null. </exception>
        public AzureDatabricksLinkedService(object domain)
        {
            Argument.AssertNotNull(domain, nameof(domain));

            Domain = domain;
            NewClusterSparkConf = new ChangeTrackingDictionary<string, object>();
            NewClusterSparkEnvVars = new ChangeTrackingDictionary<string, object>();
            NewClusterCustomTags = new ChangeTrackingDictionary<string, object>();
            Type = "AzureDatabricks";
        }

        /// <summary> Initializes a new instance of <see cref="AzureDatabricksLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="domain"> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </param>
        /// <param name="accessToken">
        /// Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string (or Expression with resultType string).
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="authentication"> Required to specify MSI, if using Workspace resource id for databricks REST API. Type: string (or Expression with resultType string). </param>
        /// <param name="workspaceResourceId"> Workspace resource id for databricks REST API. Type: string (or Expression with resultType string). </param>
        /// <param name="existingClusterId"> The id of an existing interactive cluster that will be used for all runs of this activity. Type: string (or Expression with resultType string). </param>
        /// <param name="instancePoolId"> The id of an existing instance pool that will be used for all runs of this activity. Type: string (or Expression with resultType string). </param>
        /// <param name="newClusterVersion"> If not using an existing interactive cluster, this specifies the Spark version of a new job cluster or instance pool nodes created for each run of this activity. Required if instancePoolId is specified. Type: string (or Expression with resultType string). </param>
        /// <param name="newClusterNumOfWorker"> If not using an existing interactive cluster, this specifies the number of worker nodes to use for the new job cluster or instance pool. For new job clusters, this a string-formatted Int32, like '1' means numOfWorker is 1 or '1:10' means auto-scale from 1 (min) to 10 (max). For instance pools, this is a string-formatted Int32, and can only specify a fixed number of worker nodes, such as '2'. Required if newClusterVersion is specified. Type: string (or Expression with resultType string). </param>
        /// <param name="newClusterNodeType"> The node type of the new job cluster. This property is required if newClusterVersion is specified and instancePoolId is not specified. If instancePoolId is specified, this property is ignored. Type: string (or Expression with resultType string). </param>
        /// <param name="newClusterSparkConf"> A set of optional, user-specified Spark configuration key-value pairs. </param>
        /// <param name="newClusterSparkEnvVars"> A set of optional, user-specified Spark environment variables key-value pairs. </param>
        /// <param name="newClusterCustomTags"> Additional tags for cluster resources. This property is ignored in instance pool configurations. </param>
        /// <param name="newClusterLogDestination"> Specify a location to deliver Spark driver, worker, and event logs. Type: string (or Expression with resultType string). </param>
        /// <param name="newClusterDriverNodeType"> The driver node type for the new job cluster. This property is ignored in instance pool configurations. Type: string (or Expression with resultType string). </param>
        /// <param name="newClusterInitScripts"> User-defined initialization scripts for the new cluster. Type: array of strings (or Expression with resultType array of strings). </param>
        /// <param name="newClusterEnableElasticDisk"> Enable the elastic disk on the new cluster. This property is now ignored, and takes the default elastic disk behavior in Databricks (elastic disks are always enabled). Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="policyId"> The policy id for limiting the ability to configure clusters based on a user defined set of rules. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDatabricksLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object domain, SecretBase accessToken, object authentication, object workspaceResourceId, object existingClusterId, object instancePoolId, object newClusterVersion, object newClusterNumOfWorker, object newClusterNodeType, IDictionary<string, object> newClusterSparkConf, IDictionary<string, object> newClusterSparkEnvVars, IDictionary<string, object> newClusterCustomTags, object newClusterLogDestination, object newClusterDriverNodeType, object newClusterInitScripts, object newClusterEnableElasticDisk, object encryptedCredential, object policyId, CredentialReference credential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Domain = domain;
            AccessToken = accessToken;
            Authentication = authentication;
            WorkspaceResourceId = workspaceResourceId;
            ExistingClusterId = existingClusterId;
            InstancePoolId = instancePoolId;
            NewClusterVersion = newClusterVersion;
            NewClusterNumOfWorker = newClusterNumOfWorker;
            NewClusterNodeType = newClusterNodeType;
            NewClusterSparkConf = newClusterSparkConf;
            NewClusterSparkEnvVars = newClusterSparkEnvVars;
            NewClusterCustomTags = newClusterCustomTags;
            NewClusterLogDestination = newClusterLogDestination;
            NewClusterDriverNodeType = newClusterDriverNodeType;
            NewClusterInitScripts = newClusterInitScripts;
            NewClusterEnableElasticDisk = newClusterEnableElasticDisk;
            EncryptedCredential = encryptedCredential;
            PolicyId = policyId;
            Credential = credential;
            Type = type ?? "AzureDatabricks";
        }

        /// <summary> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </summary>
        public object Domain { get; set; }
        /// <summary>
        /// Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string (or Expression with resultType string).
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase AccessToken { get; set; }
        /// <summary> Required to specify MSI, if using Workspace resource id for databricks REST API. Type: string (or Expression with resultType string). </summary>
        public object Authentication { get; set; }
        /// <summary> Workspace resource id for databricks REST API. Type: string (or Expression with resultType string). </summary>
        public object WorkspaceResourceId { get; set; }
        /// <summary> The id of an existing interactive cluster that will be used for all runs of this activity. Type: string (or Expression with resultType string). </summary>
        public object ExistingClusterId { get; set; }
        /// <summary> The id of an existing instance pool that will be used for all runs of this activity. Type: string (or Expression with resultType string). </summary>
        public object InstancePoolId { get; set; }
        /// <summary> If not using an existing interactive cluster, this specifies the Spark version of a new job cluster or instance pool nodes created for each run of this activity. Required if instancePoolId is specified. Type: string (or Expression with resultType string). </summary>
        public object NewClusterVersion { get; set; }
        /// <summary> If not using an existing interactive cluster, this specifies the number of worker nodes to use for the new job cluster or instance pool. For new job clusters, this a string-formatted Int32, like '1' means numOfWorker is 1 or '1:10' means auto-scale from 1 (min) to 10 (max). For instance pools, this is a string-formatted Int32, and can only specify a fixed number of worker nodes, such as '2'. Required if newClusterVersion is specified. Type: string (or Expression with resultType string). </summary>
        public object NewClusterNumOfWorker { get; set; }
        /// <summary> The node type of the new job cluster. This property is required if newClusterVersion is specified and instancePoolId is not specified. If instancePoolId is specified, this property is ignored. Type: string (or Expression with resultType string). </summary>
        public object NewClusterNodeType { get; set; }
        /// <summary> A set of optional, user-specified Spark configuration key-value pairs. </summary>
        public IDictionary<string, object> NewClusterSparkConf { get; }
        /// <summary> A set of optional, user-specified Spark environment variables key-value pairs. </summary>
        public IDictionary<string, object> NewClusterSparkEnvVars { get; }
        /// <summary> Additional tags for cluster resources. This property is ignored in instance pool configurations. </summary>
        public IDictionary<string, object> NewClusterCustomTags { get; }
        /// <summary> Specify a location to deliver Spark driver, worker, and event logs. Type: string (or Expression with resultType string). </summary>
        public object NewClusterLogDestination { get; set; }
        /// <summary> The driver node type for the new job cluster. This property is ignored in instance pool configurations. Type: string (or Expression with resultType string). </summary>
        public object NewClusterDriverNodeType { get; set; }
        /// <summary> User-defined initialization scripts for the new cluster. Type: array of strings (or Expression with resultType array of strings). </summary>
        public object NewClusterInitScripts { get; set; }
        /// <summary> Enable the elastic disk on the new cluster. This property is now ignored, and takes the default elastic disk behavior in Databricks (elastic disks are always enabled). Type: boolean (or Expression with resultType boolean). </summary>
        public object NewClusterEnableElasticDisk { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The policy id for limiting the ability to configure clusters based on a user defined set of rules. Type: string (or Expression with resultType string). </summary>
        public object PolicyId { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
