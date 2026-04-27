
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response listing all available effect types.
    /// </summary>
    public sealed partial class AvailableEffectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.AvailableEffect> Effects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableEffectsResponse" /> class.
        /// </summary>
        /// <param name="effects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvailableEffectsResponse(
            global::System.Collections.Generic.IList<global::Voicebox.AvailableEffect> effects)
        {
            this.Effects = effects ?? throw new global::System.ArgumentNullException(nameof(effects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableEffectsResponse" /> class.
        /// </summary>
        public AvailableEffectsResponse()
        {
        }
    }
}