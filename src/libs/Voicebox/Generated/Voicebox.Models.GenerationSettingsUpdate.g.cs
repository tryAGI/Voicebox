
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Partial update for generation settings — every field is optional.
    /// </summary>
    public sealed partial class GenerationSettingsUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoplay_on_generate")]
        public bool? AutoplayOnGenerate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossfade_ms")]
        public int? CrossfadeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunk_chars")]
        public int? MaxChunkChars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize_audio")]
        public bool? NormalizeAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSettingsUpdate" /> class.
        /// </summary>
        /// <param name="autoplayOnGenerate"></param>
        /// <param name="crossfadeMs"></param>
        /// <param name="maxChunkChars"></param>
        /// <param name="normalizeAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationSettingsUpdate(
            bool? autoplayOnGenerate,
            int? crossfadeMs,
            int? maxChunkChars,
            bool? normalizeAudio)
        {
            this.AutoplayOnGenerate = autoplayOnGenerate;
            this.CrossfadeMs = crossfadeMs;
            this.MaxChunkChars = maxChunkChars;
            this.NormalizeAudio = normalizeAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSettingsUpdate" /> class.
        /// </summary>
        public GenerationSettingsUpdate()
        {
        }
    }
}