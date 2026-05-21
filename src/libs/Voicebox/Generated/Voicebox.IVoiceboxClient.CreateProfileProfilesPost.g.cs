#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Create Profile<br/>
        /// Create a new voice profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.VoiceProfileResponse> CreateProfileProfilesPostAsync(

            global::Voicebox.VoiceProfileCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Profile<br/>
        /// Create a new voice profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.VoiceProfileResponse>> CreateProfileProfilesPostAsResponseAsync(

            global::Voicebox.VoiceProfileCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Profile<br/>
        /// Create a new voice profile.
        /// </summary>
        /// <param name="defaultEngine"></param>
        /// <param name="description"></param>
        /// <param name="designPrompt"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="name"></param>
        /// <param name="personality"></param>
        /// <param name="presetEngine"></param>
        /// <param name="presetVoiceId"></param>
        /// <param name="voiceType">
        /// Default Value: cloned
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.VoiceProfileResponse> CreateProfileProfilesPostAsync(
            string name,
            string? defaultEngine = default,
            string? description = default,
            string? designPrompt = default,
            string? language = default,
            string? personality = default,
            string? presetEngine = default,
            string? presetVoiceId = default,
            string? voiceType = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}