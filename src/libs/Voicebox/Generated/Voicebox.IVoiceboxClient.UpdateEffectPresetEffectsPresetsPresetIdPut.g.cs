#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Effect Preset<br/>
        /// Update an effect preset.
        /// </summary>
        /// <param name="presetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.EffectPresetResponse> UpdateEffectPresetEffectsPresetsPresetIdPutAsync(
            string presetId,

            global::Voicebox.EffectPresetUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Effect Preset<br/>
        /// Update an effect preset.
        /// </summary>
        /// <param name="presetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.EffectPresetResponse>> UpdateEffectPresetEffectsPresetsPresetIdPutAsResponseAsync(
            string presetId,

            global::Voicebox.EffectPresetUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Effect Preset<br/>
        /// Update an effect preset.
        /// </summary>
        /// <param name="presetId"></param>
        /// <param name="description"></param>
        /// <param name="effectsChain"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.EffectPresetResponse> UpdateEffectPresetEffectsPresetsPresetIdPutAsync(
            string presetId,
            string? description = default,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain = default,
            string? name = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}