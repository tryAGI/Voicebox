
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request to re-run STT on a capture's audio with a different model.
    /// </summary>
    public sealed partial class CaptureRetranscribeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRetranscribeRequest" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptureRetranscribeRequest(
            string? language,
            string? model)
        {
            this.Language = language;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRetranscribeRequest" /> class.
        /// </summary>
        public CaptureRetranscribeRequest()
        {
        }
    }
}