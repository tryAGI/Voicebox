#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Speak<br/>
        /// Speak text in a voice profile. Mirrors voicebox.speak (MCP).<br/>
        /// Response shape matches POST /generate — a ``GenerationResponse`` with<br/>
        /// ``status="generating"`` and an ``id`` the caller polls at<br/>
        /// ``GET /generate/{id}/status``.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> SpeakSpeakPostAsync(

            global::Voicebox.SpeakRequest request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speak<br/>
        /// Speak text in a voice profile. Mirrors voicebox.speak (MCP).<br/>
        /// Response shape matches POST /generate — a ``GenerationResponse`` with<br/>
        /// ``status="generating"`` and an ``id`` the caller polls at<br/>
        /// ``GET /generate/{id}/status``.
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="language"></param>
        /// <param name="personality">
        /// When true and the profile has a personality prompt, the input text is rewritten in-character before TTS. When null, the per-client binding's default_personality flag decides.
        /// </param>
        /// <param name="profile">
        /// Voice profile name or id. Falls back to per-client binding, then default.
        /// </param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.GenerationResponse> SpeakSpeakPostAsync(
            string text,
            string? engine = default,
            string? language = default,
            bool? personality = default,
            string? profile = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}