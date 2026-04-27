
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for updating an audio channel.
    /// </summary>
    public sealed partial class AudioChannelUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_ids")]
        public global::System.Collections.Generic.IList<string>? DeviceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChannelUpdate" /> class.
        /// </summary>
        /// <param name="deviceIds"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioChannelUpdate(
            global::System.Collections.Generic.IList<string>? deviceIds,
            string? name)
        {
            this.DeviceIds = deviceIds;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChannelUpdate" /> class.
        /// </summary>
        public AudioChannelUpdate()
        {
        }
    }
}