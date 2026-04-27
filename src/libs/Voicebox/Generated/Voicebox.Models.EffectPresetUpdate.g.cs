
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for updating an effect preset.
    /// </summary>
    public sealed partial class EffectPresetUpdate
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
        public global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? EffectsChain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectPresetUpdate" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="effectsChain"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectPresetUpdate(
            string? description,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain,
            string? name)
        {
            this.Description = description;
            this.EffectsChain = effectsChain;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectPresetUpdate" /> class.
        /// </summary>
        public EffectPresetUpdate()
        {
        }
    }
}