
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Detail model for story item with generation info.
    /// </summary>
    public sealed partial class StoryItemDetail
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
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime GenerationCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("story_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        public int? Track { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_end_ms")]
        public int? TrimEndMs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_start_ms")]
        public int? TrimStartMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::Voicebox.GenerationVersionResponse>? Versions { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemDetail" /> class.
        /// </summary>
        /// <param name="audioPath"></param>
        /// <param name="createdAt"></param>
        /// <param name="duration"></param>
        /// <param name="generationCreatedAt"></param>
        /// <param name="generationId"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="profileId"></param>
        /// <param name="profileName"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="storyId"></param>
        /// <param name="text"></param>
        /// <param name="activeVersionId"></param>
        /// <param name="engine"></param>
        /// <param name="instruct"></param>
        /// <param name="seed"></param>
        /// <param name="track">
        /// Default Value: 0
        /// </param>
        /// <param name="trimEndMs">
        /// Default Value: 0
        /// </param>
        /// <param name="trimStartMs">
        /// Default Value: 0
        /// </param>
        /// <param name="versionId"></param>
        /// <param name="versions"></param>
        /// <param name="volume">
        /// Default Value: 1F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemDetail(
            string audioPath,
            global::System.DateTime createdAt,
            double duration,
            global::System.DateTime generationCreatedAt,
            string generationId,
            string id,
            string language,
            string profileId,
            string profileName,
            int startTimeMs,
            string storyId,
            string text,
            string? activeVersionId,
            string? engine,
            string? instruct,
            int? seed,
            int? track,
            int? trimEndMs,
            int? trimStartMs,
            string? versionId,
            global::System.Collections.Generic.IList<global::Voicebox.GenerationVersionResponse>? versions,
            double? volume)
        {
            this.ActiveVersionId = activeVersionId;
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.CreatedAt = createdAt;
            this.Duration = duration;
            this.Engine = engine;
            this.GenerationCreatedAt = generationCreatedAt;
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Instruct = instruct;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
            this.ProfileName = profileName ?? throw new global::System.ArgumentNullException(nameof(profileName));
            this.Seed = seed;
            this.StartTimeMs = startTimeMs;
            this.StoryId = storyId ?? throw new global::System.ArgumentNullException(nameof(storyId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Track = track;
            this.TrimEndMs = trimEndMs;
            this.TrimStartMs = trimStartMs;
            this.VersionId = versionId;
            this.Versions = versions;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemDetail" /> class.
        /// </summary>
        public StoryItemDetail()
        {
        }
    }
}