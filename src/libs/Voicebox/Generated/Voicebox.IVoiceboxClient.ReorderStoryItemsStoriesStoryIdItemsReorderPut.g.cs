#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Reorder Story Items<br/>
        /// Reorder story items and recalculate timecodes.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Voicebox.StoryItemDetail>> ReorderStoryItemsStoriesStoryIdItemsReorderPutAsync(
            string storyId,

            global::Voicebox.StoryItemReorder request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reorder Story Items<br/>
        /// Reorder story items and recalculate timecodes.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="generationIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Voicebox.StoryItemDetail>> ReorderStoryItemsStoriesStoryIdItemsReorderPutAsync(
            string storyId,
            global::System.Collections.Generic.IList<string> generationIds,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}