
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Body for POST /speak — non-MCP REST surface that mirrors voicebox.speak.
    /// </summary>
    public sealed partial class SpeakRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// When true and the profile has a personality prompt, the input text is rewritten in-character before TTS. When null, the per-client binding's default_personality flag decides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        public bool? Personality { get; set; }

        /// <summary>
        /// Voice profile name or id. Falls back to per-client binding, then default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; set; }

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
        /// Initializes a new instance of the <see cref="SpeakRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="personality">
        /// When true and the profile has a personality prompt, the input text is rewritten in-character before TTS. When null, the per-client binding's default_personality flag decides.
        /// </param>
        /// <param name="profile">
        /// Voice profile name or id. Falls back to per-client binding, then default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakRequest(
            string text,
            string? engine,
            string? language,
            bool? personality,
            string? profile)
        {
            this.Engine = engine;
            this.Language = language;
            this.Personality = personality;
            this.Profile = profile;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakRequest" /> class.
        /// </summary>
        public SpeakRequest()
        {
        }
    }
}