#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Apply Effects To Generation<br/>
        /// Apply an effects chain to an existing generation, creating a new version.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationVersionResponse> ApplyEffectsToGenerationGenerationsGenerationIdVersionsApplyEffectsPostAsync(
            string generationId,

            global::Voicebox.ApplyEffectsRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply Effects To Generation<br/>
        /// Apply an effects chain to an existing generation, creating a new version.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="effectsChain"></param>
        /// <param name="label">
        /// Label for this version (auto-generated if omitted)
        /// </param>
        /// <param name="setAsDefault">
        /// Set this version as the default<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sourceVersionId">
        /// Version to use as source audio (defaults to clean/original)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationVersionResponse> ApplyEffectsToGenerationGenerationsGenerationIdVersionsApplyEffectsPostAsync(
            string generationId,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> effectsChain,
            string? label = default,
            bool? setAsDefault = default,
            string? sourceVersionId = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}