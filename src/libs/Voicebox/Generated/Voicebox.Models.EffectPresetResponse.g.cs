
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for effect preset.
    /// </summary>
    public sealed partial class EffectPresetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects_chain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> EffectsChain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_builtin")]
        public bool? IsBuiltin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectPresetResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="effectsChain"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isBuiltin">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectPresetResponse(
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> effectsChain,
            string id,
            string name,
            string? description,
            bool? isBuiltin)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.EffectsChain = effectsChain ?? throw new global::System.ArgumentNullException(nameof(effectsChain));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsBuiltin = isBuiltin;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectPresetResponse" /> class.
        /// </summary>
        public EffectPresetResponse()
        {
        }
    }
}