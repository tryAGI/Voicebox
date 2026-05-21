#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Add Story Item<br/>
        /// Add a generation to a story.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> AddStoryItemStoriesStoryIdItemsPostAsync(
            string storyId,

            global::Voicebox.StoryItemCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Story Item<br/>
        /// Add a generation to a story.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.StoryItemDetail>> AddStoryItemStoriesStoryIdItemsPostAsResponseAsync(
            string storyId,

            global::Voicebox.StoryItemCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Story Item<br/>
        /// Add a generation to a story.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="generationId"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="track">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryItemDetail> AddStoryItemStoriesStoryIdItemsPostAsync(
            string storyId,
            string generationId,
            int? startTimeMs = default,
            int? track = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}