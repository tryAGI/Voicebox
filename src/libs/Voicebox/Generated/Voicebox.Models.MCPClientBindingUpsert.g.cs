
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Create or update a binding. Matched by ``client_id``.
    /// </summary>
    public sealed partial class MCPClientBindingUpsert
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
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        public string? ProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPClientBindingUpsert" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="defaultEngine"></param>
        /// <param name="defaultPersonality">
        /// Default Value: false
        /// </param>
        /// <param name="label"></param>
        /// <param name="profileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPClientBindingUpsert(
            string clientId,
            string? defaultEngine,
            bool? defaultPersonality,
            string? label,
            string? profileId)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.DefaultEngine = defaultEngine;
            this.DefaultPersonality = defaultPersonality;
            this.Label = label;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPClientBindingUpsert" /> class.
        /// </summary>
        public MCPClientBindingUpsert()
        {
        }
    }
}