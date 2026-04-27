#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Llm Generate<br/>
        /// Run a single-turn Qwen3 completion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.LLMGenerateResponse> LlmGenerateLlmGeneratePostAsync(

            global::Voicebox.LLMGenerateRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Llm Generate<br/>
        /// Run a single-turn Qwen3 completion.
        /// </summary>
        /// <param name="examples"></param>
        /// <param name="maxTokens">
        /// Default Value: 512
        /// </param>
        /// <param name="modelSize">
        /// Default Value: 0.6B
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="system"></param>
        /// <param name="temperature">
        /// Default Value: 0.7F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.LLMGenerateResponse> LlmGenerateLlmGeneratePostAsync(
            string prompt,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? examples = default,
            int? maxTokens = default,
            string? modelSize = default,
            string? system = default,
            double? temperature = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}