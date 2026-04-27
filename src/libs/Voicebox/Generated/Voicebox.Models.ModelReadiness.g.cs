
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Per-model entry in the dictation readiness checklist.<br/>
    /// ``model_name`` is the canonical id used by ``POST /models/download`` so the<br/>
    /// frontend can wire a one-click "Download" button without a second lookup.<br/>
    /// ``size`` is the user's chosen variant (e.g. "turbo", "0.6B"); ``display_name``<br/>
    /// is what the checklist row should show ("Whisper Turbo").
    /// </summary>
    public sealed partial class ModelReadiness
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ready { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_mb")]
        public int? SizeMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelReadiness" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="modelName"></param>
        /// <param name="ready"></param>
        /// <param name="size"></param>
        /// <param name="sizeMb"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelReadiness(
            string displayName,
            string modelName,
            bool ready,
            string size,
            int? sizeMb)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Ready = ready;
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.SizeMb = sizeMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelReadiness" /> class.
        /// </summary>
        public ModelReadiness()
        {
        }
    }
}