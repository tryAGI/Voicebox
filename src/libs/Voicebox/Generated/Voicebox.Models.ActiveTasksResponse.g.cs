
#nullable enable

namespace Voicebox
{
    /// <summary>
    /// Response model for active tasks.
    /// </summary>
    public sealed partial class ActiveTasksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.ActiveDownloadTask> Downloads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Voicebox.ActiveGenerationTask> Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveTasksResponse" /> class.
        /// </summary>
        /// <param name="downloads"></param>
        /// <param name="generations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveTasksResponse(
            global::System.Collections.Generic.IList<global::Voicebox.ActiveDownloadTask> downloads,
            global::System.Collections.Generic.IList<global::Voicebox.ActiveGenerationTask> generations)
        {
            this.Downloads = downloads ?? throw new global::System.ArgumentNullException(nameof(downloads));
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveTasksResponse" /> class.
        /// </summary>
        public ActiveTasksResponse()
        {
        }
    }
}