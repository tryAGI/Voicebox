
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for batch updating story item timecodes.
    /// </summary>
    public sealed partial class StoryItemBatchUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.StoryItemUpdateTime> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemBatchUpdate" /> class.
        /// </summary>
        /// <param name="updates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemBatchUpdate(
            global::System.Collections.Generic.IList<global::Voicebox.StoryItemUpdateTime> updates)
        {
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemBatchUpdate" /> class.
        /// </summary>
        public StoryItemBatchUpdate()
        {
        }
    }
}