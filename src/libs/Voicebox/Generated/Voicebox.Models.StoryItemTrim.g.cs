
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for trimming a story item.
    /// </summary>
    public sealed partial class StoryItemTrim
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrimEndMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrimStartMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemTrim" /> class.
        /// </summary>
        /// <param name="trimEndMs"></param>
        /// <param name="trimStartMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemTrim(
            int trimEndMs,
            int trimStartMs)
        {
            this.TrimEndMs = trimEndMs;
            this.TrimStartMs = trimStartMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemTrim" /> class.
        /// </summary>
        public StoryItemTrim()
        {
        }
    }
}