#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Get Rocm Download Progress<br/>
        /// Get ROCm backend download progress via Server-Sent Events.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRocmDownloadProgressBackendRocmProgressGetAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Rocm Download Progress<br/>
        /// Get ROCm backend download progress via Server-Sent Events.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<string>> GetRocmDownloadProgressBackendRocmProgressGetAsResponseAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}