#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Profile Effects<br/>
        /// Set or clear the default effects chain for a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.VoiceProfileResponse> UpdateProfileEffectsProfilesProfileIdEffectsPutAsync(
            string profileId,

            global::Voicebox.ProfileEffectsUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Profile Effects<br/>
        /// Set or clear the default effects chain for a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="effectsChain">
        /// Effects chain (null to remove)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.VoiceProfileResponse> UpdateProfileEffectsProfilesProfileIdEffectsPutAsync(
            string profileId,
            global::System.Collections.Generic.IList<global::Voicebox.EffectConfig>? effectsChain = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}