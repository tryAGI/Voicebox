#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Capture Settings Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureSettingsResponse> UpdateCaptureSettingsEndpointSettingsCapturesPutAsync(

            global::Voicebox.CaptureSettingsUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Capture Settings Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.CaptureSettingsResponse>> UpdateCaptureSettingsEndpointSettingsCapturesPutAsResponseAsync(

            global::Voicebox.CaptureSettingsUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Capture Settings Endpoint
        /// </summary>
        /// <param name="allowAutoPaste"></param>
        /// <param name="autoRefine"></param>
        /// <param name="chordPushToTalkKeys"></param>
        /// <param name="chordToggleToTalkKeys"></param>
        /// <param name="defaultPlaybackVoiceId"></param>
        /// <param name="hotkeyEnabled"></param>
        /// <param name="language"></param>
        /// <param name="llmModel"></param>
        /// <param name="preserveTechnical"></param>
        /// <param name="selfCorrection"></param>
        /// <param name="smartCleanup"></param>
        /// <param name="sttModel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureSettingsResponse> UpdateCaptureSettingsEndpointSettingsCapturesPutAsync(
            bool? allowAutoPaste = default,
            bool? autoRefine = default,
            global::System.Collections.Generic.IList<string>? chordPushToTalkKeys = default,
            global::System.Collections.Generic.IList<string>? chordToggleToTalkKeys = default,
            string? defaultPlaybackVoiceId = default,
            bool? hotkeyEnabled = default,
            string? language = default,
            string? llmModel = default,
            bool? preserveTechnical = default,
            bool? selfCorrection = default,
            bool? smartCleanup = default,
            string? sttModel = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}