#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Create Effect Preset<br/>
        /// Create a new effect preset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.EffectPresetResponse> CreateEffectPresetEffectsPresetsPostAsync(

            global::Voicebox.EffectPresetCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Effect Preset<br/>
        /// Create a new effect preset.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="effectsChain"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.EffectPresetResponse> CreateEffectPresetEffectsPresetsPostAsync(
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig> effectsChain,
            string name,
            string? description = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}