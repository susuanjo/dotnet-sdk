// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Pulls.Item.Merge {
    /// <summary>The merge method to use.</summary>
    public enum MergePutRequestBody_merge_method {
        [EnumMember(Value = "merge")]
        Merge,
        [EnumMember(Value = "squash")]
        Squash,
        [EnumMember(Value = "rebase")]
        Rebase,
    }
}