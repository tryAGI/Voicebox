
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for audio channel.
    /// </summary>
    public sealed partial class AudioChannelResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DeviceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChannelResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="deviceIds"></param>
        /// <param name="id"></param>
        /// <param name="isDefault"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioChannelResponse(
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<string> deviceIds,
            string id,
            bool isDefault,
            string name)
        {
            this.CreatedAt = createdAt;
            this.DeviceIds = deviceIds ?? throw new global::System.ArgumentNullException(nameof(deviceIds));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsDefault = isDefault;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChannelResponse" /> class.
        /// </summary>
        public AudioChannelResponse()
        {
        }
    }
}