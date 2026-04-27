#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Generation Settings Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationSettingsResponse> UpdateGenerationSettingsEndpointSettingsGenerationPutAsync(

            global::Voicebox.GenerationSettingsUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Generation Settings Endpoint
        /// </summary>
        /// <param name="autoplayOnGenerate"></param>
        /// <param name="crossfadeMs"></param>
        /// <param name="maxChunkChars"></param>
        /// <param name="normalizeAudio"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationSettingsResponse> UpdateGenerationSettingsEndpointSettingsGenerationPutAsync(
            bool? autoplayOnGenerate = default,
            int? crossfadeMs = default,
            int? maxChunkChars = default,
            bool? normalizeAudio = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}