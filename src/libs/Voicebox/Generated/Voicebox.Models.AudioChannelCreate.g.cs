
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for creating an audio channel.
    /// </summary>
    public sealed partial class AudioChannelCreate
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChannelCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="deviceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioChannelCreate(
            string name,
            global::System.Collections.Generic.IList<string>? deviceIds)
        {
            this.DeviceIds = deviceIds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChannelCreate" /> class.
        /// </summary>
        public AudioChannelCreate()
        {
        }
    }
}