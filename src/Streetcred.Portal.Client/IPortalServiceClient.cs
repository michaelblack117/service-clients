// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IPortalServiceClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Upload image
        /// </summary>
        /// <remarks>
        /// Upload an image and return a URL with the static remote location
        /// </remarks>
        /// <param name='uploadedFiles'>
        /// The uploaded files.
        /// </param>
        /// <param name='filename'>
        /// The filename.
        /// </param>
        /// <param name='contentType'>
        /// (Optional) Type of the image content.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> UploadImageWithHttpMessagesAsync(Stream uploadedFiles = default(Stream), string filename = default(string), string contentType = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List available ledger networks
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<NetworkInfo>>> GetNetworksWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the connections.
        /// </summary>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ConnectionInfo>>> GetConnectionsWithHttpMessagesAsync(string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the invitations.
        /// </summary>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ConnectionInfo>>> GetInvitationsWithHttpMessagesAsync(string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Sends the email invitation.
        /// </summary>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='createInvitation'>
        /// The create invitation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ObjectId>> CreateInvitationMethodWithHttpMessagesAsync(string xStreetcredTenantId, CreateInvitation createInvitation = default(CreateInvitation), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the connections.
        /// </summary>
        /// <param name='connectionId'>
        /// The connection identifier.
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ConnectionInfo>> GetConnectionWithHttpMessagesAsync(string connectionId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists the credentials.
        /// </summary>
        /// <param name='definitionId'>
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<CredentialInfo>>> ListCredentialsWithHttpMessagesAsync(string definitionId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <param name='credentialId'>
        /// The credential identifier.
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CredentialInfo>> GetCredentialWithHttpMessagesAsync(string credentialId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revokes a credential.
        /// </summary>
        /// <remarks>
        /// Revoke credential that was issued previously. Process of revocation
        /// will update the revocation
        /// registry locally and on the ledger. Issued credentials can still
        /// participate in proof workflows
        /// and be considered valid, but only if the verifying ignores the
        /// revocation trail.
        /// </remarks>
        /// <param name='credentialId'>
        /// Credential identifier.
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> RevokeCredentialWithHttpMessagesAsync(string credentialId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Sends credential offer of the specified DefinitionId to the
        /// specified ConnectionId
        /// </summary>
        /// <remarks>
        /// Sends credential offer of the specified DefinitionId to the
        /// specified ConnectionId
        /// </remarks>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='sendOffer'>
        /// The definition and connection to which this offer will be sent.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> SendOfferMethodWithHttpMessagesAsync(string xStreetcredTenantId, SendOffer sendOffer = default(SendOffer), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Issues the credential.
        /// </summary>
        /// <param name='credentialId'>
        /// The credential identifier.
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='values'>
        /// The values.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> IssueCredentialWithHttpMessagesAsync(string credentialId, string xStreetcredTenantId, IDictionary<string, string> values = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Approves the request.
        /// </summary>
        /// <param name='credentialId'>
        /// Credential identifier.
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApproveRequestWithHttpMessagesAsync(string credentialId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reject credential request.
        /// </summary>
        /// <param name='credentialId'>
        /// Credential identifier.
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> RejectRequestWithHttpMessagesAsync(string credentialId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the definitions.
        /// </summary>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<DefinitionInfo>>> GetDefinitionsWithHttpMessagesAsync(string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new credential definition.
        /// </summary>
        /// <remarks>
        /// Create new credential definition for a given schema. If schema
        /// already exists on the ledger
        /// specify the 'schema_id' - 'name', 'version' and 'attr_names' will
        /// be ignored.
        /// If schema doesn't exist, you must specify 'name', 'version' and
        /// 'attr_names'
        /// - schema_id will be ignored and generated automatically.
        /// </remarks>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='definition'>
        /// Definition.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ObjectId>> CreateDefinitionMethodWithHttpMessagesAsync(string xStreetcredTenantId, CreateDefinition definition = default(CreateDefinition), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the definitions.
        /// </summary>
        /// <param name='definitionId'>
        /// </param>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<DefinitionInfo>> GetDefinitionWithHttpMessagesAsync(string definitionId, string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the schemas.
        /// </summary>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<SchemaRecord>>> GetSchemasWithHttpMessagesAsync(string xStreetcredTenantId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Register new schema
        /// </summary>
        /// <remarks>
        /// Register schema with the current agency tenant and write the schema
        /// to the ledger using the tenant as issuer.
        /// </remarks>
        /// <param name='xStreetcredTenantId'>
        /// Identifier of the tenant used with this request.
        /// </param>
        /// <param name='schema'>
        /// Schema details
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> RegisterSchemaWithHttpMessagesAsync(string xStreetcredTenantId, Schema schema = default(Schema), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List available tenants
        /// </summary>
        /// <remarks>
        /// Get a collection of available tenants for the current authorization
        /// context.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<TenantInfo>>> ListTenantsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new tenant
        /// </summary>
        /// <remarks>
        /// Create new tenant and setup a unique agency endpoint. The agency
        /// will be set as an issuer
        /// </remarks>
        /// <param name='createTenant'>
        /// Configuration options for creating new tenant.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TenantInfo>> CreateTenantMethodWithHttpMessagesAsync(CreateTenant createTenant = default(CreateTenant), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a tenant.
        /// </summary>
        /// <remarks>
        /// Permanently remove a tenant, including their wallet, endpoint
        /// registrations and all data.
        /// All definitions, connections and credentials issued will be
        /// deleted.
        /// This action cannot be reverted.
        /// </remarks>
        /// <param name='tenantId'>
        /// Tenant identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteTenantWithHttpMessagesAsync(string tenantId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the agent configuration
        /// </summary>
        /// <param name='tenantId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ProvisioningInfo>> GetAgentInfoWithHttpMessagesAsync(string tenantId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
