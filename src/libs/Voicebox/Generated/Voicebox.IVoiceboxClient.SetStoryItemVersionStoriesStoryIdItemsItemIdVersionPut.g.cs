#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Set Story Item Version<br/>
        /// Pin a story item to a specific generation version.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> SetStoryItemVersionStoriesStoryIdItemsItemIdVersionPutAsync(
            string storyId,
            string itemId,

            global::Voicebox.StoryItemVersionUpdate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Story Item Version<br/>
        /// Pin a story item to a specific generation version.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="itemId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> SetStoryItemVersionStoriesStoryIdItemsItemIdVersionPutAsync(
            string storyId,
            string itemId,
            string? versionId = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}