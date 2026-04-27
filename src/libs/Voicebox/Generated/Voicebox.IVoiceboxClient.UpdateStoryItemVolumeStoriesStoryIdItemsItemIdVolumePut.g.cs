#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Story Item Volume<br/>
        /// Set a story item's per-clip volume (linear gain, 0.0–2.0).
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> UpdateStoryItemVolumeStoriesStoryIdItemsItemIdVolumePutAsync(
            string storyId,
            string itemId,

            global::Voicebox.StoryItemVolumeUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Story Item Volume<br/>
        /// Set a story item's per-clip volume (linear gain, 0.0–2.0).
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="volume"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> UpdateStoryItemVolumeStoriesStoryIdItemsItemIdVolumePutAsync(
            string storyId,
            string itemId,
            double volume,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}