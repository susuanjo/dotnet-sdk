// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Enterprises.Item.Copilot.Usage {
    /// <summary>
    /// Builds and executes requests for operations under \enterprises\{enterprise}\copilot\usage
    /// </summary>
    public class UsageRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="UsageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/copilot/usage{?page*,per_page*,since*,until*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UsageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/enterprises/{enterprise}/copilot/usage{?page*,per_page*,since*,until*}", rawUrl)
        {
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDEfor all users across organizations with access to Copilot within your enterprise, with a further breakdown of suggestions, acceptances,and number of active users by editor and language for each day. See the response schema tab for detailed metrics definitions.The response contains metrics for the prior 28 days. Usage metrics are processed once per day for the previous day,and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,they must have telemetry enabled in their IDE.Only owners and billing managers can view Copilot usage metrics for the enterprise.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-usage#get-a-summary-of-copilot-usage-for-enterprise-members" />
        /// </summary>
        /// <returns>A List&lt;CopilotUsageMetrics&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BasicError">When receiving a 401 status code</exception>
        /// <exception cref="BasicError">When receiving a 403 status code</exception>
        /// <exception cref="BasicError">When receiving a 404 status code</exception>
        /// <exception cref="BasicError">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<CopilotUsageMetrics>?> GetAsync(Action<RequestConfiguration<UsageRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<CopilotUsageMetrics>> GetAsync(Action<RequestConfiguration<UsageRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<CopilotUsageMetrics>(requestInfo, CopilotUsageMetrics.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDEfor all users across organizations with access to Copilot within your enterprise, with a further breakdown of suggestions, acceptances,and number of active users by editor and language for each day. See the response schema tab for detailed metrics definitions.The response contains metrics for the prior 28 days. Usage metrics are processed once per day for the previous day,and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,they must have telemetry enabled in their IDE.Only owners and billing managers can view Copilot usage metrics for the enterprise.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsageRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsageRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="UsageRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UsageRequestBuilder WithUrl(string rawUrl)
        {
            return new UsageRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDEfor all users across organizations with access to Copilot within your enterprise, with a further breakdown of suggestions, acceptances,and number of active users by editor and language for each day. See the response schema tab for detailed metrics definitions.The response contains metrics for the prior 28 days. Usage metrics are processed once per day for the previous day,and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,they must have telemetry enabled in their IDE.Only owners and billing managers can view Copilot usage metrics for the enterprise.OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        public class UsageRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of days of metrics to display per page (max 28). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>Show usage metrics since this date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format (`YYYY-MM-DDTHH:MM:SSZ`). Maximum value is 28 days ago.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("since")]
            public string? Since { get; set; }
#nullable restore
#else
            [QueryParameter("since")]
            public string Since { get; set; }
#endif
            /// <summary>Show usage metrics until this date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format (`YYYY-MM-DDTHH:MM:SSZ`) and should not preceed the `since` date if it is passed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("until")]
            public string? Until { get; set; }
#nullable restore
#else
            [QueryParameter("until")]
            public string Until { get; set; }
#endif
        }
    }
}
