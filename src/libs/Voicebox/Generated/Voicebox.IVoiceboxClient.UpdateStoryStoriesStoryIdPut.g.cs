#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Update Story<br/>
        /// Update a story.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryResponse> UpdateStoryStoriesStoryIdPutAsync(
            string storyId,

            global::Voicebox.StoryCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Story<br/>
        /// Update a story.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.StoryResponse>> UpdateStoryStoriesStoryIdPutAsResponseAsync(
            string storyId,

            global::Voicebox.StoryCreate request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Story<br/>
        /// Update a story.
        /// </summary>
        /// <param name="storyId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.StoryResponse> UpdateStoryStoriesStoryIdPutAsync(
            string storyId,
            string name,
            string? description = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}