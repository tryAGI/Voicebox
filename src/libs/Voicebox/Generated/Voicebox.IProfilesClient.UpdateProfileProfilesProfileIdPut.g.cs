#nullable enable

namespace Voicebox
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// Update Profile<br/>
        /// Update a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.VoiceProfileResponse> UpdateProfileProfilesProfileIdPutAsync(
            string profileId,

            global::Voicebox.VoiceProfileCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Profile<br/>
        /// Update a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.VoiceProfileResponse>> UpdateProfileProfilesProfileIdPutAsResponseAsync(
            string profileId,

            global::Voicebox.VoiceProfileCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Profile<br/>
        /// Update a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="description"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.VoiceProfileResponse> UpdateProfileProfilesProfileIdPutAsync(
            string profileId,
            string name,
            string? description = default,
            string? language = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}