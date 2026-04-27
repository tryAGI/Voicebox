
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Backend gates that must be green before the global hotkey will fire.<br/>
    /// The frontend combines this with its own TCC permission checks (input<br/>
    /// monitoring, accessibility) into the full dictation readiness checklist.<br/>
    /// Hotkey-enabled is the user's intent toggle and lives outside this struct.
    /// </summary>
    public sealed partial class CaptureReadinessResponse
    {
        /// <summary>
        /// Per-model entry in the dictation readiness checklist.<br/>
        /// ``model_name`` is the canonical id used by ``POST /models/download`` so the<br/>
        /// frontend can wire a one-click "Download" button without a second lookup.<br/>
        /// ``size`` is the user's chosen variant (e.g. "turbo", "0.6B"); ``display_name``<br/>
        /// is what the checklist row should show ("Whisper Turbo").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Voicebox.ModelReadiness Llm { get; set; }

        /// <summary>
        /// Per-model entry in the dictation readiness checklist.<br/>
        /// ``model_name`` is the canonical id used by ``POST /models/download`` so the<br/>
        /// frontend can wire a one-click "Download" button without a second lookup.<br/>
        /// ``size`` is the user's chosen variant (e.g. "turbo", "0.6B"); ``display_name``<br/>
        /// is what the checklist row should show ("Whisper Turbo").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Voicebox.ModelReadiness Stt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureReadinessResponse" /> class.
        /// </summary>
        /// <param name="llm">
        /// Per-model entry in the dictation readiness checklist.<br/>
        /// ``model_name`` is the canonical id used by ``POST /models/download`` so the<br/>
        /// frontend can wire a one-click "Download" button without a second lookup.<br/>
        /// ``size`` is the user's chosen variant (e.g. "turbo", "0.6B"); ``display_name``<br/>
        /// is what the checklist row should show ("Whisper Turbo").
        /// </param>
        /// <param name="stt">
        /// Per-model entry in the dictation readiness checklist.<br/>
        /// ``model_name`` is the canonical id used by ``POST /models/download`` so the<br/>
        /// frontend can wire a one-click "Download" button without a second lookup.<br/>
        /// ``size`` is the user's chosen variant (e.g. "turbo", "0.6B"); ``display_name``<br/>
        /// is what the checklist row should show ("Whisper Turbo").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptureReadinessResponse(
            global::Voicebox.ModelReadiness llm,
            global::Voicebox.ModelReadiness stt)
        {
            this.Llm = llm ?? throw new global::System.ArgumentNullException(nameof(llm));
            this.Stt = stt ?? throw new global::System.ArgumentNullException(nameof(stt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureReadinessResponse" /> class.
        /// </summary>
        public CaptureReadinessResponse()
        {
        }
    }
}