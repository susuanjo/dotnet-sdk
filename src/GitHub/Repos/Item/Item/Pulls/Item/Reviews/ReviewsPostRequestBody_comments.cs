// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Repos.Item.Item.Pulls.Item.Reviews {
    public class ReviewsPostRequestBody_comments : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Text of the review comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The line property</summary>
        public int? Line { get; set; }
        /// <summary>The relative path to the file that necessitates a review comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. The `position` value equals the number of lines down from the first &quot;@@&quot; hunk header in the file you want to add a comment. The line just below the &quot;@@&quot; line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.</summary>
        public int? Position { get; set; }
        /// <summary>The side property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Side { get; set; }
#nullable restore
#else
        public string Side { get; set; }
#endif
        /// <summary>The start_line property</summary>
        public int? StartLine { get; set; }
        /// <summary>The start_side property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartSide { get; set; }
#nullable restore
#else
        public string StartSide { get; set; }
#endif
        /// <summary>
        /// Instantiates a new reviewsPostRequestBody_comments and sets the default values.
        /// </summary>
        public ReviewsPostRequestBody_comments() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReviewsPostRequestBody_comments CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReviewsPostRequestBody_comments();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"body", n => { Body = n.GetStringValue(); } },
                {"line", n => { Line = n.GetIntValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"position", n => { Position = n.GetIntValue(); } },
                {"side", n => { Side = n.GetStringValue(); } },
                {"start_line", n => { StartLine = n.GetIntValue(); } },
                {"start_side", n => { StartSide = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("body", Body);
            writer.WriteIntValue("line", Line);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("position", Position);
            writer.WriteStringValue("side", Side);
            writer.WriteIntValue("start_line", StartLine);
            writer.WriteStringValue("start_side", StartSide);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}