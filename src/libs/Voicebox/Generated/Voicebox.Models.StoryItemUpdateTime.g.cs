
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for updating a story item's timecode.
    /// </summary>
    public sealed partial class StoryItemUpdateTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemUpdateTime" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="startTimeMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemUpdateTime(
            string generationId,
            int startTimeMs)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.StartTimeMs = startTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemUpdateTime" /> class.
        /// </summary>
        public StoryItemUpdateTime()
        {
        }
    }
}