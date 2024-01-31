// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// A team&apos;s access to a repository.
    /// </summary>
    public class TeamRepository : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to allow Auto-merge to be used on pull requests.</summary>
        public bool? AllowAutoMerge { get; set; }
        /// <summary>Whether to allow forking this repo</summary>
        public bool? AllowForking { get; set; }
        /// <summary>Whether to allow merge commits for pull requests.</summary>
        public bool? AllowMergeCommit { get; set; }
        /// <summary>Whether to allow rebase merges for pull requests.</summary>
        public bool? AllowRebaseMerge { get; set; }
        /// <summary>Whether to allow squash merges for pull requests.</summary>
        public bool? AllowSquashMerge { get; set; }
        /// <summary>Whether the repository is archived.</summary>
        public bool? Archived { get; set; }
        /// <summary>The archive_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchiveUrl { get; set; }
#nullable restore
#else
        public string ArchiveUrl { get; set; }
#endif
        /// <summary>The assignees_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneesUrl { get; set; }
#nullable restore
#else
        public string AssigneesUrl { get; set; }
#endif
        /// <summary>The blobs_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BlobsUrl { get; set; }
#nullable restore
#else
        public string BlobsUrl { get; set; }
#endif
        /// <summary>The branches_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BranchesUrl { get; set; }
#nullable restore
#else
        public string BranchesUrl { get; set; }
#endif
        /// <summary>The clone_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloneUrl { get; set; }
#nullable restore
#else
        public string CloneUrl { get; set; }
#endif
        /// <summary>The collaborators_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CollaboratorsUrl { get; set; }
#nullable restore
#else
        public string CollaboratorsUrl { get; set; }
#endif
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The commits_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitsUrl { get; set; }
#nullable restore
#else
        public string CommitsUrl { get; set; }
#endif
        /// <summary>The compare_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompareUrl { get; set; }
#nullable restore
#else
        public string CompareUrl { get; set; }
#endif
        /// <summary>The contents_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentsUrl { get; set; }
#nullable restore
#else
        public string ContentsUrl { get; set; }
#endif
        /// <summary>The contributors_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContributorsUrl { get; set; }
#nullable restore
#else
        public string ContributorsUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The default branch of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultBranch { get; set; }
#nullable restore
#else
        public string DefaultBranch { get; set; }
#endif
        /// <summary>Whether to delete head branches when pull requests are merged</summary>
        public bool? DeleteBranchOnMerge { get; set; }
        /// <summary>The deployments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeploymentsUrl { get; set; }
