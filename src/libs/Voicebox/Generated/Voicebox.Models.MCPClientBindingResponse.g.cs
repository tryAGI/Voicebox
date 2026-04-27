
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Per-MCP-client voice binding — what voice / engine the server should<br/>
    /// use when a given client_id calls voicebox.speak without args, plus an<br/>
    /// opt-in personality-rewrite default.
    /// </summary>
    public sealed partial class MCPClientBindingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_engine")]
        public string? DefaultEngine { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_personality")]
        public bool? DefaultPersonality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_at")]
        public global::System.DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        public string? ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPClientBindingResponse" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="defaultEngine"></param>
        /// <param name="defaultPersonality">
        /// Default Value: false
        /// </param>
        /// <param name="label"></param>
        /// <param name="lastSeenAt"></param>
        /// <param name="profileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPClientBindingResponse(
            string clientId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? defaultEngine,
            bool? defaultPersonality,
            string? label,
            global::System.DateTime? lastSeenAt,
            string? profileId)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.CreatedAt = createdAt;
            this.DefaultEngine = defaultEngine;
            this.DefaultPersonality = defaultPersonality;
            this.Label = label;
            this.LastSeenAt = lastSeenAt;
            this.ProfileId = profileId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPClientBindingResponse" /> class.
        /// </summary>
        public MCPClientBindingResponse()
        {
        }
    }
}