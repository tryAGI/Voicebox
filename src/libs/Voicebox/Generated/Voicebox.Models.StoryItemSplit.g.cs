
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for splitting a story item.
    /// </summary>
    public sealed partial class StoryItemSplit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SplitTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemSplit" /> class.
        /// </summary>
        /// <param name="splitTimeMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemSplit(
            int splitTimeMs)
        {
            this.SplitTimeMs = splitTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemSplit" /> class.
        /// </summary>
        public StoryItemSplit()
        {
        }
    }
}