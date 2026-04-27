
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Request model for setting a story item's pinned version.
    /// </summary>
    public sealed partial class StoryItemVersionUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemVersionUpdate" /> class.
        /// </summary>
        /// <param name="versionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoryItemVersionUpdate(
            string? versionId)
        {
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoryItemVersionUpdate" /> class.
        /// </summary>
        public StoryItemVersionUpdate()
        {
        }
    }
}