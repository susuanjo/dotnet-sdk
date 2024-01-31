// <auto-generated/>
using GitHub.Models;
using GitHub.Orgs.Item.Actions;
using GitHub.Orgs.Item.Blocks;
using GitHub.Orgs.Item.CodeScanning;
using GitHub.Orgs.Item.Codespaces;
using GitHub.Orgs.Item.Copilot;
using GitHub.Orgs.Item.Dependabot;
using GitHub.Orgs.Item.Docker;
using GitHub.Orgs.Item.Events;
using GitHub.Orgs.Item.Failed_invitations;
using GitHub.Orgs.Item.Hooks;
using GitHub.Orgs.Item.Installation;
using GitHub.Orgs.Item.Installations;
using GitHub.Orgs.Item.InteractionLimits;
using GitHub.Orgs.Item.Invitations;
using GitHub.Orgs.Item.Issues;
using GitHub.Orgs.Item.Item;
using GitHub.Orgs.Item.Members;
using GitHub.Orgs.Item.Memberships;
using GitHub.Orgs.Item.Migrations;
using GitHub.Orgs.Item.OrganizationFineGrainedPermissions;
using GitHub.Orgs.Item.OrganizationRoles;
using GitHub.Orgs.Item.Outside_collaborators;
using GitHub.Orgs.Item.Packages;
using GitHub.Orgs.Item.PersonalAccessTokenRequests;
using GitHub.Orgs.Item.PersonalAccessTokens;
using GitHub.Orgs.Item.Projects;
using GitHub.Orgs.Item.Properties;
using GitHub.Orgs.Item.Public_members;
using GitHub.Orgs.Item.Repos;
using GitHub.Orgs.Item.Rulesets;
using GitHub.Orgs.Item.SecretScanning;
using GitHub.Orgs.Item.SecurityAdvisories;
using GitHub.Orgs.Item.SecurityManagers;
using GitHub.Orgs.Item.Settings;
using GitHub.Orgs.Item.Teams;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Orgs.Item {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}
    /// </summary>
    public class WithOrgItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The actions property</summary>
        public ActionsRequestBuilder Actions { get =>
            new ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The blocks property</summary>
        public BlocksRequestBuilder Blocks { get =>
            new BlocksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codeScanning property</summary>
        public CodeScanningRequestBuilder CodeScanning { get =>
            new CodeScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The codespaces property</summary>
        public CodespacesRequestBuilder Codespaces { get =>
            new CodespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The copilot property</summary>
        public CopilotRequestBuilder Copilot { get =>
            new CopilotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dependabot property</summary>
        public DependabotRequestBuilder Dependabot { get =>
            new DependabotRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The docker property</summary>
        public DockerRequestBuilder Docker { get =>
            new DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The failed_invitations property</summary>
        public Failed_invitationsRequestBuilder Failed_invitations { get =>
            new Failed_invitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hooks property</summary>
        public HooksRequestBuilder Hooks { get =>
            new HooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public InstallationRequestBuilder Installation { get =>
            new InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installations property</summary>
        public InstallationsRequestBuilder Installations { get =>
            new InstallationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The interactionLimits property</summary>
        public InteractionLimitsRequestBuilder InteractionLimits { get =>
            new InteractionLimitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invitations property</summary>
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issues property</summary>
        public IssuesRequestBuilder Issues { get =>
            new IssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The members property</summary>
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memberships property</summary>
        public MembershipsRequestBuilder Memberships { get =>
            new MembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The migrations property</summary>
        public MigrationsRequestBuilder Migrations { get =>
            new MigrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizationFineGrainedPermissions property</summary>
        public OrganizationFineGrainedPermissionsRequestBuilder OrganizationFineGrainedPermissions { get =>
            new OrganizationFineGrainedPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizationRoles property</summary>
        public OrganizationRolesRequestBuilder OrganizationRoles { get =>
            new OrganizationRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The outside_collaborators property</summary>
        public Outside_collaboratorsRequestBuilder Outside_collaborators { get =>
            new Outside_collaboratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public PackagesRequestBuilder Packages { get =>
            new PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The personalAccessTokenRequests property</summary>
        public PersonalAccessTokenRequestsRequestBuilder PersonalAccessTokenRequests { get =>
            new PersonalAccessTokenRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The personalAccessTokens property</summary>
        public PersonalAccessTokensRequestBuilder PersonalAccessTokens { get =>
            new PersonalAccessTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public ProjectsRequestBuilder Projects { get =>
            new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The properties property</summary>
        public PropertiesRequestBuilder Properties { get =>
            new PropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The public_members property</summary>
        public Public_membersRequestBuilder Public_members { get =>
            new Public_membersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public ReposRequestBuilder Repos { get =>
            new ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rulesets property</summary>
        public RulesetsRequestBuilder Rulesets { get =>
            new RulesetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secretScanning property</summary>
        public SecretScanningRequestBuilder SecretScanning { get =>
            new SecretScanningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityAdvisories property</summary>
        public SecurityAdvisoriesRequestBuilder SecurityAdvisories { get =>
            new SecurityAdvisoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityManagers property</summary>
        public SecurityManagersRequestBuilder SecurityManagers { get =>
            new SecurityManagersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.orgs.item.item collection</summary>
        /// <param name="position">The security feature to enable or disable.</param>
        public WithSecurity_productItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("security_product", position);
            return new WithSecurity_productItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithOrgItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithOrgItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithOrgItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}", rawUrl) {
        }
        /// <summary>
        /// Deletes an organization and all its repositories.The organization login will be unavailable for 90 days after deletion.Please review the Terms of Service regarding account deletion before using this endpoint:https://docs.github.com/site-policy/github-terms/github-terms-of-service
        /// API method documentation <see href="https://docs.github.com/rest/orgs/orgs#delete-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithOrgDeleteResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WithOrgDeleteResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithOrgDeleteResponse>(requestInfo, WithOrgDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To see many of the organization response values, you need to be an authenticated organization owner with the `admin:org` scope. When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).GitHub Apps with the `Organization plan` permission can use this endpoint to retrieve information about an organization&apos;s GitHub plan. See &quot;[Authenticating with GitHub Apps](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/)&quot; for details. For an example response, see &apos;Response with GitHub plan information&apos; below.&quot;
        /// API method documentation <see href="https://docs.github.com/rest/orgs/orgs#get-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationFull?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OrganizationFull> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationFull>(requestInfo, OrganizationFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Parameter Deprecation Notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).Enables an authenticated organization owner with the `admin:org` scope or the `repo` scope to update the organization&apos;s profile and member privileges.
        /// API method documentation <see href="https://docs.github.com/rest/orgs/orgs#update-an-organization" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OrganizationFull?> PatchAsync(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OrganizationFull> PatchAsync(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"409", BasicError.CreateFromDiscriminatorValue},
                {"422", OrganizationFull422Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OrganizationFull>(requestInfo, OrganizationFull.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes an organization and all its repositories.The organization login will be unavailable for 90 days after deletion.Please review the Terms of Service regarding account deletion before using this endpoint:https://docs.github.com/site-policy/github-terms/github-terms-of-service
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// To see many of the organization response values, you need to be an authenticated organization owner with the `admin:org` scope. When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).GitHub Apps with the `Organization plan` permission can use this endpoint to retrieve information about an organization&apos;s GitHub plan. See &quot;[Authenticating with GitHub Apps](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/)&quot; for details. For an example response, see &apos;Response with GitHub plan information&apos; below.&quot;
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
        /// **Parameter Deprecation Notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).Enables an authenticated organization owner with the `admin:org` scope or the `repo` scope to update the organization&apos;s profile and member privileges.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WithOrgPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public WithOrgItemRequestBuilder WithUrl(string rawUrl) {
            return new WithOrgItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes validationError, validationErrorSimple
        /// </summary>
        public class OrganizationFull422Error : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type validationError</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.ValidationError? ValidationError { get; set; }
#nullable restore
#else
            public GitHub.Models.ValidationError ValidationError { get; set; }
#endif
            /// <summary>Composed type representation for type validationErrorSimple</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Models.ValidationErrorSimple? ValidationErrorSimple { get; set; }
#nullable restore
#else
            public GitHub.Models.ValidationErrorSimple ValidationErrorSimple { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static OrganizationFull422Error CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new OrganizationFull422Error();
                if("validation-error".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ValidationError = new GitHub.Models.ValidationError();
                }
                else if("validation-error-simple".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ValidationErrorSimple = new GitHub.Models.ValidationErrorSimple();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(ValidationError != null) {
                    return ValidationError.GetFieldDeserializers();
                }
                else if(ValidationErrorSimple != null) {
                    return ValidationErrorSimple.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ValidationError != null) {
                    writer.WriteObjectValue<GitHub.Models.ValidationError>(null, ValidationError);
                }
                else if(ValidationErrorSimple != null) {
                    writer.WriteObjectValue<GitHub.Models.ValidationErrorSimple>(null, ValidationErrorSimple);
                }
            }
        }
    }
}