
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for voice generation.
    /// </summary>
    public sealed partial class GenerationRequest
    {
        /// <summary>
        /// Crossfade duration in ms between chunks (0 for hard cut)<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossfade_ms")]
        public int? CrossfadeMs { get; set; }

        /// <summary>
        /// Effects chain to apply after generation (overrides profile default)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects_chain")]
        public global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? EffectsChain { get; set; }

        /// <summary>
        /// Default Value: qwen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct")]
        public string? Instruct { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Max characters per chunk for long text splitting<br/>
        /// Default Value: 800
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunk_chars")]
        public int? MaxChunkChars { get; set; }

        /// <summary>
        /// Default Value: 1.7B
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_size")]
        public string? ModelSize { get; set; }

        /// <summary>
        /// Normalize output audio volume<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// When true and the profile has a personality prompt, the input text is rewritten in-character before TTS.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        public bool? Personality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="text"></param>
        /// <param name="crossfadeMs">
        /// Crossfade duration in ms between chunks (0 for hard cut)<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="effectsChain">
        /// Effects chain to apply after generation (overrides profile default)
        /// </param>
        /// <param name="engine">
        /// Default Value: qwen
        /// </param>
        /// <param name="instruct"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="maxChunkChars">
        /// Max characters per chunk for long text splitting<br/>
        /// Default Value: 800
        /// </param>
        /// <param name="modelSize">
        /// Default Value: 1.7B
        /// </param>
        /// <param name="normalize">
        /// Normalize output audio volume<br/>
        /// Default Value: true
        /// </param>
        /// <param name="personality">
        /// When true and the profile has a personality prompt, the input text is rewritten in-character before TTS.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequest(
            string profileId,
            string text,
            int? crossfadeMs,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain,
            string? engine,
            string? instruct,
            string? language,
            int? maxChunkChars,
            string? modelSize,
            bool? normalize,
            bool? personality,
            int? seed)
        {
            this.CrossfadeMs = crossfadeMs;
            this.EffectsChain = effectsChain;
            this.Engine = engine;
            this.Instruct = instruct;
            this.Language = language;
            this.MaxChunkChars = maxChunkChars;
            this.ModelSize = modelSize;
            this.Normalize = normalize;
            this.Personality = personality;
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.Seed = seed;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        public GenerationRequest()
        {
        }
    }
}