#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Retranscribe Capture Endpoint
        /// </summary>
        /// <param name="captureId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureResponse> RetranscribeCaptureEndpointCapturesCaptureIdRetranscribePostAsync(
            string captureId,

            global::Voicebox.CaptureRetranscribeRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retranscribe Capture Endpoint
        /// </summary>
        /// <param name="captureId"></param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.CaptureResponse> RetranscribeCaptureEndpointCapturesCaptureIdRetranscribePostAsync(
            string captureId,
            string? language = default,
            string? model = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}