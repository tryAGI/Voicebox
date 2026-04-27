
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for ``POST /captures``.<br/>
    /// Adds ``auto_refine`` and ``allow_auto_paste`` — the server-side settings<br/>
    /// captured at the moment the capture was created. The client reads these to<br/>
    /// decide whether to chain a refinement request and whether to fire the<br/>
    /// synthetic-paste pipeline, so it doesn't need a synced local copy of the<br/>
    /// capture_settings table across sibling Tauri webviews.
    /// </summary>
    public sealed partial class CaptureCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_paste")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAutoPaste { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_refine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRefine { get; set; }

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
        /// Initializes a new instance of the <see cref="CaptureCreateResponse" /> class.
        /// </summary>
        /// <param name="allowAutoPaste"></param>
        /// <param name="audioPath"></param>
        /// <param name="autoRefine"></param>
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
        public CaptureCreateResponse(
            bool allowAutoPaste,
            string audioPath,
            bool autoRefine,
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
            this.AllowAutoPaste = allowAutoPaste;
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.AutoRefine = autoRefine;
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
        /// Initializes a new instance of the <see cref="CaptureCreateResponse" /> class.
        /// </summary>
        public CaptureCreateResponse()
        {
        }
    }
}