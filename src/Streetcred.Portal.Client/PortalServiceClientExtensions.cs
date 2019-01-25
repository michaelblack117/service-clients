// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PortalServiceClient.
    /// </summary>
    public static partial class PortalServiceClientExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<ConnectionRecord> GetConnections(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetConnectionsAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ConnectionRecord>> GetConnectionsAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConnectionsWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<ConnectionRecord> GetInvitations(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetInvitationsAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ConnectionRecord>> GetInvitationsAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInvitationsWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='connectionId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static ConnectionRecord GetConnection(this IPortalServiceClient operations, string connectionId, string xStreetcredTenantId)
            {
                return operations.GetConnectionAsync(connectionId, xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='connectionId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionRecord> GetConnectionAsync(this IPortalServiceClient operations, string connectionId, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConnectionWithHttpMessagesAsync(connectionId, xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='createInvitation'>
            /// </param>
            public static void SendEmailInvitation(this IPortalServiceClient operations, string xStreetcredTenantId, CreateInvitation createInvitation = default(CreateInvitation))
            {
                operations.SendEmailInvitationAsync(xStreetcredTenantId, createInvitation).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='createInvitation'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SendEmailInvitationAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CreateInvitation createInvitation = default(CreateInvitation), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SendEmailInvitationWithHttpMessagesAsync(xStreetcredTenantId, createInvitation, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<CredentialRecord> GetCredentials(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetCredentialsAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CredentialRecord>> GetCredentialsAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCredentialsWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<CredentialRecord> GetOffers(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetOffersAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CredentialRecord>> GetOffersAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOffersWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='sendOffer'>
            /// </param>
            public static void SendOfferMethod(this IPortalServiceClient operations, string xStreetcredTenantId, SendOffer sendOffer = default(SendOffer))
            {
                operations.SendOfferMethodAsync(xStreetcredTenantId, sendOffer).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='sendOffer'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SendOfferMethodAsync(this IPortalServiceClient operations, string xStreetcredTenantId, SendOffer sendOffer = default(SendOffer), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SendOfferMethodWithHttpMessagesAsync(xStreetcredTenantId, sendOffer, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<CredentialRecord> GetRequests(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetRequestsAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CredentialRecord>> GetRequestsAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRequestsWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static void ApproveRequest(this IPortalServiceClient operations, string credentialId, string xStreetcredTenantId)
            {
                operations.ApproveRequestAsync(credentialId, xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApproveRequestAsync(this IPortalServiceClient operations, string credentialId, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApproveRequestWithHttpMessagesAsync(credentialId, xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static void RejectRequest(this IPortalServiceClient operations, string credentialId, string xStreetcredTenantId)
            {
                operations.RejectRequestAsync(credentialId, xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RejectRequestAsync(this IPortalServiceClient operations, string credentialId, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RejectRequestWithHttpMessagesAsync(credentialId, xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static void RevokeCredential(this IPortalServiceClient operations, string credentialId, string xStreetcredTenantId)
            {
                operations.RevokeCredentialAsync(credentialId, xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='credentialId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RevokeCredentialAsync(this IPortalServiceClient operations, string credentialId, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RevokeCredentialWithHttpMessagesAsync(credentialId, xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<DefinitionRecord> GetDefinitions(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetDefinitionsAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DefinitionRecord>> GetDefinitionsAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDefinitionsWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='definition'>
            /// </param>
            public static void CreateDefinitionMethod(this IPortalServiceClient operations, string xStreetcredTenantId, CreateDefinition definition = default(CreateDefinition))
            {
                operations.CreateDefinitionMethodAsync(xStreetcredTenantId, definition).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='definition'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateDefinitionMethodAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CreateDefinition definition = default(CreateDefinition), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateDefinitionMethodWithHttpMessagesAsync(xStreetcredTenantId, definition, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='definitionId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static void GetDefinition(this IPortalServiceClient operations, string definitionId, string xStreetcredTenantId)
            {
                operations.GetDefinitionAsync(definitionId, xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='definitionId'>
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetDefinitionAsync(this IPortalServiceClient operations, string definitionId, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetDefinitionWithHttpMessagesAsync(definitionId, xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get schema collection
            /// </summary>
            /// <remarks>
            /// Returns a collection of schemas registered with this agency tenant as owner
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static IList<SchemaRecord> GetSchemas(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                return operations.GetSchemasAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get schema collection
            /// </summary>
            /// <remarks>
            /// Returns a collection of schemas registered with this agency tenant as owner
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SchemaRecord>> GetSchemasAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchemasWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Register new schema
            /// </summary>
            /// <remarks>
            /// Create schema with the current agency tenant as owner and write the schema
            /// to the ledger
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schema'>
            /// The combination of 'name' and 'version' of the schema must be unique.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static string RegisterSchema(this IPortalServiceClient operations, Schema schema, string xStreetcredTenantId)
            {
                return operations.RegisterSchemaAsync(schema, xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Register new schema
            /// </summary>
            /// <remarks>
            /// Create schema with the current agency tenant as owner and write the schema
            /// to the ledger
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schema'>
            /// The combination of 'name' and 'version' of the schema must be unique.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> RegisterSchemaAsync(this IPortalServiceClient operations, Schema schema, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterSchemaWithHttpMessagesAsync(schema, xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<TenantInfo> GetTenants(this IPortalServiceClient operations)
            {
                return operations.GetTenantsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TenantInfo>> GetTenantsAsync(this IPortalServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTenantsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updateTenant'>
            /// </param>
            public static TenantInfo UpdateTenant(this IPortalServiceClient operations, TenantInfo updateTenant = default(TenantInfo))
            {
                return operations.UpdateTenantAsync(updateTenant).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='updateTenant'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TenantInfo> UpdateTenantAsync(this IPortalServiceClient operations, TenantInfo updateTenant = default(TenantInfo), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTenantWithHttpMessagesAsync(updateTenant, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createTenant'>
            /// </param>
            public static TenantInfo CreateTenant(this IPortalServiceClient operations, CreateTenantInfo createTenant = default(CreateTenantInfo))
            {
                return operations.CreateTenantAsync(createTenant).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='createTenant'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TenantInfo> CreateTenantAsync(this IPortalServiceClient operations, CreateTenantInfo createTenant = default(CreateTenantInfo), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateTenantWithHttpMessagesAsync(createTenant, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            public static void DeleteTenant(this IPortalServiceClient operations, string xStreetcredTenantId)
            {
                operations.DeleteTenantAsync(xStreetcredTenantId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredTenantId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteTenantAsync(this IPortalServiceClient operations, string xStreetcredTenantId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteTenantWithHttpMessagesAsync(xStreetcredTenantId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uploadedFiles'>
            /// </param>
            public static string UploadImage(this IPortalServiceClient operations, IList<object> uploadedFiles = default(IList<object>))
            {
                return operations.UploadImageAsync(uploadedFiles).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='uploadedFiles'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> UploadImageAsync(this IPortalServiceClient operations, IList<object> uploadedFiles = default(IList<object>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UploadImageWithHttpMessagesAsync(uploadedFiles, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<NetworkInfo> GetNetworks(this IPortalServiceClient operations)
            {
                return operations.GetNetworksAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<NetworkInfo>> GetNetworksAsync(this IPortalServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNetworksWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
