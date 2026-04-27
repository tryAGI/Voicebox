
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for adding a generation to a story.
    /// </summary>
    public sealed partial class StoryItemCreate
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
        public int? StartTimeMs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        public int? Track { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemCreate" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="track">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemCreate(
            string generationId,
            int? startTimeMs,
            int? track)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.StartTimeMs = startTimeMs;
            this.Track = track;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemCreate" /> class.
        /// </summary>
        public StoryItemCreate()
        {
        }
    }
}