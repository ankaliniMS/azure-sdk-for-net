// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// ApiManagement Client
    /// </summary>
    public partial class ApiManagementClient : ServiceClient<ApiManagementClient>, IApiManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Version of the API to be used with the client request.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IPolicyOperations.
        /// </summary>
        public virtual IPolicyOperations Policy { get; private set; }

        /// <summary>
        /// Gets the IPolicySnippetsOperations.
        /// </summary>
        public virtual IPolicySnippetsOperations PolicySnippets { get; private set; }

        /// <summary>
        /// Gets the IRegionsOperations.
        /// </summary>
        public virtual IRegionsOperations Regions { get; private set; }

        /// <summary>
        /// Gets the IApiOperations.
        /// </summary>
        public virtual IApiOperations Api { get; private set; }

        /// <summary>
        /// Gets the IApiOperationOperations.
        /// </summary>
        public virtual IApiOperationOperations ApiOperation { get; private set; }

        /// <summary>
        /// Gets the IApiOperationPolicyOperations.
        /// </summary>
        public virtual IApiOperationPolicyOperations ApiOperationPolicy { get; private set; }

        /// <summary>
        /// Gets the IApiProductOperations.
        /// </summary>
        public virtual IApiProductOperations ApiProduct { get; private set; }

        /// <summary>
        /// Gets the IApiPolicyOperations.
        /// </summary>
        public virtual IApiPolicyOperations ApiPolicy { get; private set; }

        /// <summary>
        /// Gets the IAuthorizationServerOperations.
        /// </summary>
        public virtual IAuthorizationServerOperations AuthorizationServer { get; private set; }

        /// <summary>
        /// Gets the IBackendOperations.
        /// </summary>
        public virtual IBackendOperations Backend { get; private set; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        public virtual ICertificateOperations Certificate { get; private set; }

        /// <summary>
        /// Gets the IApiManagementOperations.
        /// </summary>
        public virtual IApiManagementOperations ApiManagementOperations { get; private set; }

        /// <summary>
        /// Gets the IApiManagementServiceOperations.
        /// </summary>
        public virtual IApiManagementServiceOperations ApiManagementService { get; private set; }

        /// <summary>
        /// Gets the IEmailTemplateOperations.
        /// </summary>
        public virtual IEmailTemplateOperations EmailTemplate { get; private set; }

        /// <summary>
        /// Gets the IGroupOperations.
        /// </summary>
        public virtual IGroupOperations Group { get; private set; }

        /// <summary>
        /// Gets the IGroupUserOperations.
        /// </summary>
        public virtual IGroupUserOperations GroupUser { get; private set; }

        /// <summary>
        /// Gets the IIdentityProviderOperations.
        /// </summary>
        public virtual IIdentityProviderOperations IdentityProvider { get; private set; }

        /// <summary>
        /// Gets the ILoggerOperations.
        /// </summary>
        public virtual ILoggerOperations Logger { get; private set; }

        /// <summary>
        /// Gets the INetworkStatusOperations.
        /// </summary>
        public virtual INetworkStatusOperations NetworkStatus { get; private set; }

        /// <summary>
        /// Gets the IOpenIdConnectProviderOperations.
        /// </summary>
        public virtual IOpenIdConnectProviderOperations OpenIdConnectProvider { get; private set; }

        /// <summary>
        /// Gets the IProductOperations.
        /// </summary>
        public virtual IProductOperations Product { get; private set; }

        /// <summary>
        /// Gets the IProductApiOperations.
        /// </summary>
        public virtual IProductApiOperations ProductApi { get; private set; }

        /// <summary>
        /// Gets the IProductGroupOperations.
        /// </summary>
        public virtual IProductGroupOperations ProductGroup { get; private set; }

        /// <summary>
        /// Gets the IProductSubscriptionsOperations.
        /// </summary>
        public virtual IProductSubscriptionsOperations ProductSubscriptions { get; private set; }

        /// <summary>
        /// Gets the IProductPolicyOperations.
        /// </summary>
        public virtual IProductPolicyOperations ProductPolicy { get; private set; }

        /// <summary>
        /// Gets the IPropertyOperations.
        /// </summary>
        public virtual IPropertyOperations Property { get; private set; }

        /// <summary>
        /// Gets the IQuotaByCounterKeysOperations.
        /// </summary>
        public virtual IQuotaByCounterKeysOperations QuotaByCounterKeys { get; private set; }

        /// <summary>
        /// Gets the IQuotaByPeriodKeysOperations.
        /// </summary>
        public virtual IQuotaByPeriodKeysOperations QuotaByPeriodKeys { get; private set; }

        /// <summary>
        /// Gets the IReportsOperations.
        /// </summary>
        public virtual IReportsOperations Reports { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionOperations.
        /// </summary>
        public virtual ISubscriptionOperations Subscription { get; private set; }

        /// <summary>
        /// Gets the ITenantAccessOperations.
        /// </summary>
        public virtual ITenantAccessOperations TenantAccess { get; private set; }

        /// <summary>
        /// Gets the ITenantAccessGitOperations.
        /// </summary>
        public virtual ITenantAccessGitOperations TenantAccessGit { get; private set; }

        /// <summary>
        /// Gets the ITenantConfigurationOperations.
        /// </summary>
        public virtual ITenantConfigurationOperations TenantConfiguration { get; private set; }

        /// <summary>
        /// Gets the IUserOperations.
        /// </summary>
        public virtual IUserOperations User { get; private set; }

        /// <summary>
        /// Gets the IUserGroupOperations.
        /// </summary>
        public virtual IUserGroupOperations UserGroup { get; private set; }

        /// <summary>
        /// Gets the IUserSubscriptionOperations.
        /// </summary>
        public virtual IUserSubscriptionOperations UserSubscription { get; private set; }

        /// <summary>
        /// Gets the IUserIdentitiesOperations.
        /// </summary>
        public virtual IUserIdentitiesOperations UserIdentities { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ApiManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ApiManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected ApiManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected ApiManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ApiManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Policy = new PolicyOperations(this);
            PolicySnippets = new PolicySnippetsOperations(this);
            Regions = new RegionsOperations(this);
            Api = new ApiOperations(this);
            ApiOperation = new ApiOperationOperations(this);
            ApiOperationPolicy = new ApiOperationPolicyOperations(this);
            ApiProduct = new ApiProductOperations(this);
            ApiPolicy = new ApiPolicyOperations(this);
            AuthorizationServer = new AuthorizationServerOperations(this);
            Backend = new BackendOperations(this);
            Certificate = new CertificateOperations(this);
            ApiManagementOperations = new ApiManagementOperations(this);
            ApiManagementService = new ApiManagementServiceOperations(this);
            EmailTemplate = new EmailTemplateOperations(this);
            Group = new GroupOperations(this);
            GroupUser = new GroupUserOperations(this);
            IdentityProvider = new IdentityProviderOperations(this);
            Logger = new LoggerOperations(this);
            NetworkStatus = new NetworkStatusOperations(this);
            OpenIdConnectProvider = new OpenIdConnectProviderOperations(this);
            Product = new ProductOperations(this);
            ProductApi = new ProductApiOperations(this);
            ProductGroup = new ProductGroupOperations(this);
            ProductSubscriptions = new ProductSubscriptionsOperations(this);
            ProductPolicy = new ProductPolicyOperations(this);
            Property = new PropertyOperations(this);
            QuotaByCounterKeys = new QuotaByCounterKeysOperations(this);
            QuotaByPeriodKeys = new QuotaByPeriodKeysOperations(this);
            Reports = new ReportsOperations(this);
            Subscription = new SubscriptionOperations(this);
            TenantAccess = new TenantAccessOperations(this);
            TenantAccessGit = new TenantAccessGitOperations(this);
            TenantConfiguration = new TenantConfigurationOperations(this);
            User = new UserOperations(this);
            UserGroup = new UserGroupOperations(this);
            UserSubscription = new UserSubscriptionOperations(this);
            UserIdentities = new UserIdentitiesOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2017-03-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
