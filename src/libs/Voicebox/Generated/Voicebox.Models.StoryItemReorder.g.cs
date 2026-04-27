
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for reordering story items.
    /// </summary>
    public sealed partial class StoryItemReorder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GenerationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemReorder" /> class.
        /// </summary>
        /// <param name="generationIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemReorder(
            global::System.Collections.Generic.IList<string> generationIds)
        {
            this.GenerationIds = generationIds ?? throw new global::System.ArgumentNullException(nameof(generationIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemReorder" /> class.
        /// </summary>
        public StoryItemReorder()
        {
        }
    }
}