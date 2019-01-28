// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Cloud.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CloudServiceClient.
    /// </summary>
    public static partial class CloudServiceClientExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='invitation'>
            /// </param>
            public static ObjectId AcceptInvitation(this ICloudServiceClient operations, ConnectionInvitationMessage invitation = default(ConnectionInvitationMessage))
            {
                return operations.AcceptInvitationAsync(invitation).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='invitation'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ObjectId> AcceptInvitationAsync(this ICloudServiceClient operations, ConnectionInvitationMessage invitation = default(ConnectionInvitationMessage), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AcceptInvitationWithHttpMessagesAsync(invitation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ConnectionInfo> GetConnections(this ICloudServiceClient operations)
            {
                return operations.GetConnectionsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ConnectionInfo>> GetConnectionsAsync(this ICloudServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConnectionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ConnectionInfo> GetInvitations(this ICloudServiceClient operations)
            {
                return operations.GetInvitationsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ConnectionInfo>> GetInvitationsAsync(this ICloudServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInvitationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='destinationRegistration'>
            /// </param>
            public static void AssociateDestination(this ICloudServiceClient operations, string xStreetcredWalletId, DestinationRegistration destinationRegistration = default(DestinationRegistration))
            {
                operations.AssociateDestinationAsync(xStreetcredWalletId, destinationRegistration).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='destinationRegistration'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AssociateDestinationAsync(this ICloudServiceClient operations, string xStreetcredWalletId, DestinationRegistration destinationRegistration = default(DestinationRegistration), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AssociateDestinationWithHttpMessagesAsync(xStreetcredWalletId, destinationRegistration, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='deviceRegistration'>
            /// </param>
            public static void RegisterPush(this ICloudServiceClient operations, string xStreetcredWalletId, DeviceRegistration deviceRegistration = default(DeviceRegistration))
            {
                operations.RegisterPushAsync(xStreetcredWalletId, deviceRegistration).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='deviceRegistration'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegisterPushAsync(this ICloudServiceClient operations, string xStreetcredWalletId, DeviceRegistration deviceRegistration = default(DeviceRegistration), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegisterPushWithHttpMessagesAsync(xStreetcredWalletId, deviceRegistration, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ProvisioningInfo GetConfiguration(this ICloudServiceClient operations)
            {
                return operations.GetConfigurationAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProvisioningInfo> GetConfigurationAsync(this ICloudServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConfigurationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            public static IList<string> RetreiveMessages(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                return operations.RetreiveMessagesAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> RetreiveMessagesAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RetreiveMessagesWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='messageIds'>
            /// </param>
            public static void DeleteMessages(this ICloudServiceClient operations, string xStreetcredWalletId, IList<string> messageIds = default(IList<string>))
            {
                operations.DeleteMessagesAsync(xStreetcredWalletId, messageIds).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='messageIds'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteMessagesAsync(this ICloudServiceClient operations, string xStreetcredWalletId, IList<string> messageIds = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteMessagesWithHttpMessagesAsync(xStreetcredWalletId, messageIds, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<WalletInfo> ListWallets(this ICloudServiceClient operations)
            {
                return operations.ListWalletsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<WalletInfo>> ListWalletsAsync(this ICloudServiceClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWalletsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='walletInfo'>
            /// </param>
            public static ObjectId CreateWallet(this ICloudServiceClient operations, WalletInfo walletInfo = default(WalletInfo))
            {
                return operations.CreateWalletAsync(walletInfo).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='walletInfo'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ObjectId> CreateWalletAsync(this ICloudServiceClient operations, WalletInfo walletInfo = default(WalletInfo), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWalletWithHttpMessagesAsync(walletInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            public static void DeleteWallet(this ICloudServiceClient operations, string xStreetcredWalletId)
            {
                operations.DeleteWalletAsync(xStreetcredWalletId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xStreetcredWalletId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteWalletAsync(this ICloudServiceClient operations, string xStreetcredWalletId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWalletWithHttpMessagesAsync(xStreetcredWalletId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
