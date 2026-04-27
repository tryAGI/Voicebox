#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Profile Sample<br/>
        /// Update a profile sample's reference text.
        /// </summary>
        /// <param name="sampleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.ProfileSampleResponse> UpdateProfileSampleProfilesSamplesSampleIdPutAsync(
            string sampleId,

            global::Voicebox.ProfileSampleUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Profile Sample<br/>
        /// Update a profile sample's reference text.
        /// </summary>
        /// <param name="sampleId"></param>
        /// <param name="referenceText"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.ProfileSampleResponse> UpdateProfileSampleProfilesSamplesSampleIdPutAsync(
            string sampleId,
            string referenceText,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}