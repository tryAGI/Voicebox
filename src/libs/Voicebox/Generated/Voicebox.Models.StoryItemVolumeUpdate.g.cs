
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for adjusting a story item's playback volume.<br/>
    /// Linear gain. ``1.0`` is the original level, ``0.0`` is silent. Capped<br/>
    /// above 1.0 so a too-aggressive boost can't blow out the mix or clip<br/>
    /// the export.
    /// </summary>
    public sealed partial class StoryItemVolumeUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemVolumeUpdate" /> class.
        /// </summary>
        /// <param name="volume"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemVolumeUpdate(
            double volume)
        {
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemVolumeUpdate" /> class.
        /// </summary>
        public StoryItemVolumeUpdate()
        {
        }
    }
}