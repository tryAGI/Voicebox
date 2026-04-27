
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for moving a story item (position and/or track).
    /// </summary>
    public sealed partial class StoryItemMove
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeMs { get; set; }

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
        /// Initializes a new instance of the <see cref="StoryItemMove" /> class.
        /// </summary>
        /// <param name="startTimeMs"></param>
        /// <param name="track">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemMove(
            int startTimeMs,
            int? track)
        {
            this.StartTimeMs = startTimeMs;
            this.Track = track;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemMove" /> class.
        /// </summary>
        public StoryItemMove()
        {
        }
    }
}