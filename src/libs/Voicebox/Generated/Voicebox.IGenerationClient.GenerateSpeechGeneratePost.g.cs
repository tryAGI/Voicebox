#nullable enable

namespace Voicebox
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Generate Speech<br/>
        /// Generate speech from text using a voice profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> GenerateSpeechGeneratePostAsync(

            global::Voicebox.GenerationRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Speech<br/>
        /// Generate speech from text using a voice profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.GenerationResponse>> GenerateSpeechGeneratePostAsResponseAsync(

            global::Voicebox.GenerationRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Speech<br/>
        /// Generate speech from text using a voice profile.
        /// </summary>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="modelSize">
        /// Default Value: 1.7B
        /// </param>
        /// <param name="profileId"></param>
        /// <param name="seed"></param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> GenerateSpeechGeneratePostAsync(
            string profileId,
            string text,
            string? language = default,
            string? modelSize = default,
            int? seed = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}