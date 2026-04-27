
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for voice profile.
    /// </summary>
    public sealed partial class VoiceProfileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_path")]
        public string? AvatarPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_engine")]
        public string? DefaultEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_prompt")]
        public string? DesignPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects_chain")]
        public global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? EffectsChain { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_count")]
        public int? GenerationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        public string? Personality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_engine")]
        public string? PresetEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_voice_id")]
        public string? PresetVoiceId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_count")]
        public int? SampleCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Default Value: cloned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_type")]
        public string? VoiceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProfileResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="name"></param>
        /// <param name="updatedAt"></param>
        /// <param name="avatarPath"></param>
        /// <param name="defaultEngine"></param>
        /// <param name="description"></param>
        /// <param name="designPrompt"></param>
        /// <param name="effectsChain"></param>
        /// <param name="generationCount">
        /// Default Value: 0
        /// </param>
        /// <param name="personality"></param>
        /// <param name="presetEngine"></param>
        /// <param name="presetVoiceId"></param>
        /// <param name="sampleCount">
        /// Default Value: 0
        /// </param>
        /// <param name="voiceType">
        /// Default Value: cloned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceProfileResponse(
            global::System.DateTime createdAt,
            string id,
            string language,
            string name,
            global::System.DateTime updatedAt,
            string? avatarPath,
            string? defaultEngine,
            string? description,
            string? designPrompt,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain,
            int? generationCount,
            string? personality,
            string? presetEngine,
            string? presetVoiceId,
            int? sampleCount,
            string? voiceType)
        {
            this.AvatarPath = avatarPath;
            this.CreatedAt = createdAt;
            this.DefaultEngine = defaultEngine;
            this.Description = description;
            this.DesignPrompt = designPrompt;
            this.EffectsChain = effectsChain;
            this.GenerationCount = generationCount;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Personality = personality;
            this.PresetEngine = presetEngine;
            this.PresetVoiceId = presetVoiceId;
            this.SampleCount = sampleCount;
            this.UpdatedAt = updatedAt;
            this.VoiceType = voiceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProfileResponse" /> class.
        /// </summary>
        public VoiceProfileResponse()
        {
        }
    }
}