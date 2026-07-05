
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for history entry (includes profile name).
    /// </summary>
    public sealed partial class HistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileName { get; set; }

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
        /// Initializes a new instance of the <see cref="HistoryResponse" /> class.
        /// </summary>
        /// <param name="audioPath"></param>
        /// <param name="createdAt"></param>
        /// <param name="duration"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="profileId"></param>
        /// <param name="profileName"></param>
        /// <param name="text"></param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryResponse(
            string audioPath,
            global::System.DateTime createdAt,
            double duration,
            string id,
            string language,
            string profileId,
            string profileName,
            string text,
            int? seed)
        {
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.CreatedAt = createdAt;
            this.Duration = duration;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.ProfileName = profileName ?? throw new global::System.ArgumentNullException(nameof(profileName));
            this.Seed = seed;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponse" /> class.
        /// </summary>
        public HistoryResponse()
        {
        }

    }
}