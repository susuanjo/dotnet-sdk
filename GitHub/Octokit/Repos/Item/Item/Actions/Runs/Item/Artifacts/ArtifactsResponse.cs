// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Actions.Runs.Item.Artifacts {
    [Obsolete("This class is obsolete. Use artifactsGetResponse instead.")]
    public class ArtifactsResponse : ArtifactsGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ArtifactsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ArtifactsResponse();
        }
    }
}
