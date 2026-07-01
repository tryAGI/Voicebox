#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Delete Rocm Backend<br/>
        /// Delete the downloaded ROCm backend binary.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRocmBackendBackendRocmDeleteAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Rocm Backend<br/>
        /// Delete the downloaded ROCm backend binary.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<string>> DeleteRocmBackendBackendRocmDeleteAsResponseAsync(
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}