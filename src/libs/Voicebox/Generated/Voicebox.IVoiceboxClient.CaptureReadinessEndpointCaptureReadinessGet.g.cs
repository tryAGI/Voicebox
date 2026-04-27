#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Capture Readiness Endpoint<br/>
        /// Whether the STT and LLM models the user has selected are downloaded.<br/>
        /// The frontend gates the global hotkey on this — pressing the chord with<br/>
        /// a missing model would otherwise produce a stuck "transcribing" pill that<br/>
        /// waits forever for a download to finish. Checks on-disk cache, not RAM<br/>
        /// load, so the answer survives backend restarts.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureReadinessResponse> CaptureReadinessEndpointCaptureReadinessGetAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}