// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Commits.Item.Status {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\commits\{commits-id}\status
    /// </summary>
    public class StatusRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new StatusRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/commits/{commits%2Did}/status{?per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new StatusRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StatusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/commits/{commits%2Did}/status{?per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.Additionally, a combined `state` is returned. The `state` is one of:*   **failure** if any of the contexts report as `error` or `failure`*   **pending** if there are no statuses or a context is `pending`*   **success** if the latest status for all contexts is `success`
        /// API method documentation <see href="https://docs.github.com/rest/commits/statuses#get-the-combined-status-for-a-specific-reference" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CombinedCommitStatus?> GetAsync(Action<RequestConfiguration<StatusRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CombinedCommitStatus> GetAsync(Action<RequestConfiguration<StatusRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CombinedCommitStatus>(requestInfo, CombinedCommitStatus.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.Additionally, a combined `state` is returned. The `state` is one of:*   **failure** if any of the contexts report as `error` or `failure`*   **pending** if there are no statuses or a context is `pending`*   **success** if the latest status for all contexts is `success`
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StatusRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StatusRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public StatusRequestBuilder WithUrl(string rawUrl) {
            return new StatusRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.Additionally, a combined `state` is returned. The `state` is one of:*   **failure** if any of the contexts report as `error` or `failure`*   **pending** if there are no statuses or a context is `pending`*   **success** if the latest status for all contexts is `success`
        /// </summary>
        public class StatusRequestBuilderGetQueryParameters {
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class StatusRequestBuilderGetRequestConfiguration : RequestConfiguration<StatusRequestBuilderGetQueryParameters> {
        }
    }
}
