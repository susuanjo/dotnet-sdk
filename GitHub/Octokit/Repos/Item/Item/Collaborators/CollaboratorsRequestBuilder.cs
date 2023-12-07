// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Collaborators.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Collaborators {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\collaborators
    /// </summary>
    public class CollaboratorsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.collaborators.item collection</summary>
        /// <param name="position">The handle for the GitHub user account.</param>
        public WithUsernameItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("username", position);
            return new WithUsernameItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CollaboratorsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollaboratorsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/collaborators{?affiliation*,permission*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CollaboratorsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CollaboratorsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/collaborators{?affiliation*,permission*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.Team members will include the members of child teams.You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use thisendpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use thisendpoint.
        /// API method documentation <see href="https://docs.github.com/rest/collaborators/collaborators#list-repository-collaborators" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Collaborator>?> GetAsync(Action<RequestConfiguration<CollaboratorsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Collaborator>> GetAsync(Action<RequestConfiguration<CollaboratorsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Collaborator>(requestInfo, Collaborator.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.Team members will include the members of child teams.You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use thisendpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use thisendpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CollaboratorsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CollaboratorsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CollaboratorsRequestBuilder WithUrl(string rawUrl) {
            return new CollaboratorsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.Team members will include the members of child teams.You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use thisendpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use thisendpoint.
        /// </summary>
        public class CollaboratorsRequestBuilderGetQueryParameters {
            /// <summary>Filter collaborators returned by their affiliation. `outside` means all outside collaborators of an organization-owned repository. `direct` means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. `all` means all collaborators the authenticated user can see.</summary>
            [Obsolete("This property is deprecated, use affiliationAsGetAffiliationQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("affiliation")]
            public string? Affiliation { get; set; }
#nullable restore
#else
            [QueryParameter("affiliation")]
            public string Affiliation { get; set; }
#endif
            /// <summary>Filter collaborators returned by their affiliation. `outside` means all outside collaborators of an organization-owned repository. `direct` means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. `all` means all collaborators the authenticated user can see.</summary>
            [QueryParameter("affiliation")]
            public GetAffiliationQueryParameterType? AffiliationAsGetAffiliationQueryParameterType { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>Filter collaborators by the permissions they have on the repository. If not specified, all collaborators will be returned.</summary>
            [Obsolete("This property is deprecated, use permissionAsGetPermissionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("permission")]
            public string? Permission { get; set; }
#nullable restore
#else
            [QueryParameter("permission")]
            public string Permission { get; set; }
#endif
            /// <summary>Filter collaborators by the permissions they have on the repository. If not specified, all collaborators will be returned.</summary>
            [QueryParameter("permission")]
            public GetPermissionQueryParameterType? PermissionAsGetPermissionQueryParameterType { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CollaboratorsRequestBuilderGetRequestConfiguration : RequestConfiguration<CollaboratorsRequestBuilderGetQueryParameters> {
        }
    }
}
