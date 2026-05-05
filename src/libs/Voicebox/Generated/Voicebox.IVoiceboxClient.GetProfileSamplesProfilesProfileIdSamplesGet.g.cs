#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Get Profile Samples<br/>
        /// Get all samples for a profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Voicebox.ProfileSampleResponse>> GetProfileSamplesProfilesProfileIdSamplesGetAsync(
            string profileId,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Profile Samples<br/>
        /// Get all samples for a profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Voicebox.ProfileSampleResponse>>> GetProfileSamplesProfilesProfileIdSamplesGetAsResponseAsync(
            string profileId,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}