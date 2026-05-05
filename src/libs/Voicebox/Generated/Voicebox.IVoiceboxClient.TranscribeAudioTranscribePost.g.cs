#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe audio file to text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.TranscriptionResponse> TranscribeAudioTranscribePostAsync(

            global::Voicebox.BodyTranscribeAudioTranscribePost request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe audio file to text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.TranscriptionResponse>> TranscribeAudioTranscribePostAsResponseAsync(

            global::Voicebox.BodyTranscribeAudioTranscribePost request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe audio file to text.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.TranscriptionResponse> TranscribeAudioTranscribePostAsync(
            byte[] file,
            string filename,
            string? language = default,
            string? model = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe audio file to text.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.TranscriptionResponse> TranscribeAudioTranscribePostAsync(
            global::System.IO.Stream file,
            string filename,
            string? language = default,
            string? model = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe audio file to text.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="language"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.TranscriptionResponse>> TranscribeAudioTranscribePostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? language = default,
            string? model = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}