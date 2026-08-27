
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for voice generation.
    /// </summary>
    public sealed partial class GenerationRequest
    {
        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Default Value: 1.7B
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_size")]
        public string? ModelSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="text"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="modelSize">
        /// Default Value: 1.7B
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationRequest(
            string profileId,
            string text,
            string? language,
            string? modelSize,
            int? seed)
        {
            this.Language = language;
            this.ModelSize = modelSize;
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.Seed = seed;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        public GenerationRequest()
        {
        }

    }
}