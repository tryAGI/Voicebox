
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request to apply effects to an existing generation.
    /// </summary>
    public sealed partial class ApplyEffectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects_chain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> EffectsChain { get; set; }

        /// <summary>
        /// Label for this version (auto-generated if omitted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Set this version as the default<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_as_default")]
        public bool? SetAsDefault { get; set; }

        /// <summary>
        /// Version to use as source audio (defaults to clean/original)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_version_id")]
        public string? SourceVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyEffectsRequest" /> class.
        /// </summary>
        /// <param name="effectsChain"></param>
        /// <param name="label">
        /// Label for this version (auto-generated if omitted)
        /// </param>
        /// <param name="setAsDefault">
        /// Set this version as the default<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sourceVersionId">
        /// Version to use as source audio (defaults to clean/original)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyEffectsRequest(
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> effectsChain,
            string? label,
            bool? setAsDefault,
            string? sourceVersionId)
        {
            this.EffectsChain = effectsChain ?? throw new global::System.ArgumentNullException(nameof(effectsChain));
            this.Label = label;
            this.SetAsDefault = setAsDefault;
            this.SourceVersionId = sourceVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyEffectsRequest" /> class.
        /// </summary>
        public ApplyEffectsRequest()
        {
        }
    }
}