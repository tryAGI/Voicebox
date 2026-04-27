#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Channel<br/>
        /// Update an audio channel.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AudioChannelResponse> UpdateChannelChannelsChannelIdPutAsync(
            string channelId,

            global::Voicebox.AudioChannelUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Channel<br/>
        /// Update an audio channel.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="deviceIds"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AudioChannelResponse> UpdateChannelChannelsChannelIdPutAsync(
            string channelId,
            global::System.Collections.Generic.IList<string>? deviceIds = default,
            string? name = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}