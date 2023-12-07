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
namespace GitHub.Octokit.Orgs.Item.Copilot.Billing.Selected_teams {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot\billing\selected_teams
    /// </summary>
    public class Selected_teamsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Selected_teamsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Selected_teamsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/selected_teams", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Selected_teamsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Selected_teamsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/selected_teams", rawUrl) {
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Cancels the Copilot Business seat assignment for all members of each team specified.This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.For more information about Copilot Business pricing, see &quot;[Pricing for GitHub Copilot Business](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#pricing-for-github-copilot-business)&quot;.For more information about disabling access to Copilot Business, see &quot;[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-access-for-copilot-business-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)&quot;.Only organization owners can configure GitHub Copilot in their organization. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#remove-teams-from-the-copilot-business-subscription-for-an-organization" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Selected_teamsDeleteResponse?> DeleteAsSelected_teamsDeleteResponseAsync(Selected_teamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Selected_teamsDeleteResponse> DeleteAsSelected_teamsDeleteResponseAsync(Selected_teamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Selected_teamsDeleteResponse>(requestInfo, Selected_teamsDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Cancels the Copilot Business seat assignment for all members of each team specified.This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.For more information about Copilot Business pricing, see &quot;[Pricing for GitHub Copilot Business](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#pricing-for-github-copilot-business)&quot;.For more information about disabling access to Copilot Business, see &quot;[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-access-for-copilot-business-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)&quot;.Only organization owners can configure GitHub Copilot in their organization. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#remove-teams-from-the-copilot-business-subscription-for-an-organization" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use DeleteAsSelected_teamsDeleteResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Selected_teamsResponse?> DeleteAsync(Selected_teamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Selected_teamsResponse> DeleteAsync(Selected_teamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Selected_teamsResponse>(requestInfo, Selected_teamsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change. Purchases a GitHub Copilot Business seat for all users within each specified team. The organization will be billed accordingly. For more information about Copilot Business pricing, see &quot;[Pricing for GitHub Copilot Business](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#pricing-for-github-copilot-business)&quot;. Only organization owners can configure GitHub Copilot in their organization. You must authenticate using an access token with the `manage_billing:copilot` scope to use this endpoint. In order for an admin to use this endpoint, the organization must have a Copilot Business subscription and a configured suggestion matching policy. For more information about setting up a Copilot Business subscription, see &quot;[Setting up a Copilot Business subscription for your organization](https://docs.github.com/billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise#setting-up-a-copilot-business-subscription-for-your-organization)&quot;. For more information about setting a suggestion matching policy, see &quot;[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-policies-for-copilot-business-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)&quot;.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#add-teams-to-the-copilot-business-subscription-for-an-organization" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Selected_teamsPostResponse?> PostAsSelected_teamsPostResponseAsync(Selected_teamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Selected_teamsPostResponse> PostAsSelected_teamsPostResponseAsync(Selected_teamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Selected_teamsPostResponse>(requestInfo, Selected_teamsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change. Purchases a GitHub Copilot Business seat for all users within each specified team. The organization will be billed accordingly. For more information about Copilot Business pricing, see &quot;[Pricing for GitHub Copilot Business](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#pricing-for-github-copilot-business)&quot;. Only organization owners can configure GitHub Copilot in their organization. You must authenticate using an access token with the `manage_billing:copilot` scope to use this endpoint. In order for an admin to use this endpoint, the organization must have a Copilot Business subscription and a configured suggestion matching policy. For more information about setting up a Copilot Business subscription, see &quot;[Setting up a Copilot Business subscription for your organization](https://docs.github.com/billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise#setting-up-a-copilot-business-subscription-for-your-organization)&quot;. For more information about setting a suggestion matching policy, see &quot;[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-policies-for-copilot-business-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)&quot;.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#add-teams-to-the-copilot-business-subscription-for-an-organization" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsSelected_teamsPostResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Selected_teamsResponse?> PostAsync(Selected_teamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Selected_teamsResponse> PostAsync(Selected_teamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Selected_teamsResponse>(requestInfo, Selected_teamsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Cancels the Copilot Business seat assignment for all members of each team specified.This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.For more information about Copilot Business pricing, see &quot;[Pricing for GitHub Copilot Business](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#pricing-for-github-copilot-business)&quot;.For more information about disabling access to Copilot Business, see &quot;[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-access-for-copilot-business-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)&quot;.Only organization owners can configure GitHub Copilot in their organization. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Selected_teamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Selected_teamsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change. Purchases a GitHub Copilot Business seat for all users within each specified team. The organization will be billed accordingly. For more information about Copilot Business pricing, see &quot;[Pricing for GitHub Copilot Business](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#pricing-for-github-copilot-business)&quot;. Only organization owners can configure GitHub Copilot in their organization. You must authenticate using an access token with the `manage_billing:copilot` scope to use this endpoint. In order for an admin to use this endpoint, the organization must have a Copilot Business subscription and a configured suggestion matching policy. For more information about setting up a Copilot Business subscription, see &quot;[Setting up a Copilot Business subscription for your organization](https://docs.github.com/billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise#setting-up-a-copilot-business-subscription-for-your-organization)&quot;. For more information about setting a suggestion matching policy, see &quot;[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot-business/managing-policies-for-copilot-business-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)&quot;.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Selected_teamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Selected_teamsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Selected_teamsRequestBuilder WithUrl(string rawUrl) {
            return new Selected_teamsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class Selected_teamsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class Selected_teamsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}