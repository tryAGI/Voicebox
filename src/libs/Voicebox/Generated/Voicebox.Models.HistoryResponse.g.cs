
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
        [global::System.Text.Json.Serialization.JsonPropertyName("active_version_id")]
        public string? ActiveVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        public string? AudioPath { get; set; }

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
        public double? Duration { get; set; }

        /// <summary>
        /// Default Value: qwen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruct")]
        public string? Instruct { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorited")]
        public bool? IsFavorited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
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
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::Voicebox.GenerationVersionResponse>? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="profileId"></param>
        /// <param name="profileName"></param>
        /// <param name="text"></param>
        /// <param name="activeVersionId"></param>
        /// <param name="audioPath"></param>
        /// <param name="duration"></param>
        /// <param name="engine">
        /// Default Value: qwen
        /// </param>
        /// <param name="error"></param>
        /// <param name="instruct"></param>
        /// <param name="isFavorited">
        /// Default Value: false
        /// </param>
        /// <param name="modelSize"></param>
        /// <param name="seed"></param>
        /// <param name="status">
        /// Default Value: completed
        /// </param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryResponse(
            global::System.DateTime createdAt,
            string id,
            string language,
            string profileId,
            string profileName,
            string text,
            string? activeVersionId,
            string? audioPath,
            double? duration,
            string? engine,
            string? error,
            string? instruct,
            bool? isFavorited,
            string? modelSize,
            int? seed,
            string? status,
            global::System.Collections.Generic.IList<global::Voicebox.GenerationVersionResponse>? versions)
        {
            this.ActiveVersionId = activeVersionId;
            this.AudioPath = audioPath;
            this.CreatedAt = createdAt;
            this.Duration = duration;
            this.Engine = engine;
            this.Error = error;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Instruct = instruct;
            this.IsFavorited = isFavorited;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ModelSize = modelSize;
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.ProfileName = profileName ?? throw new global::System.ArgumentNullException(nameof(profileName));
            this.Seed = seed;
            this.Status = status;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResponse" /> class.
        /// </summary>
        public HistoryResponse()
        {
        }
    }
}