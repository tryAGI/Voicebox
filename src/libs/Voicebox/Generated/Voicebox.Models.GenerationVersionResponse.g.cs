
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for a generation version.
    /// </summary>
    public sealed partial class GenerationVersionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects_chain")]
        public global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? EffectsChain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_version_id")]
        public string? SourceVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationVersionResponse" /> class.
        /// </summary>
        /// <param name="audioPath"></param>
        /// <param name="createdAt"></param>
        /// <param name="generationId"></param>
        /// <param name="id"></param>
        /// <param name="isDefault"></param>
        /// <param name="label"></param>
        /// <param name="effectsChain"></param>
        /// <param name="sourceVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationVersionResponse(
            string audioPath,
            global::System.DateTime createdAt,
            string generationId,
            string id,
            bool isDefault,
            string label,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain,
            string? sourceVersionId)
        {
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.CreatedAt = createdAt;
            this.EffectsChain = effectsChain;
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsDefault = isDefault;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.SourceVersionId = sourceVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationVersionResponse" /> class.
        /// </summary>
        public GenerationVersionResponse()
        {
        }
    }
}