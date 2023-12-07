// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.User.Blocks;
using GitHub.Octokit.User.Codespaces;
using GitHub.Octokit.User.Docker;
using GitHub.Octokit.User.Email;
using GitHub.Octokit.User.Emails;
using GitHub.Octokit.User.Followers;
using GitHub.Octokit.User.Following;
using GitHub.Octokit.User.Gpg_keys;
using GitHub.Octokit.User.Installations;
using GitHub.Octokit.User.InteractionLimits;
using GitHub.Octokit.User.Issues;
using GitHub.Octokit.User.Keys;
using GitHub.Octokit.User.Marketplace_purchases;
using GitHub.Octokit.User.Memberships;
using GitHub.Octokit.User.Migrations;
using GitHub.Octokit.User.Orgs;
using GitHub.Octokit.User.Packages;
using GitHub.Octokit.User.Projects;
using GitHub.Octokit.User.Public_emails;
using GitHub.Octokit.User.Repos;
using GitHub.Octokit.User.Repository_invitations;
using GitHub.Octokit.User.Social_accounts;
using GitHub.Octokit.User.Ssh_signing_keys;
using GitHub.Octokit.User.Starred;
using GitHub.Octokit.User.Subscriptions;
using GitHub.Octokit.User.Teams;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.User {
    /// <summary>
    /// Builds and executes requests for operations under \user
    /// </summary>
    public class UserRequestBuilder : BaseRequestBuilder {
        /// <summary>The blocks property</summary>
        public BlocksRequestBuilder Blocks { get =>
            new BlocksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codespaces property</summary>
        public CodespacesRequestBuilder Codespaces { get =>
            new CodespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The docker property</summary>
        public DockerRequestBuilder Docker { get =>
            new DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The email property</summary>
        public EmailRequestBuilder Email { get =>
            new EmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emails property</summary>
        public EmailsRequestBuilder Emails { get =>
            new EmailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The followers property</summary>
        public FollowersRequestBuilder Followers { get =>
            new FollowersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The following property</summary>
        public FollowingRequestBuilder Following { get =>
            new FollowingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gpg_keys property</summary>
        public Gpg_keysRequestBuilder Gpg_keys { get =>
            new Gpg_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installations property</summary>
        public InstallationsRequestBuilder Installations { get =>
            new InstallationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The interactionLimits property</summary>
        public InteractionLimitsRequestBuilder InteractionLimits { get =>
            new InteractionLimitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public IssuesRequestBuilder Issues { get =>
            new IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public KeysRequestBuilder Keys { get =>
            new KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The marketplace_purchases property</summary>
        public Marketplace_purchasesRequestBuilder Marketplace_purchases { get =>
            new Marketplace_purchasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberships property</summary>
        public MembershipsRequestBuilder Memberships { get =>
            new MembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The migrations property</summary>
        public MigrationsRequestBuilder Migrations { get =>
            new MigrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orgs property</summary>
        public OrgsRequestBuilder Orgs { get =>
            new OrgsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public PackagesRequestBuilder Packages { get =>
            new PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public ProjectsRequestBuilder Projects { get =>
            new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The public_emails property</summary>
        public Public_emailsRequestBuilder Public_emails { get =>
            new Public_emailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public ReposRequestBuilder Repos { get =>
            new ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repository_invitations property</summary>
        public Repository_invitationsRequestBuilder Repository_invitations { get =>
            new Repository_invitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The social_accounts property</summary>
        public Social_accountsRequestBuilder Social_accounts { get =>
            new Social_accountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ssh_signing_keys property</summary>
        public Ssh_signing_keysRequestBuilder Ssh_signing_keys { get =>
            new Ssh_signing_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The starred property</summary>
        public StarredRequestBuilder Starred { get =>
            new StarredRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscriptions property</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/user", rawUrl) {
        }
        /// <summary>
        /// If the authenticated user is authenticated with an OAuth token with the `user` scope, then the response lists public and private profile information.If the authenticated user is authenticated through OAuth without the `user` scope, then the response lists only public profile information.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#get-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserGetResponse?> GetAsUserGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserGetResponse> GetAsUserGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserGetResponse>(requestInfo, UserGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// If the authenticated user is authenticated with an OAuth token with the `user` scope, then the response lists public and private profile information.If the authenticated user is authenticated through OAuth without the `user` scope, then the response lists only public profile information.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#get-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsUserGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserResponse>(requestInfo, UserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#update-the-authenticated-user" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PrivateUser?> PatchAsync(UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PrivateUser> PatchAsync(UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PrivateUser>(requestInfo, PrivateUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// If the authenticated user is authenticated with an OAuth token with the `user` scope, then the response lists public and private profile information.If the authenticated user is authenticated through OAuth without the `user` scope, then the response lists only public profile information.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(UserPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UserRequestBuilder WithUrl(string rawUrl) {
            return new UserRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes privateUser, publicUser
        /// </summary>
        public class UserGetResponse : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type privateUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type publicUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static UserGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new UserGetResponse();
                if("private-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PrivateUser = new GitHub.Octokit.Models.PrivateUser();
                }
                else if("public-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PublicUser = new GitHub.Octokit.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(PrivateUser != null) {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null) {
                    return PublicUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(PrivateUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PublicUser>(null, PublicUser);
                }
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UserRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UserRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Composed type wrapper for classes privateUser, publicUser
        /// </summary>
        public class UserResponse : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type privateUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type publicUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static UserResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new UserResponse();
                if("private-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PrivateUser = new GitHub.Octokit.Models.PrivateUser();
                }
                else if("public-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PublicUser = new GitHub.Octokit.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(PrivateUser != null) {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null) {
                    return PublicUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(PrivateUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PublicUser>(null, PublicUser);
                }
            }
        }
    }
}
