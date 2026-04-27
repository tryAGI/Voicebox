
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Server-persisted defaults for the generation flow.
    /// </summary>
    public sealed partial class GenerationSettingsResponse
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoplay_on_generate")]
        public bool? AutoplayOnGenerate { get; set; }

        /// <summary>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossfade_ms")]
        public int? CrossfadeMs { get; set; }

        /// <summary>
        /// Default Value: 800
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunk_chars")]
        public int? MaxChunkChars { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize_audio")]
        public bool? NormalizeAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSettingsResponse" /> class.
        /// </summary>
        /// <param name="autoplayOnGenerate">
        /// Default Value: true
        /// </param>
        /// <param name="crossfadeMs">
        /// Default Value: 50
        /// </param>
        /// <param name="maxChunkChars">
        /// Default Value: 800
        /// </param>
        /// <param name="normalizeAudio">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationSettingsResponse(
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
        /// Initializes a new instance of the <see cref="GenerationSettingsResponse" /> class.
        /// </summary>
        public GenerationSettingsResponse()
        {
        }
    }
}