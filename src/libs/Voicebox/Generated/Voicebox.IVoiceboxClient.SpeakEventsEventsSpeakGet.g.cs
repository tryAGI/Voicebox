#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Speak Events<br/>
        /// SSE stream of speak-start / speak-end events.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SpeakEventsEventsSpeakGetAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speak Events<br/>
        /// SSE stream of speak-start / speak-end events.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<string>> SpeakEventsEventsSpeakGetAsResponseAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}