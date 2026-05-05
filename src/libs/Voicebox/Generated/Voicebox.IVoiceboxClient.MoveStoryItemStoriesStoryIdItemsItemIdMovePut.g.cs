#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Move Story Item<br/>
        /// Move a story item (update position and/or track).
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> MoveStoryItemStoriesStoryIdItemsItemIdMovePutAsync(
            string storyId,
            string itemId,

            global::Voicebox.StoryItemMove request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Story Item<br/>
        /// Move a story item (update position and/or track).
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.StoryItemDetail>> MoveStoryItemStoriesStoryIdItemsItemIdMovePutAsResponseAsync(
            string storyId,
            string itemId,

            global::Voicebox.StoryItemMove request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Story Item<br/>
        /// Move a story item (update position and/or track).
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="track">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> MoveStoryItemStoriesStoryIdItemsItemIdMovePutAsync(
            string storyId,
            string itemId,
            int startTimeMs,
            int? track = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}