#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Get Model Progress<br/>
        /// Get model download progress via Server-Sent Events.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetModelProgressModelsProgressModelNameGetAsync(
            string modelName,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Model Progress<br/>
        /// Get model download progress via Server-Sent Events.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<string>> GetModelProgressModelsProgressModelNameGetAsResponseAsync(
            string modelName,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}