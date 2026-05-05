#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Story Item Times<br/>
        /// Update story item timecodes.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateStoryItemTimesStoriesStoryIdItemsTimesPutAsync(
            string storyId,

            global::Voicebox.StoryItemBatchUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Story Item Times<br/>
        /// Update story item timecodes.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<string>> UpdateStoryItemTimesStoriesStoryIdItemsTimesPutAsResponseAsync(
            string storyId,

            global::Voicebox.StoryItemBatchUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Story Item Times<br/>
        /// Update story item timecodes.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="updates"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateStoryItemTimesStoriesStoryIdItemsTimesPutAsync(
            string storyId,
            global::System.Collections.Generic.IList<global::Voicebox.StoryItemUpdateTime> updates,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}