#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Import Audio<br/>
        /// Register an external audio file as a generation row.<br/>
        /// Designed for the story timeline so users can drop in music or other<br/>
        /// non-TTS audio. The row points at a singleton "Imported Audio" profile<br/>
        /// so the existing generation/story plumbing keeps working unchanged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> ImportAudioGenerateImportPostAsync(

            global::Voicebox.BodyImportAudioGenerateImportPost request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Audio<br/>
        /// Register an external audio file as a generation row.<br/>
        /// Designed for the story timeline so users can drop in music or other<br/>
        /// non-TTS audio. The row points at a singleton "Imported Audio" profile<br/>
        /// so the existing generation/story plumbing keeps working unchanged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.GenerationResponse>> ImportAudioGenerateImportPostAsResponseAsync(

            global::Voicebox.BodyImportAudioGenerateImportPost request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Audio<br/>
        /// Register an external audio file as a generation row.<br/>
        /// Designed for the story timeline so users can drop in music or other<br/>
        /// non-TTS audio. The row points at a singleton "Imported Audio" profile<br/>
        /// so the existing generation/story plumbing keeps working unchanged.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> ImportAudioGenerateImportPostAsync(
            byte[] file,
            string filename,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Import Audio<br/>
        /// Register an external audio file as a generation row.<br/>
        /// Designed for the story timeline so users can drop in music or other<br/>
        /// non-TTS audio. The row points at a singleton "Imported Audio" profile<br/>
        /// so the existing generation/story plumbing keeps working unchanged.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> ImportAudioGenerateImportPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Audio<br/>
        /// Register an external audio file as a generation row.<br/>
        /// Designed for the story timeline so users can drop in music or other<br/>
        /// non-TTS audio. The row points at a singleton "Imported Audio" profile<br/>
        /// so the existing generation/story plumbing keeps working unchanged.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.GenerationResponse>> ImportAudioGenerateImportPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}