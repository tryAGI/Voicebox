
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Server-persisted defaults for the capture / refine flow.
    /// </summary>
    public sealed partial class CaptureSettingsResponse
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_auto_paste")]
        public bool? AllowAutoPaste { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_refine")]
        public bool? AutoRefine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chord_push_to_talk_keys")]
        public global::System.Collections.Generic.IList<string>? ChordPushToTalkKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chord_toggle_to_talk_keys")]
        public global::System.Collections.Generic.IList<string>? ChordToggleToTalkKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_playback_voice_id")]
        public string? DefaultPlaybackVoiceId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotkey_enabled")]
        public bool? HotkeyEnabled { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Default Value: 0.6B
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_technical")]
        public bool? PreserveTechnical { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_correction")]
        public bool? SelfCorrection { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_cleanup")]
        public bool? SmartCleanup { get; set; }

        /// <summary>
        /// Default Value: turbo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_model")]
        public string? SttModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureSettingsResponse" /> class.
        /// </summary>
        /// <param name="allowAutoPaste">
        /// Default Value: true
        /// </param>
        /// <param name="autoRefine">
        /// Default Value: true
        /// </param>
        /// <param name="chordPushToTalkKeys"></param>
        /// <param name="chordToggleToTalkKeys"></param>
        /// <param name="defaultPlaybackVoiceId"></param>
        /// <param name="hotkeyEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="language">
        /// Default Value: auto
        /// </param>
        /// <param name="llmModel">
        /// Default Value: 0.6B
        /// </param>
        /// <param name="preserveTechnical">
        /// Default Value: true
        /// </param>
        /// <param name="selfCorrection">
        /// Default Value: true
        /// </param>
        /// <param name="smartCleanup">
        /// Default Value: true
        /// </param>
        /// <param name="sttModel">
        /// Default Value: turbo
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptureSettingsResponse(
            bool? allowAutoPaste,
            bool? autoRefine,
            global::System.Collections.Generic.IList<string>? chordPushToTalkKeys,
            global::System.Collections.Generic.IList<string>? chordToggleToTalkKeys,
            string? defaultPlaybackVoiceId,
            bool? hotkeyEnabled,
            string? language,
            string? llmModel,
            bool? preserveTechnical,
            bool? selfCorrection,
            bool? smartCleanup,
            string? sttModel)
        {
            this.AllowAutoPaste = allowAutoPaste;
            this.AutoRefine = autoRefine;
            this.ChordPushToTalkKeys = chordPushToTalkKeys;
            this.ChordToggleToTalkKeys = chordToggleToTalkKeys;
            this.DefaultPlaybackVoiceId = defaultPlaybackVoiceId;
            this.HotkeyEnabled = hotkeyEnabled;
            this.Language = language;
            this.LlmModel = llmModel;
            this.PreserveTechnical = preserveTechnical;
            this.SelfCorrection = selfCorrection;
            this.SmartCleanup = smartCleanup;
            this.SttModel = sttModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureSettingsResponse" /> class.
        /// </summary>
        public CaptureSettingsResponse()
        {
        }
    }
}