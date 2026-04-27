
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for a capture.
    /// </summary>
    public sealed partial class CaptureResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

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
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refinement_flags")]
        public global::Voicebox.RefinementFlagsModel? RefinementFlags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_model")]
        public string? SttModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_raw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptRaw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_refined")]
        public string? TranscriptRefined { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureResponse" /> class.
        /// </summary>
        /// <param name="audioPath"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="source"></param>
        /// <param name="transcriptRaw"></param>
        /// <param name="durationMs"></param>
        /// <param name="language"></param>
        /// <param name="llmModel"></param>
        /// <param name="refinementFlags"></param>
        /// <param name="sttModel"></param>
        /// <param name="transcriptRefined"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptureResponse(
            string audioPath,
            global::System.DateTime createdAt,
            string id,
            string source,
            string transcriptRaw,
            int? durationMs,
            string? language,
            string? llmModel,
            global::Voicebox.RefinementFlagsModel? refinementFlags,
            string? sttModel,
            string? transcriptRefined)
        {
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.CreatedAt = createdAt;
            this.DurationMs = durationMs;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Language = language;
            this.LlmModel = llmModel;
            this.RefinementFlags = refinementFlags;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.SttModel = sttModel;
            this.TranscriptRaw = transcriptRaw ?? throw new global::System.ArgumentNullException(nameof(transcriptRaw));
            this.TranscriptRefined = transcriptRefined;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureResponse" /> class.
        /// </summary>
        public CaptureResponse()
        {
        }
    }
}