#nullable restore
#else
        public string DeploymentsUrl { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Returns whether or not this repository disabled.</summary>
        public bool? Disabled { get; set; }
        /// <summary>The downloads_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DownloadsUrl { get; set; }
#nullable restore
#else
        public string DownloadsUrl { get; set; }
#endif
        /// <summary>The events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>The fork property</summary>
        public bool? Fork { get; set; }
        /// <summary>The forks property</summary>
        public int? Forks { get; set; }
        /// <summary>The forks_count property</summary>
        public int? ForksCount { get; set; }
        /// <summary>The forks_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForksUrl { get; set; }
#nullable restore
#else
        public string ForksUrl { get; set; }
#endif
        /// <summary>The full_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullName { get; set; }
#nullable restore
#else
        public string FullName { get; set; }
#endif
        /// <summary>The git_commits_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitCommitsUrl { get; set; }
#nullable restore
#else
        public string GitCommitsUrl { get; set; }
#endif
        /// <summary>The git_refs_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitRefsUrl { get; set; }
#nullable restore
#else
        public string GitRefsUrl { get; set; }
#endif
        /// <summary>The git_tags_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitTagsUrl { get; set; }
#nullable restore
#else
        public string GitTagsUrl { get; set; }
#endif
        /// <summary>The git_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GitUrl { get; set; }
#nullable restore
#else
        public string GitUrl { get; set; }
#endif
        /// <summary>Whether downloads are enabled.</summary>
        public bool? HasDownloads { get; set; }
        /// <summary>Whether issues are enabled.</summary>
        public bool? HasIssues { get; set; }
        /// <summary>The has_pages property</summary>
        public bool? HasPages { get; set; }
        /// <summary>Whether projects are enabled.</summary>
        public bool? HasProjects { get; set; }
        /// <summary>Whether the wiki is enabled.</summary>
        public bool? HasWiki { get; set; }
        /// <summary>The homepage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Homepage { get; set; }
#nullable restore
#else
        public string Homepage { get; set; }
#endif
        /// <summary>The hooks_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HooksUrl { get; set; }
#nullable restore
#else
        public string HooksUrl { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>Unique identifier of the repository</summary>
        public int? Id { get; set; }
        /// <summary>The issue_comment_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueCommentUrl { get; set; }
#nullable restore
#else
        public string IssueCommentUrl { get; set; }
#endif
        /// <summary>The issue_events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueEventsUrl { get; set; }
#nullable restore
#else
        public string IssueEventsUrl { get; set; }
#endif
        /// <summary>The issues_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuesUrl { get; set; }
#nullable restore
#else
        public string IssuesUrl { get; set; }
#endif
        /// <summary>Whether this repository acts as a template that can be used to generate new repositories.</summary>
        public bool? IsTemplate { get; set; }
        /// <summary>The keys_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeysUrl { get; set; }
#nullable restore
#else
        public string KeysUrl { get; set; }
#endif
        /// <summary>The labels_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelsUrl { get; set; }
#nullable restore
#else
        public string LabelsUrl { get; set; }
#endif
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The languages_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguagesUrl { get; set; }
#nullable restore
#else
        public string LanguagesUrl { get; set; }
#endif
        /// <summary>License Simple</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableLicenseSimple? License { get; set; }
#nullable restore
#else
        public NullableLicenseSimple License { get; set; }
#endif
        /// <summary>The master_branch property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MasterBranch { get; set; }
#nullable restore
#else
        public string MasterBranch { get; set; }
#endif
        /// <summary>The merges_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MergesUrl { get; set; }
#nullable restore
#else
        public string MergesUrl { get; set; }
#endif
        /// <summary>The milestones_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MilestonesUrl { get; set; }
#nullable restore
#else
        public string MilestonesUrl { get; set; }
#endif
        /// <summary>The mirror_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MirrorUrl { get; set; }
#nullable restore
#else
        public string MirrorUrl { get; set; }
#endif
        /// <summary>The name of the repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The network_count property</summary>
        public int? NetworkCount { get; set; }
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The notifications_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationsUrl { get; set; }
#nullable restore
#else
        public string NotificationsUrl { get; set; }
#endif
        /// <summary>The open_issues property</summary>
        public int? OpenIssues { get; set; }
        /// <summary>The open_issues_count property</summary>
        public int? OpenIssuesCount { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Owner { get; set; }
#nullable restore
#else
        public NullableSimpleUser Owner { get; set; }
#endif
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamRepository_permissions? Permissions { get; set; }
#nullable restore
#else
        public TeamRepository_permissions Permissions { get; set; }
#endif
        /// <summary>Whether the repository is private or public.</summary>
        public bool? Private { get; set; }
        /// <summary>The pulls_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PullsUrl { get; set; }
#nullable restore
#else
        public string PullsUrl { get; set; }
#endif
        /// <summary>The pushed_at property</summary>
        public DateTimeOffset? PushedAt { get; set; }
        /// <summary>The releases_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReleasesUrl { get; set; }
#nullable restore
#else
        public string ReleasesUrl { get; set; }
#endif
        /// <summary>The role_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleName { get; set; }
#nullable restore
#else
        public string RoleName { get; set; }
#endif
        /// <summary>The size property</summary>
        public int? Size { get; set; }
        /// <summary>The ssh_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshUrl { get; set; }
#nullable restore
#else
        public string SshUrl { get; set; }
#endif
        /// <summary>The stargazers_count property</summary>
        public int? StargazersCount { get; set; }
        /// <summary>The stargazers_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StargazersUrl { get; set; }
#nullable restore
#else
        public string StargazersUrl { get; set; }
#endif
        /// <summary>The statuses_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusesUrl { get; set; }
#nullable restore
#else
        public string StatusesUrl { get; set; }
#endif
        /// <summary>The subscribers_count property</summary>
        public int? SubscribersCount { get; set; }
        /// <summary>The subscribers_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscribersUrl { get; set; }
#nullable restore
#else
        public string SubscribersUrl { get; set; }
#endif
        /// <summary>The subscription_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionUrl { get; set; }
#nullable restore
#else
        public string SubscriptionUrl { get; set; }
#endif
        /// <summary>The svn_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SvnUrl { get; set; }
#nullable restore
#else
        public string SvnUrl { get; set; }
#endif
        /// <summary>The tags_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TagsUrl { get; set; }
#nullable restore
#else
        public string TagsUrl { get; set; }
#endif
        /// <summary>The teams_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsUrl { get; set; }
#nullable restore
#else
        public string TeamsUrl { get; set; }
#endif
        /// <summary>The temp_clone_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TempCloneToken { get; set; }
#nullable restore
#else
        public string TempCloneToken { get; set; }
#endif
        /// <summary>The topics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Topics { get; set; }
#nullable restore
#else
        public List<string> Topics { get; set; }
#endif
        /// <summary>The trees_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TreesUrl { get; set; }
#nullable restore
#else
        public string TreesUrl { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The repository visibility: public, private, or internal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility { get; set; }
#nullable restore
#else
        public string Visibility { get; set; }
#endif
        /// <summary>The watchers property</summary>
        public int? Watchers { get; set; }
        /// <summary>The watchers_count property</summary>
        public int? WatchersCount { get; set; }
        /// <summary>Whether to require contributors to sign off on web-based commits</summary>
        public bool? WebCommitSignoffRequired { get; set; }
        /// <summary>
        /// Instantiates a new teamRepository and sets the default values.
        /// </summary>
        public TeamRepository() {
            AdditionalData = new Dictionary<string, object>();
            Visibility = "public";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamRepository CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamRepository();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allow_auto_merge", n => { AllowAutoMerge = n.GetBoolValue(); } },
                {"allow_forking", n => { AllowForking = n.GetBoolValue(); } },
                {"allow_merge_commit", n => { AllowMergeCommit = n.GetBoolValue(); } },
                {"allow_rebase_merge", n => { AllowRebaseMerge = n.GetBoolValue(); } },
                {"allow_squash_merge", n => { AllowSquashMerge = n.GetBoolValue(); } },
                {"archive_url", n => { ArchiveUrl = n.GetStringValue(); } },
                {"archived", n => { Archived = n.GetBoolValue(); } },
                {"assignees_url", n => { AssigneesUrl = n.GetStringValue(); } },
                {"blobs_url", n => { BlobsUrl = n.GetStringValue(); } },
                {"branches_url", n => { BranchesUrl = n.GetStringValue(); } },
                {"clone_url", n => { CloneUrl = n.GetStringValue(); } },
                {"collaborators_url", n => { CollaboratorsUrl = n.GetStringValue(); } },
                {"comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                {"commits_url", n => { CommitsUrl = n.GetStringValue(); } },
                {"compare_url", n => { CompareUrl = n.GetStringValue(); } },
                {"contents_url", n => { ContentsUrl = n.GetStringValue(); } },
                {"contributors_url", n => { ContributorsUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"default_branch", n => { DefaultBranch = n.GetStringValue(); } },
                {"delete_branch_on_merge", n => { DeleteBranchOnMerge = n.GetBoolValue(); } },
                {"deployments_url", n => { DeploymentsUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disabled", n => { Disabled = n.GetBoolValue(); } },
                {"downloads_url", n => { DownloadsUrl = n.GetStringValue(); } },
                {"events_url", n => { EventsUrl = n.GetStringValue(); } },
                {"fork", n => { Fork = n.GetBoolValue(); } },
                {"forks", n => { Forks = n.GetIntValue(); } },
                {"forks_count", n => { ForksCount = n.GetIntValue(); } },
                {"forks_url", n => { ForksUrl = n.GetStringValue(); } },
                {"full_name", n => { FullName = n.GetStringValue(); } },
                {"git_commits_url", n => { GitCommitsUrl = n.GetStringValue(); } },
                {"git_refs_url", n => { GitRefsUrl = n.GetStringValue(); } },
                {"git_tags_url", n => { GitTagsUrl = n.GetStringValue(); } },
                {"git_url", n => { GitUrl = n.GetStringValue(); } },
                {"has_downloads", n => { HasDownloads = n.GetBoolValue(); } },
                {"has_issues", n => { HasIssues = n.GetBoolValue(); } },
                {"has_pages", n => { HasPages = n.GetBoolValue(); } },
                {"has_projects", n => { HasProjects = n.GetBoolValue(); } },
                {"has_wiki", n => { HasWiki = n.GetBoolValue(); } },
                {"homepage", n => { Homepage = n.GetStringValue(); } },
                {"hooks_url", n => { HooksUrl = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"is_template", n => { IsTemplate = n.GetBoolValue(); } },
                {"issue_comment_url", n => { IssueCommentUrl = n.GetStringValue(); } },
                {"issue_events_url", n => { IssueEventsUrl = n.GetStringValue(); } },
                {"issues_url", n => { IssuesUrl = n.GetStringValue(); } },
                {"keys_url", n => { KeysUrl = n.GetStringValue(); } },
                {"labels_url", n => { LabelsUrl = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"languages_url", n => { LanguagesUrl = n.GetStringValue(); } },
                {"license", n => { License = n.GetObjectValue<NullableLicenseSimple>(NullableLicenseSimple.CreateFromDiscriminatorValue); } },
                {"master_branch", n => { MasterBranch = n.GetStringValue(); } },
                {"merges_url", n => { MergesUrl = n.GetStringValue(); } },
                {"milestones_url", n => { MilestonesUrl = n.GetStringValue(); } },
                {"mirror_url", n => { MirrorUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"network_count", n => { NetworkCount = n.GetIntValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"notifications_url", n => { NotificationsUrl = n.GetStringValue(); } },
                {"open_issues", n => { OpenIssues = n.GetIntValue(); } },
                {"open_issues_count", n => { OpenIssuesCount = n.GetIntValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"permissions", n => { Permissions = n.GetObjectValue<TeamRepository_permissions>(TeamRepository_permissions.CreateFromDiscriminatorValue); } },
                {"private", n => { Private = n.GetBoolValue(); } },
                {"pulls_url", n => { PullsUrl = n.GetStringValue(); } },
                {"pushed_at", n => { PushedAt = n.GetDateTimeOffsetValue(); } },
                {"releases_url", n => { ReleasesUrl = n.GetStringValue(); } },
                {"role_name", n => { RoleName = n.GetStringValue(); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"ssh_url", n => { SshUrl = n.GetStringValue(); } },
                {"stargazers_count", n => { StargazersCount = n.GetIntValue(); } },
                {"stargazers_url", n => { StargazersUrl = n.GetStringValue(); } },
                {"statuses_url", n => { StatusesUrl = n.GetStringValue(); } },
                {"subscribers_count", n => { SubscribersCount = n.GetIntValue(); } },
                {"subscribers_url", n => { SubscribersUrl = n.GetStringValue(); } },
                {"subscription_url", n => { SubscriptionUrl = n.GetStringValue(); } },
                {"svn_url", n => { SvnUrl = n.GetStringValue(); } },
                {"tags_url", n => { TagsUrl = n.GetStringValue(); } },
                {"teams_url", n => { TeamsUrl = n.GetStringValue(); } },
                {"temp_clone_token", n => { TempCloneToken = n.GetStringValue(); } },
                {"topics", n => { Topics = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"trees_url", n => { TreesUrl = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"visibility", n => { Visibility = n.GetStringValue(); } },
                {"watchers", n => { Watchers = n.GetIntValue(); } },
                {"watchers_count", n => { WatchersCount = n.GetIntValue(); } },
                {"web_commit_signoff_required", n => { WebCommitSignoffRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_auto_merge", AllowAutoMerge);
            writer.WriteBoolValue("allow_forking", AllowForking);
            writer.WriteBoolValue("allow_merge_commit", AllowMergeCommit);
            writer.WriteBoolValue("allow_rebase_merge", AllowRebaseMerge);
            writer.WriteBoolValue("allow_squash_merge", AllowSquashMerge);
            writer.WriteBoolValue("archived", Archived);
            writer.WriteStringValue("archive_url", ArchiveUrl);
            writer.WriteStringValue("assignees_url", AssigneesUrl);
            writer.WriteStringValue("blobs_url", BlobsUrl);
            writer.WriteStringValue("branches_url", BranchesUrl);
            writer.WriteStringValue("clone_url", CloneUrl);
            writer.WriteStringValue("collaborators_url", CollaboratorsUrl);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteStringValue("commits_url", CommitsUrl);
            writer.WriteStringValue("compare_url", CompareUrl);
            writer.WriteStringValue("contents_url", ContentsUrl);
            writer.WriteStringValue("contributors_url", ContributorsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("default_branch", DefaultBranch);
            writer.WriteBoolValue("delete_branch_on_merge", DeleteBranchOnMerge);
            writer.WriteStringValue("deployments_url", DeploymentsUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("disabled", Disabled);
            writer.WriteStringValue("downloads_url", DownloadsUrl);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteBoolValue("fork", Fork);
            writer.WriteIntValue("forks", Forks);
            writer.WriteIntValue("forks_count", ForksCount);
            writer.WriteStringValue("forks_url", ForksUrl);
            writer.WriteStringValue("full_name", FullName);
            writer.WriteStringValue("git_commits_url", GitCommitsUrl);
            writer.WriteStringValue("git_refs_url", GitRefsUrl);
            writer.WriteStringValue("git_tags_url", GitTagsUrl);
            writer.WriteStringValue("git_url", GitUrl);
            writer.WriteBoolValue("has_downloads", HasDownloads);
            writer.WriteBoolValue("has_issues", HasIssues);
            writer.WriteBoolValue("has_pages", HasPages);
            writer.WriteBoolValue("has_projects", HasProjects);
            writer.WriteBoolValue("has_wiki", HasWiki);
            writer.WriteStringValue("homepage", Homepage);
            writer.WriteStringValue("hooks_url", HooksUrl);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issue_comment_url", IssueCommentUrl);
            writer.WriteStringValue("issue_events_url", IssueEventsUrl);
            writer.WriteStringValue("issues_url", IssuesUrl);
            writer.WriteBoolValue("is_template", IsTemplate);
            writer.WriteStringValue("keys_url", KeysUrl);
            writer.WriteStringValue("labels_url", LabelsUrl);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("languages_url", LanguagesUrl);
            writer.WriteObjectValue<NullableLicenseSimple>("license", License);
            writer.WriteStringValue("master_branch", MasterBranch);
            writer.WriteStringValue("merges_url", MergesUrl);
            writer.WriteStringValue("milestones_url", MilestonesUrl);
            writer.WriteStringValue("mirror_url", MirrorUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("network_count", NetworkCount);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("notifications_url", NotificationsUrl);
            writer.WriteIntValue("open_issues", OpenIssues);
            writer.WriteIntValue("open_issues_count", OpenIssuesCount);
            writer.WriteObjectValue<NullableSimpleUser>("owner", Owner);
            writer.WriteObjectValue<TeamRepository_permissions>("permissions", Permissions);
            writer.WriteBoolValue("private", Private);
            writer.WriteStringValue("pulls_url", PullsUrl);
            writer.WriteDateTimeOffsetValue("pushed_at", PushedAt);
            writer.WriteStringValue("releases_url", ReleasesUrl);
            writer.WriteStringValue("role_name", RoleName);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("ssh_url", SshUrl);
            writer.WriteIntValue("stargazers_count", StargazersCount);
            writer.WriteStringValue("stargazers_url", StargazersUrl);
            writer.WriteStringValue("statuses_url", StatusesUrl);
            writer.WriteIntValue("subscribers_count", SubscribersCount);
            writer.WriteStringValue("subscribers_url", SubscribersUrl);
            writer.WriteStringValue("subscription_url", SubscriptionUrl);
            writer.WriteStringValue("svn_url", SvnUrl);
            writer.WriteStringValue("tags_url", TagsUrl);
            writer.WriteStringValue("teams_url", TeamsUrl);
            writer.WriteStringValue("temp_clone_token", TempCloneToken);
            writer.WriteCollectionOfPrimitiveValues<string>("topics", Topics);
            writer.WriteStringValue("trees_url", TreesUrl);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("visibility", Visibility);
            writer.WriteIntValue("watchers", Watchers);
            writer.WriteIntValue("watchers_count", WatchersCount);
            writer.WriteBoolValue("web_commit_signoff_required", WebCommitSignoffRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}