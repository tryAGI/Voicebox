#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Add Profile Sample<br/>
        /// Add a sample to a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.ProfileSampleResponse> AddProfileSampleProfilesProfileIdSamplesPostAsync(
            string profileId,

            global::Voicebox.BodyAddProfileSampleProfilesProfileIdSamplesPost request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Profile Sample<br/>
        /// Add a sample to a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.ProfileSampleResponse>> AddProfileSampleProfilesProfileIdSamplesPostAsResponseAsync(
            string profileId,

            global::Voicebox.BodyAddProfileSampleProfilesProfileIdSamplesPost request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Profile Sample<br/>
        /// Add a sample to a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="referenceText"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.ProfileSampleResponse> AddProfileSampleProfilesProfileIdSamplesPostAsync(
            string profileId,
            byte[] file,
            string filename,
            string referenceText,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Profile Sample<br/>
        /// Add a sample to a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="referenceText"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.ProfileSampleResponse> AddProfileSampleProfilesProfileIdSamplesPostAsync(
            string profileId,
            global::System.IO.Stream file,
            string filename,
            string referenceText,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Profile Sample<br/>
        /// Add a sample to a voice profile.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="referenceText"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.ProfileSampleResponse>> AddProfileSampleProfilesProfileIdSamplesPostAsResponseAsync(
            string profileId,
            global::System.IO.Stream file,
            string filename,
            string referenceText,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}