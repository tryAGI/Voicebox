
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request to update the default effects chain on a profile.
    /// </summary>
    public sealed partial class ProfileEffectsUpdate
    {
        /// <summary>
        /// Effects chain (null to remove)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects_chain")]
        public global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? EffectsChain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileEffectsUpdate" /> class.
        /// </summary>
        /// <param name="effectsChain">
        /// Effects chain (null to remove)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileEffectsUpdate(
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain)
        {
            this.EffectsChain = effectsChain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileEffectsUpdate" /> class.
        /// </summary>
        public ProfileEffectsUpdate()
        {
        }
    }
}