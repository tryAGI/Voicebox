#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Set Profile Channels<br/>
        /// Set which channels a profile is assigned to.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetProfileChannelsProfilesProfileIdChannelsPutAsync(
            string profileId,

            global::Voicebox.ProfileChannelAssignment request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Profile Channels<br/>
        /// Set which channels a profile is assigned to.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<string>> SetProfileChannelsProfilesProfileIdChannelsPutAsResponseAsync(
            string profileId,

            global::Voicebox.ProfileChannelAssignment request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Profile Channels<br/>
        /// Set which channels a profile is assigned to.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="channelIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetProfileChannelsProfilesProfileIdChannelsPutAsync(
            string profileId,
            global::System.Collections.Generic.IList<string> channelIds,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}