// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Pages {
    /// <summary>The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.</summary>
    public enum PagesPutRequestBody_build_type {
        [EnumMember(Value = "legacy")]
        Legacy,
        [EnumMember(Value = "workflow")]
        Workflow,
    }
}