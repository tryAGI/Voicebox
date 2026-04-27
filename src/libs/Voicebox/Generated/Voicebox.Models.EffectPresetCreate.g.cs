
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for creating an effect preset.
    /// </summary>
    public sealed partial class EffectPresetCreate
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectPresetCreate" /> class.
        /// </summary>
        /// <param name="effectsChain"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectPresetCreate(
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> effectsChain,
            string name,
            string? description)
        {
            this.Description = description;
            this.EffectsChain = effectsChain ?? throw new global::System.ArgumentNullException(nameof(effectsChain));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectPresetCreate" /> class.
        /// </summary>
        public EffectPresetCreate()
        {
        }
    }
}