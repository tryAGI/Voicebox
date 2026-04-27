#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Set Channel Voices<br/>
        /// Set which voices are assigned to a channel.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetChannelVoicesChannelsChannelIdVoicesPutAsync(
            string channelId,

            global::Voicebox.ChannelVoiceAssignment request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Channel Voices<br/>
        /// Set which voices are assigned to a channel.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="profileIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetChannelVoicesChannelsChannelIdVoicesPutAsync(
            string channelId,
            global::System.Collections.Generic.IList<string> profileIds,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}