// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    /// <summary>
    /// A code security configuration
    /// </summary>
    public class CodeSecurityConfiguration : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enablement status of GitHub Advanced Security</summary>
        public CodeSecurityConfiguration_advanced_security? AdvancedSecurity { get; set; }
        /// <summary>The enablement status of code scanning default setup</summary>
        public CodeSecurityConfiguration_code_scanning_default_setup? CodeScanningDefaultSetup { get; set; }
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The enablement status of Dependabot alerts</summary>
        public CodeSecurityConfiguration_dependabot_alerts? DependabotAlerts { get; set; }
        /// <summary>The enablement status of Dependabot security updates</summary>
        public CodeSecurityConfiguration_dependabot_security_updates? DependabotSecurityUpdates { get; set; }
        /// <summary>The enablement status of Dependency Graph</summary>
        public CodeSecurityConfiguration_dependency_graph? DependencyGraph { get; set; }
        /// <summary>The enablement status of Automatic dependency submission</summary>
        public CodeSecurityConfiguration_dependency_graph_autosubmit_action? DependencyGraphAutosubmitAction { get; set; }
        /// <summary>Feature options for Automatic dependency submission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CodeSecurityConfiguration_dependency_graph_autosubmit_action_options? DependencyGraphAutosubmitActionOptions { get; set; }
#nullable restore
#else
        public CodeSecurityConfiguration_dependency_graph_autosubmit_action_options DependencyGraphAutosubmitActionOptions { get; set; }
#endif
        /// <summary>A description of the code security configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The enforcement status for a security configuration</summary>
        public CodeSecurityConfiguration_enforcement? Enforcement { get; set; }
        /// <summary>The URL of the configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The ID of the code security configuration</summary>
        public int? Id { get; set; }
        /// <summary>The name of the code security configuration. Must be unique within the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The enablement status of private vulnerability reporting</summary>
        public CodeSecurityConfiguration_private_vulnerability_reporting? PrivateVulnerabilityReporting { get; set; }
        /// <summary>The enablement status of secret scanning</summary>
        public CodeSecurityConfiguration_secret_scanning? SecretScanning { get; set; }
        /// <summary>The enablement status of secret scanning push protection</summary>
        public CodeSecurityConfiguration_secret_scanning_push_protection? SecretScanningPushProtection { get; set; }
        /// <summary>The enablement status of secret scanning validity checks</summary>
        public CodeSecurityConfiguration_secret_scanning_validity_checks? SecretScanningValidityChecks { get; set; }
        /// <summary>The type of the code security configuration.</summary>
        public CodeSecurityConfiguration_target_type? TargetType { get; set; }
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The URL of the configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CodeSecurityConfiguration"/> and sets the default values.
        /// </summary>
        public CodeSecurityConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CodeSecurityConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CodeSecurityConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CodeSecurityConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"advanced_security", n => { AdvancedSecurity = n.GetEnumValue<CodeSecurityConfiguration_advanced_security>(); } },
                {"code_scanning_default_setup", n => { CodeScanningDefaultSetup = n.GetEnumValue<CodeSecurityConfiguration_code_scanning_default_setup>(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"dependabot_alerts", n => { DependabotAlerts = n.GetEnumValue<CodeSecurityConfiguration_dependabot_alerts>(); } },
                {"dependabot_security_updates", n => { DependabotSecurityUpdates = n.GetEnumValue<CodeSecurityConfiguration_dependabot_security_updates>(); } },
                {"dependency_graph", n => { DependencyGraph = n.GetEnumValue<CodeSecurityConfiguration_dependency_graph>(); } },
                {"dependency_graph_autosubmit_action", n => { DependencyGraphAutosubmitAction = n.GetEnumValue<CodeSecurityConfiguration_dependency_graph_autosubmit_action>(); } },
                {"dependency_graph_autosubmit_action_options", n => { DependencyGraphAutosubmitActionOptions = n.GetObjectValue<CodeSecurityConfiguration_dependency_graph_autosubmit_action_options>(CodeSecurityConfiguration_dependency_graph_autosubmit_action_options.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"enforcement", n => { Enforcement = n.GetEnumValue<CodeSecurityConfiguration_enforcement>(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"private_vulnerability_reporting", n => { PrivateVulnerabilityReporting = n.GetEnumValue<CodeSecurityConfiguration_private_vulnerability_reporting>(); } },
                {"secret_scanning", n => { SecretScanning = n.GetEnumValue<CodeSecurityConfiguration_secret_scanning>(); } },
                {"secret_scanning_push_protection", n => { SecretScanningPushProtection = n.GetEnumValue<CodeSecurityConfiguration_secret_scanning_push_protection>(); } },
                {"secret_scanning_validity_checks", n => { SecretScanningValidityChecks = n.GetEnumValue<CodeSecurityConfiguration_secret_scanning_validity_checks>(); } },
                {"target_type", n => { TargetType = n.GetEnumValue<CodeSecurityConfiguration_target_type>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CodeSecurityConfiguration_advanced_security>("advanced_security", AdvancedSecurity);
            writer.WriteEnumValue<CodeSecurityConfiguration_code_scanning_default_setup>("code_scanning_default_setup", CodeScanningDefaultSetup);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteEnumValue<CodeSecurityConfiguration_dependabot_alerts>("dependabot_alerts", DependabotAlerts);
            writer.WriteEnumValue<CodeSecurityConfiguration_dependabot_security_updates>("dependabot_security_updates", DependabotSecurityUpdates);
            writer.WriteEnumValue<CodeSecurityConfiguration_dependency_graph>("dependency_graph", DependencyGraph);
            writer.WriteEnumValue<CodeSecurityConfiguration_dependency_graph_autosubmit_action>("dependency_graph_autosubmit_action", DependencyGraphAutosubmitAction);
            writer.WriteObjectValue<CodeSecurityConfiguration_dependency_graph_autosubmit_action_options>("dependency_graph_autosubmit_action_options", DependencyGraphAutosubmitActionOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<CodeSecurityConfiguration_enforcement>("enforcement", Enforcement);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<CodeSecurityConfiguration_private_vulnerability_reporting>("private_vulnerability_reporting", PrivateVulnerabilityReporting);
            writer.WriteEnumValue<CodeSecurityConfiguration_secret_scanning>("secret_scanning", SecretScanning);
            writer.WriteEnumValue<CodeSecurityConfiguration_secret_scanning_push_protection>("secret_scanning_push_protection", SecretScanningPushProtection);
            writer.WriteEnumValue<CodeSecurityConfiguration_secret_scanning_validity_checks>("secret_scanning_validity_checks", SecretScanningValidityChecks);
            writer.WriteEnumValue<CodeSecurityConfiguration_target_type>("target_type", TargetType);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
