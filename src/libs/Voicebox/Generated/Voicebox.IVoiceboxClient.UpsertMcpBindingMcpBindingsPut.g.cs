#nullable enable

namespace Voicebox
{
    public partial interface IVoiceboxClient
    {
        /// <summary>
        /// Upsert Mcp Binding<br/>
        /// Create-or-update a binding. Matches by client_id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.MCPClientBindingResponse> UpsertMcpBindingMcpBindingsPutAsync(

            global::Voicebox.MCPClientBindingUpsert request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Mcp Binding<br/>
        /// Create-or-update a binding. Matches by client_id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Voicebox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.AutoSDKHttpResponse<global::Voicebox.MCPClientBindingResponse>> UpsertMcpBindingMcpBindingsPutAsResponseAsync(

            global::Voicebox.MCPClientBindingUpsert request,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Mcp Binding<br/>
        /// Create-or-update a binding. Matches by client_id.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="defaultEngine"></param>
        /// <param name="defaultPersonality">
        /// Default Value: false
        /// </param>
        /// <param name="label"></param>
        /// <param name="profileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Voicebox.MCPClientBindingResponse> UpsertMcpBindingMcpBindingsPutAsync(
            string clientId,
            string? defaultEngine = default,
            bool? defaultPersonality = default,
            string? label = default,
            string? profileId = default,
            global::Voicebox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}