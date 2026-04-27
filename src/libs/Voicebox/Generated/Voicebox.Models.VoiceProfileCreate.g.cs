
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for creating a voice profile.
    /// </summary>
    public sealed partial class VoiceProfileCreate
    {
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
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

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
        /// Initializes a new instance of the <see cref="VoiceProfileCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultEngine"></param>
        /// <param name="description"></param>
        /// <param name="designPrompt"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="personality"></param>
        /// <param name="presetEngine"></param>
        /// <param name="presetVoiceId"></param>
        /// <param name="voiceType">
        /// Default Value: cloned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceProfileCreate(
            string name,
            string? defaultEngine,
            string? description,
            string? designPrompt,
            string? language,
            string? personality,
            string? presetEngine,
            string? presetVoiceId,
            string? voiceType)
        {
            this.DefaultEngine = defaultEngine;
            this.Description = description;
            this.DesignPrompt = designPrompt;
            this.Language = language;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Personality = personality;
            this.PresetEngine = presetEngine;
            this.PresetVoiceId = presetVoiceId;
            this.VoiceType = voiceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceProfileCreate" /> class.
        /// </summary>
        public VoiceProfileCreate()
        {
        }
    }
}