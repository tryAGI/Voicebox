#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Refine Capture Endpoint
        /// </summary>
        /// <param name="captureId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureResponse> RefineCaptureEndpointCapturesCaptureIdRefinePostAsync(
            string captureId,

            global::Voicebox.CaptureRefineRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refine Capture Endpoint
        /// </summary>
        /// <param name="captureId"></param>
        /// <param name="flags"></param>
        /// <param name="modelSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureResponse> RefineCaptureEndpointCapturesCaptureIdRefinePostAsync(
            string captureId,
            global::Voicebox.RefinementFlagsModel? flags = default,
            string? modelSize = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}