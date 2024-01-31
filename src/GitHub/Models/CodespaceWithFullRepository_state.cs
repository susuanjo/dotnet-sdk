// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Models {
    /// <summary>State of this codespace.</summary>
    public enum CodespaceWithFullRepository_state {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Queued")]
        Queued,
        [EnumMember(Value = "Provisioning")]
        Provisioning,
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Awaiting")]
        Awaiting,
        [EnumMember(Value = "Unavailable")]
        Unavailable,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Moved")]
        Moved,
        [EnumMember(Value = "Shutdown")]
        Shutdown,
        [EnumMember(Value = "Archived")]
        Archived,
        [EnumMember(Value = "Starting")]
        Starting,
        [EnumMember(Value = "ShuttingDown")]
        ShuttingDown,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Exporting")]
        Exporting,
        [EnumMember(Value = "Updating")]
        Updating,
        [EnumMember(Value = "Rebuilding")]
        Rebuilding,
    }
}