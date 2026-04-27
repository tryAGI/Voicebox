#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Trim Story Item<br/>
        /// Trim a story item.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> TrimStoryItemStoriesStoryIdItemsItemIdTrimPutAsync(
            string storyId,
            string itemId,

            global::Voicebox.StoryItemTrim request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trim Story Item<br/>
        /// Trim a story item.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="trimEndMs"></param>
        /// <param name="trimStartMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> TrimStoryItemStoriesStoryIdItemsItemIdTrimPutAsync(
            string storyId,
            string itemId,
            int trimEndMs,
            int trimStartMs,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}