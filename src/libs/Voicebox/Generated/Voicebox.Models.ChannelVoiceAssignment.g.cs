
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for assigning voices to a channel.
    /// </summary>
    public sealed partial class ChannelVoiceAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProfileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelVoiceAssignment" /> class.
        /// </summary>
        /// <param name="profileIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelVoiceAssignment(
            global::System.Collections.Generic.IList<string> profileIds)
        {
            this.ProfileIds = profileIds ?? throw new global::System.ArgumentNullException(nameof(profileIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelVoiceAssignment" /> class.
        /// </summary>
        public ChannelVoiceAssignment()
        {
        }
    }
}