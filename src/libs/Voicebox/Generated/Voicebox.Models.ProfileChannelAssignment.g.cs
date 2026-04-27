
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for assigning channels to a profile.
    /// </summary>
    public sealed partial class ProfileChannelAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ChannelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileChannelAssignment" /> class.
        /// </summary>
        /// <param name="channelIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileChannelAssignment(
            global::System.Collections.Generic.IList<string> channelIds)
        {
            this.ChannelIds = channelIds ?? throw new global::System.ArgumentNullException(nameof(channelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileChannelAssignment" /> class.
        /// </summary>
        public ProfileChannelAssignment()
        {
        }
    }
}