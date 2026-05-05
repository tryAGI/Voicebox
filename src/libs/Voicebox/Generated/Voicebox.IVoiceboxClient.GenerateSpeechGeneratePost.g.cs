#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
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
        /// <param name="crossfadeMs">
        /// Crossfade duration in ms between chunks (0 for hard cut)<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="effectsChain">
        /// Effects chain to apply after generation (overrides profile default)
        /// </param>
        /// <param name="engine">
        /// Default Value: qwen
        /// </param>
        /// <param name="instruct"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="maxChunkChars">
        /// Max characters per chunk for long text splitting<br/>
        /// Default Value: 800
        /// </param>
        /// <param name="modelSize">
        /// Default Value: 1.7B
        /// </param>
        /// <param name="normalize">
        /// Normalize output audio volume<br/>
        /// Default Value: true
        /// </param>
        /// <param name="personality">
        /// When true and the profile has a personality prompt, the input text is rewritten in-character before TTS.<br/>
        /// Default Value: false
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
            int? crossfadeMs = default,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain = default,
            string? engine = default,
            string? instruct = default,
            string? language = default,
            int? maxChunkChars = default,
            string? modelSize = default,
            bool? normalize = default,
            bool? personality = default,
            int? seed = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}